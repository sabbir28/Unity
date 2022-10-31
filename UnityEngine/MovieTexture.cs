using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001E0 RID: 480
	public sealed class MovieTexture : Texture
	{
		// Token: 0x06002123 RID: 8483 RVA: 0x00026BC8 File Offset: 0x00024DC8
		public void Play()
		{
			MovieTexture.INTERNAL_CALL_Play(this);
		}

		// Token: 0x06002124 RID: 8484
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Play(MovieTexture self);

		// Token: 0x06002125 RID: 8485 RVA: 0x00026BD4 File Offset: 0x00024DD4
		public void Stop()
		{
			MovieTexture.INTERNAL_CALL_Stop(this);
		}

		// Token: 0x06002126 RID: 8486
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Stop(MovieTexture self);

		// Token: 0x06002127 RID: 8487 RVA: 0x00026BE0 File Offset: 0x00024DE0
		public void Pause()
		{
			MovieTexture.INTERNAL_CALL_Pause(this);
		}

		// Token: 0x06002128 RID: 8488
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Pause(MovieTexture self);

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06002129 RID: 8489
		public extern AudioClip audioClip { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600212A RID: 8490
		// (set) Token: 0x0600212B RID: 8491
		public extern bool loop { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600212C RID: 8492
		public extern bool isPlaying { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x0600212D RID: 8493
		public extern bool isReadyToPlay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x0600212E RID: 8494
		public extern float duration { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
