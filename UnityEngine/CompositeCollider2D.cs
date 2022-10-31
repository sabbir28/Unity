using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000180 RID: 384
	[RequireComponent(typeof(Rigidbody2D))]
	public sealed class CompositeCollider2D : Collider2D
	{
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001CCD RID: 7373
		// (set) Token: 0x06001CCE RID: 7374
		public extern CompositeCollider2D.GeometryType geometryType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001CCF RID: 7375
		// (set) Token: 0x06001CD0 RID: 7376
		public extern CompositeCollider2D.GenerationType generationType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001CD1 RID: 7377
		// (set) Token: 0x06001CD2 RID: 7378
		public extern float vertexDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001CD3 RID: 7379
		// (set) Token: 0x06001CD4 RID: 7380
		public extern float edgeRadius { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00024078 File Offset: 0x00022278
		public void GenerateGeometry()
		{
			CompositeCollider2D.INTERNAL_CALL_GenerateGeometry(this);
		}

		// Token: 0x06001CD6 RID: 7382
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GenerateGeometry(CompositeCollider2D self);

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00024084 File Offset: 0x00022284
		public int GetPathPointCount(int index)
		{
			if (index < 0 || index >= this.pathCount)
			{
				throw new ArgumentOutOfRangeException("index", string.Format("Path index {0} must be in the range of 0 to {1}.", index, this.pathCount - 1));
			}
			return this.Internal_GetPathPointCount(index);
		}

		// Token: 0x06001CD8 RID: 7384
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int Internal_GetPathPointCount(int index);

		// Token: 0x06001CD9 RID: 7385 RVA: 0x000240DC File Offset: 0x000222DC
		public int GetPath(int index, Vector2[] points)
		{
			if (index < 0 || index >= this.pathCount)
			{
				throw new ArgumentOutOfRangeException("index", string.Format("Path index {0} must be in the range of 0 to {1}.", index, this.pathCount - 1));
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			return this.Internal_GetPath(index, points);
		}

		// Token: 0x06001CDA RID: 7386
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int Internal_GetPath(int index, Vector2[] points);

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001CDB RID: 7387
		public extern int pathCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001CDC RID: 7388
		public extern int pointCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x02000181 RID: 385
		public enum GeometryType
		{
			// Token: 0x0400042B RID: 1067
			Outlines,
			// Token: 0x0400042C RID: 1068
			Polygons
		}

		// Token: 0x02000182 RID: 386
		public enum GenerationType
		{
			// Token: 0x0400042E RID: 1070
			Synchronous,
			// Token: 0x0400042F RID: 1071
			Manual
		}
	}
}
