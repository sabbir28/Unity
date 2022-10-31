using System;
using System.IO;
using System.Text;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x020000D5 RID: 213
	internal sealed class WWWTranscoder
	{
		// Token: 0x06000FA7 RID: 4007 RVA: 0x00015040 File Offset: 0x00013240
		private static byte Hex2Byte(byte[] b, int offset)
		{
			byte b2 = 0;
			for (int i = offset; i < offset + 2; i++)
			{
				b2 *= 16;
				int num = (int)b[i];
				if (num >= 48 && num <= 57)
				{
					num -= 48;
				}
				else if (num >= 65 && num <= 75)
				{
					num -= 55;
				}
				else if (num >= 97 && num <= 102)
				{
					num -= 87;
				}
				if (num > 15)
				{
					return 63;
				}
				b2 += (byte)num;
			}
			return b2;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000150D8 File Offset: 0x000132D8
		private static byte[] Byte2Hex(byte b, byte[] hexChars)
		{
			return new byte[]
			{
				hexChars[b >> 4],
				hexChars[(int)(b & 15)]
			};
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00015108 File Offset: 0x00013308
		[ExcludeFromDocs]
		public static string URLEncode(string toEncode)
		{
			Encoding utf = Encoding.UTF8;
			return WWWTranscoder.URLEncode(toEncode, utf);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x0001512C File Offset: 0x0001332C
		public static string URLEncode(string toEncode, [DefaultValue("Encoding.UTF8")] Encoding e)
		{
			byte[] array = WWWTranscoder.Encode(e.GetBytes(toEncode), WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace, WWWTranscoder.urlForbidden, false);
			return WWW.DefaultEncoding.GetString(array, 0, array.Length);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00015170 File Offset: 0x00013370
		public static byte[] URLEncode(byte[] toEncode)
		{
			return WWWTranscoder.Encode(toEncode, WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace, WWWTranscoder.urlForbidden, false);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0001519C File Offset: 0x0001339C
		[ExcludeFromDocs]
		public static string QPEncode(string toEncode)
		{
			Encoding utf = Encoding.UTF8;
			return WWWTranscoder.QPEncode(toEncode, utf);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x000151C0 File Offset: 0x000133C0
		public static string QPEncode(string toEncode, [DefaultValue("Encoding.UTF8")] Encoding e)
		{
			byte[] array = WWWTranscoder.Encode(e.GetBytes(toEncode), WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace, WWWTranscoder.qpForbidden, true);
			return WWW.DefaultEncoding.GetString(array, 0, array.Length);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00015204 File Offset: 0x00013404
		public static byte[] QPEncode(byte[] toEncode)
		{
			return WWWTranscoder.Encode(toEncode, WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace, WWWTranscoder.qpForbidden, true);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00015230 File Offset: 0x00013430
		public static byte[] Encode(byte[] input, byte escapeChar, byte space, byte[] forbidden, bool uppercase)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(input.Length * 2))
			{
				for (int i = 0; i < input.Length; i++)
				{
					if (input[i] == 32)
					{
						memoryStream.WriteByte(space);
					}
					else if (input[i] < 32 || input[i] > 126 || WWWTranscoder.ByteArrayContains(forbidden, input[i]))
					{
						memoryStream.WriteByte(escapeChar);
						memoryStream.Write(WWWTranscoder.Byte2Hex(input[i], (!uppercase) ? WWWTranscoder.lcHexChars : WWWTranscoder.ucHexChars), 0, 2);
					}
					else
					{
						memoryStream.WriteByte(input[i]);
					}
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00015304 File Offset: 0x00013504
		private static bool ByteArrayContains(byte[] array, byte b)
		{
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				if (array[i] == b)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00015344 File Offset: 0x00013544
		[ExcludeFromDocs]
		public static string URLDecode(string toEncode)
		{
			Encoding utf = Encoding.UTF8;
			return WWWTranscoder.URLDecode(toEncode, utf);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00015368 File Offset: 0x00013568
		public static string URLDecode(string toEncode, [DefaultValue("Encoding.UTF8")] Encoding e)
		{
			byte[] array = WWWTranscoder.Decode(WWW.DefaultEncoding.GetBytes(toEncode), WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace);
			return e.GetString(array, 0, array.Length);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x000153A4 File Offset: 0x000135A4
		public static byte[] URLDecode(byte[] toEncode)
		{
			return WWWTranscoder.Decode(toEncode, WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace);
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x000153CC File Offset: 0x000135CC
		[ExcludeFromDocs]
		public static string QPDecode(string toEncode)
		{
			Encoding utf = Encoding.UTF8;
			return WWWTranscoder.QPDecode(toEncode, utf);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x000153F0 File Offset: 0x000135F0
		public static string QPDecode(string toEncode, [DefaultValue("Encoding.UTF8")] Encoding e)
		{
			byte[] array = WWWTranscoder.Decode(WWW.DefaultEncoding.GetBytes(toEncode), WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace);
			return e.GetString(array, 0, array.Length);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0001542C File Offset: 0x0001362C
		public static byte[] QPDecode(byte[] toEncode)
		{
			return WWWTranscoder.Decode(toEncode, WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00015454 File Offset: 0x00013654
		public static byte[] Decode(byte[] input, byte escapeChar, byte space)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(input.Length))
			{
				for (int i = 0; i < input.Length; i++)
				{
					if (input[i] == space)
					{
						memoryStream.WriteByte(32);
					}
					else if (input[i] == escapeChar && i + 2 < input.Length)
					{
						i++;
						memoryStream.WriteByte(WWWTranscoder.Hex2Byte(input, i++));
					}
					else
					{
						memoryStream.WriteByte(input[i]);
					}
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00015500 File Offset: 0x00013700
		[ExcludeFromDocs]
		public static bool SevenBitClean(string s)
		{
			Encoding utf = Encoding.UTF8;
			return WWWTranscoder.SevenBitClean(s, utf);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00015524 File Offset: 0x00013724
		public static bool SevenBitClean(string s, [DefaultValue("Encoding.UTF8")] Encoding e)
		{
			return WWWTranscoder.SevenBitClean(e.GetBytes(s));
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00015548 File Offset: 0x00013748
		public static bool SevenBitClean(byte[] input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] < 32 || input[i] > 126)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040001F6 RID: 502
		private static byte[] ucHexChars = WWW.DefaultEncoding.GetBytes("0123456789ABCDEF");

		// Token: 0x040001F7 RID: 503
		private static byte[] lcHexChars = WWW.DefaultEncoding.GetBytes("0123456789abcdef");

		// Token: 0x040001F8 RID: 504
		private static byte urlEscapeChar = 37;

		// Token: 0x040001F9 RID: 505
		private static byte urlSpace = 43;

		// Token: 0x040001FA RID: 506
		private static byte[] urlForbidden = WWW.DefaultEncoding.GetBytes("@&;:<>=?\"'/\\!#%+$,{}|^[]`");

		// Token: 0x040001FB RID: 507
		private static byte qpEscapeChar = 61;

		// Token: 0x040001FC RID: 508
		private static byte qpSpace = 95;

		// Token: 0x040001FD RID: 509
		private static byte[] qpForbidden = WWW.DefaultEncoding.GetBytes("&;=?\"'%+_");
	}
}
