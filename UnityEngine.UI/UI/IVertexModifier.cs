using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x020000AB RID: 171
	[Obsolete("Use IMeshModifier instead", true)]
	public interface IVertexModifier
	{
		// Token: 0x0600061C RID: 1564
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", true)]
		void ModifyVertices(List<UIVertex> verts);
	}
}
