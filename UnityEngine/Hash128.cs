using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D1 RID: 209
	public struct Hash128
	{
		// Token: 0x06000F60 RID: 3936 RVA: 0x0001415C File Offset: 0x0001235C
		public Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3)
		{
			this.m_u32_0 = u32_0;
			this.m_u32_1 = u32_1;
			this.m_u32_2 = u32_2;
			this.m_u32_3 = u32_3;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x0001417C File Offset: 0x0001237C
		public bool isValid
		{
			get
			{
				return this.m_u32_0 != 0U || this.m_u32_1 != 0U || this.m_u32_2 != 0U || this.m_u32_3 != 0U;
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x000141C4 File Offset: 0x000123C4
		public override string ToString()
		{
			return Hash128.Internal_Hash128ToString(this.m_u32_0, this.m_u32_1, this.m_u32_2, this.m_u32_3);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000141F8 File Offset: 0x000123F8
		public static Hash128 Parse(string hashString)
		{
			Hash128 result;
			Hash128.INTERNAL_CALL_Parse(hashString, out result);
			return result;
		}

		// Token: 0x06000F64 RID: 3940
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Parse(string hashString, out Hash128 value);

		// Token: 0x06000F65 RID: 3941
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string Internal_Hash128ToString(uint d0, uint d1, uint d2, uint d3);

		// Token: 0x06000F66 RID: 3942 RVA: 0x00014218 File Offset: 0x00012418
		public override bool Equals(object obj)
		{
			return obj is Hash128 && this == (Hash128)obj;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0001424C File Offset: 0x0001244C
		public override int GetHashCode()
		{
			return this.m_u32_0.GetHashCode() ^ this.m_u32_1.GetHashCode() ^ this.m_u32_2.GetHashCode() ^ this.m_u32_3.GetHashCode();
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000142A8 File Offset: 0x000124A8
		public static bool operator ==(Hash128 hash1, Hash128 hash2)
		{
			return hash1.m_u32_0 == hash2.m_u32_0 && hash1.m_u32_1 == hash2.m_u32_1 && hash1.m_u32_2 == hash2.m_u32_2 && hash1.m_u32_3 == hash2.m_u32_3;
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0001430C File Offset: 0x0001250C
		public static bool operator !=(Hash128 hash1, Hash128 hash2)
		{
			return !(hash1 == hash2);
		}

		// Token: 0x040001DD RID: 477
		private uint m_u32_0;

		// Token: 0x040001DE RID: 478
		private uint m_u32_1;

		// Token: 0x040001DF RID: 479
		private uint m_u32_2;

		// Token: 0x040001E0 RID: 480
		private uint m_u32_3;
	}
}
