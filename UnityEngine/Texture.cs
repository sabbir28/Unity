using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C5 RID: 197
	[UsedByNativeCode]
	public class Texture : Object
	{
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000E2E RID: 3630
		// (set) Token: 0x06000E2F RID: 3631
		public static extern int masterTextureLimit { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000E30 RID: 3632
		// (set) Token: 0x06000E31 RID: 3633
		public static extern AnisotropicFiltering anisotropicFiltering { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000E32 RID: 3634
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax);

		// Token: 0x06000E33 RID: 3635
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetWidth(Texture t);

		// Token: 0x06000E34 RID: 3636
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetHeight(Texture t);

		// Token: 0x06000E35 RID: 3637
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TextureDimension Internal_GetDimension(Texture t);

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00013118 File Offset: 0x00011318
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00013134 File Offset: 0x00011334
		public virtual int width
		{
			get
			{
				return Texture.Internal_GetWidth(this);
			}
			set
			{
				throw new Exception("not implemented");
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00013144 File Offset: 0x00011344
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00013160 File Offset: 0x00011360
		public virtual int height
		{
			get
			{
				return Texture.Internal_GetHeight(this);
			}
			set
			{
				throw new Exception("not implemented");
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00013170 File Offset: 0x00011370
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x0001318C File Offset: 0x0001138C
		public virtual TextureDimension dimension
		{
			get
			{
				return Texture.Internal_GetDimension(this);
			}
			set
			{
				throw new Exception("not implemented");
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000E3C RID: 3644
		// (set) Token: 0x06000E3D RID: 3645
		public extern FilterMode filterMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000E3E RID: 3646
		// (set) Token: 0x06000E3F RID: 3647
		public extern int anisoLevel { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E40 RID: 3648
		// (set) Token: 0x06000E41 RID: 3649
		public extern TextureWrapMode wrapMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E42 RID: 3650
		// (set) Token: 0x06000E43 RID: 3651
		public extern float mipMapBias { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x0001319C File Offset: 0x0001139C
		public Vector2 texelSize
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_texelSize(out result);
				return result;
			}
		}

		// Token: 0x06000E45 RID: 3653
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_texelSize(out Vector2 value);

		// Token: 0x06000E46 RID: 3654 RVA: 0x000131BC File Offset: 0x000113BC
		public IntPtr GetNativeTexturePtr()
		{
			IntPtr result;
			Texture.INTERNAL_CALL_GetNativeTexturePtr(this, out result);
			return result;
		}

		// Token: 0x06000E47 RID: 3655
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetNativeTexturePtr(Texture self, out IntPtr value);

		// Token: 0x06000E48 RID: 3656
		[Obsolete("Use GetNativeTexturePtr instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetNativeTextureID();
	}
}
