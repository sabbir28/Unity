using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000080 RID: 128
	[UsedByNativeCode]
	public struct Bounds
	{
		// Token: 0x06000944 RID: 2372 RVA: 0x0000D1B4 File Offset: 0x0000B3B4
		public Bounds(Vector3 center, Vector3 size)
		{
			this.m_Center = center;
			this.m_Extents = size * 0.5f;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		[ThreadAndSerializationSafe]
		private static bool Internal_Contains(Bounds m, Vector3 point)
		{
			return Bounds.INTERNAL_CALL_Internal_Contains(ref m, ref point);
		}

		// Token: 0x06000946 RID: 2374
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_Contains(ref Bounds m, ref Vector3 point);

		// Token: 0x06000947 RID: 2375 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		public bool Contains(Vector3 point)
		{
			return Bounds.Internal_Contains(this, point);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0000D214 File Offset: 0x0000B414
		private static float Internal_SqrDistance(Bounds m, Vector3 point)
		{
			return Bounds.INTERNAL_CALL_Internal_SqrDistance(ref m, ref point);
		}

		// Token: 0x06000949 RID: 2377
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_Internal_SqrDistance(ref Bounds m, ref Vector3 point);

		// Token: 0x0600094A RID: 2378 RVA: 0x0000D234 File Offset: 0x0000B434
		public float SqrDistance(Vector3 point)
		{
			return Bounds.Internal_SqrDistance(this, point);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0000D258 File Offset: 0x0000B458
		private static bool Internal_IntersectRay(ref Ray ray, ref Bounds bounds, out float distance)
		{
			return Bounds.INTERNAL_CALL_Internal_IntersectRay(ref ray, ref bounds, out distance);
		}

		// Token: 0x0600094C RID: 2380
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_IntersectRay(ref Ray ray, ref Bounds bounds, out float distance);

		// Token: 0x0600094D RID: 2381 RVA: 0x0000D278 File Offset: 0x0000B478
		public bool IntersectRay(Ray ray)
		{
			float num;
			return Bounds.Internal_IntersectRay(ref ray, ref this, out num);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0000D298 File Offset: 0x0000B498
		public bool IntersectRay(Ray ray, out float distance)
		{
			return Bounds.Internal_IntersectRay(ref ray, ref this, out distance);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		private static Vector3 Internal_GetClosestPoint(ref Bounds bounds, ref Vector3 point)
		{
			Vector3 result;
			Bounds.INTERNAL_CALL_Internal_GetClosestPoint(ref bounds, ref point, out result);
			return result;
		}

		// Token: 0x06000950 RID: 2384
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetClosestPoint(ref Bounds bounds, ref Vector3 point, out Vector3 value);

		// Token: 0x06000951 RID: 2385 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		public Vector3 ClosestPoint(Vector3 point)
		{
			return Bounds.Internal_GetClosestPoint(ref this, ref point);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0000D2F8 File Offset: 0x0000B4F8
		public override int GetHashCode()
		{
			return this.center.GetHashCode() ^ this.extents.GetHashCode() << 2;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0000D338 File Offset: 0x0000B538
		public override bool Equals(object other)
		{
			bool result;
			if (!(other is Bounds))
			{
				result = false;
			}
			else
			{
				Bounds bounds = (Bounds)other;
				result = (this.center.Equals(bounds.center) && this.extents.Equals(bounds.extents));
			}
			return result;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x0000D3CC File Offset: 0x0000B5CC
		public Vector3 center
		{
			get
			{
				return this.m_Center;
			}
			set
			{
				this.m_Center = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0000D3D8 File Offset: 0x0000B5D8
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x0000D400 File Offset: 0x0000B600
		public Vector3 size
		{
			get
			{
				return this.m_Extents * 2f;
			}
			set
			{
				this.m_Extents = value * 0.5f;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0000D414 File Offset: 0x0000B614
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x0000D430 File Offset: 0x0000B630
		public Vector3 extents
		{
			get
			{
				return this.m_Extents;
			}
			set
			{
				this.m_Extents = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0000D43C File Offset: 0x0000B63C
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x0000D464 File Offset: 0x0000B664
		public Vector3 min
		{
			get
			{
				return this.center - this.extents;
			}
			set
			{
				this.SetMinMax(value, this.max);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0000D474 File Offset: 0x0000B674
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x0000D49C File Offset: 0x0000B69C
		public Vector3 max
		{
			get
			{
				return this.center + this.extents;
			}
			set
			{
				this.SetMinMax(this.min, value);
			}
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0000D4AC File Offset: 0x0000B6AC
		public static bool operator ==(Bounds lhs, Bounds rhs)
		{
			return lhs.center == rhs.center && lhs.extents == rhs.extents;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
		public static bool operator !=(Bounds lhs, Bounds rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0000D510 File Offset: 0x0000B710
		public void SetMinMax(Vector3 min, Vector3 max)
		{
			this.extents = (max - min) * 0.5f;
			this.center = min + this.extents;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0000D53C File Offset: 0x0000B73C
		public void Encapsulate(Vector3 point)
		{
			this.SetMinMax(Vector3.Min(this.min, point), Vector3.Max(this.max, point));
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0000D560 File Offset: 0x0000B760
		public void Encapsulate(Bounds bounds)
		{
			this.Encapsulate(bounds.center - bounds.extents);
			this.Encapsulate(bounds.center + bounds.extents);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0000D598 File Offset: 0x0000B798
		public void Expand(float amount)
		{
			amount *= 0.5f;
			this.extents += new Vector3(amount, amount, amount);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		public void Expand(Vector3 amount)
		{
			this.extents += amount * 0.5f;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0000D5E0 File Offset: 0x0000B7E0
		public bool Intersects(Bounds bounds)
		{
			return this.min.x <= bounds.max.x && this.max.x >= bounds.min.x && this.min.y <= bounds.max.y && this.max.y >= bounds.min.y && this.min.z <= bounds.max.z && this.max.z >= bounds.min.z;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
		public override string ToString()
		{
			return UnityString.Format("Center: {0}, Extents: {1}", new object[]
			{
				this.m_Center,
				this.m_Extents
			});
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0000D714 File Offset: 0x0000B914
		public string ToString(string format)
		{
			return UnityString.Format("Center: {0}, Extents: {1}", new object[]
			{
				this.m_Center.ToString(format),
				this.m_Extents.ToString(format)
			});
		}

		// Token: 0x040000E8 RID: 232
		private Vector3 m_Center;

		// Token: 0x040000E9 RID: 233
		private Vector3 m_Extents;
	}
}
