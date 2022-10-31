using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000104 RID: 260
	[NativeClass("UI::RectTransform")]
	public sealed class RectTransform : Transform
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x000180EC File Offset: 0x000162EC
		public Rect rect
		{
			get
			{
				Rect result;
				this.INTERNAL_get_rect(out result);
				return result;
			}
		}

		// Token: 0x06001219 RID: 4633
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rect(out Rect value);

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x0001810C File Offset: 0x0001630C
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x0001812C File Offset: 0x0001632C
		public Vector2 anchorMin
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_anchorMin(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_anchorMin(ref value);
			}
		}

		// Token: 0x0600121C RID: 4636
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_anchorMin(out Vector2 value);

		// Token: 0x0600121D RID: 4637
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_anchorMin(ref Vector2 value);

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x00018138 File Offset: 0x00016338
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x00018158 File Offset: 0x00016358
		public Vector2 anchorMax
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_anchorMax(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_anchorMax(ref value);
			}
		}

		// Token: 0x06001220 RID: 4640
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_anchorMax(out Vector2 value);

		// Token: 0x06001221 RID: 4641
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_anchorMax(ref Vector2 value);

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x00018164 File Offset: 0x00016364
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x000181A4 File Offset: 0x000163A4
		public Vector3 anchoredPosition3D
		{
			get
			{
				Vector2 anchoredPosition = this.anchoredPosition;
				return new Vector3(anchoredPosition.x, anchoredPosition.y, base.localPosition.z);
			}
			set
			{
				this.anchoredPosition = new Vector2(value.x, value.y);
				Vector3 localPosition = base.localPosition;
				localPosition.z = value.z;
				base.localPosition = localPosition;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x000181E8 File Offset: 0x000163E8
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x00018208 File Offset: 0x00016408
		public Vector2 anchoredPosition
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_anchoredPosition(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_anchoredPosition(ref value);
			}
		}

		// Token: 0x06001226 RID: 4646
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_anchoredPosition(out Vector2 value);

		// Token: 0x06001227 RID: 4647
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_anchoredPosition(ref Vector2 value);

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00018214 File Offset: 0x00016414
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x00018234 File Offset: 0x00016434
		public Vector2 sizeDelta
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_sizeDelta(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_sizeDelta(ref value);
			}
		}

		// Token: 0x0600122A RID: 4650
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_sizeDelta(out Vector2 value);

		// Token: 0x0600122B RID: 4651
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_sizeDelta(ref Vector2 value);

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x00018240 File Offset: 0x00016440
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x00018260 File Offset: 0x00016460
		public Vector2 pivot
		{
			get
			{
				Vector2 result;
				this.INTERNAL_get_pivot(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_pivot(ref value);
			}
		}

		// Token: 0x0600122E RID: 4654
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pivot(out Vector2 value);

		// Token: 0x0600122F RID: 4655
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_pivot(ref Vector2 value);

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001230 RID: 4656
		// (set) Token: 0x06001231 RID: 4657
		internal extern Object drivenByObject { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001232 RID: 4658
		// (set) Token: 0x06001233 RID: 4659
		internal extern DrivenTransformProperties drivenProperties { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06001234 RID: 4660 RVA: 0x0001826C File Offset: 0x0001646C
		// (remove) Token: 0x06001235 RID: 4661 RVA: 0x000182A0 File Offset: 0x000164A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;

		// Token: 0x06001236 RID: 4662 RVA: 0x000182D4 File Offset: 0x000164D4
		[RequiredByNativeCode]
		internal static void SendReapplyDrivenProperties(RectTransform driven)
		{
			if (RectTransform.reapplyDrivenProperties != null)
			{
				RectTransform.reapplyDrivenProperties(driven);
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000182EC File Offset: 0x000164EC
		public void GetLocalCorners(Vector3[] fourCornersArray)
		{
			if (fourCornersArray == null || fourCornersArray.Length < 4)
			{
				Debug.LogError("Calling GetLocalCorners with an array that is null or has less than 4 elements.");
			}
			else
			{
				Rect rect = this.rect;
				float x = rect.x;
				float y = rect.y;
				float xMax = rect.xMax;
				float yMax = rect.yMax;
				fourCornersArray[0] = new Vector3(x, y, 0f);
				fourCornersArray[1] = new Vector3(x, yMax, 0f);
				fourCornersArray[2] = new Vector3(xMax, yMax, 0f);
				fourCornersArray[3] = new Vector3(xMax, y, 0f);
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000183A4 File Offset: 0x000165A4
		public void GetWorldCorners(Vector3[] fourCornersArray)
		{
			if (fourCornersArray == null || fourCornersArray.Length < 4)
			{
				Debug.LogError("Calling GetWorldCorners with an array that is null or has less than 4 elements.");
			}
			else
			{
				this.GetLocalCorners(fourCornersArray);
				Transform transform = base.transform;
				for (int i = 0; i < 4; i++)
				{
					fourCornersArray[i] = transform.TransformPoint(fourCornersArray[i]);
				}
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00018410 File Offset: 0x00016610
		internal Rect GetRectInParentSpace()
		{
			Rect rect = this.rect;
			Vector2 a = this.offsetMin + Vector2.Scale(this.pivot, rect.size);
			Transform parent = base.transform.parent;
			if (parent)
			{
				RectTransform component = parent.GetComponent<RectTransform>();
				if (component)
				{
					a += Vector2.Scale(this.anchorMin, component.rect.size);
				}
			}
			rect.x += a.x;
			rect.y += a.y;
			return rect;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x000184C4 File Offset: 0x000166C4
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x000184F8 File Offset: 0x000166F8
		public Vector2 offsetMin
		{
			get
			{
				return this.anchoredPosition - Vector2.Scale(this.sizeDelta, this.pivot);
			}
			set
			{
				Vector2 vector = value - (this.anchoredPosition - Vector2.Scale(this.sizeDelta, this.pivot));
				this.sizeDelta -= vector;
				this.anchoredPosition += Vector2.Scale(vector, Vector2.one - this.pivot);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x00018564 File Offset: 0x00016764
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x000185A0 File Offset: 0x000167A0
		public Vector2 offsetMax
		{
			get
			{
				return this.anchoredPosition + Vector2.Scale(this.sizeDelta, Vector2.one - this.pivot);
			}
			set
			{
				Vector2 vector = value - (this.anchoredPosition + Vector2.Scale(this.sizeDelta, Vector2.one - this.pivot));
				this.sizeDelta += vector;
				this.anchoredPosition += Vector2.Scale(vector, this.pivot);
			}
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0001860C File Offset: 0x0001680C
		public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size)
		{
			int index = (edge != RectTransform.Edge.Top && edge != RectTransform.Edge.Bottom) ? 0 : 1;
			bool flag = edge == RectTransform.Edge.Top || edge == RectTransform.Edge.Right;
			float value = (float)((!flag) ? 0 : 1);
			Vector2 vector = this.anchorMin;
			vector[index] = value;
			this.anchorMin = vector;
			vector = this.anchorMax;
			vector[index] = value;
			this.anchorMax = vector;
			Vector2 sizeDelta = this.sizeDelta;
			sizeDelta[index] = size;
			this.sizeDelta = sizeDelta;
			Vector2 anchoredPosition = this.anchoredPosition;
			anchoredPosition[index] = ((!flag) ? (inset + size * this.pivot[index]) : (-inset - size * (1f - this.pivot[index])));
			this.anchoredPosition = anchoredPosition;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000186E8 File Offset: 0x000168E8
		public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size)
		{
			Vector2 sizeDelta = this.sizeDelta;
			sizeDelta[(int)axis] = size - this.GetParentSize()[(int)axis] * (this.anchorMax[(int)axis] - this.anchorMin[(int)axis]);
			this.sizeDelta = sizeDelta;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00018740 File Offset: 0x00016940
		private Vector2 GetParentSize()
		{
			RectTransform rectTransform = base.parent as RectTransform;
			Vector2 result;
			if (!rectTransform)
			{
				result = Vector2.zero;
			}
			else
			{
				result = rectTransform.rect.size;
			}
			return result;
		}

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x06001242 RID: 4674
		public delegate void ReapplyDrivenProperties(RectTransform driven);

		// Token: 0x02000106 RID: 262
		public enum Edge
		{
			// Token: 0x04000278 RID: 632
			Left,
			// Token: 0x04000279 RID: 633
			Right,
			// Token: 0x0400027A RID: 634
			Top,
			// Token: 0x0400027B RID: 635
			Bottom
		}

		// Token: 0x02000107 RID: 263
		public enum Axis
		{
			// Token: 0x0400027D RID: 637
			Horizontal,
			// Token: 0x0400027E RID: 638
			Vertical
		}
	}
}
