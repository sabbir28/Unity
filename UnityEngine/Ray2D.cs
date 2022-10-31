using System;

namespace UnityEngine
{
	// Token: 0x020003C9 RID: 969
	public struct Ray2D
	{
		// Token: 0x06003285 RID: 12933 RVA: 0x0004DB54 File Offset: 0x0004BD54
		public Ray2D(Vector2 origin, Vector2 direction)
		{
			this.m_Origin = origin;
			this.m_Direction = direction.normalized;
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x0004DB6C File Offset: 0x0004BD6C
		// (set) Token: 0x06003287 RID: 12935 RVA: 0x0004DB88 File Offset: 0x0004BD88
		public Vector2 origin
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

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x0004DB94 File Offset: 0x0004BD94
		// (set) Token: 0x06003289 RID: 12937 RVA: 0x0004DBB0 File Offset: 0x0004BDB0
		public Vector2 direction
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

		// Token: 0x0600328A RID: 12938 RVA: 0x0004DBC0 File Offset: 0x0004BDC0
		public Vector2 GetPoint(float distance)
		{
			return this.m_Origin + this.m_Direction * distance;
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x0004DBEC File Offset: 0x0004BDEC
		public override string ToString()
		{
			return UnityString.Format("Origin: {0}, Dir: {1}", new object[]
			{
				this.m_Origin,
				this.m_Direction
			});
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x0004DC30 File Offset: 0x0004BE30
		public string ToString(string format)
		{
			return UnityString.Format("Origin: {0}, Dir: {1}", new object[]
			{
				this.m_Origin.ToString(format),
				this.m_Direction.ToString(format)
			});
		}

		// Token: 0x04000E96 RID: 3734
		private Vector2 m_Origin;

		// Token: 0x04000E97 RID: 3735
		private Vector2 m_Direction;
	}
}
