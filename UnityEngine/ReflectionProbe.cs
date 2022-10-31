using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000A4 RID: 164
	public sealed class ReflectionProbe : Behaviour
	{
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000B93 RID: 2963
		// (set) Token: 0x06000B94 RID: 2964
		[Obsolete("type property has been deprecated. Starting with Unity 5.4, the only supported reflection probe type is Cube.", true)]
		public extern ReflectionProbeType type { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000B95 RID: 2965
		// (set) Token: 0x06000B96 RID: 2966
		public extern bool hdr { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x000100C4 File Offset: 0x0000E2C4
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x000100E4 File Offset: 0x0000E2E4
		public Vector3 size
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_size(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_size(ref value);
			}
		}

		// Token: 0x06000B99 RID: 2969
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector3 value);

		// Token: 0x06000B9A RID: 2970
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector3 value);

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x000100F0 File Offset: 0x0000E2F0
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x00010110 File Offset: 0x0000E310
		public Vector3 center
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_center(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_center(ref value);
			}
		}

		// Token: 0x06000B9D RID: 2973
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x06000B9E RID: 2974
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000B9F RID: 2975
		// (set) Token: 0x06000BA0 RID: 2976
		public extern float nearClipPlane { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000BA1 RID: 2977
		// (set) Token: 0x06000BA2 RID: 2978
		public extern float farClipPlane { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000BA3 RID: 2979
		// (set) Token: 0x06000BA4 RID: 2980
		public extern float shadowDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000BA5 RID: 2981
		// (set) Token: 0x06000BA6 RID: 2982
		public extern int resolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000BA7 RID: 2983
		// (set) Token: 0x06000BA8 RID: 2984
		public extern int cullingMask { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000BA9 RID: 2985
		// (set) Token: 0x06000BAA RID: 2986
		public extern ReflectionProbeClearFlags clearFlags { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x0001011C File Offset: 0x0000E31C
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x0001013C File Offset: 0x0000E33C
		public Color backgroundColor
		{
			get
			{
				Color result;
				this.INTERNAL_get_backgroundColor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_backgroundColor(ref value);
			}
		}

		// Token: 0x06000BAD RID: 2989
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_backgroundColor(out Color value);

		// Token: 0x06000BAE RID: 2990
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_backgroundColor(ref Color value);

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000BAF RID: 2991
		// (set) Token: 0x06000BB0 RID: 2992
		public extern float intensity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000BB1 RID: 2993
		// (set) Token: 0x06000BB2 RID: 2994
		public extern float blendDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000BB3 RID: 2995
		// (set) Token: 0x06000BB4 RID: 2996
		public extern bool boxProjection { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00010148 File Offset: 0x0000E348
		public Bounds bounds
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_bounds(out result);
				return result;
			}
		}

		// Token: 0x06000BB6 RID: 2998
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000BB7 RID: 2999
		// (set) Token: 0x06000BB8 RID: 3000
		public extern ReflectionProbeMode mode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000BB9 RID: 3001
		// (set) Token: 0x06000BBA RID: 3002
		public extern int importance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000BBB RID: 3003
		// (set) Token: 0x06000BBC RID: 3004
		public extern ReflectionProbeRefreshMode refreshMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000BBD RID: 3005
		// (set) Token: 0x06000BBE RID: 3006
		public extern ReflectionProbeTimeSlicingMode timeSlicingMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000BBF RID: 3007
		// (set) Token: 0x06000BC0 RID: 3008
		public extern Texture bakedTexture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000BC1 RID: 3009
		// (set) Token: 0x06000BC2 RID: 3010
		public extern Texture customBakedTexture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000BC3 RID: 3011
		public extern Texture texture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00010168 File Offset: 0x0000E368
		public Vector4 textureHDRDecodeValues
		{
			get
			{
				Vector4 result;
				this.INTERNAL_get_textureHDRDecodeValues(out result);
				return result;
			}
		}

		// Token: 0x06000BC5 RID: 3013
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_textureHDRDecodeValues(out Vector4 value);

		// Token: 0x06000BC6 RID: 3014
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int RenderProbe([DefaultValue("null")] RenderTexture targetTexture);

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00010188 File Offset: 0x0000E388
		[ExcludeFromDocs]
		public int RenderProbe()
		{
			RenderTexture targetTexture = null;
			return this.RenderProbe(targetTexture);
		}

		// Token: 0x06000BC8 RID: 3016
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsFinishedRendering(int renderId);

		// Token: 0x06000BC9 RID: 3017
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target);

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000BCA RID: 3018
		public static extern int minBakedCubemapResolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000BCB RID: 3019
		public static extern int maxBakedCubemapResolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x000101A8 File Offset: 0x0000E3A8
		public static Vector4 defaultTextureHDRDecodeValues
		{
			get
			{
				Vector4 result;
				ReflectionProbe.INTERNAL_get_defaultTextureHDRDecodeValues(out result);
				return result;
			}
		}

		// Token: 0x06000BCD RID: 3021
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_defaultTextureHDRDecodeValues(out Vector4 value);

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000BCE RID: 3022
		public static extern Texture defaultTexture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
