using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200001E RID: 30
	public struct RaycastResult
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000033F0 File Offset: 0x000017F0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000340B File Offset: 0x0000180B
		public GameObject gameObject
		{
			get
			{
				return this.m_GameObject;
			}
			set
			{
				this.m_GameObject = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003418 File Offset: 0x00001818
		public bool isValid
		{
			get
			{
				return this.module != null && this.gameObject != null;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003450 File Offset: 0x00001850
		public void Clear()
		{
			this.gameObject = null;
			this.module = null;
			this.distance = 0f;
			this.index = 0f;
			this.depth = 0;
			this.sortingLayer = 0;
			this.sortingOrder = 0;
			this.worldNormal = Vector3.up;
			this.worldPosition = Vector3.zero;
			this.screenPosition = Vector2.zero;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000034B8 File Offset: 0x000018B8
		public override string ToString()
		{
			string result;
			if (!this.isValid)
			{
				result = "";
			}
			else
			{
				result = string.Concat(new object[]
				{
					"Name: ",
					this.gameObject,
					"\nmodule: ",
					this.module,
					"\ndistance: ",
					this.distance,
					"\nindex: ",
					this.index,
					"\ndepth: ",
					this.depth,
					"\nworldNormal: ",
					this.worldNormal,
					"\nworldPosition: ",
					this.worldPosition,
					"\nscreenPosition: ",
					this.screenPosition,
					"\nmodule.sortOrderPriority: ",
					this.module.sortOrderPriority,
					"\nmodule.renderOrderPriority: ",
					this.module.renderOrderPriority,
					"\nsortingLayer: ",
					this.sortingLayer,
					"\nsortingOrder: ",
					this.sortingOrder
				});
			}
			return result;
		}

		// Token: 0x04000051 RID: 81
		private GameObject m_GameObject;

		// Token: 0x04000052 RID: 82
		public BaseRaycaster module;

		// Token: 0x04000053 RID: 83
		public float distance;

		// Token: 0x04000054 RID: 84
		public float index;

		// Token: 0x04000055 RID: 85
		public int depth;

		// Token: 0x04000056 RID: 86
		public int sortingLayer;

		// Token: 0x04000057 RID: 87
		public int sortingOrder;

		// Token: 0x04000058 RID: 88
		public Vector3 worldPosition;

		// Token: 0x04000059 RID: 89
		public Vector3 worldNormal;

		// Token: 0x0400005A RID: 90
		public Vector2 screenPosition;
	}
}
