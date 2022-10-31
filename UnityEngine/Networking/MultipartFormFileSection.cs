using System;
using System.Text;

namespace UnityEngine.Networking
{
	// Token: 0x0200027E RID: 638
	public class MultipartFormFileSection : IMultipartFormSection
	{
		// Token: 0x06002B02 RID: 11010 RVA: 0x0003C8F4 File Offset: 0x0003AAF4
		public MultipartFormFileSection(string name, byte[] data, string fileName, string contentType)
		{
			if (data == null || data.Length < 1)
			{
				throw new ArgumentException("Cannot create a multipart form file section without body data");
			}
			if (string.IsNullOrEmpty(fileName))
			{
				fileName = "file.dat";
			}
			if (string.IsNullOrEmpty(contentType))
			{
				contentType = "application/octet-stream";
			}
			this.Init(name, data, fileName, contentType);
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x0003C958 File Offset: 0x0003AB58
		public MultipartFormFileSection(byte[] data) : this(null, data, null, null)
		{
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x0003C968 File Offset: 0x0003AB68
		public MultipartFormFileSection(string fileName, byte[] data) : this(null, data, fileName, null)
		{
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x0003C978 File Offset: 0x0003AB78
		public MultipartFormFileSection(string name, string data, Encoding dataEncoding, string fileName)
		{
			if (data == null || data.Length < 1)
			{
				throw new ArgumentException("Cannot create a multipart form file section without body data");
			}
			if (dataEncoding == null)
			{
				dataEncoding = Encoding.UTF8;
			}
			byte[] bytes = dataEncoding.GetBytes(data);
			if (string.IsNullOrEmpty(fileName))
			{
				fileName = "file.txt";
			}
			if (string.IsNullOrEmpty(this.content))
			{
				this.content = "text/plain; charset=" + dataEncoding.WebName;
			}
			this.Init(name, bytes, fileName, this.content);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x0003CA10 File Offset: 0x0003AC10
		public MultipartFormFileSection(string data, Encoding dataEncoding, string fileName) : this(null, data, dataEncoding, fileName)
		{
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x0003CA20 File Offset: 0x0003AC20
		public MultipartFormFileSection(string data, string fileName) : this(data, null, fileName)
		{
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x0003CA2C File Offset: 0x0003AC2C
		private void Init(string name, byte[] data, string fileName, string contentType)
		{
			this.name = name;
			this.data = data;
			this.file = fileName;
			this.content = contentType;
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x0003CA4C File Offset: 0x0003AC4C
		public string sectionName
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002B0A RID: 11018 RVA: 0x0003CA68 File Offset: 0x0003AC68
		public byte[] sectionData
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x0003CA84 File Offset: 0x0003AC84
		public string fileName
		{
			get
			{
				return this.file;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002B0C RID: 11020 RVA: 0x0003CAA0 File Offset: 0x0003ACA0
		public string contentType
		{
			get
			{
				return this.content;
			}
		}

		// Token: 0x04000857 RID: 2135
		private string name;

		// Token: 0x04000858 RID: 2136
		private byte[] data;

		// Token: 0x04000859 RID: 2137
		private string file;

		// Token: 0x0400085A RID: 2138
		private string content;
	}
}
