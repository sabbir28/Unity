using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine
{
	// Token: 0x02000448 RID: 1096
	internal class InternalStaticBatchingUtility
	{
		// Token: 0x0600352A RID: 13610 RVA: 0x00054674 File Offset: 0x00052874
		public static void CombineRoot(GameObject staticBatchRoot)
		{
			InternalStaticBatchingUtility.Combine(staticBatchRoot, false, false);
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00054680 File Offset: 0x00052880
		public static void Combine(GameObject staticBatchRoot, bool combineOnlyStatic, bool isEditorPostprocessScene)
		{
			GameObject[] array = (GameObject[])Object.FindObjectsOfType(typeof(GameObject));
			List<GameObject> list = new List<GameObject>();
			foreach (GameObject gameObject in array)
			{
				if (!(staticBatchRoot != null) || gameObject.transform.IsChildOf(staticBatchRoot.transform))
				{
					if (!combineOnlyStatic || gameObject.isStaticBatchable)
					{
						list.Add(gameObject);
					}
				}
			}
			array = list.ToArray();
			InternalStaticBatchingUtility.CombineGameObjects(array, staticBatchRoot, isEditorPostprocessScene);
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x00054720 File Offset: 0x00052920
		public static void CombineGameObjects(GameObject[] gos, GameObject staticBatchRoot, bool isEditorPostprocessScene)
		{
			Matrix4x4 lhs = Matrix4x4.identity;
			Transform staticBatchRootTransform = null;
			if (staticBatchRoot)
			{
				lhs = staticBatchRoot.transform.worldToLocalMatrix;
				staticBatchRootTransform = staticBatchRoot.transform;
			}
			int batchIndex = 0;
			int num = 0;
			List<MeshSubsetCombineUtility.MeshContainer> list = new List<MeshSubsetCombineUtility.MeshContainer>();
			Array.Sort(gos, new InternalStaticBatchingUtility.SortGO());
			foreach (GameObject gameObject in gos)
			{
				MeshFilter meshFilter = gameObject.GetComponent(typeof(MeshFilter)) as MeshFilter;
				if (!(meshFilter == null))
				{
					Mesh sharedMesh = meshFilter.sharedMesh;
					if (!(sharedMesh == null) && (isEditorPostprocessScene || sharedMesh.canAccess))
					{
						Renderer component = meshFilter.GetComponent<Renderer>();
						if (!(component == null) && component.enabled)
						{
							if (component.staticBatchIndex == 0)
							{
								Material[] array = component.sharedMaterials;
								if (!array.Any((Material m) => m != null && m.shader != null && m.shader.disableBatching != DisableBatchingType.False))
								{
									int vertexCount = sharedMesh.vertexCount;
									if (vertexCount != 0)
									{
										MeshRenderer meshRenderer = component as MeshRenderer;
										if (meshRenderer != null && meshRenderer.additionalVertexStreams != null)
										{
											if (vertexCount != meshRenderer.additionalVertexStreams.vertexCount)
											{
												goto IL_387;
											}
										}
										if (num + vertexCount > 64000)
										{
											InternalStaticBatchingUtility.MakeBatch(list, staticBatchRootTransform, batchIndex++);
											list.Clear();
											num = 0;
										}
										MeshSubsetCombineUtility.MeshInstance instance = default(MeshSubsetCombineUtility.MeshInstance);
										instance.meshInstanceID = sharedMesh.GetInstanceID();
										instance.rendererInstanceID = component.GetInstanceID();
										if (meshRenderer != null && meshRenderer.additionalVertexStreams != null)
										{
											instance.additionalVertexStreamsMeshInstanceID = meshRenderer.additionalVertexStreams.GetInstanceID();
										}
										instance.transform = lhs * meshFilter.transform.localToWorldMatrix;
										instance.lightmapScaleOffset = component.lightmapScaleOffset;
										instance.realtimeLightmapScaleOffset = component.realtimeLightmapScaleOffset;
										MeshSubsetCombineUtility.MeshContainer item = new MeshSubsetCombineUtility.MeshContainer
										{
											gameObject = gameObject,
											instance = instance,
											subMeshInstances = new List<MeshSubsetCombineUtility.SubMeshInstance>()
										};
										list.Add(item);
										if (array.Length > sharedMesh.subMeshCount)
										{
											Debug.LogWarning(string.Concat(new object[]
											{
												"Mesh '",
												sharedMesh.name,
												"' has more materials (",
												array.Length,
												") than subsets (",
												sharedMesh.subMeshCount,
												")"
											}), component);
											Material[] array2 = new Material[sharedMesh.subMeshCount];
											for (int j = 0; j < sharedMesh.subMeshCount; j++)
											{
												array2[j] = component.sharedMaterials[j];
											}
											component.sharedMaterials = array2;
											array = array2;
										}
										for (int k = 0; k < Math.Min(array.Length, sharedMesh.subMeshCount); k++)
										{
											MeshSubsetCombineUtility.SubMeshInstance item2 = default(MeshSubsetCombineUtility.SubMeshInstance);
											item2.meshInstanceID = meshFilter.sharedMesh.GetInstanceID();
											item2.vertexOffset = num;
											item2.subMeshIndex = k;
											item2.gameObjectInstanceID = gameObject.GetInstanceID();
											item2.transform = instance.transform;
											item.subMeshInstances.Add(item2);
										}
										num += sharedMesh.vertexCount;
									}
								}
							}
						}
					}
				}
				IL_387:;
			}
			InternalStaticBatchingUtility.MakeBatch(list, staticBatchRootTransform, batchIndex);
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00054AD0 File Offset: 0x00052CD0
		private static void MakeBatch(List<MeshSubsetCombineUtility.MeshContainer> meshes, Transform staticBatchRootTransform, int batchIndex)
		{
			if (meshes.Count >= 2)
			{
				List<MeshSubsetCombineUtility.MeshInstance> list = new List<MeshSubsetCombineUtility.MeshInstance>();
				List<MeshSubsetCombineUtility.SubMeshInstance> list2 = new List<MeshSubsetCombineUtility.SubMeshInstance>();
				foreach (MeshSubsetCombineUtility.MeshContainer meshContainer in meshes)
				{
					list.Add(meshContainer.instance);
					list2.AddRange(meshContainer.subMeshInstances);
				}
				string text = "Combined Mesh";
				text = text + " (root: " + ((!(staticBatchRootTransform != null)) ? "scene" : staticBatchRootTransform.name) + ")";
				if (batchIndex > 0)
				{
					text = text + " " + (batchIndex + 1);
				}
				Mesh mesh = StaticBatchingHelper.InternalCombineVertices(list.ToArray(), text);
				StaticBatchingHelper.InternalCombineIndices(list2.ToArray(), mesh);
				int num = 0;
				foreach (MeshSubsetCombineUtility.MeshContainer meshContainer2 in meshes)
				{
					MeshFilter meshFilter = (MeshFilter)meshContainer2.gameObject.GetComponent(typeof(MeshFilter));
					meshFilter.sharedMesh = mesh;
					int num2 = meshContainer2.subMeshInstances.Count<MeshSubsetCombineUtility.SubMeshInstance>();
					Renderer component = meshContainer2.gameObject.GetComponent<Renderer>();
					component.SetStaticBatchInfo(num, num2);
					component.staticBatchRootTransform = staticBatchRootTransform;
					component.enabled = false;
					component.enabled = true;
					MeshRenderer meshRenderer = component as MeshRenderer;
					if (meshRenderer != null)
					{
						meshRenderer.additionalVertexStreams = null;
					}
					num += num2;
				}
			}
		}

		// Token: 0x04000F86 RID: 3974
		private const int MaxVerticesInBatch = 64000;

		// Token: 0x04000F87 RID: 3975
		private const string CombinedMeshPrefix = "Combined Mesh";

		// Token: 0x02000449 RID: 1097
		internal class SortGO : IComparer
		{
			// Token: 0x06003530 RID: 13616 RVA: 0x00054CEC File Offset: 0x00052EEC
			int IComparer.Compare(object a, object b)
			{
				int result;
				if (a == b)
				{
					result = 0;
				}
				else
				{
					Renderer renderer = InternalStaticBatchingUtility.SortGO.GetRenderer(a as GameObject);
					Renderer renderer2 = InternalStaticBatchingUtility.SortGO.GetRenderer(b as GameObject);
					int num = InternalStaticBatchingUtility.SortGO.GetMaterialId(renderer).CompareTo(InternalStaticBatchingUtility.SortGO.GetMaterialId(renderer2));
					if (num == 0)
					{
						num = InternalStaticBatchingUtility.SortGO.GetLightmapIndex(renderer).CompareTo(InternalStaticBatchingUtility.SortGO.GetLightmapIndex(renderer2));
					}
					result = num;
				}
				return result;
			}

			// Token: 0x06003531 RID: 13617 RVA: 0x00054D5C File Offset: 0x00052F5C
			private static int GetMaterialId(Renderer renderer)
			{
				int result;
				if (renderer == null || renderer.sharedMaterial == null)
				{
					result = 0;
				}
				else
				{
					result = renderer.sharedMaterial.GetInstanceID();
				}
				return result;
			}

			// Token: 0x06003532 RID: 13618 RVA: 0x00054DA0 File Offset: 0x00052FA0
			private static int GetLightmapIndex(Renderer renderer)
			{
				int result;
				if (renderer == null)
				{
					result = -1;
				}
				else
				{
					result = renderer.lightmapIndex;
				}
				return result;
			}

			// Token: 0x06003533 RID: 13619 RVA: 0x00054DD0 File Offset: 0x00052FD0
			private static Renderer GetRenderer(GameObject go)
			{
				Renderer result;
				if (go == null)
				{
					result = null;
				}
				else
				{
					MeshFilter meshFilter = go.GetComponent(typeof(MeshFilter)) as MeshFilter;
					if (meshFilter == null)
					{
						result = null;
					}
					else
					{
						result = meshFilter.GetComponent<Renderer>();
					}
				}
				return result;
			}
		}
	}
}
