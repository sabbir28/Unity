using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000087 RID: 135
	public sealed class Mesh : Object
	{
		// Token: 0x060009D4 RID: 2516 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		public Mesh()
		{
			Mesh.Internal_Create(this);
		}

		// Token: 0x060009D5 RID: 2517
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] Mesh mono);

		// Token: 0x060009D6 RID: 2518
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear([UnityEngine.Internal.DefaultValue("true")] bool keepVertexLayout);

		// Token: 0x060009D7 RID: 2519 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		[ExcludeFromDocs]
		public void Clear()
		{
			bool keepVertexLayout = true;
			this.Clear(keepVertexLayout);
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060009D8 RID: 2520
		public extern bool isReadable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060009D9 RID: 2521
		internal extern bool canAccess { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060009DA RID: 2522
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void PrintErrorCantAccessMesh(Mesh.InternalShaderChannel channel);

		// Token: 0x060009DB RID: 2523
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void PrintErrorCantAccessMeshForIndices();

		// Token: 0x060009DC RID: 2524
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void PrintErrorBadSubmeshIndexTriangles();

		// Token: 0x060009DD RID: 2525
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void PrintErrorBadSubmeshIndexIndices();

		// Token: 0x060009DE RID: 2526
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetArrayForChannelImpl(Mesh.InternalShaderChannel channel, Mesh.InternalVertexChannelType format, int dim, Array values, int arraySize);

		// Token: 0x060009DF RID: 2527
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Array GetAllocArrayFromChannelImpl(Mesh.InternalShaderChannel channel, Mesh.InternalVertexChannelType format, int dim);

		// Token: 0x060009E0 RID: 2528
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetArrayFromChannelImpl(Mesh.InternalShaderChannel channel, Mesh.InternalVertexChannelType format, int dim, Array values);

		// Token: 0x060009E1 RID: 2529
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool HasChannel(Mesh.InternalShaderChannel channel);

		// Token: 0x060009E2 RID: 2530
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ResizeList(object list, int size);

		// Token: 0x060009E3 RID: 2531
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Array ExtractArrayFromList(object list);

		// Token: 0x060009E4 RID: 2532
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int[] GetTrianglesImpl(int submesh);

		// Token: 0x060009E5 RID: 2533
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetTrianglesNonAllocImpl(object values, int submesh);

		// Token: 0x060009E6 RID: 2534
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int[] GetIndicesImpl(int submesh);

		// Token: 0x060009E7 RID: 2535
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetIndicesNonAllocImpl(object values, int submesh);

		// Token: 0x060009E8 RID: 2536
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTrianglesImpl(int submesh, Array triangles, int arraySize, [UnityEngine.Internal.DefaultValue("true")] bool calculateBounds);

		// Token: 0x060009E9 RID: 2537 RVA: 0x0000E610 File Offset: 0x0000C810
		[ExcludeFromDocs]
		private void SetTrianglesImpl(int submesh, Array triangles, int arraySize)
		{
			bool calculateBounds = true;
			this.SetTrianglesImpl(submesh, triangles, arraySize, calculateBounds);
		}

		// Token: 0x060009EA RID: 2538
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetIndicesImpl(int submesh, MeshTopology topology, Array indices, int arraySize, [UnityEngine.Internal.DefaultValue("true")] bool calculateBounds);

		// Token: 0x060009EB RID: 2539 RVA: 0x0000E62C File Offset: 0x0000C82C
		[ExcludeFromDocs]
		private void SetIndicesImpl(int submesh, MeshTopology topology, Array indices, int arraySize)
		{
			bool calculateBounds = true;
			this.SetIndicesImpl(submesh, topology, indices, arraySize, calculateBounds);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0000E648 File Offset: 0x0000C848
		[ExcludeFromDocs]
		public void SetTriangles(int[] triangles, int submesh)
		{
			bool calculateBounds = true;
			this.SetTriangles(triangles, submesh, calculateBounds);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0000E664 File Offset: 0x0000C864
		public void SetTriangles(int[] triangles, int submesh, [UnityEngine.Internal.DefaultValue("true")] bool calculateBounds)
		{
			if (this.CheckCanAccessSubmeshTriangles(submesh))
			{
				this.SetTrianglesImpl(submesh, triangles, this.SafeLength(triangles), calculateBounds);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0000E684 File Offset: 0x0000C884
		[ExcludeFromDocs]
		public void SetTriangles(List<int> triangles, int submesh)
		{
			bool calculateBounds = true;
			this.SetTriangles(triangles, submesh, calculateBounds);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		public void SetTriangles(List<int> triangles, int submesh, [UnityEngine.Internal.DefaultValue("true")] bool calculateBounds)
		{
			if (this.CheckCanAccessSubmeshTriangles(submesh))
			{
				this.SetTrianglesImpl(submesh, Mesh.ExtractArrayFromList(triangles), this.SafeLength<int>(triangles), calculateBounds);
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0000E6C4 File Offset: 0x0000C8C4
		[ExcludeFromDocs]
		public void SetIndices(int[] indices, MeshTopology topology, int submesh)
		{
			bool calculateBounds = true;
			this.SetIndices(indices, topology, submesh, calculateBounds);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0000E6E0 File Offset: 0x0000C8E0
		public void SetIndices(int[] indices, MeshTopology topology, int submesh, [UnityEngine.Internal.DefaultValue("true")] bool calculateBounds)
		{
			if (this.CheckCanAccessSubmeshIndices(submesh))
			{
				this.SetIndicesImpl(submesh, topology, indices, this.SafeLength(indices), calculateBounds);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060009F2 RID: 2546
		public extern int blendShapeCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060009F3 RID: 2547
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ClearBlendShapes();

		// Token: 0x060009F4 RID: 2548
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetBlendShapeName(int shapeIndex);

		// Token: 0x060009F5 RID: 2549
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetBlendShapeFrameCount(int shapeIndex);

		// Token: 0x060009F6 RID: 2550
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex);

		// Token: 0x060009F7 RID: 2551
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents);

		// Token: 0x060009F8 RID: 2552
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents);

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060009F9 RID: 2553
		public extern int vertexBufferCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060009FA RID: 2554 RVA: 0x0000E704 File Offset: 0x0000C904
		public IntPtr GetNativeVertexBufferPtr(int bufferIndex)
		{
			IntPtr result;
			Mesh.INTERNAL_CALL_GetNativeVertexBufferPtr(this, bufferIndex, out result);
			return result;
		}

		// Token: 0x060009FB RID: 2555
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetNativeVertexBufferPtr(Mesh self, int bufferIndex, out IntPtr value);

		// Token: 0x060009FC RID: 2556 RVA: 0x0000E724 File Offset: 0x0000C924
		public IntPtr GetNativeIndexBufferPtr()
		{
			IntPtr result;
			Mesh.INTERNAL_CALL_GetNativeIndexBufferPtr(this, out result);
			return result;
		}

		// Token: 0x060009FD RID: 2557
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetNativeIndexBufferPtr(Mesh self, out IntPtr value);

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0000E744 File Offset: 0x0000C944
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0000E764 File Offset: 0x0000C964
		public Bounds bounds
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_bounds(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_bounds(ref value);
			}
		}

		// Token: 0x06000A00 RID: 2560
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		// Token: 0x06000A01 RID: 2561
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_bounds(ref Bounds value);

		// Token: 0x06000A02 RID: 2562
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RecalculateBounds();

		// Token: 0x06000A03 RID: 2563
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RecalculateNormals();

		// Token: 0x06000A04 RID: 2564
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RecalculateTangents();

		// Token: 0x06000A05 RID: 2565
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This method is no longer supported (UnityUpgradable)", true)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Optimize();

		// Token: 0x06000A06 RID: 2566
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MeshTopology GetTopology(int submesh);

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A07 RID: 2567
		public extern int vertexCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A08 RID: 2568
		// (set) Token: 0x06000A09 RID: 2569
		public extern int subMeshCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000A0A RID: 2570
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern uint GetIndexStart(int submesh);

		// Token: 0x06000A0B RID: 2571
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern uint GetIndexCount(int submesh);

		// Token: 0x06000A0C RID: 2572
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CombineMeshes(CombineInstance[] combine, [UnityEngine.Internal.DefaultValue("true")] bool mergeSubMeshes, [UnityEngine.Internal.DefaultValue("true")] bool useMatrices, [UnityEngine.Internal.DefaultValue("false")] bool hasLightmapData);

		// Token: 0x06000A0D RID: 2573 RVA: 0x0000E770 File Offset: 0x0000C970
		[ExcludeFromDocs]
		public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices)
		{
			bool hasLightmapData = false;
			this.CombineMeshes(combine, mergeSubMeshes, useMatrices, hasLightmapData);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0000E78C File Offset: 0x0000C98C
		[ExcludeFromDocs]
		public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes)
		{
			bool hasLightmapData = false;
			bool useMatrices = true;
			this.CombineMeshes(combine, mergeSubMeshes, useMatrices, hasLightmapData);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		[ExcludeFromDocs]
		public void CombineMeshes(CombineInstance[] combine)
		{
			bool hasLightmapData = false;
			bool useMatrices = true;
			bool mergeSubMeshes = true;
			this.CombineMeshes(combine, mergeSubMeshes, useMatrices, hasLightmapData);
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A10 RID: 2576
		// (set) Token: 0x06000A11 RID: 2577
		public extern BoneWeight[] boneWeights { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000A12 RID: 2578
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetBoneWeightsNonAllocImpl(object values);

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A13 RID: 2579
		// (set) Token: 0x06000A14 RID: 2580
		public extern Matrix4x4[] bindposes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000A15 RID: 2581
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetBindposeCount();

		// Token: 0x06000A16 RID: 2582
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetBindposesNonAllocImpl(object values);

		// Token: 0x06000A17 RID: 2583
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void MarkDynamic();

		// Token: 0x06000A18 RID: 2584
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UploadMeshData(bool markNoLogerReadable);

		// Token: 0x06000A19 RID: 2585
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetBlendShapeIndex(string blendShapeName);

		// Token: 0x06000A1A RID: 2586 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
		internal Mesh.InternalShaderChannel GetUVChannel(int uvIndex)
		{
			if (uvIndex < 0 || uvIndex > 3)
			{
				throw new ArgumentException("GetUVChannel called for bad uvIndex", "uvIndex");
			}
			return Mesh.InternalShaderChannel.TexCoord0 + uvIndex;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0000E800 File Offset: 0x0000CA00
		internal static int DefaultDimensionForChannel(Mesh.InternalShaderChannel channel)
		{
			int result;
			if (channel == Mesh.InternalShaderChannel.Vertex || channel == Mesh.InternalShaderChannel.Normal)
			{
				result = 3;
			}
			else if (channel >= Mesh.InternalShaderChannel.TexCoord0 && channel <= Mesh.InternalShaderChannel.TexCoord3)
			{
				result = 2;
			}
			else
			{
				if (channel != Mesh.InternalShaderChannel.Tangent && channel != Mesh.InternalShaderChannel.Color)
				{
					throw new ArgumentException("DefaultDimensionForChannel called for bad channel", "channel");
				}
				result = 4;
			}
			return result;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0000E860 File Offset: 0x0000CA60
		private T[] GetAllocArrayFromChannel<T>(Mesh.InternalShaderChannel channel, Mesh.InternalVertexChannelType format, int dim)
		{
			if (this.canAccess)
			{
				if (this.HasChannel(channel))
				{
					return (T[])this.GetAllocArrayFromChannelImpl(channel, format, dim);
				}
			}
			else
			{
				this.PrintErrorCantAccessMesh(channel);
			}
			return new T[0];
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		private T[] GetAllocArrayFromChannel<T>(Mesh.InternalShaderChannel channel)
		{
			return this.GetAllocArrayFromChannel<T>(channel, Mesh.InternalVertexChannelType.Float, Mesh.DefaultDimensionForChannel(channel));
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0000E8DC File Offset: 0x0000CADC
		private int SafeLength(Array values)
		{
			return (values == null) ? 0 : values.Length;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0000E904 File Offset: 0x0000CB04
		private int SafeLength<T>(List<T> values)
		{
			return (values == null) ? 0 : values.Count;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0000E92C File Offset: 0x0000CB2C
		private void SetSizedArrayForChannel(Mesh.InternalShaderChannel channel, Mesh.InternalVertexChannelType format, int dim, Array values, int valuesCount)
		{
			if (this.canAccess)
			{
				this.SetArrayForChannelImpl(channel, format, dim, values, valuesCount);
			}
			else
			{
				this.PrintErrorCantAccessMesh(channel);
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0000E954 File Offset: 0x0000CB54
		private void SetArrayForChannel<T>(Mesh.InternalShaderChannel channel, Mesh.InternalVertexChannelType format, int dim, T[] values)
		{
			this.SetSizedArrayForChannel(channel, format, dim, values, this.SafeLength(values));
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0000E96C File Offset: 0x0000CB6C
		private void SetArrayForChannel<T>(Mesh.InternalShaderChannel channel, T[] values)
		{
			this.SetSizedArrayForChannel(channel, Mesh.InternalVertexChannelType.Float, Mesh.DefaultDimensionForChannel(channel), values, this.SafeLength(values));
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0000E988 File Offset: 0x0000CB88
		private void SetListForChannel<T>(Mesh.InternalShaderChannel channel, Mesh.InternalVertexChannelType format, int dim, List<T> values)
		{
			this.SetSizedArrayForChannel(channel, format, dim, Mesh.ExtractArrayFromList(values), this.SafeLength<T>(values));
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0000E9A4 File Offset: 0x0000CBA4
		private void SetListForChannel<T>(Mesh.InternalShaderChannel channel, List<T> values)
		{
			this.SetSizedArrayForChannel(channel, Mesh.InternalVertexChannelType.Float, Mesh.DefaultDimensionForChannel(channel), Mesh.ExtractArrayFromList(values), this.SafeLength<T>(values));
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0000E9C4 File Offset: 0x0000CBC4
		private void GetListForChannel<T>(List<T> buffer, int capacity, Mesh.InternalShaderChannel channel, int dim)
		{
			this.GetListForChannel<T>(buffer, capacity, channel, dim, Mesh.InternalVertexChannelType.Float);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0000E9D4 File Offset: 0x0000CBD4
		private void GetListForChannel<T>(List<T> buffer, int capacity, Mesh.InternalShaderChannel channel, int dim, Mesh.InternalVertexChannelType channelType)
		{
			buffer.Clear();
			if (!this.canAccess)
			{
				this.PrintErrorCantAccessMesh(channel);
			}
			else if (this.HasChannel(channel))
			{
				this.PrepareUserBuffer<T>(buffer, capacity);
				this.GetArrayFromChannelImpl(channel, channelType, dim, Mesh.ExtractArrayFromList(buffer));
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0000EA2C File Offset: 0x0000CC2C
		private void PrepareUserBuffer<T>(List<T> buffer, int capacity)
		{
			buffer.Clear();
			if (buffer.Capacity < capacity)
			{
				buffer.Capacity = capacity;
			}
			Mesh.ResizeList(buffer, capacity);
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0000EA50 File Offset: 0x0000CC50
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x0000EA6C File Offset: 0x0000CC6C
		public Vector3[] vertices
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector3>(Mesh.InternalShaderChannel.Vertex);
			}
			set
			{
				this.SetArrayForChannel<Vector3>(Mesh.InternalShaderChannel.Vertex, value);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0000EA78 File Offset: 0x0000CC78
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x0000EA94 File Offset: 0x0000CC94
		public Vector3[] normals
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector3>(Mesh.InternalShaderChannel.Normal);
			}
			set
			{
				this.SetArrayForChannel<Vector3>(Mesh.InternalShaderChannel.Normal, value);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x0000EABC File Offset: 0x0000CCBC
		public Vector4[] tangents
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector4>(Mesh.InternalShaderChannel.Tangent);
			}
			set
			{
				this.SetArrayForChannel<Vector4>(Mesh.InternalShaderChannel.Tangent, value);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0000EAC8 File Offset: 0x0000CCC8
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
		public Vector2[] uv
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(Mesh.InternalShaderChannel.TexCoord0);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(Mesh.InternalShaderChannel.TexCoord0, value);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		public Vector2[] uv2
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(Mesh.InternalShaderChannel.TexCoord1);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(Mesh.InternalShaderChannel.TexCoord1, value);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0000EB18 File Offset: 0x0000CD18
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x0000EB34 File Offset: 0x0000CD34
		public Vector2[] uv3
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(Mesh.InternalShaderChannel.TexCoord2);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(Mesh.InternalShaderChannel.TexCoord2, value);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0000EB40 File Offset: 0x0000CD40
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x0000EB5C File Offset: 0x0000CD5C
		public Vector2[] uv4
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(Mesh.InternalShaderChannel.TexCoord3);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(Mesh.InternalShaderChannel.TexCoord3, value);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0000EB68 File Offset: 0x0000CD68
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x0000EB84 File Offset: 0x0000CD84
		public Color[] colors
		{
			get
			{
				return this.GetAllocArrayFromChannel<Color>(Mesh.InternalShaderChannel.Color);
			}
			set
			{
				this.SetArrayForChannel<Color>(Mesh.InternalShaderChannel.Color, value);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0000EB90 File Offset: 0x0000CD90
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		public Color32[] colors32
		{
			get
			{
				return this.GetAllocArrayFromChannel<Color32>(Mesh.InternalShaderChannel.Color, Mesh.InternalVertexChannelType.Color, 1);
			}
			set
			{
				this.SetArrayForChannel<Color32>(Mesh.InternalShaderChannel.Color, Mesh.InternalVertexChannelType.Color, 1, value);
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		public void GetVertices(List<Vector3> vertices)
		{
			if (vertices == null)
			{
				throw new ArgumentNullException("The result vertices list cannot be null.", "vertices");
			}
			this.GetListForChannel<Vector3>(vertices, this.vertexCount, Mesh.InternalShaderChannel.Vertex, Mesh.DefaultDimensionForChannel(Mesh.InternalShaderChannel.Vertex));
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		public void SetVertices(List<Vector3> inVertices)
		{
			this.SetListForChannel<Vector3>(Mesh.InternalShaderChannel.Vertex, inVertices);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0000EBFC File Offset: 0x0000CDFC
		public void GetNormals(List<Vector3> normals)
		{
			if (normals == null)
			{
				throw new ArgumentNullException("The result normals list cannot be null.", "normals");
			}
			this.GetListForChannel<Vector3>(normals, this.vertexCount, Mesh.InternalShaderChannel.Normal, Mesh.DefaultDimensionForChannel(Mesh.InternalShaderChannel.Normal));
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0000EC2C File Offset: 0x0000CE2C
		public void SetNormals(List<Vector3> inNormals)
		{
			this.SetListForChannel<Vector3>(Mesh.InternalShaderChannel.Normal, inNormals);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0000EC38 File Offset: 0x0000CE38
		public void GetTangents(List<Vector4> tangents)
		{
			if (tangents == null)
			{
				throw new ArgumentNullException("The result tangents list cannot be null.", "tangents");
			}
			this.GetListForChannel<Vector4>(tangents, this.vertexCount, Mesh.InternalShaderChannel.Tangent, Mesh.DefaultDimensionForChannel(Mesh.InternalShaderChannel.Tangent));
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0000EC68 File Offset: 0x0000CE68
		public void SetTangents(List<Vector4> inTangents)
		{
			this.SetListForChannel<Vector4>(Mesh.InternalShaderChannel.Tangent, inTangents);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0000EC74 File Offset: 0x0000CE74
		public void GetColors(List<Color> colors)
		{
			if (colors == null)
			{
				throw new ArgumentNullException("The result colors list cannot be null.", "colors");
			}
			this.GetListForChannel<Color>(colors, this.vertexCount, Mesh.InternalShaderChannel.Color, Mesh.DefaultDimensionForChannel(Mesh.InternalShaderChannel.Color));
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
		public void SetColors(List<Color> inColors)
		{
			this.SetListForChannel<Color>(Mesh.InternalShaderChannel.Color, inColors);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0000ECB0 File Offset: 0x0000CEB0
		public void GetColors(List<Color32> colors)
		{
			if (colors == null)
			{
				throw new ArgumentNullException("The result colors list cannot be null.", "colors");
			}
			this.GetListForChannel<Color32>(colors, this.vertexCount, Mesh.InternalShaderChannel.Color, 1, Mesh.InternalVertexChannelType.Color);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0000ECDC File Offset: 0x0000CEDC
		public void SetColors(List<Color32> inColors)
		{
			this.SetListForChannel<Color32>(Mesh.InternalShaderChannel.Color, Mesh.InternalVertexChannelType.Color, 1, inColors);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs)
		{
			if (uvIndex < 0 || uvIndex > 3)
			{
				Debug.LogError("The uv index is invalid (must be in [0..3]");
			}
			else
			{
				this.SetListForChannel<T>(this.GetUVChannel(uvIndex), Mesh.InternalVertexChannelType.Float, dim, uvs);
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0000ED20 File Offset: 0x0000CF20
		public void SetUVs(int channel, List<Vector2> uvs)
		{
			this.SetUvsImpl<Vector2>(channel, 2, uvs);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0000ED2C File Offset: 0x0000CF2C
		public void SetUVs(int channel, List<Vector3> uvs)
		{
			this.SetUvsImpl<Vector3>(channel, 3, uvs);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0000ED38 File Offset: 0x0000CF38
		public void SetUVs(int channel, List<Vector4> uvs)
		{
			this.SetUvsImpl<Vector4>(channel, 4, uvs);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0000ED44 File Offset: 0x0000CF44
		private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim)
		{
			if (uvs == null)
			{
				throw new ArgumentNullException("The result uvs list cannot be null.", "uvs");
			}
			if (uvIndex < 0 || uvIndex > 3)
			{
				throw new IndexOutOfRangeException("Specified uv index is out of range. Must be in the range [0, 3].");
			}
			this.GetListForChannel<T>(uvs, this.vertexCount, this.GetUVChannel(uvIndex), dim);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0000ED98 File Offset: 0x0000CF98
		public void GetUVs(int channel, List<Vector2> uvs)
		{
			this.GetUVsImpl<Vector2>(channel, uvs, 2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
		public void GetUVs(int channel, List<Vector3> uvs)
		{
			this.GetUVsImpl<Vector3>(channel, uvs, 3);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0000EDB0 File Offset: 0x0000CFB0
		public void GetUVs(int channel, List<Vector4> uvs)
		{
			this.GetUVsImpl<Vector4>(channel, uvs, 4);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0000EDBC File Offset: 0x0000CFBC
		private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
		{
			bool result;
			if (!this.canAccess)
			{
				this.PrintErrorCantAccessMeshForIndices();
				result = false;
			}
			else if (submesh < 0 || submesh >= this.subMeshCount)
			{
				if (errorAboutTriangles)
				{
					this.PrintErrorBadSubmeshIndexTriangles();
				}
				else
				{
					this.PrintErrorBadSubmeshIndexIndices();
				}
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0000EE20 File Offset: 0x0000D020
		private bool CheckCanAccessSubmeshTriangles(int submesh)
		{
			return this.CheckCanAccessSubmesh(submesh, true);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0000EE40 File Offset: 0x0000D040
		private bool CheckCanAccessSubmeshIndices(int submesh)
		{
			return this.CheckCanAccessSubmesh(submesh, false);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0000EE60 File Offset: 0x0000D060
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x0000EE9C File Offset: 0x0000D09C
		public int[] triangles
		{
			get
			{
				int[] result;
				if (this.canAccess)
				{
					result = this.GetTrianglesImpl(-1);
				}
				else
				{
					this.PrintErrorCantAccessMeshForIndices();
					result = new int[0];
				}
				return result;
			}
			set
			{
				if (this.canAccess)
				{
					this.SetTrianglesImpl(-1, value, this.SafeLength(value));
				}
				else
				{
					this.PrintErrorCantAccessMeshForIndices();
				}
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		public int[] GetTriangles(int submesh)
		{
			return (!this.CheckCanAccessSubmeshTriangles(submesh)) ? new int[0] : this.GetTrianglesImpl(submesh);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		public void GetTriangles(List<int> triangles, int submesh)
		{
			if (triangles == null)
			{
				throw new ArgumentNullException("The result triangles list cannot be null.", "triangles");
			}
			if (submesh < 0 || submesh >= this.subMeshCount)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			this.PrepareUserBuffer<int>(triangles, (int)this.GetIndexCount(submesh));
			this.GetTrianglesNonAllocImpl(triangles, submesh);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0000EF50 File Offset: 0x0000D150
		public int[] GetIndices(int submesh)
		{
			return (!this.CheckCanAccessSubmeshIndices(submesh)) ? new int[0] : this.GetIndicesImpl(submesh);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0000EF84 File Offset: 0x0000D184
		public void GetIndices(List<int> indices, int submesh)
		{
			if (indices == null)
			{
				throw new ArgumentNullException("The result indices list cannot be null.", "indices");
			}
			if (submesh < 0 || submesh >= this.subMeshCount)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			this.PrepareUserBuffer<int>(indices, (int)this.GetIndexCount(submesh));
			indices.Clear();
			this.GetIndicesNonAllocImpl(indices, submesh);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0000EFE4 File Offset: 0x0000D1E4
		public void GetBindposes(List<Matrix4x4> bindposes)
		{
			if (bindposes == null)
			{
				throw new ArgumentNullException("The result bindposes list cannot be null.", "bindposes");
			}
			this.PrepareUserBuffer<Matrix4x4>(bindposes, this.GetBindposeCount());
			this.GetBindposesNonAllocImpl(bindposes);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0000F014 File Offset: 0x0000D214
		public void GetBoneWeights(List<BoneWeight> boneWeights)
		{
			if (boneWeights == null)
			{
				throw new ArgumentNullException("The result boneWeights list cannot be null.", "boneWeights");
			}
			this.PrepareUserBuffer<BoneWeight>(boneWeights, this.vertexCount);
			this.GetBoneWeightsNonAllocImpl(boneWeights);
		}

		// Token: 0x02000088 RID: 136
		internal enum InternalShaderChannel
		{
			// Token: 0x040000FD RID: 253
			Vertex,
			// Token: 0x040000FE RID: 254
			Normal,
			// Token: 0x040000FF RID: 255
			Color,
			// Token: 0x04000100 RID: 256
			TexCoord0,
			// Token: 0x04000101 RID: 257
			TexCoord1,
			// Token: 0x04000102 RID: 258
			TexCoord2,
			// Token: 0x04000103 RID: 259
			TexCoord3,
			// Token: 0x04000104 RID: 260
			Tangent
		}

		// Token: 0x02000089 RID: 137
		internal enum InternalVertexChannelType
		{
			// Token: 0x04000106 RID: 262
			Float,
			// Token: 0x04000107 RID: 263
			Color = 2
		}
	}
}
