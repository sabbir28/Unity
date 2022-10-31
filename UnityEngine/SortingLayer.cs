using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B0 RID: 176
	public struct SortingLayer
	{
		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00011DBC File Offset: 0x0000FFBC
		public int id
		{
			get
			{
				return this.m_Id;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		public string name
		{
			get
			{
				return SortingLayer.IDToName(this.m_Id);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00011DF8 File Offset: 0x0000FFF8
		public int value
		{
			get
			{
				return SortingLayer.GetLayerValueFromID(this.m_Id);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00011E18 File Offset: 0x00010018
		public static SortingLayer[] layers
		{
			get
			{
				int[] sortingLayerIDsInternal = SortingLayer.GetSortingLayerIDsInternal();
				SortingLayer[] array = new SortingLayer[sortingLayerIDsInternal.Length];
				for (int i = 0; i < sortingLayerIDsInternal.Length; i++)
				{
					array[i].m_Id = sortingLayerIDsInternal[i];
				}
				return array;
			}
		}

		// Token: 0x06000D96 RID: 3478
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int[] GetSortingLayerIDsInternal();

		// Token: 0x06000D97 RID: 3479
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetLayerValueFromID(int id);

		// Token: 0x06000D98 RID: 3480
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetLayerValueFromName(string name);

		// Token: 0x06000D99 RID: 3481
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int NameToID(string name);

		// Token: 0x06000D9A RID: 3482
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string IDToName(int id);

		// Token: 0x06000D9B RID: 3483
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValid(int id);

		// Token: 0x04000161 RID: 353
		private int m_Id;
	}
}
