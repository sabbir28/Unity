using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020003BA RID: 954
	[UsedByNativeCode]
	public struct Plane
	{
		// Token: 0x06003250 RID: 12880 RVA: 0x0004D484 File Offset: 0x0004B684
		public Plane(Vector3 inNormal, Vector3 inPoint)
		{
			this.m_Normal = Vector3.Normalize(inNormal);
			this.m_Distance = -Vector3.Dot(inNormal, inPoint);
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x0004D4A4 File Offset: 0x0004B6A4
		public Plane(Vector3 inNormal, float d)
		{
			this.m_Normal = Vector3.Normalize(inNormal);
			this.m_Distance = d;
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x0004D4BC File Offset: 0x0004B6BC
		public Plane(Vector3 a, Vector3 b, Vector3 c)
		{
			this.m_Normal = Vector3.Normalize(Vector3.Cross(b - a, c - a));
			this.m_Distance = -Vector3.Dot(this.m_Normal, a);
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x0004D4F0 File Offset: 0x0004B6F0
		// (set) Token: 0x06003254 RID: 12884 RVA: 0x0004D50C File Offset: 0x0004B70C
		public Vector3 normal
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

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x0004D518 File Offset: 0x0004B718
		// (set) Token: 0x06003256 RID: 12886 RVA: 0x0004D534 File Offset: 0x0004B734
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

		// Token: 0x06003257 RID: 12887 RVA: 0x0004D540 File Offset: 0x0004B740
		public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint)
		{
			this.normal = Vector3.Normalize(inNormal);
			this.distance = -Vector3.Dot(inNormal, inPoint);
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x0004D560 File Offset: 0x0004B760
		public void Set3Points(Vector3 a, Vector3 b, Vector3 c)
		{
			this.normal = Vector3.Normalize(Vector3.Cross(b - a, c - a));
			this.distance = -Vector3.Dot(this.normal, a);
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x0004D594 File Offset: 0x0004B794
		public float GetDistanceToPoint(Vector3 inPt)
		{
			return Vector3.Dot(this.normal, inPt) + this.distance;
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x0004D5BC File Offset: 0x0004B7BC
		public bool GetSide(Vector3 inPt)
		{
			return Vector3.Dot(this.normal, inPt) + this.distance > 0f;
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x0004D5EC File Offset: 0x0004B7EC
		public bool SameSide(Vector3 inPt0, Vector3 inPt1)
		{
			float distanceToPoint = this.GetDistanceToPoint(inPt0);
			float distanceToPoint2 = this.GetDistanceToPoint(inPt1);
			return (distanceToPoint > 0f && distanceToPoint2 > 0f) || (distanceToPoint <= 0f && distanceToPoint2 <= 0f);
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x0004D64C File Offset: 0x0004B84C
		public bool Raycast(Ray ray, out float enter)
		{
			float num = Vector3.Dot(ray.direction, this.normal);
			float num2 = -Vector3.Dot(ray.origin, this.normal) - this.distance;
			bool result;
			if (Mathf.Approximately(num, 0f))
			{
				enter = 0f;
				result = false;
			}
			else
			{
				enter = num2 / num;
				result = (enter > 0f);
			}
			return result;
		}

		// Token: 0x04000E7E RID: 3710
		private Vector3 m_Normal;

		// Token: 0x04000E7F RID: 3711
		private float m_Distance;
	}
}
