using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001E3 RID: 483
	public sealed class WebCamTexture : Texture
	{
		// Token: 0x06002131 RID: 8497 RVA: 0x00026C28 File Offset: 0x00024E28
		public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight, int requestedFPS)
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, deviceName, requestedWidth, requestedHeight, requestedFPS);
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00026C3C File Offset: 0x00024E3C
		public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight)
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, deviceName, requestedWidth, requestedHeight, 0);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00026C50 File Offset: 0x00024E50
		public WebCamTexture(string deviceName)
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, deviceName, 0, 0, 0);
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00026C64 File Offset: 0x00024E64
		public WebCamTexture(int requestedWidth, int requestedHeight, int requestedFPS)
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, "", requestedWidth, requestedHeight, requestedFPS);
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00026C7C File Offset: 0x00024E7C
		public WebCamTexture(int requestedWidth, int requestedHeight)
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, "", requestedWidth, requestedHeight, 0);
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00026C94 File Offset: 0x00024E94
		public WebCamTexture()
		{
			WebCamTexture.Internal_CreateWebCamTexture(this, "", 0, 0, 0);
		}

		// Token: 0x06002137 RID: 8503
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateWebCamTexture([Writable] WebCamTexture self, string scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate);

		// Token: 0x06002138 RID: 8504 RVA: 0x00026CAC File Offset: 0x00024EAC
		public void Play()
		{
			WebCamTexture.INTERNAL_CALL_Play(this);
		}

		// Token: 0x06002139 RID: 8505
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Play(WebCamTexture self);

		// Token: 0x0600213A RID: 8506 RVA: 0x00026CB8 File Offset: 0x00024EB8
		public void Pause()
		{
			WebCamTexture.INTERNAL_CALL_Pause(this);
		}

		// Token: 0x0600213B RID: 8507
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Pause(WebCamTexture self);

		// Token: 0x0600213C RID: 8508 RVA: 0x00026CC4 File Offset: 0x00024EC4
		public void Stop()
		{
			WebCamTexture.INTERNAL_CALL_Stop(this);
		}

		// Token: 0x0600213D RID: 8509
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Stop(WebCamTexture self);

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x0600213E RID: 8510
		public extern bool isPlaying { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600213F RID: 8511
		// (set) Token: 0x06002140 RID: 8512
		public extern string deviceName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06002141 RID: 8513
		// (set) Token: 0x06002142 RID: 8514
		public extern float requestedFPS { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06002143 RID: 8515
		// (set) Token: 0x06002144 RID: 8516
		public extern int requestedWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06002145 RID: 8517
		// (set) Token: 0x06002146 RID: 8518
		public extern int requestedHeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06002147 RID: 8519
		public static extern WebCamDevice[] devices { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002148 RID: 8520 RVA: 0x00026CD0 File Offset: 0x00024ED0
		public Color GetPixel(int x, int y)
		{
			Color result;
			WebCamTexture.INTERNAL_CALL_GetPixel(this, x, y, out result);
			return result;
		}

		// Token: 0x06002149 RID: 8521
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPixel(WebCamTexture self, int x, int y, out Color value);

		// Token: 0x0600214A RID: 8522 RVA: 0x00026CF0 File Offset: 0x00024EF0
		public Color[] GetPixels()
		{
			return this.GetPixels(0, 0, this.width, this.height);
		}

		// Token: 0x0600214B RID: 8523
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);

		// Token: 0x0600214C RID: 8524
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color32[] GetPixels32([DefaultValue("null")] Color32[] colors);

		// Token: 0x0600214D RID: 8525 RVA: 0x00026D1C File Offset: 0x00024F1C
		[ExcludeFromDocs]
		public Color32[] GetPixels32()
		{
			Color32[] colors = null;
			return this.GetPixels32(colors);
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x0600214E RID: 8526
		public extern int videoRotationAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600214F RID: 8527
		public extern bool videoVerticallyMirrored { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06002150 RID: 8528
		public extern bool didUpdateThisFrame { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
