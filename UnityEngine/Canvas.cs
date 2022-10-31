using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000241 RID: 577
	[RequireComponent(typeof(RectTransform))]
	[NativeClass("UI::Canvas")]
	public sealed class Canvas : Behaviour
	{
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002660 RID: 9824
		// (set) Token: 0x06002661 RID: 9825
		public extern RenderMode renderMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002662 RID: 9826
		public extern bool isRootCanvas { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002663 RID: 9827
		// (set) Token: 0x06002664 RID: 9828
		public extern Camera worldCamera { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002665 RID: 9829 RVA: 0x0002C614 File Offset: 0x0002A814
		public Rect pixelRect
		{
			get
			{
				Rect result;
				this.INTERNAL_get_pixelRect(out result);
				return result;
			}
		}

		// Token: 0x06002666 RID: 9830
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pixelRect(out Rect value);

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002667 RID: 9831
		// (set) Token: 0x06002668 RID: 9832
		public extern float scaleFactor { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002669 RID: 9833
		// (set) Token: 0x0600266A RID: 9834
		public extern float referencePixelsPerUnit { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x0600266B RID: 9835
		// (set) Token: 0x0600266C RID: 9836
		public extern bool overridePixelPerfect { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x0600266D RID: 9837
		// (set) Token: 0x0600266E RID: 9838
		public extern bool pixelPerfect { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x0600266F RID: 9839
		// (set) Token: 0x06002670 RID: 9840
		public extern float planeDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002671 RID: 9841
		public extern int renderOrder { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002672 RID: 9842
		// (set) Token: 0x06002673 RID: 9843
		public extern bool overrideSorting { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002674 RID: 9844
		// (set) Token: 0x06002675 RID: 9845
		public extern int sortingOrder { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002676 RID: 9846
		// (set) Token: 0x06002677 RID: 9847
		public extern int targetDisplay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002678 RID: 9848
		// (set) Token: 0x06002679 RID: 9849
		[Obsolete("Setting normalizedSize via a int is not supported. Please use normalizedSortingGridSize")]
		public extern int sortingGridNormalizedSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x0600267A RID: 9850
		// (set) Token: 0x0600267B RID: 9851
		public extern float normalizedSortingGridSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x0600267C RID: 9852
		// (set) Token: 0x0600267D RID: 9853
		public extern int sortingLayerID { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x0600267E RID: 9854
		public extern int cachedSortingLayerValue { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x0600267F RID: 9855
		// (set) Token: 0x06002680 RID: 9856
		public extern AdditionalCanvasShaderChannels additionalShaderChannels { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002681 RID: 9857
		// (set) Token: 0x06002682 RID: 9858
		public extern string sortingLayerName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002683 RID: 9859
		public extern Canvas rootCanvas { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002684 RID: 9860
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Material GetDefaultCanvasMaterial();

		// Token: 0x06002685 RID: 9861
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Material GetETC1SupportedCanvasMaterial();

		// Token: 0x06002686 RID: 9862
		[Obsolete("Shared default material now used for text and general UI elements, call Canvas.GetDefaultCanvasMaterial()")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Material GetDefaultCanvasTextMaterial();

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06002687 RID: 9863 RVA: 0x0002C634 File Offset: 0x0002A834
		// (remove) Token: 0x06002688 RID: 9864 RVA: 0x0002C668 File Offset: 0x0002A868
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Canvas.WillRenderCanvases willRenderCanvases;

		// Token: 0x06002689 RID: 9865 RVA: 0x0002C69C File Offset: 0x0002A89C
		[RequiredByNativeCode]
		private static void SendWillRenderCanvases()
		{
			if (Canvas.willRenderCanvases != null)
			{
				Canvas.willRenderCanvases();
			}
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x0002C6B4 File Offset: 0x0002A8B4
		public static void ForceUpdateCanvases()
		{
			Canvas.SendWillRenderCanvases();
		}

		// Token: 0x02000242 RID: 578
		// (Invoke) Token: 0x0600268C RID: 9868
		public delegate void WillRenderCanvases();
	}
}
