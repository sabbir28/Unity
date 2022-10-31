﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x020000D4 RID: 212
	public sealed class WWWForm
	{
		// Token: 0x06000F9D RID: 3997 RVA: 0x0001493C File Offset: 0x00012B3C
		public WWWForm()
		{
			this.formData = new List<byte[]>();
			this.fieldNames = new List<string>();
			this.fileNames = new List<string>();
			this.types = new List<string>();
			this.boundary = new byte[40];
			for (int i = 0; i < 40; i++)
			{
				int num = Random.Range(48, 110);
				if (num > 57)
				{
					num += 7;
				}
				if (num > 90)
				{
					num += 6;
				}
				this.boundary[i] = (byte)num;
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x000149D4 File Offset: 0x00012BD4
		[ExcludeFromDocs]
		public void AddField(string fieldName, string value)
		{
			Encoding utf = Encoding.UTF8;
			this.AddField(fieldName, value, utf);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x000149F4 File Offset: 0x00012BF4
		public void AddField(string fieldName, string value, [DefaultValue("System.Text.Encoding.UTF8")] Encoding e)
		{
			this.fieldNames.Add(fieldName);
			this.fileNames.Add(null);
			this.formData.Add(e.GetBytes(value));
			this.types.Add("text/plain; charset=\"" + e.WebName + "\"");
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00014A4C File Offset: 0x00012C4C
		public void AddField(string fieldName, int i)
		{
			this.AddField(fieldName, i.ToString());
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00014A64 File Offset: 0x00012C64
		[ExcludeFromDocs]
		public void AddBinaryData(string fieldName, byte[] contents, string fileName)
		{
			string mimeType = null;
			this.AddBinaryData(fieldName, contents, fileName, mimeType);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00014A80 File Offset: 0x00012C80
		[ExcludeFromDocs]
		public void AddBinaryData(string fieldName, byte[] contents)
		{
			string mimeType = null;
			string fileName = null;
			this.AddBinaryData(fieldName, contents, fileName, mimeType);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00014A9C File Offset: 0x00012C9C
		public void AddBinaryData(string fieldName, byte[] contents, [DefaultValue("null")] string fileName, [DefaultValue("null")] string mimeType)
		{
			this.containsFiles = true;
			bool flag = contents.Length > 8 && contents[0] == 137 && contents[1] == 80 && contents[2] == 78 && contents[3] == 71 && contents[4] == 13 && contents[5] == 10 && contents[6] == 26 && contents[7] == 10;
			if (fileName == null)
			{
				fileName = fieldName + ((!flag) ? ".dat" : ".png");
			}
			if (mimeType == null)
			{
				if (flag)
				{
					mimeType = "image/png";
				}
				else
				{
					mimeType = "application/octet-stream";
				}
			}
			this.fieldNames.Add(fieldName);
			this.fileNames.Add(fileName);
			this.formData.Add(contents);
			this.types.Add(mimeType);
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00014B88 File Offset: 0x00012D88
		public Dictionary<string, string> headers
		{
			get
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				if (this.containsFiles)
				{
					dictionary["Content-Type"] = "multipart/form-data; boundary=\"" + Encoding.UTF8.GetString(this.boundary, 0, this.boundary.Length) + "\"";
				}
				else
				{
					dictionary["Content-Type"] = "application/x-www-form-urlencoded";
				}
				return dictionary;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x00014BF8 File Offset: 0x00012DF8
		public byte[] data
		{
			get
			{
				if (this.containsFiles)
				{
					byte[] bytes = WWW.DefaultEncoding.GetBytes("--");
					byte[] bytes2 = WWW.DefaultEncoding.GetBytes("\r\n");
					byte[] bytes3 = WWW.DefaultEncoding.GetBytes("Content-Type: ");
					byte[] bytes4 = WWW.DefaultEncoding.GetBytes("Content-disposition: form-data; name=\"");
					byte[] bytes5 = WWW.DefaultEncoding.GetBytes("\"");
					byte[] bytes6 = WWW.DefaultEncoding.GetBytes("; filename=\"");
					using (MemoryStream memoryStream = new MemoryStream(1024))
					{
						for (int i = 0; i < this.formData.Count; i++)
						{
							memoryStream.Write(bytes2, 0, bytes2.Length);
							memoryStream.Write(bytes, 0, bytes.Length);
							memoryStream.Write(this.boundary, 0, this.boundary.Length);
							memoryStream.Write(bytes2, 0, bytes2.Length);
							memoryStream.Write(bytes3, 0, bytes3.Length);
							byte[] bytes7 = Encoding.UTF8.GetBytes(this.types[i]);
							memoryStream.Write(bytes7, 0, bytes7.Length);
							memoryStream.Write(bytes2, 0, bytes2.Length);
							memoryStream.Write(bytes4, 0, bytes4.Length);
							string headerName = Encoding.UTF8.HeaderName;
							string text = this.fieldNames[i];
							if (!WWWTranscoder.SevenBitClean(text, Encoding.UTF8) || text.IndexOf("=?") > -1)
							{
								text = string.Concat(new string[]
								{
									"=?",
									headerName,
									"?Q?",
									WWWTranscoder.QPEncode(text, Encoding.UTF8),
									"?="
								});
							}
							byte[] bytes8 = Encoding.UTF8.GetBytes(text);
							memoryStream.Write(bytes8, 0, bytes8.Length);
							memoryStream.Write(bytes5, 0, bytes5.Length);
							if (this.fileNames[i] != null)
							{
								string text2 = this.fileNames[i];
								if (!WWWTranscoder.SevenBitClean(text2, Encoding.UTF8) || text2.IndexOf("=?") > -1)
								{
									text2 = string.Concat(new string[]
									{
										"=?",
										headerName,
										"?Q?",
										WWWTranscoder.QPEncode(text2, Encoding.UTF8),
										"?="
									});
								}
								byte[] bytes9 = Encoding.UTF8.GetBytes(text2);
								memoryStream.Write(bytes6, 0, bytes6.Length);
								memoryStream.Write(bytes9, 0, bytes9.Length);
								memoryStream.Write(bytes5, 0, bytes5.Length);
							}
							memoryStream.Write(bytes2, 0, bytes2.Length);
							memoryStream.Write(bytes2, 0, bytes2.Length);
							byte[] array = this.formData[i];
							memoryStream.Write(array, 0, array.Length);
						}
						memoryStream.Write(bytes2, 0, bytes2.Length);
						memoryStream.Write(bytes, 0, bytes.Length);
						memoryStream.Write(this.boundary, 0, this.boundary.Length);
						memoryStream.Write(bytes, 0, bytes.Length);
						memoryStream.Write(bytes2, 0, bytes2.Length);
						return memoryStream.ToArray();
					}
				}
				byte[] bytes10 = WWW.DefaultEncoding.GetBytes("&");
				byte[] bytes11 = WWW.DefaultEncoding.GetBytes("=");
				byte[] result;
				using (MemoryStream memoryStream2 = new MemoryStream(1024))
				{
					for (int j = 0; j < this.formData.Count; j++)
					{
						byte[] array2 = WWWTranscoder.URLEncode(Encoding.UTF8.GetBytes(this.fieldNames[j]));
						byte[] toEncode = this.formData[j];
						byte[] array3 = WWWTranscoder.URLEncode(toEncode);
						if (j > 0)
						{
							memoryStream2.Write(bytes10, 0, bytes10.Length);
						}
						memoryStream2.Write(array2, 0, array2.Length);
						memoryStream2.Write(bytes11, 0, bytes11.Length);
						memoryStream2.Write(array3, 0, array3.Length);
					}
					result = memoryStream2.ToArray();
				}
				return result;
			}
		}

		// Token: 0x040001F0 RID: 496
		private List<byte[]> formData;

		// Token: 0x040001F1 RID: 497
		private List<string> fieldNames;

		// Token: 0x040001F2 RID: 498
		private List<string> fileNames;

		// Token: 0x040001F3 RID: 499
		private List<string> types;

		// Token: 0x040001F4 RID: 500
		private byte[] boundary;

		// Token: 0x040001F5 RID: 501
		private bool containsFiles = false;
	}
}
