using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	public sealed class BillboardAsset : Object
	{
		// Token: 0x06000202 RID: 514 RVA: 0x00005038 File Offset: 0x00003238
		public BillboardAsset()
		{
			BillboardAsset.Internal_Create(this);
		}

		// Token: 0x06000203 RID: 515
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] BillboardAsset obj);

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000204 RID: 516
		// (set) Token: 0x06000205 RID: 517
		public extern float width { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000206 RID: 518
		// (set) Token: 0x06000207 RID: 519
		public extern float height { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000208 RID: 520
		// (set) Token: 0x06000209 RID: 521
		public extern float bottom { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600020A RID: 522
		public extern int imageCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600020B RID: 523
		public extern int vertexCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600020C RID: 524
		public extern int indexCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600020D RID: 525
		// (set) Token: 0x0600020E RID: 526
		public extern Material material { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600020F RID: 527 RVA: 0x00005048 File Offset: 0x00003248
		public void GetImageTexCoords(List<Vector4> imageTexCoords)
		{
			if (imageTexCoords == null)
			{
				throw new ArgumentNullException("imageTexCoords");
			}
			this.GetImageTexCoordsInternal(imageTexCoords);
		}

		// Token: 0x06000210 RID: 528
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Vector4[] GetImageTexCoords();

		// Token: 0x06000211 RID: 529
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetImageTexCoordsInternal(object list);

		// Token: 0x06000212 RID: 530 RVA: 0x00005064 File Offset: 0x00003264
		public void SetImageTexCoords(List<Vector4> imageTexCoords)
		{
			if (imageTexCoords == null)
			{
				throw new ArgumentNullException("imageTexCoords");
			}
			this.SetImageTexCoordsInternalList(imageTexCoords);
		}

		// Token: 0x06000213 RID: 531
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetImageTexCoords(Vector4[] imageTexCoords);

		// Token: 0x06000214 RID: 532
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetImageTexCoordsInternalList(object list);

		// Token: 0x06000215 RID: 533 RVA: 0x00005080 File Offset: 0x00003280
		public void GetVertices(List<Vector2> vertices)
		{
			if (vertices == null)
			{
				throw new ArgumentNullException("vertices");
			}
			this.GetVerticesInternal(vertices);
		}

		// Token: 0x06000216 RID: 534
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Vector2[] GetVertices();

		// Token: 0x06000217 RID: 535
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetVerticesInternal(object list);

		// Token: 0x06000218 RID: 536 RVA: 0x0000509C File Offset: 0x0000329C
		public void SetVertices(List<Vector2> vertices)
		{
			if (vertices == null)
			{
				throw new ArgumentNullException("vertices");
			}
			this.SetVerticesInternalList(vertices);
		}

		// Token: 0x06000219 RID: 537
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetVertices(Vector2[] vertices);

		// Token: 0x0600021A RID: 538
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetVerticesInternalList(object list);

		// Token: 0x0600021B RID: 539 RVA: 0x000050B8 File Offset: 0x000032B8
		public void GetIndices(List<ushort> indices)
		{
			if (indices == null)
			{
				throw new ArgumentNullException("indices");
			}
			this.GetIndicesInternal(indices);
		}

		// Token: 0x0600021C RID: 540
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ushort[] GetIndices();

		// Token: 0x0600021D RID: 541
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetIndicesInternal(object list);

		// Token: 0x0600021E RID: 542 RVA: 0x000050D4 File Offset: 0x000032D4
		public void SetIndices(List<ushort> indices)
		{
			if (indices == null)
			{
				throw new ArgumentNullException("indices");
			}
			this.SetIndicesInternalList(indices);
		}

		// Token: 0x0600021F RID: 543
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetIndices(ushort[] indices);

		// Token: 0x06000220 RID: 544
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetIndicesInternalList(object list);

		// Token: 0x06000221 RID: 545
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void MakeMaterialProperties(MaterialPropertyBlock properties, Camera camera);
	}
}
