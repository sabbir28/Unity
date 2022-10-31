using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CD RID: 205
	[UsedByNativeCode]
	public class RenderTexture : Texture
	{
		// Token: 0x06000ECF RID: 3791 RVA: 0x0001398C File Offset: 0x00011B8C
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			RenderTexture.Internal_CreateRenderTexture(this);
			this.width = width;
			this.height = height;
			this.depth = depth;
			this.format = format;
			bool sRGB = readWrite == RenderTextureReadWrite.sRGB;
			if (readWrite == RenderTextureReadWrite.Default)
			{
				sRGB = (QualitySettings.activeColorSpace == ColorSpace.Linear);
			}
			RenderTexture.Internal_SetSRGBReadWrite(this, sRGB);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000139E4 File Offset: 0x00011BE4
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format)
		{
			RenderTexture.Internal_CreateRenderTexture(this);
			this.width = width;
			this.height = height;
			this.depth = depth;
			this.format = format;
			RenderTexture.Internal_SetSRGBReadWrite(this, QualitySettings.activeColorSpace == ColorSpace.Linear);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00013A20 File Offset: 0x00011C20
		public RenderTexture(int width, int height, int depth)
		{
			RenderTexture.Internal_CreateRenderTexture(this);
			this.width = width;
			this.height = height;
			this.depth = depth;
			this.format = RenderTextureFormat.Default;
			RenderTexture.Internal_SetSRGBReadWrite(this, QualitySettings.activeColorSpace == ColorSpace.Linear);
		}

		// Token: 0x06000ED2 RID: 3794
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateRenderTexture([Writable] RenderTexture rt);

		// Token: 0x06000ED3 RID: 3795
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern RenderTexture GetTemporary(int width, int height, [DefaultValue("0")] int depthBuffer, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite, [DefaultValue("1")] int antiAliasing);

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00013A5C File Offset: 0x00011C5C
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			int antiAliasing = 1;
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, antiAliasing);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00013A80 File Offset: 0x00011C80
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format)
		{
			int antiAliasing = 1;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, antiAliasing);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00013AA4 File Offset: 0x00011CA4
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer)
		{
			int antiAliasing = 1;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			RenderTextureFormat format = RenderTextureFormat.Default;
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, antiAliasing);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00013ACC File Offset: 0x00011CCC
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height)
		{
			int antiAliasing = 1;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			RenderTextureFormat format = RenderTextureFormat.Default;
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, antiAliasing);
		}

		// Token: 0x06000ED8 RID: 3800
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ReleaseTemporary(RenderTexture temp);

		// Token: 0x06000ED9 RID: 3801
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetWidth(RenderTexture mono);

		// Token: 0x06000EDA RID: 3802
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetWidth(RenderTexture mono, int width);

		// Token: 0x06000EDB RID: 3803
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetHeight(RenderTexture mono);

		// Token: 0x06000EDC RID: 3804
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetHeight(RenderTexture mono, int width);

		// Token: 0x06000EDD RID: 3805
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetSRGBReadWrite(RenderTexture mono, bool sRGB);

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x00013AF8 File Offset: 0x00011CF8
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x00013B14 File Offset: 0x00011D14
		public override int width
		{
			get
			{
				return RenderTexture.Internal_GetWidth(this);
			}
			set
			{
				RenderTexture.Internal_SetWidth(this, value);
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00013B20 File Offset: 0x00011D20
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x00013B3C File Offset: 0x00011D3C
		public override int height
		{
			get
			{
				return RenderTexture.Internal_GetHeight(this);
			}
			set
			{
				RenderTexture.Internal_SetHeight(this, value);
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000EE2 RID: 3810
		// (set) Token: 0x06000EE3 RID: 3811
		public extern int depth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000EE4 RID: 3812
		// (set) Token: 0x06000EE5 RID: 3813
		public extern bool isPowerOfTwo { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000EE6 RID: 3814
		public extern bool sRGB { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000EE7 RID: 3815
		// (set) Token: 0x06000EE8 RID: 3816
		public extern RenderTextureFormat format { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000EE9 RID: 3817
		// (set) Token: 0x06000EEA RID: 3818
		public extern bool useMipMap { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000EEB RID: 3819
		// (set) Token: 0x06000EEC RID: 3820
		public extern bool autoGenerateMips { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000EED RID: 3821
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TextureDimension Internal_GetDimension(RenderTexture rt);

		// Token: 0x06000EEE RID: 3822
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetDimension(RenderTexture rt, TextureDimension dim);

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00013B48 File Offset: 0x00011D48
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x00013B64 File Offset: 0x00011D64
		public override TextureDimension dimension
		{
			get
			{
				return RenderTexture.Internal_GetDimension(this);
			}
			set
			{
				RenderTexture.Internal_SetDimension(this, value);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000EF1 RID: 3825
		// (set) Token: 0x06000EF2 RID: 3826
		[Obsolete("Use RenderTexture.dimension instead.")]
		public extern bool isCubemap { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000EF3 RID: 3827
		// (set) Token: 0x06000EF4 RID: 3828
		[Obsolete("Use RenderTexture.dimension instead.")]
		public extern bool isVolume { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000EF5 RID: 3829
		// (set) Token: 0x06000EF6 RID: 3830
		public extern int volumeDepth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000EF7 RID: 3831
		// (set) Token: 0x06000EF8 RID: 3832
		public extern int antiAliasing { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000EF9 RID: 3833
		// (set) Token: 0x06000EFA RID: 3834
		public extern bool enableRandomWrite { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000EFB RID: 3835 RVA: 0x00013B70 File Offset: 0x00011D70
		public bool Create()
		{
			return RenderTexture.INTERNAL_CALL_Create(this);
		}

		// Token: 0x06000EFC RID: 3836
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Create(RenderTexture self);

		// Token: 0x06000EFD RID: 3837 RVA: 0x00013B8C File Offset: 0x00011D8C
		public void Release()
		{
			RenderTexture.INTERNAL_CALL_Release(this);
		}

		// Token: 0x06000EFE RID: 3838
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Release(RenderTexture self);

		// Token: 0x06000EFF RID: 3839 RVA: 0x00013B98 File Offset: 0x00011D98
		public bool IsCreated()
		{
			return RenderTexture.INTERNAL_CALL_IsCreated(this);
		}

		// Token: 0x06000F00 RID: 3840
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsCreated(RenderTexture self);

		// Token: 0x06000F01 RID: 3841 RVA: 0x00013BB4 File Offset: 0x00011DB4
		public void DiscardContents()
		{
			RenderTexture.INTERNAL_CALL_DiscardContents(this);
		}

		// Token: 0x06000F02 RID: 3842
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DiscardContents(RenderTexture self);

		// Token: 0x06000F03 RID: 3843
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DiscardContents(bool discardColor, bool discardDepth);

		// Token: 0x06000F04 RID: 3844 RVA: 0x00013BC0 File Offset: 0x00011DC0
		public void MarkRestoreExpected()
		{
			RenderTexture.INTERNAL_CALL_MarkRestoreExpected(this);
		}

		// Token: 0x06000F05 RID: 3845
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MarkRestoreExpected(RenderTexture self);

		// Token: 0x06000F06 RID: 3846 RVA: 0x00013BCC File Offset: 0x00011DCC
		public void GenerateMips()
		{
			RenderTexture.INTERNAL_CALL_GenerateMips(this);
		}

		// Token: 0x06000F07 RID: 3847
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GenerateMips(RenderTexture self);

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x00013BD8 File Offset: 0x00011DD8
		public RenderBuffer colorBuffer
		{
			get
			{
				RenderBuffer result;
				this.GetColorBuffer(out result);
				return result;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00013BF8 File Offset: 0x00011DF8
		public RenderBuffer depthBuffer
		{
			get
			{
				RenderBuffer result;
				this.GetDepthBuffer(out result);
				return result;
			}
		}

		// Token: 0x06000F0A RID: 3850
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetColorBuffer(out RenderBuffer res);

		// Token: 0x06000F0B RID: 3851
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetDepthBuffer(out RenderBuffer res);

		// Token: 0x06000F0C RID: 3852 RVA: 0x00013C18 File Offset: 0x00011E18
		public IntPtr GetNativeDepthBufferPtr()
		{
			IntPtr result;
			RenderTexture.INTERNAL_CALL_GetNativeDepthBufferPtr(this, out result);
			return result;
		}

		// Token: 0x06000F0D RID: 3853
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetNativeDepthBufferPtr(RenderTexture self, out IntPtr value);

		// Token: 0x06000F0E RID: 3854
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetGlobalShaderProperty(string propertyName);

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000F0F RID: 3855
		// (set) Token: 0x06000F10 RID: 3856
		public static extern RenderTexture active { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000F11 RID: 3857
		// (set) Token: 0x06000F12 RID: 3858
		[Obsolete("RenderTexture.enabled is always now, no need to use it")]
		public static extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000F13 RID: 3859 RVA: 0x00013C38 File Offset: 0x00011E38
		[Obsolete("GetTexelOffset always returns zero now, no point in using it.")]
		public Vector2 GetTexelOffset()
		{
			return Vector2.zero;
		}

		// Token: 0x06000F14 RID: 3860
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SupportsStencil(RenderTexture rt);

		// Token: 0x06000F15 RID: 3861 RVA: 0x00013C54 File Offset: 0x00011E54
		[Obsolete("SetBorderColor is no longer supported.", true)]
		public void SetBorderColor(Color color)
		{
		}
	}
}
