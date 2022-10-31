using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020002FF RID: 767
	[Obsolete("This component is part of the legacy particle system, which is deprecated and will be removed in a future release. Use the ParticleSystem component instead.", false)]
	public sealed class ParticleRenderer : Renderer
	{
		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002FCC RID: 12236
		// (set) Token: 0x06002FCD RID: 12237
		public extern ParticleRenderMode particleRenderMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002FCE RID: 12238
		// (set) Token: 0x06002FCF RID: 12239
		public extern float lengthScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002FD0 RID: 12240
		// (set) Token: 0x06002FD1 RID: 12241
		public extern float velocityScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002FD2 RID: 12242
		// (set) Token: 0x06002FD3 RID: 12243
		public extern float cameraVelocityScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002FD4 RID: 12244
		// (set) Token: 0x06002FD5 RID: 12245
		public extern float maxParticleSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002FD6 RID: 12246
		// (set) Token: 0x06002FD7 RID: 12247
		public extern int uvAnimationXTile { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002FD8 RID: 12248
		// (set) Token: 0x06002FD9 RID: 12249
		public extern int uvAnimationYTile { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002FDA RID: 12250
		// (set) Token: 0x06002FDB RID: 12251
		public extern float uvAnimationCycles { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002FDC RID: 12252 RVA: 0x00045C94 File Offset: 0x00043E94
		// (set) Token: 0x06002FDD RID: 12253 RVA: 0x00045CB0 File Offset: 0x00043EB0
		[Obsolete("animatedTextureCount has been replaced by uvAnimationXTile and uvAnimationYTile.")]
		public int animatedTextureCount
		{
			get
			{
				return this.uvAnimationXTile;
			}
			set
			{
				this.uvAnimationXTile = value;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002FDE RID: 12254 RVA: 0x00045CBC File Offset: 0x00043EBC
		// (set) Token: 0x06002FDF RID: 12255 RVA: 0x00045CD8 File Offset: 0x00043ED8
		public float maxPartileSize
		{
			get
			{
				return this.maxParticleSize;
			}
			set
			{
				this.maxParticleSize = value;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002FE0 RID: 12256
		// (set) Token: 0x06002FE1 RID: 12257
		public extern Rect[] uvTiles { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002FE2 RID: 12258 RVA: 0x00045CE4 File Offset: 0x00043EE4
		// (set) Token: 0x06002FE3 RID: 12259 RVA: 0x00045CFC File Offset: 0x00043EFC
		[Obsolete("This function has been removed.", true)]
		public AnimationCurve widthCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x00045D00 File Offset: 0x00043F00
		// (set) Token: 0x06002FE5 RID: 12261 RVA: 0x00045D18 File Offset: 0x00043F18
		[Obsolete("This function has been removed.", true)]
		public AnimationCurve heightCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002FE6 RID: 12262 RVA: 0x00045D1C File Offset: 0x00043F1C
		// (set) Token: 0x06002FE7 RID: 12263 RVA: 0x00045D34 File Offset: 0x00043F34
		[Obsolete("This function has been removed.", true)]
		public AnimationCurve rotationCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
