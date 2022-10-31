using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200001F RID: 31
	public abstract class UIBehaviour : MonoBehaviour
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00002058 File Offset: 0x00000458
		protected virtual void Awake()
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000205B File Offset: 0x0000045B
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000205E File Offset: 0x0000045E
		protected virtual void Start()
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002061 File Offset: 0x00000461
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002064 File Offset: 0x00000464
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002068 File Offset: 0x00000468
		public virtual bool IsActive()
		{
			return base.isActiveAndEnabled;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002083 File Offset: 0x00000483
		protected virtual void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002086 File Offset: 0x00000486
		protected virtual void OnBeforeTransformParentChanged()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002089 File Offset: 0x00000489
		protected virtual void OnTransformParentChanged()
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000208C File Offset: 0x0000048C
		protected virtual void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000208F File Offset: 0x0000048F
		protected virtual void OnCanvasGroupChanged()
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002092 File Offset: 0x00000492
		protected virtual void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002098 File Offset: 0x00000498
		public bool IsDestroyed()
		{
			return this == null;
		}
	}
}
