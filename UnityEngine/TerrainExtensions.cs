using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200022B RID: 555
	public static class TerrainExtensions
	{
		// Token: 0x0600259E RID: 9630 RVA: 0x0002AEC4 File Offset: 0x000290C4
		public static void UpdateGIMaterials(this Terrain terrain)
		{
			if (terrain.terrainData == null)
			{
				throw new ArgumentException("Invalid terrainData.");
			}
			TerrainExtensions.UpdateGIMaterialsForTerrain(terrain, new Rect(0f, 0f, 1f, 1f));
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x0002AF04 File Offset: 0x00029104
		public static void UpdateGIMaterials(this Terrain terrain, int x, int y, int width, int height)
		{
			if (terrain.terrainData == null)
			{
				throw new ArgumentException("Invalid terrainData.");
			}
			float num = (float)terrain.terrainData.alphamapWidth;
			float num2 = (float)terrain.terrainData.alphamapHeight;
			TerrainExtensions.UpdateGIMaterialsForTerrain(terrain, new Rect((float)x / num, (float)y / num2, (float)width / num, (float)height / num2));
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x0002AF64 File Offset: 0x00029164
		internal static void UpdateGIMaterialsForTerrain(Terrain terrain, Rect uvBounds)
		{
			TerrainExtensions.INTERNAL_CALL_UpdateGIMaterialsForTerrain(terrain, ref uvBounds);
		}

		// Token: 0x060025A1 RID: 9633
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_UpdateGIMaterialsForTerrain(Terrain terrain, ref Rect uvBounds);
	}
}
