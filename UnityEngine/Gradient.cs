using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200003F RID: 63
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Gradient
	{
		// Token: 0x06000479 RID: 1145 RVA: 0x00007434 File Offset: 0x00005634
		[RequiredByNativeCode]
		public Gradient()
		{
			this.Init();
		}

		// Token: 0x0600047A RID: 1146
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x0600047B RID: 1147
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		// Token: 0x0600047C RID: 1148 RVA: 0x00007444 File Offset: 0x00005644
		~Gradient()
		{
			this.Cleanup();
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00007474 File Offset: 0x00005674
		public Color Evaluate(float time)
		{
			Color result;
			Gradient.INTERNAL_CALL_Evaluate(this, time, out result);
			return result;
		}

		// Token: 0x0600047E RID: 1150
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Evaluate(Gradient self, float time, out Color value);

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600047F RID: 1151
		// (set) Token: 0x06000480 RID: 1152
		public extern GradientColorKey[] colorKeys { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000481 RID: 1153
		// (set) Token: 0x06000482 RID: 1154
		public extern GradientAlphaKey[] alphaKeys { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000483 RID: 1155
		// (set) Token: 0x06000484 RID: 1156
		public extern GradientMode mode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000485 RID: 1157
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys);

		// Token: 0x04000062 RID: 98
		internal IntPtr m_Ptr;
	}
}
