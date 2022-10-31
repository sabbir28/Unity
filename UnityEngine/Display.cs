using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000036 RID: 54
	[UsedByNativeCode]
	public sealed class Display
	{
		// Token: 0x060003DC RID: 988 RVA: 0x000068A0 File Offset: 0x00004AA0
		internal Display()
		{
			this.nativeDisplay = new IntPtr(0);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000068B8 File Offset: 0x00004AB8
		internal Display(IntPtr nativeDisplay)
		{
			this.nativeDisplay = nativeDisplay;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003DE RID: 990 RVA: 0x000068C8 File Offset: 0x00004AC8
		public int renderingWidth
		{
			get
			{
				int result = 0;
				int num = 0;
				Display.GetRenderingExtImpl(this.nativeDisplay, out result, out num);
				return result;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003DF RID: 991 RVA: 0x000068F4 File Offset: 0x00004AF4
		public int renderingHeight
		{
			get
			{
				int num = 0;
				int result = 0;
				Display.GetRenderingExtImpl(this.nativeDisplay, out num, out result);
				return result;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00006920 File Offset: 0x00004B20
		public int systemWidth
		{
			get
			{
				int result = 0;
				int num = 0;
				Display.GetSystemExtImpl(this.nativeDisplay, out result, out num);
				return result;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0000694C File Offset: 0x00004B4C
		public int systemHeight
		{
			get
			{
				int num = 0;
				int result = 0;
				Display.GetSystemExtImpl(this.nativeDisplay, out num, out result);
				return result;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00006978 File Offset: 0x00004B78
		public RenderBuffer colorBuffer
		{
			get
			{
				RenderBuffer result;
				RenderBuffer renderBuffer;
				Display.GetRenderingBuffersImpl(this.nativeDisplay, out result, out renderBuffer);
				return result;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000069A0 File Offset: 0x00004BA0
		public RenderBuffer depthBuffer
		{
			get
			{
				RenderBuffer renderBuffer;
				RenderBuffer result;
				Display.GetRenderingBuffersImpl(this.nativeDisplay, out renderBuffer, out result);
				return result;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x000069C8 File Offset: 0x00004BC8
		public bool active
		{
			get
			{
				return Display.GetActiveImp(this.nativeDisplay);
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000069E8 File Offset: 0x00004BE8
		public void Activate()
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, 0, 0, 60);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000069FC File Offset: 0x00004BFC
		public void Activate(int width, int height, int refreshRate)
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, width, height, refreshRate);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00006A10 File Offset: 0x00004C10
		public void SetParams(int width, int height, int x, int y)
		{
			Display.SetParamsImpl(this.nativeDisplay, width, height, x, y);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00006A24 File Offset: 0x00004C24
		public void SetRenderingResolution(int w, int h)
		{
			Display.SetRenderingResolutionImpl(this.nativeDisplay, w, h);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00006A34 File Offset: 0x00004C34
		[Obsolete("MultiDisplayLicense has been deprecated.", false)]
		public static bool MultiDisplayLicense()
		{
			return true;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00006A4C File Offset: 0x00004C4C
		public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
		{
			int num = 0;
			int num2 = 0;
			int x = (int)inputMouseCoordinates.x;
			int y = (int)inputMouseCoordinates.y;
			Vector3 result;
			result.z = (float)Display.RelativeMouseAtImpl(x, y, out num, out num2);
			result.x = (float)num;
			result.y = (float)num2;
			return result;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00006AA4 File Offset: 0x00004CA4
		public static Display main
		{
			get
			{
				return Display._mainDisplay;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00006AC0 File Offset: 0x00004CC0
		[RequiredByNativeCode]
		private static void RecreateDisplayList(IntPtr[] nativeDisplay)
		{
			Display.displays = new Display[nativeDisplay.Length];
			for (int i = 0; i < nativeDisplay.Length; i++)
			{
				Display.displays[i] = new Display(nativeDisplay[i]);
			}
			Display._mainDisplay = Display.displays[0];
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00006B0C File Offset: 0x00004D0C
		[RequiredByNativeCode]
		private static void FireDisplaysUpdated()
		{
			if (Display.onDisplaysUpdated != null)
			{
				Display.onDisplaysUpdated();
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060003EE RID: 1006 RVA: 0x00006B24 File Offset: 0x00004D24
		// (remove) Token: 0x060003EF RID: 1007 RVA: 0x00006B58 File Offset: 0x00004D58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Display.DisplaysUpdatedDelegate onDisplaysUpdated;

		// Token: 0x060003F0 RID: 1008
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h);

		// Token: 0x060003F1 RID: 1009
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h);

		// Token: 0x060003F2 RID: 1010
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth);

		// Token: 0x060003F3 RID: 1011
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetRenderingResolutionImpl(IntPtr nativeDisplay, int w, int h);

		// Token: 0x060003F4 RID: 1012
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ActivateDisplayImpl(IntPtr nativeDisplay, int width, int height, int refreshRate);

		// Token: 0x060003F5 RID: 1013
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetParamsImpl(IntPtr nativeDisplay, int width, int height, int x, int y);

		// Token: 0x060003F6 RID: 1014
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int RelativeMouseAtImpl(int x, int y, out int rx, out int ry);

		// Token: 0x060003F7 RID: 1015
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetActiveImp(IntPtr nativeDisplay);

		// Token: 0x060003F8 RID: 1016 RVA: 0x00006B8C File Offset: 0x00004D8C
		// Note: this type is marked as 'beforefieldinit'.
		static Display()
		{
			Display.onDisplaysUpdated = null;
		}

		// Token: 0x04000056 RID: 86
		internal IntPtr nativeDisplay;

		// Token: 0x04000057 RID: 87
		public static Display[] displays = new Display[]
		{
			new Display()
		};

		// Token: 0x04000058 RID: 88
		private static Display _mainDisplay = Display.displays[0];

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x060003FA RID: 1018
		public delegate void DisplaysUpdatedDelegate();
	}
}
