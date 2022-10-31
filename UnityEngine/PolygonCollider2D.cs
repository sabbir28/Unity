using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000183 RID: 387
	public sealed class PolygonCollider2D : Collider2D
	{
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001CDE RID: 7390
		// (set) Token: 0x06001CDF RID: 7391
		public extern Vector2[] points { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001CE0 RID: 7392
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Vector2[] GetPath(int index);

		// Token: 0x06001CE1 RID: 7393
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPath(int index, Vector2[] points);

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001CE2 RID: 7394
		// (set) Token: 0x06001CE3 RID: 7395
		public extern int pathCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001CE4 RID: 7396
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetTotalPointCount();

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00024150 File Offset: 0x00022350
		public void CreatePrimitive(int sides, [DefaultValue("Vector2.one")] Vector2 scale, [DefaultValue("Vector2.zero")] Vector2 offset)
		{
			PolygonCollider2D.INTERNAL_CALL_CreatePrimitive(this, sides, ref scale, ref offset);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00024160 File Offset: 0x00022360
		[ExcludeFromDocs]
		public void CreatePrimitive(int sides, Vector2 scale)
		{
			Vector2 zero = Vector2.zero;
			PolygonCollider2D.INTERNAL_CALL_CreatePrimitive(this, sides, ref scale, ref zero);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00024180 File Offset: 0x00022380
		[ExcludeFromDocs]
		public void CreatePrimitive(int sides)
		{
			Vector2 zero = Vector2.zero;
			Vector2 one = Vector2.one;
			PolygonCollider2D.INTERNAL_CALL_CreatePrimitive(this, sides, ref one, ref zero);
		}

		// Token: 0x06001CE8 RID: 7400
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CreatePrimitive(PolygonCollider2D self, int sides, ref Vector2 scale, ref Vector2 offset);

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001CE9 RID: 7401
		// (set) Token: 0x06001CEA RID: 7402
		public extern bool autoTiling { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
