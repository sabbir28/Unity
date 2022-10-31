using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000061 RID: 97
	[UsedByNativeCode]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class RectOffset
	{
		// Token: 0x06000746 RID: 1862 RVA: 0x0000943C File Offset: 0x0000763C
		public RectOffset()
		{
			this.Init();
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0000944C File Offset: 0x0000764C
		internal RectOffset(object sourceStyle, IntPtr source)
		{
			this.m_SourceStyle = sourceStyle;
			this.m_Ptr = source;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00009464 File Offset: 0x00007664
		public RectOffset(int left, int right, int top, int bottom)
		{
			this.Init();
			this.left = left;
			this.right = right;
			this.top = top;
			this.bottom = bottom;
		}

		// Token: 0x06000749 RID: 1865
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x0600074A RID: 1866
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600074B RID: 1867
		// (set) Token: 0x0600074C RID: 1868
		public extern int left { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600074D RID: 1869
		// (set) Token: 0x0600074E RID: 1870
		public extern int right { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600074F RID: 1871
		// (set) Token: 0x06000750 RID: 1872
		public extern int top { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000751 RID: 1873
		// (set) Token: 0x06000752 RID: 1874
		public extern int bottom { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000753 RID: 1875
		public extern int horizontal { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000754 RID: 1876
		public extern int vertical { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000755 RID: 1877 RVA: 0x00009490 File Offset: 0x00007690
		public Rect Add(Rect rect)
		{
			Rect result;
			RectOffset.INTERNAL_CALL_Add(this, ref rect, out result);
			return result;
		}

		// Token: 0x06000756 RID: 1878
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Add(RectOffset self, ref Rect rect, out Rect value);

		// Token: 0x06000757 RID: 1879 RVA: 0x000094B0 File Offset: 0x000076B0
		public Rect Remove(Rect rect)
		{
			Rect result;
			RectOffset.INTERNAL_CALL_Remove(this, ref rect, out result);
			return result;
		}

		// Token: 0x06000758 RID: 1880
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Remove(RectOffset self, ref Rect rect, out Rect value);

		// Token: 0x06000759 RID: 1881 RVA: 0x000094D0 File Offset: 0x000076D0
		~RectOffset()
		{
			if (this.m_SourceStyle == null)
			{
				this.Cleanup();
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0000950C File Offset: 0x0000770C
		public override string ToString()
		{
			return UnityString.Format("RectOffset (l:{0} r:{1} t:{2} b:{3})", new object[]
			{
				this.left,
				this.right,
				this.top,
				this.bottom
			});
		}

		// Token: 0x0400007F RID: 127
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x04000080 RID: 128
		private readonly object m_SourceStyle;
	}
}
