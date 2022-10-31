using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000023 RID: 35
	[UsedByNativeCode]
	[RequireComponent(typeof(Transform))]
	public sealed class Camera : Behaviour
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000243 RID: 579 RVA: 0x000051FC File Offset: 0x000033FC
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00005218 File Offset: 0x00003418
		[Obsolete("use Camera.fieldOfView instead.")]
		public float fov
		{
			get
			{
				return this.fieldOfView;
			}
			set
			{
				this.fieldOfView = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00005224 File Offset: 0x00003424
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00005240 File Offset: 0x00003440
		[Obsolete("use Camera.nearClipPlane instead.")]
		public float near
		{
			get
			{
				return this.nearClipPlane;
			}
			set
			{
				this.nearClipPlane = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000524C File Offset: 0x0000344C
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00005268 File Offset: 0x00003468
		[Obsolete("use Camera.farClipPlane instead.")]
		public float far
		{
			get
			{
				return this.farClipPlane;
			}
			set
			{
				this.farClipPlane = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000249 RID: 585
		// (set) Token: 0x0600024A RID: 586
		public extern float fieldOfView { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600024B RID: 587
		// (set) Token: 0x0600024C RID: 588
		public extern float nearClipPlane { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600024D RID: 589
		// (set) Token: 0x0600024E RID: 590
		public extern float farClipPlane { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600024F RID: 591
		// (set) Token: 0x06000250 RID: 592
		public extern RenderingPath renderingPath { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000251 RID: 593
		public extern RenderingPath actualRenderingPath { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000252 RID: 594
		// (set) Token: 0x06000253 RID: 595
		public extern bool allowHDR { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000254 RID: 596
		// (set) Token: 0x06000255 RID: 597
		[Obsolete("use Camera.allowHDR instead.")]
		public extern bool hdr { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000256 RID: 598
		// (set) Token: 0x06000257 RID: 599
		public extern bool forceIntoRenderTexture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000258 RID: 600
		// (set) Token: 0x06000259 RID: 601
		public extern bool allowMSAA { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600025A RID: 602
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern string[] GetCameraBufferWarnings();

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600025B RID: 603
		// (set) Token: 0x0600025C RID: 604
		public extern float orthographicSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600025D RID: 605
		// (set) Token: 0x0600025E RID: 606
		public extern bool orthographic { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600025F RID: 607
		// (set) Token: 0x06000260 RID: 608
		public extern OpaqueSortMode opaqueSortMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000261 RID: 609
		// (set) Token: 0x06000262 RID: 610
		public extern TransparencySortMode transparencySortMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00005274 File Offset: 0x00003474
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00005294 File Offset: 0x00003494
		public Vector3 transparencySortAxis
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_transparencySortAxis(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_transparencySortAxis(ref value);
			}
		}

		// Token: 0x06000265 RID: 613
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_transparencySortAxis(out Vector3 value);

		// Token: 0x06000266 RID: 614
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_transparencySortAxis(ref Vector3 value);

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000267 RID: 615
		// (set) Token: 0x06000268 RID: 616
		public extern float depth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000269 RID: 617
		// (set) Token: 0x0600026A RID: 618
		public extern float aspect { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600026B RID: 619
		// (set) Token: 0x0600026C RID: 620
		public extern int cullingMask { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600026D RID: 621
		internal static extern int PreviewCullingLayer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600026E RID: 622
		// (set) Token: 0x0600026F RID: 623
		public extern int eventMask { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000052A0 File Offset: 0x000034A0
		// (set) Token: 0x06000271 RID: 625 RVA: 0x000052C0 File Offset: 0x000034C0
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

		// Token: 0x06000272 RID: 626
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_backgroundColor(out Color value);

		// Token: 0x06000273 RID: 627
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_backgroundColor(ref Color value);

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000052CC File Offset: 0x000034CC
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000052EC File Offset: 0x000034EC
		public Rect rect
		{
			get
			{
				Rect result;
				this.INTERNAL_get_rect(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_rect(ref value);
			}
		}

		// Token: 0x06000276 RID: 630
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rect(out Rect value);

		// Token: 0x06000277 RID: 631
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rect(ref Rect value);

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000052F8 File Offset: 0x000034F8
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00005318 File Offset: 0x00003518
		public Rect pixelRect
		{
			get
			{
				Rect result;
				this.INTERNAL_get_pixelRect(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_pixelRect(ref value);
			}
		}

		// Token: 0x0600027A RID: 634
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pixelRect(out Rect value);

		// Token: 0x0600027B RID: 635
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_pixelRect(ref Rect value);

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600027C RID: 636
		// (set) Token: 0x0600027D RID: 637
		public extern RenderTexture targetTexture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600027E RID: 638
		public extern RenderTexture activeTexture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600027F RID: 639
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTargetBuffersImpl(out RenderBuffer color, out RenderBuffer depth);

		// Token: 0x06000280 RID: 640
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTargetBuffersMRTImpl(RenderBuffer[] color, out RenderBuffer depth);

		// Token: 0x06000281 RID: 641 RVA: 0x00005324 File Offset: 0x00003524
		public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
		{
			this.SetTargetBuffersImpl(out colorBuffer, out depthBuffer);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00005334 File Offset: 0x00003534
		public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer)
		{
			this.SetTargetBuffersMRTImpl(colorBuffer, out depthBuffer);
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000283 RID: 643
		public extern int pixelWidth { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000284 RID: 644
		public extern int pixelHeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00005340 File Offset: 0x00003540
		public Matrix4x4 cameraToWorldMatrix
		{
			get
			{
				Matrix4x4 result;
				this.INTERNAL_get_cameraToWorldMatrix(out result);
				return result;
			}
		}

		// Token: 0x06000286 RID: 646
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_cameraToWorldMatrix(out Matrix4x4 value);

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00005360 File Offset: 0x00003560
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00005380 File Offset: 0x00003580
		public Matrix4x4 worldToCameraMatrix
		{
			get
			{
				Matrix4x4 result;
				this.INTERNAL_get_worldToCameraMatrix(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_worldToCameraMatrix(ref value);
			}
		}

		// Token: 0x06000289 RID: 649
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldToCameraMatrix(out Matrix4x4 value);

		// Token: 0x0600028A RID: 650
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_worldToCameraMatrix(ref Matrix4x4 value);

		// Token: 0x0600028B RID: 651 RVA: 0x0000538C File Offset: 0x0000358C
		public void ResetWorldToCameraMatrix()
		{
			Camera.INTERNAL_CALL_ResetWorldToCameraMatrix(this);
		}

		// Token: 0x0600028C RID: 652
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetWorldToCameraMatrix(Camera self);

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00005398 File Offset: 0x00003598
		// (set) Token: 0x0600028E RID: 654 RVA: 0x000053B8 File Offset: 0x000035B8
		public Matrix4x4 projectionMatrix
		{
			get
			{
				Matrix4x4 result;
				this.INTERNAL_get_projectionMatrix(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_projectionMatrix(ref value);
			}
		}

		// Token: 0x0600028F RID: 655
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_projectionMatrix(out Matrix4x4 value);

		// Token: 0x06000290 RID: 656
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_projectionMatrix(ref Matrix4x4 value);

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000053C4 File Offset: 0x000035C4
		// (set) Token: 0x06000292 RID: 658 RVA: 0x000053E4 File Offset: 0x000035E4
		public Matrix4x4 nonJitteredProjectionMatrix
		{
			get
			{
				Matrix4x4 result;
				this.INTERNAL_get_nonJitteredProjectionMatrix(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_nonJitteredProjectionMatrix(ref value);
			}
		}

		// Token: 0x06000293 RID: 659
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_nonJitteredProjectionMatrix(out Matrix4x4 value);

		// Token: 0x06000294 RID: 660
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_nonJitteredProjectionMatrix(ref Matrix4x4 value);

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000295 RID: 661
		// (set) Token: 0x06000296 RID: 662
		public extern bool useJitteredProjectionMatrixForTransparentRendering { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000297 RID: 663 RVA: 0x000053F0 File Offset: 0x000035F0
		public void ResetProjectionMatrix()
		{
			Camera.INTERNAL_CALL_ResetProjectionMatrix(this);
		}

		// Token: 0x06000298 RID: 664
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetProjectionMatrix(Camera self);

		// Token: 0x06000299 RID: 665 RVA: 0x000053FC File Offset: 0x000035FC
		public void ResetAspect()
		{
			Camera.INTERNAL_CALL_ResetAspect(this);
		}

		// Token: 0x0600029A RID: 666
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetAspect(Camera self);

		// Token: 0x0600029B RID: 667 RVA: 0x00005408 File Offset: 0x00003608
		[Obsolete("Camera.ResetFieldOfView has been deprecated in Unity 5.6 and will be removed in the future. Please replace it by explicitly setting the camera's FOV to 60 degrees.")]
		public void ResetFieldOfView()
		{
			Camera.INTERNAL_CALL_ResetFieldOfView(this);
		}

		// Token: 0x0600029C RID: 668
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetFieldOfView(Camera self);

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00005414 File Offset: 0x00003614
		public Vector3 velocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_velocity(out result);
				return result;
			}
		}

		// Token: 0x0600029E RID: 670
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600029F RID: 671
		// (set) Token: 0x060002A0 RID: 672
		public extern CameraClearFlags clearFlags { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002A1 RID: 673
		public extern bool stereoEnabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002A2 RID: 674
		// (set) Token: 0x060002A3 RID: 675
		public extern float stereoSeparation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002A4 RID: 676
		// (set) Token: 0x060002A5 RID: 677
		public extern float stereoConvergence { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002A6 RID: 678
		// (set) Token: 0x060002A7 RID: 679
		public extern CameraType cameraType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002A8 RID: 680
		// (set) Token: 0x060002A9 RID: 681
		public extern bool stereoMirrorMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060002AA RID: 682
		[Obsolete("GetStereoViewMatrices is deprecated. Use GetStereoViewMatrix(StereoscopicEye eye) instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Matrix4x4[] GetStereoViewMatrices();

		// Token: 0x060002AB RID: 683 RVA: 0x00005434 File Offset: 0x00003634
		public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye)
		{
			Matrix4x4 result;
			Camera.INTERNAL_CALL_GetStereoViewMatrix(this, eye, out result);
			return result;
		}

		// Token: 0x060002AC RID: 684
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetStereoViewMatrix(Camera self, Camera.StereoscopicEye eye, out Matrix4x4 value);

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002AD RID: 685
		// (set) Token: 0x060002AE RID: 686
		public extern StereoTargetEyeMask stereoTargetEye { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060002AF RID: 687 RVA: 0x00005454 File Offset: 0x00003654
		[Obsolete("SetStereoViewMatrices is deprecated. Use SetStereoViewMatrix(StereoscopicEye eye) instead.")]
		public void SetStereoViewMatrices(Matrix4x4 leftMatrix, Matrix4x4 rightMatrix)
		{
			Camera.INTERNAL_CALL_SetStereoViewMatrices(this, ref leftMatrix, ref rightMatrix);
		}

		// Token: 0x060002B0 RID: 688
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetStereoViewMatrices(Camera self, ref Matrix4x4 leftMatrix, ref Matrix4x4 rightMatrix);

		// Token: 0x060002B1 RID: 689 RVA: 0x00005464 File Offset: 0x00003664
		public void SetStereoViewMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix)
		{
			Camera.INTERNAL_CALL_SetStereoViewMatrix(this, eye, ref matrix);
		}

		// Token: 0x060002B2 RID: 690
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetStereoViewMatrix(Camera self, Camera.StereoscopicEye eye, ref Matrix4x4 matrix);

		// Token: 0x060002B3 RID: 691
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ResetStereoViewMatrices();

		// Token: 0x060002B4 RID: 692
		[Obsolete("GetStereoProjectionMatrices is deprecated. Use GetStereoProjectionMatrix(StereoscopicEye eye) instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Matrix4x4[] GetStereoProjectionMatrices();

		// Token: 0x060002B5 RID: 693 RVA: 0x00005470 File Offset: 0x00003670
		public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye)
		{
			Matrix4x4 result;
			Camera.INTERNAL_CALL_GetStereoProjectionMatrix(this, eye, out result);
			return result;
		}

		// Token: 0x060002B6 RID: 694
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetStereoProjectionMatrix(Camera self, Camera.StereoscopicEye eye, out Matrix4x4 value);

		// Token: 0x060002B7 RID: 695 RVA: 0x00005490 File Offset: 0x00003690
		public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix)
		{
			Camera.INTERNAL_CALL_SetStereoProjectionMatrix(this, eye, ref matrix);
		}

		// Token: 0x060002B8 RID: 696
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetStereoProjectionMatrix(Camera self, Camera.StereoscopicEye eye, ref Matrix4x4 matrix);

		// Token: 0x060002B9 RID: 697 RVA: 0x0000549C File Offset: 0x0000369C
		[Obsolete("SetStereoProjectionMatrices is deprecated. Use SetStereoProjectionMatrix(StereoscopicEye eye) instead.")]
		public void SetStereoProjectionMatrices(Matrix4x4 leftMatrix, Matrix4x4 rightMatrix)
		{
			Camera.INTERNAL_CALL_SetStereoProjectionMatrices(this, ref leftMatrix, ref rightMatrix);
		}

		// Token: 0x060002BA RID: 698
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetStereoProjectionMatrices(Camera self, ref Matrix4x4 leftMatrix, ref Matrix4x4 rightMatrix);

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002BB RID: 699
		public extern Camera.MonoOrStereoscopicEye stereoActiveEye { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060002BC RID: 700 RVA: 0x000054AC File Offset: 0x000036AC
		public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners)
		{
			if (outCorners == null)
			{
				throw new ArgumentNullException("outCorners");
			}
			if (outCorners.Length < 4)
			{
				throw new ArgumentException("outCorners minimum size is 4", "outCorners");
			}
			this.CalculateFrustumCornersInternal(viewport, z, eye, outCorners);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000054E8 File Offset: 0x000036E8
		private void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners)
		{
			Camera.INTERNAL_CALL_CalculateFrustumCornersInternal(this, ref viewport, z, eye, outCorners);
		}

		// Token: 0x060002BE RID: 702
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CalculateFrustumCornersInternal(Camera self, ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners);

		// Token: 0x060002BF RID: 703
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ResetStereoProjectionMatrices();

		// Token: 0x060002C0 RID: 704
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ResetTransparencySortSettings();

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002C1 RID: 705
		// (set) Token: 0x060002C2 RID: 706
		public extern int targetDisplay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060002C3 RID: 707 RVA: 0x000054F8 File Offset: 0x000036F8
		public Vector3 WorldToScreenPoint(Vector3 position)
		{
			Vector3 result;
			Camera.INTERNAL_CALL_WorldToScreenPoint(this, ref position, out result);
			return result;
		}

		// Token: 0x060002C4 RID: 708
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_WorldToScreenPoint(Camera self, ref Vector3 position, out Vector3 value);

		// Token: 0x060002C5 RID: 709 RVA: 0x00005518 File Offset: 0x00003718
		public Vector3 WorldToViewportPoint(Vector3 position)
		{
			Vector3 result;
			Camera.INTERNAL_CALL_WorldToViewportPoint(this, ref position, out result);
			return result;
		}

		// Token: 0x060002C6 RID: 710
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_WorldToViewportPoint(Camera self, ref Vector3 position, out Vector3 value);

		// Token: 0x060002C7 RID: 711 RVA: 0x00005538 File Offset: 0x00003738
		public Vector3 ViewportToWorldPoint(Vector3 position)
		{
			Vector3 result;
			Camera.INTERNAL_CALL_ViewportToWorldPoint(this, ref position, out result);
			return result;
		}

		// Token: 0x060002C8 RID: 712
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ViewportToWorldPoint(Camera self, ref Vector3 position, out Vector3 value);

		// Token: 0x060002C9 RID: 713 RVA: 0x00005558 File Offset: 0x00003758
		public Vector3 ScreenToWorldPoint(Vector3 position)
		{
			Vector3 result;
			Camera.INTERNAL_CALL_ScreenToWorldPoint(this, ref position, out result);
			return result;
		}

		// Token: 0x060002CA RID: 714
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ScreenToWorldPoint(Camera self, ref Vector3 position, out Vector3 value);

		// Token: 0x060002CB RID: 715 RVA: 0x00005578 File Offset: 0x00003778
		public Vector3 ScreenToViewportPoint(Vector3 position)
		{
			Vector3 result;
			Camera.INTERNAL_CALL_ScreenToViewportPoint(this, ref position, out result);
			return result;
		}

		// Token: 0x060002CC RID: 716
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ScreenToViewportPoint(Camera self, ref Vector3 position, out Vector3 value);

		// Token: 0x060002CD RID: 717 RVA: 0x00005598 File Offset: 0x00003798
		public Vector3 ViewportToScreenPoint(Vector3 position)
		{
			Vector3 result;
			Camera.INTERNAL_CALL_ViewportToScreenPoint(this, ref position, out result);
			return result;
		}

		// Token: 0x060002CE RID: 718
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ViewportToScreenPoint(Camera self, ref Vector3 position, out Vector3 value);

		// Token: 0x060002CF RID: 719 RVA: 0x000055B8 File Offset: 0x000037B8
		public Ray ViewportPointToRay(Vector3 position)
		{
			Ray result;
			Camera.INTERNAL_CALL_ViewportPointToRay(this, ref position, out result);
			return result;
		}

		// Token: 0x060002D0 RID: 720
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ViewportPointToRay(Camera self, ref Vector3 position, out Ray value);

		// Token: 0x060002D1 RID: 721 RVA: 0x000055D8 File Offset: 0x000037D8
		public Ray ScreenPointToRay(Vector3 position)
		{
			Ray result;
			Camera.INTERNAL_CALL_ScreenPointToRay(this, ref position, out result);
			return result;
		}

		// Token: 0x060002D2 RID: 722
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ScreenPointToRay(Camera self, ref Vector3 position, out Ray value);

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002D3 RID: 723
		public static extern Camera main { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002D4 RID: 724
		public static extern Camera current { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002D5 RID: 725
		public static extern Camera[] allCameras { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002D6 RID: 726
		public static extern int allCamerasCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060002D7 RID: 727
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetAllCameras(Camera[] cameras);

		// Token: 0x060002D8 RID: 728 RVA: 0x000055F8 File Offset: 0x000037F8
		[RequiredByNativeCode]
		private static void FireOnPreCull(Camera cam)
		{
			if (Camera.onPreCull != null)
			{
				Camera.onPreCull(cam);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00005610 File Offset: 0x00003810
		[RequiredByNativeCode]
		private static void FireOnPreRender(Camera cam)
		{
			if (Camera.onPreRender != null)
			{
				Camera.onPreRender(cam);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00005628 File Offset: 0x00003828
		[RequiredByNativeCode]
		private static void FireOnPostRender(Camera cam)
		{
			if (Camera.onPostRender != null)
			{
				Camera.onPostRender(cam);
			}
		}

		// Token: 0x060002DB RID: 731
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Render();

		// Token: 0x060002DC RID: 732
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RenderWithShader(Shader shader, string replacementTag);

		// Token: 0x060002DD RID: 733
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetReplacementShader(Shader shader, string replacementTag);

		// Token: 0x060002DE RID: 734 RVA: 0x00005640 File Offset: 0x00003840
		public void ResetReplacementShader()
		{
			Camera.INTERNAL_CALL_ResetReplacementShader(this);
		}

		// Token: 0x060002DF RID: 735
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetReplacementShader(Camera self);

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002E0 RID: 736
		// (set) Token: 0x060002E1 RID: 737
		public extern bool useOcclusionCulling { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000564C File Offset: 0x0000384C
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000566C File Offset: 0x0000386C
		public Matrix4x4 cullingMatrix
		{
			get
			{
				Matrix4x4 result;
				this.INTERNAL_get_cullingMatrix(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_cullingMatrix(ref value);
			}
		}

		// Token: 0x060002E4 RID: 740
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_cullingMatrix(out Matrix4x4 value);

		// Token: 0x060002E5 RID: 741
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_cullingMatrix(ref Matrix4x4 value);

		// Token: 0x060002E6 RID: 742 RVA: 0x00005678 File Offset: 0x00003878
		public void ResetCullingMatrix()
		{
			Camera.INTERNAL_CALL_ResetCullingMatrix(this);
		}

		// Token: 0x060002E7 RID: 743
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetCullingMatrix(Camera self);

		// Token: 0x060002E8 RID: 744
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RenderDontRestore();

		// Token: 0x060002E9 RID: 745
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetupCurrent(Camera cur);

		// Token: 0x060002EA RID: 746 RVA: 0x00005684 File Offset: 0x00003884
		[ExcludeFromDocs]
		public bool RenderToCubemap(Cubemap cubemap)
		{
			int faceMask = 63;
			return this.RenderToCubemap(cubemap, faceMask);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000056A4 File Offset: 0x000038A4
		public bool RenderToCubemap(Cubemap cubemap, [DefaultValue("63")] int faceMask)
		{
			return this.Internal_RenderToCubemapTexture(cubemap, faceMask);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000056C4 File Offset: 0x000038C4
		[ExcludeFromDocs]
		public bool RenderToCubemap(RenderTexture cubemap)
		{
			int faceMask = 63;
			return this.RenderToCubemap(cubemap, faceMask);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000056E4 File Offset: 0x000038E4
		public bool RenderToCubemap(RenderTexture cubemap, [DefaultValue("63")] int faceMask)
		{
			return this.Internal_RenderToCubemapRT(cubemap, faceMask);
		}

		// Token: 0x060002EE RID: 750
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_RenderToCubemapRT(RenderTexture cubemap, int faceMask);

		// Token: 0x060002EF RID: 751
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_RenderToCubemapTexture(Cubemap cubemap, int faceMask);

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002F0 RID: 752
		// (set) Token: 0x060002F1 RID: 753
		public extern float[] layerCullDistances { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002F2 RID: 754
		// (set) Token: 0x060002F3 RID: 755
		public extern bool layerCullSpherical { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060002F4 RID: 756
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CopyFrom(Camera other);

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002F5 RID: 757
		// (set) Token: 0x060002F6 RID: 758
		public extern DepthTextureMode depthTextureMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002F7 RID: 759
		// (set) Token: 0x060002F8 RID: 760
		public extern bool clearStencilAfterLightingPass { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060002F9 RID: 761
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool IsFiltered(GameObject go);

		// Token: 0x060002FA RID: 762
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer);

		// Token: 0x060002FB RID: 763
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer);

		// Token: 0x060002FC RID: 764
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveCommandBuffers(CameraEvent evt);

		// Token: 0x060002FD RID: 765
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveAllCommandBuffers();

		// Token: 0x060002FE RID: 766
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern CommandBuffer[] GetCommandBuffers(CameraEvent evt);

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002FF RID: 767
		public extern int commandBufferCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000300 RID: 768 RVA: 0x00005704 File Offset: 0x00003904
		internal GameObject RaycastTry(Ray ray, float distance, int layerMask)
		{
			return Camera.INTERNAL_CALL_RaycastTry(this, ref ray, distance, layerMask);
		}

		// Token: 0x06000301 RID: 769
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern GameObject INTERNAL_CALL_RaycastTry(Camera self, ref Ray ray, float distance, int layerMask);

		// Token: 0x06000302 RID: 770 RVA: 0x00005724 File Offset: 0x00003924
		internal GameObject RaycastTry2D(Ray ray, float distance, int layerMask)
		{
			return Camera.INTERNAL_CALL_RaycastTry2D(this, ref ray, distance, layerMask);
		}

		// Token: 0x06000303 RID: 771
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern GameObject INTERNAL_CALL_RaycastTry2D(Camera self, ref Ray ray, float distance, int layerMask);

		// Token: 0x06000304 RID: 772 RVA: 0x00005744 File Offset: 0x00003944
		public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane)
		{
			Matrix4x4 result;
			Camera.INTERNAL_CALL_CalculateObliqueMatrix(this, ref clipPlane, out result);
			return result;
		}

		// Token: 0x06000305 RID: 773
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CalculateObliqueMatrix(Camera self, ref Vector4 clipPlane, out Matrix4x4 value);

		// Token: 0x06000306 RID: 774 RVA: 0x00005764 File Offset: 0x00003964
		internal void OnlyUsedForTesting1()
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00005768 File Offset: 0x00003968
		internal void OnlyUsedForTesting2()
		{
		}

		// Token: 0x04000030 RID: 48
		public static Camera.CameraCallback onPreCull;

		// Token: 0x04000031 RID: 49
		public static Camera.CameraCallback onPreRender;

		// Token: 0x04000032 RID: 50
		public static Camera.CameraCallback onPostRender;

		// Token: 0x02000024 RID: 36
		public enum StereoscopicEye
		{
			// Token: 0x04000034 RID: 52
			Left,
			// Token: 0x04000035 RID: 53
			Right
		}

		// Token: 0x02000025 RID: 37
		public enum MonoOrStereoscopicEye
		{
			// Token: 0x04000037 RID: 55
			Left,
			// Token: 0x04000038 RID: 56
			Right,
			// Token: 0x04000039 RID: 57
			Mono
		}

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000309 RID: 777
		public delegate void CameraCallback(Camera cam);
	}
}
