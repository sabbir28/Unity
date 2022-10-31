using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BA RID: 186
	[RequireComponent(typeof(Transform))]
	public sealed class SpriteRenderer : Renderer
	{
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00012F50 File Offset: 0x00011150
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00012F6C File Offset: 0x0001116C
		public Sprite sprite
		{
			get
			{
				return this.GetSprite_INTERNAL();
			}
			set
			{
				this.SetSprite_INTERNAL(value);
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000DD3 RID: 3539
		// (set) Token: 0x06000DD4 RID: 3540
		public extern SpriteDrawMode drawMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000DD5 RID: 3541
		internal extern bool shouldSupportTiling { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00012F78 File Offset: 0x00011178
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x00012F98 File Offset: 0x00011198
		public Vector2 size
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_size(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_size(ref value);
			}
		}

		// Token: 0x06000DD8 RID: 3544
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector2 value);

		// Token: 0x06000DD9 RID: 3545
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector2 value);

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000DDA RID: 3546
		// (set) Token: 0x06000DDB RID: 3547
		public extern float adaptiveModeThreshold { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000DDC RID: 3548
		// (set) Token: 0x06000DDD RID: 3549
		public extern SpriteTileMode tileMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000DDE RID: 3550
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Sprite GetSprite_INTERNAL();

		// Token: 0x06000DDF RID: 3551
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetSprite_INTERNAL(Sprite sprite);

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00012FA4 File Offset: 0x000111A4
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00012FC4 File Offset: 0x000111C4
		public Color color
		{
			get
			{
				Color result;
				this.INTERNAL_get_color(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_color(ref value);
			}
		}

		// Token: 0x06000DE2 RID: 3554
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x06000DE3 RID: 3555
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000DE4 RID: 3556
		// (set) Token: 0x06000DE5 RID: 3557
		public extern bool flipX { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000DE6 RID: 3558
		// (set) Token: 0x06000DE7 RID: 3559
		public extern bool flipY { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00012FD0 File Offset: 0x000111D0
		internal Bounds GetSpriteBounds()
		{
			Bounds result;
			SpriteRenderer.INTERNAL_CALL_GetSpriteBounds(this, out result);
			return result;
		}

		// Token: 0x06000DE9 RID: 3561
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetSpriteBounds(SpriteRenderer self, out Bounds value);
	}
}
