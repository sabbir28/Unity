using System;

namespace UnityEngine.Networking.Types
{
	// Token: 0x020002A4 RID: 676
	public class NetworkAccessToken
	{
		// Token: 0x06002C32 RID: 11314 RVA: 0x0003EDD4 File Offset: 0x0003CFD4
		public NetworkAccessToken()
		{
			this.array = new byte[64];
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x0003EDEC File Offset: 0x0003CFEC
		public NetworkAccessToken(byte[] array)
		{
			this.array = array;
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x0003EDFC File Offset: 0x0003CFFC
		public NetworkAccessToken(string strArray)
		{
			try
			{
				this.array = Convert.FromBase64String(strArray);
			}
			catch (Exception)
			{
				this.array = new byte[64];
			}
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x0003EE48 File Offset: 0x0003D048
		public string GetByteString()
		{
			return Convert.ToBase64String(this.array);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x0003EE68 File Offset: 0x0003D068
		public bool IsValid()
		{
			bool result;
			if (this.array == null || this.array.Length != 64)
			{
				result = false;
			}
			else
			{
				bool flag = false;
				foreach (byte b in this.array)
				{
					if (b != 0)
					{
						flag = true;
						break;
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x040008B7 RID: 2231
		private const int NETWORK_ACCESS_TOKEN_SIZE = 64;

		// Token: 0x040008B8 RID: 2232
		public byte[] array;
	}
}
