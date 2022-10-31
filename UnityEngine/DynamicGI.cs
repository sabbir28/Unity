using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000E0 RID: 224
	public sealed class DynamicGI
	{
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001071 RID: 4209
		// (set) Token: 0x06001072 RID: 4210
		public static extern float indirectScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001073 RID: 4211
		// (set) Token: 0x06001074 RID: 4212
		public static extern float updateThreshold { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001075 RID: 4213 RVA: 0x000163C8 File Offset: 0x000145C8
		public static void SetEmissive(Renderer renderer, Color color)
		{
			DynamicGI.INTERNAL_CALL_SetEmissive(renderer, ref color);
		}

		// Token: 0x06001076 RID: 4214
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetEmissive(Renderer renderer, ref Color color);

		// Token: 0x06001077 RID: 4215 RVA: 0x000163D4 File Offset: 0x000145D4
		[Obsolete("DynamicGI.UpdateMaterials(Renderer) is deprecated; instead, use extension method from RendererExtensions: 'renderer.UpdateGIMaterials()' (UnityUpgradable).", true)]
		public static void UpdateMaterials(Renderer renderer)
		{
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x000163D8 File Offset: 0x000145D8
		[Obsolete("DynamicGI.UpdateMaterials(Terrain) is deprecated; instead, use extension method from TerrainExtensions: 'terrain.UpdateGIMaterials()' (UnityUpgradable).", true)]
		public static void UpdateMaterials(Object renderer)
		{
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x000163DC File Offset: 0x000145DC
		[Obsolete("DynamicGI.UpdateMaterials(Terrain, int, int, int, int) is deprecated; instead, use extension method from TerrainExtensions: 'terrain.UpdateGIMaterials(x, y, width, height)' (UnityUpgradable).", true)]
		public static void UpdateMaterials(Object renderer, int x, int y, int width, int height)
		{
		}

		// Token: 0x0600107A RID: 4218
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateEnvironment();

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600107B RID: 4219
		// (set) Token: 0x0600107C RID: 4220
		public static extern bool synchronousMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
