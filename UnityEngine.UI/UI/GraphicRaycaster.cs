using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200004A RID: 74
	[AddComponentMenu("Event/Graphic Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class GraphicRaycaster : BaseRaycaster
	{
		// Token: 0x0600025D RID: 605 RVA: 0x0000BE7B File Offset: 0x0000A27B
		protected GraphicRaycaster()
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000BEAC File Offset: 0x0000A2AC
		public override int sortOrderPriority
		{
			get
			{
				int result;
				if (this.canvas.renderMode == RenderMode.ScreenSpaceOverlay)
				{
					result = this.canvas.sortingOrder;
				}
				else
				{
					result = base.sortOrderPriority;
				}
				return result;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000BEE8 File Offset: 0x0000A2E8
		public override int renderOrderPriority
		{
			get
			{
				int result;
				if (this.canvas.renderMode == RenderMode.ScreenSpaceOverlay)
				{
					result = this.canvas.rootCanvas.renderOrder;
				}
				else
				{
					result = base.renderOrderPriority;
				}
				return result;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000BF2C File Offset: 0x0000A32C
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000BF47 File Offset: 0x0000A347
		public bool ignoreReversedGraphics
		{
			get
			{
				return this.m_IgnoreReversedGraphics;
			}
			set
			{
				this.m_IgnoreReversedGraphics = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000BF54 File Offset: 0x0000A354
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0000BF6F File Offset: 0x0000A36F
		public GraphicRaycaster.BlockingObjects blockingObjects
		{
			get
			{
				return this.m_BlockingObjects;
			}
			set
			{
				this.m_BlockingObjects = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000BF7C File Offset: 0x0000A37C
		private Canvas canvas
		{
			get
			{
				Canvas canvas;
				if (this.m_Canvas != null)
				{
					canvas = this.m_Canvas;
				}
				else
				{
					this.m_Canvas = base.GetComponent<Canvas>();
					canvas = this.m_Canvas;
				}
				return canvas;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000BFC0 File Offset: 0x0000A3C0
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			if (!(this.canvas == null))
			{
				int targetDisplay;
				if (this.canvas.renderMode == RenderMode.ScreenSpaceOverlay || !this.eventCamera)
				{
					targetDisplay = this.canvas.targetDisplay;
				}
				else
				{
					targetDisplay = this.eventCamera.targetDisplay;
				}
				Vector3 vector = Display.RelativeMouseAt(eventData.position);
				if (vector != Vector3.zero)
				{
					int num = (int)vector.z;
					if (num != targetDisplay)
					{
						return;
					}
				}
				else
				{
					vector = eventData.position;
				}
				Vector2 vector2;
				if (this.eventCamera == null)
				{
					float num2 = (float)Screen.width;
					float num3 = (float)Screen.height;
					if (targetDisplay > 0 && targetDisplay < Display.displays.Length)
					{
						num2 = (float)Display.displays[targetDisplay].systemWidth;
						num3 = (float)Display.displays[targetDisplay].systemHeight;
					}
					vector2 = new Vector2(vector.x / num2, vector.y / num3);
				}
				else
				{
					vector2 = this.eventCamera.ScreenToViewportPoint(vector);
				}
				if (vector2.x >= 0f && vector2.x <= 1f && vector2.y >= 0f && vector2.y <= 1f)
				{
					float num4 = float.MaxValue;
					Ray r = default(Ray);
					if (this.eventCamera != null)
					{
						r = this.eventCamera.ScreenPointToRay(vector);
					}
					if (this.canvas.renderMode != RenderMode.ScreenSpaceOverlay && this.blockingObjects != GraphicRaycaster.BlockingObjects.None)
					{
						float num5 = 100f;
						if (this.eventCamera != null)
						{
							num5 = this.eventCamera.farClipPlane - this.eventCamera.nearClipPlane;
						}
						if (this.blockingObjects == GraphicRaycaster.BlockingObjects.ThreeD || this.blockingObjects == GraphicRaycaster.BlockingObjects.All)
						{
							if (ReflectionMethodsCache.Singleton.raycast3D != null)
							{
								RaycastHit raycastHit;
								if (ReflectionMethodsCache.Singleton.raycast3D(r, out raycastHit, num5, this.m_BlockingMask))
								{
									num4 = raycastHit.distance;
								}
							}
						}
						if (this.blockingObjects == GraphicRaycaster.BlockingObjects.TwoD || this.blockingObjects == GraphicRaycaster.BlockingObjects.All)
						{
							if (ReflectionMethodsCache.Singleton.raycast2D != null)
							{
								RaycastHit2D raycastHit2D = ReflectionMethodsCache.Singleton.raycast2D(r.origin, r.direction, num5, this.m_BlockingMask);
								if (raycastHit2D.collider)
								{
									num4 = raycastHit2D.fraction * num5;
								}
							}
						}
					}
					this.m_RaycastResults.Clear();
					GraphicRaycaster.Raycast(this.canvas, this.eventCamera, vector, this.m_RaycastResults);
					int i = 0;
					while (i < this.m_RaycastResults.Count)
					{
						GameObject gameObject = this.m_RaycastResults[i].gameObject;
						bool flag = true;
						if (this.ignoreReversedGraphics)
						{
							if (this.eventCamera == null)
							{
								Vector3 rhs = gameObject.transform.rotation * Vector3.forward;
								flag = (Vector3.Dot(Vector3.forward, rhs) > 0f);
							}
							else
							{
								Vector3 lhs = this.eventCamera.transform.rotation * Vector3.forward;
								Vector3 rhs2 = gameObject.transform.rotation * Vector3.forward;
								flag = (Vector3.Dot(lhs, rhs2) > 0f);
							}
						}
						if (flag)
						{
							float num6;
							if (this.eventCamera == null || this.canvas.renderMode == RenderMode.ScreenSpaceOverlay)
							{
								num6 = 0f;
							}
							else
							{
								Transform transform = gameObject.transform;
								Vector3 forward = transform.forward;
								num6 = Vector3.Dot(forward, transform.position - r.origin) / Vector3.Dot(forward, r.direction);
								if (num6 < 0f)
								{
									goto IL_4C8;
								}
							}
							if (num6 < num4)
							{
								RaycastResult item = new RaycastResult
								{
									gameObject = gameObject,
									module = this,
									distance = num6,
									screenPosition = vector,
									index = (float)resultAppendList.Count,
									depth = this.m_RaycastResults[i].depth,
									sortingLayer = this.canvas.sortingLayerID,
									sortingOrder = this.canvas.sortingOrder
								};
								resultAppendList.Add(item);
							}
						}
						IL_4C8:
						i++;
						continue;
						goto IL_4C8;
					}
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000C4B0 File Offset: 0x0000A8B0
		public override Camera eventCamera
		{
			get
			{
				Camera result;
				if (this.canvas.renderMode == RenderMode.ScreenSpaceOverlay || (this.canvas.renderMode == RenderMode.ScreenSpaceCamera && this.canvas.worldCamera == null))
				{
					result = null;
				}
				else
				{
					result = ((!(this.canvas.worldCamera != null)) ? Camera.main : this.canvas.worldCamera);
				}
				return result;
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000C530 File Offset: 0x0000A930
		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, List<Graphic> results)
		{
			IList<Graphic> graphicsForCanvas = GraphicRegistry.GetGraphicsForCanvas(canvas);
			for (int i = 0; i < graphicsForCanvas.Count; i++)
			{
				Graphic graphic = graphicsForCanvas[i];
				if (!graphic.canvasRenderer.cull)
				{
					if (graphic.depth != -1 && graphic.raycastTarget)
					{
						if (RectTransformUtility.RectangleContainsScreenPoint(graphic.rectTransform, pointerPosition, eventCamera))
						{
							if (graphic.Raycast(pointerPosition, eventCamera))
							{
								GraphicRaycaster.s_SortedGraphics.Add(graphic);
							}
						}
					}
				}
			}
			GraphicRaycaster.s_SortedGraphics.Sort((Graphic g1, Graphic g2) => g2.depth.CompareTo(g1.depth));
			for (int j = 0; j < GraphicRaycaster.s_SortedGraphics.Count; j++)
			{
				results.Add(GraphicRaycaster.s_SortedGraphics[j]);
			}
			GraphicRaycaster.s_SortedGraphics.Clear();
		}

		// Token: 0x04000118 RID: 280
		protected const int kNoEventMaskSet = -1;

		// Token: 0x04000119 RID: 281
		[FormerlySerializedAs("ignoreReversedGraphics")]
		[SerializeField]
		private bool m_IgnoreReversedGraphics = true;

		// Token: 0x0400011A RID: 282
		[FormerlySerializedAs("blockingObjects")]
		[SerializeField]
		private GraphicRaycaster.BlockingObjects m_BlockingObjects = GraphicRaycaster.BlockingObjects.None;

		// Token: 0x0400011B RID: 283
		[SerializeField]
		protected LayerMask m_BlockingMask = -1;

		// Token: 0x0400011C RID: 284
		private Canvas m_Canvas;

		// Token: 0x0400011D RID: 285
		[NonSerialized]
		private List<Graphic> m_RaycastResults = new List<Graphic>();

		// Token: 0x0400011E RID: 286
		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics = new List<Graphic>();

		// Token: 0x0200004B RID: 75
		public enum BlockingObjects
		{
			// Token: 0x04000121 RID: 289
			None,
			// Token: 0x04000122 RID: 290
			TwoD,
			// Token: 0x04000123 RID: 291
			ThreeD,
			// Token: 0x04000124 RID: 292
			All
		}
	}
}
