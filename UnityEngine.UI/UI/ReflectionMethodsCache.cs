using System;
using System.Reflection;
using UnityEngineInternal;

namespace UnityEngine.UI
{
	// Token: 0x020000A3 RID: 163
	internal class ReflectionMethodsCache
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x0001D8D4 File Offset: 0x0001BCD4
		public ReflectionMethodsCache()
		{
			MethodInfo method = typeof(Physics).GetMethod("Raycast", new Type[]
			{
				typeof(Ray),
				typeof(RaycastHit).MakeByRefType(),
				typeof(float),
				typeof(int)
			});
			if (method != null)
			{
				this.raycast3D = (ReflectionMethodsCache.Raycast3DCallback)ScriptingUtils.CreateDelegate(typeof(ReflectionMethodsCache.Raycast3DCallback), method);
			}
			MethodInfo method2 = typeof(Physics2D).GetMethod("Raycast", new Type[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(float),
				typeof(int)
			});
			if (method2 != null)
			{
				this.raycast2D = (ReflectionMethodsCache.Raycast2DCallback)ScriptingUtils.CreateDelegate(typeof(ReflectionMethodsCache.Raycast2DCallback), method2);
			}
			MethodInfo method3 = typeof(Physics).GetMethod("RaycastAll", new Type[]
			{
				typeof(Ray),
				typeof(float),
				typeof(int)
			});
			if (method3 != null)
			{
				this.raycast3DAll = (ReflectionMethodsCache.RaycastAllCallback)ScriptingUtils.CreateDelegate(typeof(ReflectionMethodsCache.RaycastAllCallback), method3);
			}
			MethodInfo method4 = typeof(Physics2D).GetMethod("GetRayIntersectionAll", new Type[]
			{
				typeof(Ray),
				typeof(float),
				typeof(int)
			});
			if (method4 != null)
			{
				this.getRayIntersectionAll = (ReflectionMethodsCache.GetRayIntersectionAllCallback)ScriptingUtils.CreateDelegate(typeof(ReflectionMethodsCache.GetRayIntersectionAllCallback), method4);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0001DAB0 File Offset: 0x0001BEB0
		public static ReflectionMethodsCache Singleton
		{
			get
			{
				if (ReflectionMethodsCache.s_ReflectionMethodsCache == null)
				{
					ReflectionMethodsCache.s_ReflectionMethodsCache = new ReflectionMethodsCache();
				}
				return ReflectionMethodsCache.s_ReflectionMethodsCache;
			}
		}

		// Token: 0x040002C5 RID: 709
		public ReflectionMethodsCache.Raycast3DCallback raycast3D = null;

		// Token: 0x040002C6 RID: 710
		public ReflectionMethodsCache.RaycastAllCallback raycast3DAll = null;

		// Token: 0x040002C7 RID: 711
		public ReflectionMethodsCache.Raycast2DCallback raycast2D = null;

		// Token: 0x040002C8 RID: 712
		public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll = null;

		// Token: 0x040002C9 RID: 713
		private static ReflectionMethodsCache s_ReflectionMethodsCache = null;

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x060005F2 RID: 1522
		public delegate bool Raycast3DCallback(Ray r, out RaycastHit hit, float f, int i);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x060005F6 RID: 1526
		public delegate RaycastHit2D Raycast2DCallback(Vector2 p1, Vector2 p2, float f, int i);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x060005FA RID: 1530
		public delegate RaycastHit[] RaycastAllCallback(Ray r, float f, int i);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x060005FE RID: 1534
		public delegate RaycastHit2D[] GetRayIntersectionAllCallback(Ray r, float f, int i);
	}
}
