using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200016C RID: 364
	[UsedByNativeCode]
	public struct RaycastHit
	{
		// Token: 0x06001A5C RID: 6748 RVA: 0x000208B8 File Offset: 0x0001EAB8
		private static void CalculateRaycastTexCoord(out Vector2 output, Collider col, Vector2 uv, Vector3 point, int face, int index)
		{
			RaycastHit.INTERNAL_CALL_CalculateRaycastTexCoord(out output, col, ref uv, ref point, face, index);
		}

		// Token: 0x06001A5D RID: 6749
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CalculateRaycastTexCoord(out Vector2 output, Collider col, ref Vector2 uv, ref Vector3 point, int face, int index);

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x000208CC File Offset: 0x0001EACC
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x000208E8 File Offset: 0x0001EAE8
		public Vector3 point
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

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x000208F4 File Offset: 0x0001EAF4
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x00020910 File Offset: 0x0001EB10
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

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0002091C File Offset: 0x0001EB1C
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0002096C File Offset: 0x0001EB6C
		public Vector3 barycentricCoordinate
		{
			get
			{
				return new Vector3(1f - (this.m_UV.y + this.m_UV.x), this.m_UV.x, this.m_UV.y);
			}
			set
			{
				this.m_UV = value;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0002097C File Offset: 0x0001EB7C
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x00020998 File Offset: 0x0001EB98
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

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x000209A4 File Offset: 0x0001EBA4
		public int triangleIndex
		{
			get
			{
				return this.m_FaceID;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x000209C0 File Offset: 0x0001EBC0
		public Vector2 textureCoord
		{
			get
			{
				Vector2 result;
				RaycastHit.CalculateRaycastTexCoord(out result, this.collider, this.m_UV, this.m_Point, this.m_FaceID, 0);
				return result;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x000209F8 File Offset: 0x0001EBF8
		public Vector2 textureCoord2
		{
			get
			{
				Vector2 result;
				RaycastHit.CalculateRaycastTexCoord(out result, this.collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
				return result;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x00020A30 File Offset: 0x0001EC30
		[Obsolete("Use textureCoord2 instead")]
		public Vector2 textureCoord1
		{
			get
			{
				Vector2 result;
				RaycastHit.CalculateRaycastTexCoord(out result, this.collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
				return result;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00020A68 File Offset: 0x0001EC68
		public Vector2 lightmapCoord
		{
			get
			{
				Vector2 result;
				RaycastHit.CalculateRaycastTexCoord(out result, this.collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
				if (this.collider.GetComponent<Renderer>() != null)
				{
					Vector4 lightmapScaleOffset = this.collider.GetComponent<Renderer>().lightmapScaleOffset;
					result.x = result.x * lightmapScaleOffset.x + lightmapScaleOffset.z;
					result.y = result.y * lightmapScaleOffset.y + lightmapScaleOffset.w;
				}
				return result;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x00020B04 File Offset: 0x0001ED04
		public Collider collider
		{
			get
			{
				return this.m_Collider;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00020B20 File Offset: 0x0001ED20
		public Rigidbody rigidbody
		{
			get
			{
				return (!(this.collider != null)) ? null : this.collider.attachedRigidbody;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x00020B58 File Offset: 0x0001ED58
		public Transform transform
		{
			get
			{
				Rigidbody rigidbody = this.rigidbody;
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

		// Token: 0x040003ED RID: 1005
		private Vector3 m_Point;

		// Token: 0x040003EE RID: 1006
		private Vector3 m_Normal;

		// Token: 0x040003EF RID: 1007
		private int m_FaceID;

		// Token: 0x040003F0 RID: 1008
		private float m_Distance;

		// Token: 0x040003F1 RID: 1009
		private Vector2 m_UV;

		// Token: 0x040003F2 RID: 1010
		private Collider m_Collider;
	}
}
