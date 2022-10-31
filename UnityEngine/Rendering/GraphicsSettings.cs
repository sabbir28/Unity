using System;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020000A5 RID: 165
	public sealed class GraphicsSettings : Object
	{
		// Token: 0x06000BD0 RID: 3024
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShaderMode(BuiltinShaderType type, BuiltinShaderMode mode);

		// Token: 0x06000BD1 RID: 3025
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern BuiltinShaderMode GetShaderMode(BuiltinShaderType type);

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x000101D0 File Offset: 0x0000E3D0
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x000101F0 File Offset: 0x0000E3F0
		public static RenderPipelineAsset renderPipelineAsset
		{
			get
			{
				return GraphicsSettings.INTERNAL_renderPipelineAsset as RenderPipelineAsset;
			}
			set
			{
				GraphicsSettings.INTERNAL_renderPipelineAsset = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000BD4 RID: 3028
		// (set) Token: 0x06000BD5 RID: 3029
		private static extern ScriptableObject INTERNAL_renderPipelineAsset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000BD6 RID: 3030
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCustomShader(BuiltinShaderType type, Shader shader);

		// Token: 0x06000BD7 RID: 3031
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Shader GetCustomShader(BuiltinShaderType type);

		// Token: 0x06000BD8 RID: 3032
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Object GetGraphicsSettings();

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000BD9 RID: 3033
		// (set) Token: 0x06000BDA RID: 3034
		public static extern TransparencySortMode transparencySortMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x000101FC File Offset: 0x0000E3FC
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x0001021C File Offset: 0x0000E41C
		public static Vector3 transparencySortAxis
		{
			get
			{
				Vector3 result;
				GraphicsSettings.INTERNAL_get_transparencySortAxis(out result);
				return result;
			}
			set
			{
				GraphicsSettings.INTERNAL_set_transparencySortAxis(ref value);
			}
		}

		// Token: 0x06000BDD RID: 3037
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_transparencySortAxis(out Vector3 value);

		// Token: 0x06000BDE RID: 3038
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_transparencySortAxis(ref Vector3 value);

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000BDF RID: 3039
		// (set) Token: 0x06000BE0 RID: 3040
		public static extern bool lightsUseLinearIntensity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000BE1 RID: 3041
		// (set) Token: 0x06000BE2 RID: 3042
		public static extern bool lightsUseColorTemperature { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
