using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000072 RID: 114
	[UsedByNativeCode]
	public struct LayerMask
	{
		// Token: 0x06000819 RID: 2073 RVA: 0x0000A0B4 File Offset: 0x000082B4
		public static implicit operator int(LayerMask mask)
		{
			return mask.m_Mask;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0000A0D0 File Offset: 0x000082D0
		public static implicit operator LayerMask(int intVal)
		{
			LayerMask result;
			result.m_Mask = intVal;
			return result;
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x0000A0F0 File Offset: 0x000082F0
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x0000A10C File Offset: 0x0000830C
		public int value
		{
			get
			{
				return this.m_Mask;
			}
			set
			{
				this.m_Mask = value;
			}
		}

		// Token: 0x0600081D RID: 2077
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string LayerToName(int layer);

		// Token: 0x0600081E RID: 2078
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int NameToLayer(string layerName);

		// Token: 0x0600081F RID: 2079 RVA: 0x0000A118 File Offset: 0x00008318
		public static int GetMask(params string[] layerNames)
		{
			if (layerNames == null)
			{
				throw new ArgumentNullException("layerNames");
			}
			int num = 0;
			foreach (string layerName in layerNames)
			{
				int num2 = LayerMask.NameToLayer(layerName);
				if (num2 != -1)
				{
					num |= 1 << num2;
				}
			}
			return num;
		}

		// Token: 0x040000B8 RID: 184
		private int m_Mask;
	}
}
