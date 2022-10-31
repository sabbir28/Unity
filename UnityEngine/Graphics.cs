using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000053 RID: 83
	public sealed class Graphics
	{
		// Token: 0x06000642 RID: 1602
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Array ExtractArrayFromList(object list);

		// Token: 0x06000643 RID: 1603 RVA: 0x00007FF0 File Offset: 0x000061F0
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
		{
			bool useLightProbes = true;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00008018 File Offset: 0x00006218
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			bool useLightProbes = true;
			bool receiveShadows = true;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00008040 File Offset: 0x00006240
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			bool useLightProbes = true;
			bool receiveShadows = true;
			bool castShadows = true;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00008068 File Offset: 0x00006268
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex)
		{
			bool useLightProbes = true;
			bool receiveShadows = true;
			bool castShadows = true;
			MaterialPropertyBlock properties = null;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00008094 File Offset: 0x00006294
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera)
		{
			bool useLightProbes = true;
			bool receiveShadows = true;
			bool castShadows = true;
			MaterialPropertyBlock properties = null;
			int submeshIndex = 0;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000080C0 File Offset: 0x000062C0
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer)
		{
			bool useLightProbes = true;
			bool receiveShadows = true;
			bool castShadows = true;
			MaterialPropertyBlock properties = null;
			int submeshIndex = 0;
			Camera camera = null;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x000080F0 File Offset: 0x000062F0
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, [DefaultValue("null")] Camera camera, [DefaultValue("0")] int submeshIndex, [DefaultValue("null")] MaterialPropertyBlock properties, [DefaultValue("true")] bool castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("true")] bool useLightProbes)
		{
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, (!castShadows) ? ShadowCastingMode.Off : ShadowCastingMode.On, receiveShadows, null, useLightProbes);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00008124 File Offset: 0x00006324
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
		{
			bool useLightProbes = true;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000814C File Offset: 0x0000634C
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows)
		{
			bool useLightProbes = true;
			Transform probeAnchor = null;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00008178 File Offset: 0x00006378
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows)
		{
			bool useLightProbes = true;
			Transform probeAnchor = null;
			bool receiveShadows = true;
			Graphics.DrawMesh(mesh, position, rotation, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000081A4 File Offset: 0x000063A4
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("null")] Transform probeAnchor, [DefaultValue("true")] bool useLightProbes)
		{
			Graphics.DrawMeshImpl(mesh, Matrix4x4.TRS(position, rotation, Vector3.one), material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000081D8 File Offset: 0x000063D8
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows)
		{
			bool useLightProbes = true;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000081FC File Offset: 0x000063FC
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows)
		{
			bool useLightProbes = true;
			bool receiveShadows = true;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00008224 File Offset: 0x00006424
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties)
		{
			bool useLightProbes = true;
			bool receiveShadows = true;
			bool castShadows = true;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0000824C File Offset: 0x0000644C
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex)
		{
			bool useLightProbes = true;
			bool receiveShadows = true;
			bool castShadows = true;
			MaterialPropertyBlock properties = null;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00008274 File Offset: 0x00006474
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera)
		{
			bool useLightProbes = true;
			bool receiveShadows = true;
			bool castShadows = true;
			MaterialPropertyBlock properties = null;
			int submeshIndex = 0;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000082A0 File Offset: 0x000064A0
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer)
		{
			bool useLightProbes = true;
			bool receiveShadows = true;
			bool castShadows = true;
			MaterialPropertyBlock properties = null;
			int submeshIndex = 0;
			Camera camera = null;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, useLightProbes);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000082D0 File Offset: 0x000064D0
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, [DefaultValue("null")] Camera camera, [DefaultValue("0")] int submeshIndex, [DefaultValue("null")] MaterialPropertyBlock properties, [DefaultValue("true")] bool castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("true")] bool useLightProbes)
		{
			Graphics.DrawMeshImpl(mesh, matrix, material, layer, camera, submeshIndex, properties, (!castShadows) ? ShadowCastingMode.Off : ShadowCastingMode.On, receiveShadows, null, useLightProbes);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00008300 File Offset: 0x00006500
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor)
		{
			bool useLightProbes = true;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00008328 File Offset: 0x00006528
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows)
		{
			bool useLightProbes = true;
			Transform probeAnchor = null;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00008350 File Offset: 0x00006550
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows)
		{
			bool useLightProbes = true;
			Transform probeAnchor = null;
			bool receiveShadows = true;
			Graphics.DrawMesh(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00008378 File Offset: 0x00006578
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("null")] Transform probeAnchor, [DefaultValue("true")] bool useLightProbes)
		{
			Graphics.DrawMeshImpl(mesh, matrix, material, layer, camera, submeshIndex, properties, castShadows, receiveShadows, probeAnchor, useLightProbes);
		}

		// Token: 0x06000659 RID: 1625
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_DrawMeshMatrix(ref Internal_DrawMeshMatrixArguments arguments, MaterialPropertyBlock properties, Material material, Mesh mesh, Camera camera);

		// Token: 0x0600065A RID: 1626 RVA: 0x000083A0 File Offset: 0x000065A0
		private static void Internal_DrawMeshNow1(Mesh mesh, int subsetIndex, Vector3 position, Quaternion rotation)
		{
			Graphics.INTERNAL_CALL_Internal_DrawMeshNow1(mesh, subsetIndex, ref position, ref rotation);
		}

		// Token: 0x0600065B RID: 1627
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawMeshNow1(Mesh mesh, int subsetIndex, ref Vector3 position, ref Quaternion rotation);

		// Token: 0x0600065C RID: 1628 RVA: 0x000083B0 File Offset: 0x000065B0
		private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix)
		{
			Graphics.INTERNAL_CALL_Internal_DrawMeshNow2(mesh, subsetIndex, ref matrix);
		}

		// Token: 0x0600065D RID: 1629
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix);

		// Token: 0x0600065E RID: 1630
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DrawProcedural(MeshTopology topology, int vertexCount, [DefaultValue("1")] int instanceCount);

		// Token: 0x0600065F RID: 1631 RVA: 0x000083BC File Offset: 0x000065BC
		[ExcludeFromDocs]
		public static void DrawProcedural(MeshTopology topology, int vertexCount)
		{
			int instanceCount = 1;
			Graphics.DrawProcedural(topology, vertexCount, instanceCount);
		}

		// Token: 0x06000660 RID: 1632
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DrawProceduralIndirect(MeshTopology topology, ComputeBuffer bufferWithArgs, [DefaultValue("0")] int argsOffset);

		// Token: 0x06000661 RID: 1633 RVA: 0x000083D4 File Offset: 0x000065D4
		[ExcludeFromDocs]
		public static void DrawProceduralIndirect(MeshTopology topology, ComputeBuffer bufferWithArgs)
		{
			int argsOffset = 0;
			Graphics.DrawProceduralIndirect(topology, bufferWithArgs, argsOffset);
		}

		// Token: 0x06000662 RID: 1634
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMaxDrawMeshInstanceCount();

		// Token: 0x06000663 RID: 1635 RVA: 0x000083EC File Offset: 0x000065EC
		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Camera camera = null;
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00008410 File Offset: 0x00006610
		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows)
		{
			Camera camera = null;
			int layer = 0;
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00008438 File Offset: 0x00006638
		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows)
		{
			Camera camera = null;
			int layer = 0;
			bool receiveShadows = true;
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00008460 File Offset: 0x00006660
		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties)
		{
			Camera camera = null;
			int layer = 0;
			bool receiveShadows = true;
			ShadowCastingMode castShadows = ShadowCastingMode.On;
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00008488 File Offset: 0x00006688
		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count)
		{
			Camera camera = null;
			int layer = 0;
			bool receiveShadows = true;
			ShadowCastingMode castShadows = ShadowCastingMode.On;
			MaterialPropertyBlock properties = null;
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x000084B4 File Offset: 0x000066B4
		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices)
		{
			Camera camera = null;
			int layer = 0;
			bool receiveShadows = true;
			ShadowCastingMode castShadows = ShadowCastingMode.On;
			MaterialPropertyBlock properties = null;
			int count = matrices.Length;
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x000084E4 File Offset: 0x000066E4
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, [DefaultValue("matrices.Length")] int count, [DefaultValue("null")] MaterialPropertyBlock properties, [DefaultValue("ShadowCastingMode.On")] ShadowCastingMode castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("0")] int layer, [DefaultValue("null")] Camera camera)
		{
			Graphics.DrawMeshInstancedImpl(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00008508 File Offset: 0x00006708
		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Camera camera = null;
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0000852C File Offset: 0x0000672C
		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows)
		{
			Camera camera = null;
			int layer = 0;
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00008550 File Offset: 0x00006750
		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows)
		{
			Camera camera = null;
			int layer = 0;
			bool receiveShadows = true;
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00008574 File Offset: 0x00006774
		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties)
		{
			Camera camera = null;
			int layer = 0;
			bool receiveShadows = true;
			ShadowCastingMode castShadows = ShadowCastingMode.On;
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0000859C File Offset: 0x0000679C
		[ExcludeFromDocs]
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices)
		{
			Camera camera = null;
			int layer = 0;
			bool receiveShadows = true;
			ShadowCastingMode castShadows = ShadowCastingMode.On;
			MaterialPropertyBlock properties = null;
			Graphics.DrawMeshInstanced(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000085C4 File Offset: 0x000067C4
		public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, [DefaultValue("null")] MaterialPropertyBlock properties, [DefaultValue("ShadowCastingMode.On")] ShadowCastingMode castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("0")] int layer, [DefaultValue("null")] Camera camera)
		{
			Graphics.DrawMeshInstancedImpl(mesh, submeshIndex, material, matrices, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000670 RID: 1648
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera);

		// Token: 0x06000671 RID: 1649 RVA: 0x000085E8 File Offset: 0x000067E8
		[ExcludeFromDocs]
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer)
		{
			Camera camera = null;
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00008610 File Offset: 0x00006810
		[ExcludeFromDocs]
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows)
		{
			Camera camera = null;
			int layer = 0;
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00008638 File Offset: 0x00006838
		[ExcludeFromDocs]
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows)
		{
			Camera camera = null;
			int layer = 0;
			bool receiveShadows = true;
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00008660 File Offset: 0x00006860
		[ExcludeFromDocs]
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			Camera camera = null;
			int layer = 0;
			bool receiveShadows = true;
			ShadowCastingMode castShadows = ShadowCastingMode.On;
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000868C File Offset: 0x0000688C
		[ExcludeFromDocs]
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			Camera camera = null;
			int layer = 0;
			bool receiveShadows = true;
			ShadowCastingMode castShadows = ShadowCastingMode.On;
			MaterialPropertyBlock properties = null;
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000086B8 File Offset: 0x000068B8
		[ExcludeFromDocs]
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs)
		{
			Camera camera = null;
			int layer = 0;
			bool receiveShadows = true;
			ShadowCastingMode castShadows = ShadowCastingMode.On;
			MaterialPropertyBlock properties = null;
			int argsOffset = 0;
			Graphics.DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000086E8 File Offset: 0x000068E8
		public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, [DefaultValue("0")] int argsOffset, [DefaultValue("null")] MaterialPropertyBlock properties, [DefaultValue("ShadowCastingMode.On")] ShadowCastingMode castShadows, [DefaultValue("true")] bool receiveShadows, [DefaultValue("0")] int layer, [DefaultValue("null")] Camera camera)
		{
			Graphics.DrawMeshInstancedIndirectImpl(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00008710 File Offset: 0x00006910
		private static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			Graphics.INTERNAL_CALL_Internal_DrawMeshInstancedIndirect(mesh, submeshIndex, material, ref bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x06000679 RID: 1657
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera);

		// Token: 0x0600067A RID: 1658 RVA: 0x00008738 File Offset: 0x00006938
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture, Material mat)
		{
			int pass = -1;
			Graphics.DrawTexture(screenRect, texture, mat, pass);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00008754 File Offset: 0x00006954
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture)
		{
			int pass = -1;
			Material mat = null;
			Graphics.DrawTexture(screenRect, texture, mat, pass);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00008770 File Offset: 0x00006970
		public static void DrawTexture(Rect screenRect, Texture texture, [DefaultValue("null")] Material mat, [DefaultValue("-1")] int pass)
		{
			Graphics.DrawTexture(screenRect, texture, 0, 0, 0, 0, mat, pass);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00008780 File Offset: 0x00006980
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			int pass = -1;
			Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x000087A0 File Offset: 0x000069A0
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			int pass = -1;
			Material mat = null;
			Graphics.DrawTexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000087C4 File Offset: 0x000069C4
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue("null")] Material mat, [DefaultValue("-1")] int pass)
		{
			Graphics.DrawTexture(screenRect, texture, new Rect(0f, 0f, 1f, 1f), leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000087FC File Offset: 0x000069FC
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat)
		{
			int pass = -1;
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00008820 File Offset: 0x00006A20
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			int pass = -1;
			Material mat = null;
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, mat, pass);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00008844 File Offset: 0x00006A44
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue("null")] Material mat, [DefaultValue("-1")] int pass)
		{
			Color32 c = new Color32(128, 128, 128, 128);
			Graphics.DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, c, mat, pass);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00008888 File Offset: 0x00006A88
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat)
		{
			int pass = -1;
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000088AC File Offset: 0x00006AAC
		[ExcludeFromDocs]
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color)
		{
			int pass = -1;
			Material mat = null;
			Graphics.DrawTexture(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000088D4 File Offset: 0x00006AD4
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, [DefaultValue("null")] Material mat, [DefaultValue("-1")] int pass)
		{
			Graphics.DrawTextureImpl(screenRect, texture, sourceRect, leftBorder, rightBorder, topBorder, bottomBorder, color, mat, pass);
		}

		// Token: 0x06000686 RID: 1670
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_DrawTexture(ref Internal_DrawTextureArguments args);

		// Token: 0x06000687 RID: 1671
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ExecuteCommandBuffer(CommandBuffer buffer);

		// Token: 0x06000688 RID: 1672
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Blit(Texture source, RenderTexture dest);

		// Token: 0x06000689 RID: 1673 RVA: 0x000088F8 File Offset: 0x00006AF8
		[ExcludeFromDocs]
		public static void Blit(Texture source, RenderTexture dest, Material mat)
		{
			int pass = -1;
			Graphics.Blit(source, dest, mat, pass);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00008914 File Offset: 0x00006B14
		public static void Blit(Texture source, RenderTexture dest, Material mat, [DefaultValue("-1")] int pass)
		{
			Graphics.Internal_BlitMaterial(source, dest, mat, pass, true);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00008924 File Offset: 0x00006B24
		[ExcludeFromDocs]
		public static void Blit(Texture source, Material mat)
		{
			int pass = -1;
			Graphics.Blit(source, mat, pass);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0000893C File Offset: 0x00006B3C
		public static void Blit(Texture source, Material mat, [DefaultValue("-1")] int pass)
		{
			Graphics.Internal_BlitMaterial(source, null, mat, pass, false);
		}

		// Token: 0x0600068D RID: 1677
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_BlitMaterial(Texture source, RenderTexture dest, Material mat, int pass, bool setRT);

		// Token: 0x0600068E RID: 1678 RVA: 0x0000894C File Offset: 0x00006B4C
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, params Vector2[] offsets)
		{
			Graphics.Internal_BlitMultiTap(source, dest, mat, offsets);
		}

		// Token: 0x0600068F RID: 1679
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets);

		// Token: 0x06000690 RID: 1680
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CopyTexture_Full(Texture src, Texture dst);

		// Token: 0x06000691 RID: 1681
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CopyTexture_Slice_AllMips(Texture src, int srcElement, Texture dst, int dstElement);

		// Token: 0x06000692 RID: 1682
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip);

		// Token: 0x06000693 RID: 1683
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY);

		// Token: 0x06000694 RID: 1684
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool ConvertTexture_Full(Texture src, Texture dst);

		// Token: 0x06000695 RID: 1685
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool ConvertTexture_Slice(Texture src, int srcElement, Texture dst, int dstElement);

		// Token: 0x06000696 RID: 1686
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetNullRT();

		// Token: 0x06000697 RID: 1687
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetRTSimple(out RenderBuffer color, out RenderBuffer depth, int mip, CubemapFace face, int depthSlice);

		// Token: 0x06000698 RID: 1688
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetMRTFullSetup(RenderBuffer[] colorSA, out RenderBuffer depth, int mip, CubemapFace face, int depthSlice, RenderBufferLoadAction[] colorLoadSA, RenderBufferStoreAction[] colorStoreSA, RenderBufferLoadAction depthLoad, RenderBufferStoreAction depthStore);

		// Token: 0x06000699 RID: 1689
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetMRTSimple(RenderBuffer[] colorSA, out RenderBuffer depth, int mip, CubemapFace face, int depthSlice);

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00008958 File Offset: 0x00006B58
		public static RenderBuffer activeColorBuffer
		{
			get
			{
				RenderBuffer result;
				Graphics.GetActiveColorBuffer(out result);
				return result;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00008978 File Offset: 0x00006B78
		public static RenderBuffer activeDepthBuffer
		{
			get
			{
				RenderBuffer result;
				Graphics.GetActiveDepthBuffer(out result);
				return result;
			}
		}

		// Token: 0x0600069C RID: 1692
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetActiveColorBuffer(out RenderBuffer res);

		// Token: 0x0600069D RID: 1693
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetActiveDepthBuffer(out RenderBuffer res);

		// Token: 0x0600069E RID: 1694 RVA: 0x00008998 File Offset: 0x00006B98
		public static void SetRandomWriteTarget(int index, RenderTexture uav)
		{
			Graphics.Internal_SetRandomWriteTargetRT(index, uav);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000089A4 File Offset: 0x00006BA4
		[ExcludeFromDocs]
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav)
		{
			bool preserveCounterValue = false;
			Graphics.SetRandomWriteTarget(index, uav, preserveCounterValue);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000089BC File Offset: 0x00006BBC
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav, [DefaultValue("false")] bool preserveCounterValue)
		{
			if (uav == null)
			{
				throw new ArgumentNullException("uav");
			}
			if (uav.m_Ptr == IntPtr.Zero)
			{
				throw new ObjectDisposedException("uav");
			}
			Graphics.Internal_SetRandomWriteTargetBuffer(index, uav, preserveCounterValue);
		}

		// Token: 0x060006A1 RID: 1697
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearRandomWriteTargets();

		// Token: 0x060006A2 RID: 1698
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetRandomWriteTargetRT(int index, RenderTexture uav);

		// Token: 0x060006A3 RID: 1699
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue);

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060006A4 RID: 1700
		// (set) Token: 0x060006A5 RID: 1701
		public static extern GraphicsTier activeTier { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060006A6 RID: 1702
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetupVertexLights(Light[] lights);

		// Token: 0x060006A7 RID: 1703 RVA: 0x000089F8 File Offset: 0x00006BF8
		internal static void CheckLoadActionValid(RenderBufferLoadAction load, string bufferType)
		{
			if (load != RenderBufferLoadAction.Load && load != RenderBufferLoadAction.DontCare)
			{
				throw new ArgumentException(UnityString.Format("Bad {0} LoadAction provided.", new object[]
				{
					bufferType
				}));
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00008A24 File Offset: 0x00006C24
		internal static void CheckStoreActionValid(RenderBufferStoreAction store, string bufferType)
		{
			if (store != RenderBufferStoreAction.Store && store != RenderBufferStoreAction.DontCare)
			{
				throw new ArgumentException(UnityString.Format("Bad {0} StoreAction provided.", new object[]
				{
					bufferType
				}));
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00008A50 File Offset: 0x00006C50
		internal static void SetRenderTargetImpl(RenderTargetSetup setup)
		{
			if (setup.color.Length == 0)
			{
				throw new ArgumentException("Invalid color buffer count for SetRenderTarget");
			}
			if (setup.color.Length != setup.colorLoad.Length)
			{
				throw new ArgumentException("Color LoadAction and Buffer arrays have different sizes");
			}
			if (setup.color.Length != setup.colorStore.Length)
			{
				throw new ArgumentException("Color StoreAction and Buffer arrays have different sizes");
			}
			foreach (RenderBufferLoadAction load in setup.colorLoad)
			{
				Graphics.CheckLoadActionValid(load, "Color");
			}
			foreach (RenderBufferStoreAction store in setup.colorStore)
			{
				Graphics.CheckStoreActionValid(store, "Color");
			}
			Graphics.CheckLoadActionValid(setup.depthLoad, "Depth");
			Graphics.CheckStoreActionValid(setup.depthStore, "Depth");
			if (setup.cubemapFace < CubemapFace.Unknown || setup.cubemapFace > CubemapFace.NegativeZ)
			{
				throw new ArgumentException("Bad CubemapFace provided");
			}
			Graphics.Internal_SetMRTFullSetup(setup.color, out setup.depth, setup.mipLevel, setup.cubemapFace, setup.depthSlice, setup.colorLoad, setup.colorStore, setup.depthLoad, setup.depthStore);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00008BA8 File Offset: 0x00006DA8
		internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			RenderBuffer renderBuffer = colorBuffer;
			RenderBuffer renderBuffer2 = depthBuffer;
			Graphics.Internal_SetRTSimple(out renderBuffer, out renderBuffer2, mipLevel, face, depthSlice);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00008BC8 File Offset: 0x00006DC8
		internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
			if (rt)
			{
				Graphics.SetRenderTargetImpl(rt.colorBuffer, rt.depthBuffer, mipLevel, face, depthSlice);
			}
			else
			{
				Graphics.Internal_SetNullRT();
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00008BF4 File Offset: 0x00006DF4
		internal static void SetRenderTargetImpl(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			RenderBuffer renderBuffer = depthBuffer;
			Graphics.Internal_SetMRTSimple(colorBuffers, out renderBuffer, mipLevel, face, depthSlice);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00008C10 File Offset: 0x00006E10
		public static void SetRenderTarget(RenderTexture rt)
		{
			Graphics.SetRenderTargetImpl(rt, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00008C1C File Offset: 0x00006E1C
		public static void SetRenderTarget(RenderTexture rt, int mipLevel)
		{
			Graphics.SetRenderTargetImpl(rt, mipLevel, CubemapFace.Unknown, 0);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00008C28 File Offset: 0x00006E28
		public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face)
		{
			Graphics.SetRenderTargetImpl(rt, mipLevel, face, 0);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00008C34 File Offset: 0x00006E34
		public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
			Graphics.SetRenderTargetImpl(rt, mipLevel, face, depthSlice);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00008C40 File Offset: 0x00006E40
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
		{
			Graphics.SetRenderTargetImpl(colorBuffer, depthBuffer, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00008C50 File Offset: 0x00006E50
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel)
		{
			Graphics.SetRenderTargetImpl(colorBuffer, depthBuffer, mipLevel, CubemapFace.Unknown, 0);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00008C60 File Offset: 0x00006E60
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face)
		{
			Graphics.SetRenderTargetImpl(colorBuffer, depthBuffer, mipLevel, face, 0);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00008C70 File Offset: 0x00006E70
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
			Graphics.SetRenderTargetImpl(colorBuffer, depthBuffer, mipLevel, face, depthSlice);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00008C80 File Offset: 0x00006E80
		public static void SetRenderTarget(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer)
		{
			Graphics.SetRenderTargetImpl(colorBuffers, depthBuffer, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00008C90 File Offset: 0x00006E90
		public static void SetRenderTarget(RenderTargetSetup setup)
		{
			Graphics.SetRenderTargetImpl(setup);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00008C9C File Offset: 0x00006E9C
		public static void CopyTexture(Texture src, Texture dst)
		{
			Graphics.CopyTexture_Full(src, dst);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00008CA8 File Offset: 0x00006EA8
		public static void CopyTexture(Texture src, int srcElement, Texture dst, int dstElement)
		{
			Graphics.CopyTexture_Slice_AllMips(src, srcElement, dst, dstElement);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00008CB4 File Offset: 0x00006EB4
		public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip)
		{
			Graphics.CopyTexture_Slice(src, srcElement, srcMip, dst, dstElement, dstMip);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00008CC4 File Offset: 0x00006EC4
		public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			Graphics.CopyTexture_Region(src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, dst, dstElement, dstMip, dstX, dstY);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00008CEC File Offset: 0x00006EEC
		public static bool ConvertTexture(Texture src, Texture dst)
		{
			return Graphics.ConvertTexture_Full(src, dst);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00008D08 File Offset: 0x00006F08
		public static bool ConvertTexture(Texture src, int srcElement, Texture dst, int dstElement)
		{
			return Graphics.ConvertTexture_Slice(src, srcElement, dst, dstElement);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00008D28 File Offset: 0x00006F28
		private static void DrawMeshImpl(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, bool useLightProbes)
		{
			Internal_DrawMeshMatrixArguments internal_DrawMeshMatrixArguments = default(Internal_DrawMeshMatrixArguments);
			internal_DrawMeshMatrixArguments.layer = layer;
			internal_DrawMeshMatrixArguments.submeshIndex = submeshIndex;
			internal_DrawMeshMatrixArguments.matrix = matrix;
			internal_DrawMeshMatrixArguments.castShadows = (int)castShadows;
			internal_DrawMeshMatrixArguments.receiveShadows = ((!receiveShadows) ? 0 : 1);
			internal_DrawMeshMatrixArguments.reflectionProbeAnchorInstanceID = ((!(probeAnchor != null)) ? 0 : probeAnchor.GetInstanceID());
			internal_DrawMeshMatrixArguments.useLightProbes = useLightProbes;
			Graphics.Internal_DrawMeshMatrix(ref internal_DrawMeshMatrixArguments, properties, material, mesh, camera);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00008DAC File Offset: 0x00006FAC
		private static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass)
		{
			Internal_DrawTextureArguments internal_DrawTextureArguments = default(Internal_DrawTextureArguments);
			internal_DrawTextureArguments.screenRect = screenRect;
			internal_DrawTextureArguments.sourceRect = sourceRect;
			internal_DrawTextureArguments.leftBorder = leftBorder;
			internal_DrawTextureArguments.rightBorder = rightBorder;
			internal_DrawTextureArguments.topBorder = topBorder;
			internal_DrawTextureArguments.bottomBorder = bottomBorder;
			internal_DrawTextureArguments.color = color;
			internal_DrawTextureArguments.pass = pass;
			internal_DrawTextureArguments.texture = texture;
			internal_DrawTextureArguments.mat = mat;
			Graphics.Internal_DrawTexture(ref internal_DrawTextureArguments);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00008E24 File Offset: 0x00007024
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Graphics.DrawMeshNow(mesh, position, rotation, -1);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00008E30 File Offset: 0x00007030
		public static void DrawMeshNow(Mesh mesh, Vector3 position, Quaternion rotation, int materialIndex)
		{
			Graphics.Internal_DrawMeshNow1(mesh, materialIndex, position, rotation);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00008E3C File Offset: 0x0000703C
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
		{
			Graphics.DrawMeshNow(mesh, matrix, -1);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00008E48 File Offset: 0x00007048
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
		{
			Graphics.Internal_DrawMeshNow2(mesh, materialIndex, matrix);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00008E54 File Offset: 0x00007054
		private static void DrawMeshInstancedImpl(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			if (!SystemInfo.supportsInstancing)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			if (mesh == null)
			{
				throw new ArgumentNullException("mesh");
			}
			if (submeshIndex < 0 || submeshIndex >= mesh.subMeshCount)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			if (material == null)
			{
				throw new ArgumentNullException("material");
			}
			if (!material.enableInstancing)
			{
				throw new InvalidOperationException("Material needs to enable instancing for use with DrawMeshInstanced.");
			}
			if (matrices == null)
			{
				throw new ArgumentNullException("matrices");
			}
			if (count < 0 || count > Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length))
			{
				throw new ArgumentOutOfRangeException("count", string.Format("Count must be in the range of 0 to {0}.", Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length)));
			}
			if (count > 0)
			{
				Graphics.Internal_DrawMeshInstanced(mesh, submeshIndex, material, matrices, count, properties, castShadows, receiveShadows, layer, camera);
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00008F50 File Offset: 0x00007150
		private static void DrawMeshInstancedImpl(Mesh mesh, int submeshIndex, Material material, List<Matrix4x4> matrices, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			if (matrices == null)
			{
				throw new ArgumentNullException("matrices");
			}
			if (matrices.Count > Graphics.kMaxDrawMeshInstanceCount)
			{
				throw new ArgumentOutOfRangeException("matrices", string.Format("Matrix list count must be in the range of 0 to {0}.", Graphics.kMaxDrawMeshInstanceCount));
			}
			Graphics.DrawMeshInstancedImpl(mesh, submeshIndex, material, (Matrix4x4[])Graphics.ExtractArrayFromList(matrices), matrices.Count, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00008FC4 File Offset: 0x000071C4
		private static void DrawMeshInstancedIndirectImpl(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera)
		{
			if (!SystemInfo.supportsInstancing)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			if (mesh == null)
			{
				throw new ArgumentNullException("mesh");
			}
			if (submeshIndex < 0 || submeshIndex >= mesh.subMeshCount)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			if (material == null)
			{
				throw new ArgumentNullException("material");
			}
			if (bufferWithArgs == null)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			Graphics.Internal_DrawMeshInstancedIndirect(mesh, submeshIndex, material, bounds, bufferWithArgs, argsOffset, properties, castShadows, receiveShadows, layer, camera);
		}

		// Token: 0x0400006C RID: 108
		internal static readonly int kMaxDrawMeshInstanceCount = Graphics.Internal_GetMaxDrawMeshInstanceCount();
	}
}
