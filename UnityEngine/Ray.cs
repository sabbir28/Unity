using System;

namespace UnityEngine
{
	// Token: 0x020003C8 RID: 968
	public struct Ray
	{
		// Token: 0x0600327D RID: 12925 RVA: 0x0004DA34 File Offset: 0x0004BC34
		public Ray(Vector3 origin, Vector3 direction)
		{
			this.m_Origin = origin;
			this.m_Direction = direction.normalized;
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x0004DA4C File Offset: 0x0004BC4C
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x0004DA68 File Offset: 0x0004BC68
		public Vector3 origin
		{
			get
			{
				return this.m_Origin;
			}
			set
			{
				this.m_Origin = value;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x0004DA74 File Offset: 0x0004BC74
		// (set) Token: 0x06003281 RID: 12929 RVA: 0x0004DA90 File Offset: 0x0004BC90
		public Vector3 direction
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				this.m_Direction = value.normalized;
			}
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x0004DAA0 File Offset: 0x0004BCA0
		public Vector3 GetPoint(float distance)
		{
			return this.m_Origin + this.m_Direction * distance;
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x0004DACC File Offset: 0x0004BCCC
		public override string ToString()
		{
			return UnityString.Format("Origin: {0}, Dir: {1}", new object[]
			{
				this.m_Origin,
				this.m_Direction
			});
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x0004DB10 File Offset: 0x0004BD10
		public string ToString(string format)
		{
			return UnityString.Format("Origin: {0}, Dir: {1}", new object[]
			{
				this.m_Origin.ToString(format),
				this.m_Direction.ToString(format)
			});
		}

		// Token: 0x04000E94 RID: 3732
		private Vector3 m_Origin;

		// Token: 0x04000E95 RID: 3733
		private Vector3 m_Direction;
	}
}
