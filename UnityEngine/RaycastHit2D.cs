using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200016F RID: 367
	[UsedByNativeCode]
	public struct RaycastHit2D
	{
		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x00020CCC File Offset: 0x0001EECC
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x00020CE8 File Offset: 0x0001EEE8
		public Vector2 centroid
		{
			get
			{
				return this.m_Centroid;
			}
			set
			{
				this.m_Centroid = value;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x00020CF4 File Offset: 0x0001EEF4
		// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x00020D10 File Offset: 0x0001EF10
		public Vector2 point
		{
			get
			{
				return this.m_Point;
			}
			set
			{
				this.m_Point = value;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x00020D1C File Offset: 0x0001EF1C
		// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x00020D38 File Offset: 0x0001EF38
		public Vector2 normal
		{
			get
			{
				return this.m_Normal;
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x00020D44 File Offset: 0x0001EF44
		// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x00020D60 File Offset: 0x0001EF60
		public float distance
		{
			get
			{
				return this.m_Distance;
			}
			set
			{
				this.m_Distance = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x00020D6C File Offset: 0x0001EF6C
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x00020D88 File Offset: 0x0001EF88
		public float fraction
		{
			get
			{
				return this.m_Fraction;
			}
			set
			{
				this.m_Fraction = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x00020D94 File Offset: 0x0001EF94
		public Collider2D collider
		{
			get
			{
				return this.m_Collider;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x00020DB0 File Offset: 0x0001EFB0
		public Rigidbody2D rigidbody
		{
			get
			{
				return (!(this.collider != null)) ? null : this.collider.attachedRigidbody;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x00020DE8 File Offset: 0x0001EFE8
		public Transform transform
		{
			get
			{
				Rigidbody2D rigidbody = this.rigidbody;
				Transform result;
				if (rigidbody != null)
				{
					result = rigidbody.transform;
				}
				else if (this.collider != null)
				{
					result = this.collider.transform;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00020E40 File Offset: 0x0001F040
		public static implicit operator bool(RaycastHit2D hit)
		{
			return hit.collider != null;
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00020E64 File Offset: 0x0001F064
		public int CompareTo(RaycastHit2D other)
		{
			int result;
			if (this.collider == null)
			{
				result = 1;
			}
			else if (other.collider == null)
			{
				result = -1;
			}
			else
			{
				result = this.fraction.CompareTo(other.fraction);
			}
			return result;
		}

		// Token: 0x040003F3 RID: 1011
		private Vector2 m_Centroid;

		// Token: 0x040003F4 RID: 1012
		private Vector2 m_Point;

		// Token: 0x040003F5 RID: 1013
		private Vector2 m_Normal;

		// Token: 0x040003F6 RID: 1014
		private float m_Distance;

		// Token: 0x040003F7 RID: 1015
		private float m_Fraction;

		// Token: 0x040003F8 RID: 1016
		private Collider2D m_Collider;
	}
}
