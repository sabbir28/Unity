using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200023E RID: 574
	public sealed class RectTransformUtility
	{
		// Token: 0x0600264D RID: 9805 RVA: 0x0002C10C File Offset: 0x0002A30C
		private RectTransformUtility()
		{
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x0002C118 File Offset: 0x0002A318
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint)
		{
			return RectTransformUtility.RectangleContainsScreenPoint(rect, screenPoint, null);
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x0002C138 File Offset: 0x0002A338
		public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
		{
			worldPoint = Vector2.zero;
			Ray ray = RectTransformUtility.ScreenPointToRay(cam, screenPoint);
			Plane plane = new Plane(rect.rotation * Vector3.back, rect.position);
			float distance;
			bool result;
			if (!plane.Raycast(ray, out distance))
			{
				result = false;
			}
			else
			{
				worldPoint = ray.GetPoint(distance);
				result = true;
			}
			return result;
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x0002C1A8 File Offset: 0x0002A3A8
		public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint)
		{
			localPoint = Vector2.zero;
			Vector3 position;
			bool result;
			if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, screenPoint, cam, out position))
			{
				localPoint = rect.InverseTransformPoint(position);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x0002C1F4 File Offset: 0x0002A3F4
		public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos)
		{
			Ray result;
			if (cam != null)
			{
				result = cam.ScreenPointToRay(screenPos);
			}
			else
			{
				Vector3 origin = screenPos;
				origin.z -= 100f;
				result = new Ray(origin, Vector3.forward);
			}
			return result;
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x0002C24C File Offset: 0x0002A44C
		public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint)
		{
			Vector2 result;
			if (cam == null)
			{
				result = new Vector2(worldPoint.x, worldPoint.y);
			}
			else
			{
				result = cam.WorldToScreenPoint(worldPoint);
			}
			return result;
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x0002C294 File Offset: 0x0002A494
		public static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child)
		{
			RectTransform[] componentsInChildren = child.GetComponentsInChildren<RectTransform>(false);
			Bounds result;
			if (componentsInChildren.Length > 0)
			{
				Vector3 vector = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
				Vector3 vector2 = new Vector3(float.MinValue, float.MinValue, float.MinValue);
				Matrix4x4 worldToLocalMatrix = root.worldToLocalMatrix;
				int i = 0;
				int num = componentsInChildren.Length;
				while (i < num)
				{
					componentsInChildren[i].GetWorldCorners(RectTransformUtility.s_Corners);
					for (int j = 0; j < 4; j++)
					{
						Vector3 lhs = worldToLocalMatrix.MultiplyPoint3x4(RectTransformUtility.s_Corners[j]);
						vector = Vector3.Min(lhs, vector);
						vector2 = Vector3.Max(lhs, vector2);
					}
					i++;
				}
				Bounds bounds = new Bounds(vector, Vector3.zero);
				bounds.Encapsulate(vector2);
				result = bounds;
			}
			else
			{
				result = new Bounds(Vector3.zero, Vector3.zero);
			}
			return result;
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x0002C390 File Offset: 0x0002A590
		public static Bounds CalculateRelativeRectTransformBounds(Transform trans)
		{
			return RectTransformUtility.CalculateRelativeRectTransformBounds(trans, trans);
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x0002C3AC File Offset: 0x0002A5AC
		public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive)
		{
			if (!(rect == null))
			{
				if (recursive)
				{
					for (int i = 0; i < rect.childCount; i++)
					{
						RectTransform rectTransform = rect.GetChild(i) as RectTransform;
						if (rectTransform != null)
						{
							RectTransformUtility.FlipLayoutOnAxis(rectTransform, axis, false, true);
						}
					}
				}
				Vector2 pivot = rect.pivot;
				pivot[axis] = 1f - pivot[axis];
				rect.pivot = pivot;
				if (!keepPositioning)
				{
					Vector2 anchoredPosition = rect.anchoredPosition;
					anchoredPosition[axis] = -anchoredPosition[axis];
					rect.anchoredPosition = anchoredPosition;
					Vector2 anchorMin = rect.anchorMin;
					Vector2 anchorMax = rect.anchorMax;
					float num = anchorMin[axis];
					anchorMin[axis] = 1f - anchorMax[axis];
					anchorMax[axis] = 1f - num;
					rect.anchorMin = anchorMin;
					rect.anchorMax = anchorMax;
				}
			}
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x0002C4AC File Offset: 0x0002A6AC
		public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive)
		{
			if (!(rect == null))
			{
				if (recursive)
				{
					for (int i = 0; i < rect.childCount; i++)
					{
						RectTransform rectTransform = rect.GetChild(i) as RectTransform;
						if (rectTransform != null)
						{
							RectTransformUtility.FlipLayoutAxes(rectTransform, false, true);
						}
					}
				}
				rect.pivot = RectTransformUtility.GetTransposed(rect.pivot);
				rect.sizeDelta = RectTransformUtility.GetTransposed(rect.sizeDelta);
				if (!keepPositioning)
				{
					rect.anchoredPosition = RectTransformUtility.GetTransposed(rect.anchoredPosition);
					rect.anchorMin = RectTransformUtility.GetTransposed(rect.anchorMin);
					rect.anchorMax = RectTransformUtility.GetTransposed(rect.anchorMax);
				}
			}
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x0002C570 File Offset: 0x0002A770
		private static Vector2 GetTransposed(Vector2 input)
		{
			return new Vector2(input.y, input.x);
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x0002C598 File Offset: 0x0002A798
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam)
		{
			return RectTransformUtility.INTERNAL_CALL_RectangleContainsScreenPoint(rect, ref screenPoint, cam);
		}

		// Token: 0x06002659 RID: 9817
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_RectangleContainsScreenPoint(RectTransform rect, ref Vector2 screenPoint, Camera cam);

		// Token: 0x0600265A RID: 9818 RVA: 0x0002C5B8 File Offset: 0x0002A7B8
		public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas)
		{
			Vector2 result;
			RectTransformUtility.INTERNAL_CALL_PixelAdjustPoint(ref point, elementTransform, canvas, out result);
			return result;
		}

		// Token: 0x0600265B RID: 9819
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_PixelAdjustPoint(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 value);

		// Token: 0x0600265C RID: 9820 RVA: 0x0002C5DC File Offset: 0x0002A7DC
		public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas)
		{
			Rect result;
			RectTransformUtility.INTERNAL_CALL_PixelAdjustRect(rectTransform, canvas, out result);
			return result;
		}

		// Token: 0x0600265D RID: 9821
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_PixelAdjustRect(RectTransform rectTransform, Canvas canvas, out Rect value);

		// Token: 0x040006C2 RID: 1730
		private static Vector3[] s_Corners = new Vector3[4];
	}
}
