using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200023D RID: 573
	[UsedByNativeCode]
	public struct UIVertex
	{
		// Token: 0x040006B7 RID: 1719
		public Vector3 position;

		// Token: 0x040006B8 RID: 1720
		public Vector3 normal;

		// Token: 0x040006B9 RID: 1721
		public Color32 color;

		// Token: 0x040006BA RID: 1722
		public Vector2 uv0;

		// Token: 0x040006BB RID: 1723
		public Vector2 uv1;

		// Token: 0x040006BC RID: 1724
		public Vector2 uv2;

		// Token: 0x040006BD RID: 1725
		public Vector2 uv3;

		// Token: 0x040006BE RID: 1726
		public Vector4 tangent;

		// Token: 0x040006BF RID: 1727
		private static readonly Color32 s_DefaultColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x040006C0 RID: 1728
		private static readonly Vector4 s_DefaultTangent = new Vector4(1f, 0f, 0f, -1f);

		// Token: 0x040006C1 RID: 1729
		public static UIVertex simpleVert = new UIVertex
		{
			position = Vector3.zero,
			normal = Vector3.back,
			tangent = UIVertex.s_DefaultTangent,
			color = UIVertex.s_DefaultColor,
			uv0 = Vector2.zero,
			uv1 = Vector2.zero,
			uv2 = Vector2.zero,
			uv3 = Vector2.zero
		};
	}
}
