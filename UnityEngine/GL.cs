using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200005C RID: 92
	public sealed class GL
	{
		// Token: 0x0600070B RID: 1803
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vertex3(float x, float y, float z);

		// Token: 0x0600070C RID: 1804 RVA: 0x00009300 File Offset: 0x00007500
		public static void Vertex(Vector3 v)
		{
			GL.INTERNAL_CALL_Vertex(ref v);
		}

		// Token: 0x0600070D RID: 1805
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Vertex(ref Vector3 v);

		// Token: 0x0600070E RID: 1806 RVA: 0x0000930C File Offset: 0x0000750C
		public static void Color(Color c)
		{
			GL.INTERNAL_CALL_Color(ref c);
		}

		// Token: 0x0600070F RID: 1807
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Color(ref Color c);

		// Token: 0x06000710 RID: 1808 RVA: 0x00009318 File Offset: 0x00007518
		public static void TexCoord(Vector3 v)
		{
			GL.INTERNAL_CALL_TexCoord(ref v);
		}

		// Token: 0x06000711 RID: 1809
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_TexCoord(ref Vector3 v);

		// Token: 0x06000712 RID: 1810
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TexCoord2(float x, float y);

		// Token: 0x06000713 RID: 1811
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TexCoord3(float x, float y, float z);

		// Token: 0x06000714 RID: 1812
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MultiTexCoord2(int unit, float x, float y);

		// Token: 0x06000715 RID: 1813
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MultiTexCoord3(int unit, float x, float y, float z);

		// Token: 0x06000716 RID: 1814 RVA: 0x00009324 File Offset: 0x00007524
		public static void MultiTexCoord(int unit, Vector3 v)
		{
			GL.INTERNAL_CALL_MultiTexCoord(unit, ref v);
		}

		// Token: 0x06000717 RID: 1815
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MultiTexCoord(int unit, ref Vector3 v);

		// Token: 0x06000718 RID: 1816
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void BeginInternal(int mode);

		// Token: 0x06000719 RID: 1817 RVA: 0x00009330 File Offset: 0x00007530
		public static void Begin(int mode)
		{
			GL.BeginInternal(mode);
		}

		// Token: 0x0600071A RID: 1818
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void End();

		// Token: 0x0600071B RID: 1819
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PushMatrix();

		// Token: 0x0600071C RID: 1820
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PopMatrix();

		// Token: 0x0600071D RID: 1821
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadIdentity();

		// Token: 0x0600071E RID: 1822
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadOrtho();

		// Token: 0x0600071F RID: 1823
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadPixelMatrix();

		// Token: 0x06000720 RID: 1824
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void LoadPixelMatrixArgs(float left, float right, float bottom, float top);

		// Token: 0x06000721 RID: 1825 RVA: 0x0000933C File Offset: 0x0000753C
		public static void LoadPixelMatrix(float left, float right, float bottom, float top)
		{
			GL.LoadPixelMatrixArgs(left, right, bottom, top);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00009348 File Offset: 0x00007548
		public static void Viewport(Rect pixelRect)
		{
			GL.INTERNAL_CALL_Viewport(ref pixelRect);
		}

		// Token: 0x06000723 RID: 1827
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Viewport(ref Rect pixelRect);

		// Token: 0x06000724 RID: 1828 RVA: 0x00009354 File Offset: 0x00007554
		public static void LoadProjectionMatrix(Matrix4x4 mat)
		{
			GL.INTERNAL_CALL_LoadProjectionMatrix(ref mat);
		}

		// Token: 0x06000725 RID: 1829
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_LoadProjectionMatrix(ref Matrix4x4 mat);

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00009360 File Offset: 0x00007560
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00009380 File Offset: 0x00007580
		public static Matrix4x4 modelview
		{
			get
			{
				Matrix4x4 result;
				GL.INTERNAL_get_modelview(out result);
				return result;
			}
			set
			{
				GL.INTERNAL_set_modelview(ref value);
			}
		}

		// Token: 0x06000728 RID: 1832
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_modelview(out Matrix4x4 value);

		// Token: 0x06000729 RID: 1833
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_modelview(ref Matrix4x4 value);

		// Token: 0x0600072A RID: 1834 RVA: 0x0000938C File Offset: 0x0000758C
		public static void MultMatrix(Matrix4x4 mat)
		{
			GL.INTERNAL_CALL_MultMatrix(ref mat);
		}

		// Token: 0x0600072B RID: 1835
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MultMatrix(ref Matrix4x4 mat);

		// Token: 0x0600072C RID: 1836 RVA: 0x00009398 File Offset: 0x00007598
		public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture)
		{
			Matrix4x4 result;
			GL.INTERNAL_CALL_GetGPUProjectionMatrix(ref proj, renderIntoTexture, out result);
			return result;
		}

		// Token: 0x0600072D RID: 1837
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetGPUProjectionMatrix(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 value);

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600072E RID: 1838
		// (set) Token: 0x0600072F RID: 1839
		public static extern bool wireframe { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000730 RID: 1840
		// (set) Token: 0x06000731 RID: 1841
		public static extern bool sRGBWrite { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000732 RID: 1842
		// (set) Token: 0x06000733 RID: 1843
		public static extern bool invertCulling { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000734 RID: 1844
		[Obsolete("Use invertCulling property")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetRevertBackfacing(bool revertBackFaces);

		// Token: 0x06000735 RID: 1845 RVA: 0x000093B8 File Offset: 0x000075B8
		[ExcludeFromDocs]
		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor)
		{
			float depth = 1f;
			GL.Clear(clearDepth, clearColor, backgroundColor, depth);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000093D8 File Offset: 0x000075D8
		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, [DefaultValue("1.0f")] float depth)
		{
			GL.Internal_Clear(clearDepth, clearColor, backgroundColor, depth);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000093E4 File Offset: 0x000075E4
		private static void Internal_Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			GL.INTERNAL_CALL_Internal_Clear(clearDepth, clearColor, ref backgroundColor, depth);
		}

		// Token: 0x06000738 RID: 1848
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Clear(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth);

		// Token: 0x06000739 RID: 1849
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearWithSkybox(bool clearDepth, Camera camera);

		// Token: 0x0600073A RID: 1850
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Flush();

		// Token: 0x0600073B RID: 1851
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InvalidateState();

		// Token: 0x0600073C RID: 1852
		[Obsolete("IssuePluginEvent(eventID) is deprecated. Use IssuePluginEvent(callback, eventID) instead.")]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void IssuePluginEvent(int eventID);

		// Token: 0x0600073D RID: 1853 RVA: 0x000093F4 File Offset: 0x000075F4
		public static void IssuePluginEvent(IntPtr callback, int eventID)
		{
			if (callback == IntPtr.Zero)
			{
				throw new ArgumentException("Null callback specified.");
			}
			GL.IssuePluginEventInternal(callback, eventID);
		}

		// Token: 0x0600073E RID: 1854
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void IssuePluginEventInternal(IntPtr callback, int eventID);

		// Token: 0x0600073F RID: 1855
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RenderTargetBarrier();

		// Token: 0x0400007A RID: 122
		public const int TRIANGLES = 4;

		// Token: 0x0400007B RID: 123
		public const int TRIANGLE_STRIP = 5;

		// Token: 0x0400007C RID: 124
		public const int QUADS = 7;

		// Token: 0x0400007D RID: 125
		public const int LINES = 1;

		// Token: 0x0400007E RID: 126
		public const int LINE_STRIP = 2;
	}
}
