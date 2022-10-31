using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x020000A9 RID: 169
	[Obsolete("Use BaseMeshEffect instead", true)]
	public abstract class BaseVertexEffect
	{
		// Token: 0x06000614 RID: 1556
		[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", true)]
		public abstract void ModifyVertices(List<UIVertex> vertices);
	}
}
