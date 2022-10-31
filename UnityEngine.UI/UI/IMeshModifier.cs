using System;

namespace UnityEngine.UI
{
	// Token: 0x020000AC RID: 172
	public interface IMeshModifier
	{
		// Token: 0x0600061D RID: 1565
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", false)]
		void ModifyMesh(Mesh mesh);

		// Token: 0x0600061E RID: 1566
		void ModifyMesh(VertexHelper verts);
	}
}
