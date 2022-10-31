using System;
using System.Text;

namespace UnityEngine.Networking
{
	// Token: 0x0200027D RID: 637
	public class MultipartFormDataSection : IMultipartFormSection
	{
		// Token: 0x06002AF7 RID: 10999 RVA: 0x0003C780 File Offset: 0x0003A980
		public MultipartFormDataSection(string name, byte[] data, string contentType)
		{
			if (data == null || data.Length < 1)
			{
				throw new ArgumentException("Cannot create a multipart form data section without body data");
			}
			this.name = name;
			this.data = data;
			this.content = contentType;
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x0003C7BC File Offset: 0x0003A9BC
		public MultipartFormDataSection(string name, byte[] data) : this(name, data, null)
		{
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x0003C7C8 File Offset: 0x0003A9C8
		public MultipartFormDataSection(byte[] data) : this(null, data)
		{
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x0003C7D4 File Offset: 0x0003A9D4
		public MultipartFormDataSection(string name, string data, Encoding encoding, string contentType)
		{
			if (data == null || data.Length < 1)
			{
				throw new ArgumentException("Cannot create a multipart form data section without body data");
			}
			byte[] bytes = encoding.GetBytes(data);
			this.name = name;
			this.data = bytes;
			if (contentType != null && !contentType.Contains("encoding="))
			{
				contentType = contentType.Trim() + "; encoding=" + encoding.WebName;
			}
			this.content = contentType;
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x0003C858 File Offset: 0x0003AA58
		public MultipartFormDataSection(string name, string data, string contentType) : this(name, data, Encoding.UTF8, contentType)
		{
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x0003C86C File Offset: 0x0003AA6C
		public MultipartFormDataSection(string name, string data) : this(name, data, "text/plain")
		{
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x0003C87C File Offset: 0x0003AA7C
		public MultipartFormDataSection(string data) : this(null, data)
		{
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x0003C888 File Offset: 0x0003AA88
		public string sectionName
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
		public byte[] sectionData
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002B00 RID: 11008 RVA: 0x0003C8C0 File Offset: 0x0003AAC0
		public string fileName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x0003C8D8 File Offset: 0x0003AAD8
		public string contentType
		{
			get
			{
				return this.content;
			}
		}

		// Token: 0x04000854 RID: 2132
		private string name;

		// Token: 0x04000855 RID: 2133
		private byte[] data;

		// Token: 0x04000856 RID: 2134
		private string content;
	}
}
