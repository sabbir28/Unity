﻿using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200026F RID: 623
	internal class ScrollViewState
	{
		// Token: 0x06002A28 RID: 10792 RVA: 0x000380E8 File Offset: 0x000362E8
		[RequiredByNativeCode]
		public ScrollViewState()
		{
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x000380F4 File Offset: 0x000362F4
		public void ScrollTo(Rect pos)
		{
			this.ScrollTowards(pos, float.PositiveInfinity);
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00038104 File Offset: 0x00036304
		public bool ScrollTowards(Rect pos, float maxDelta)
		{
			Vector2 b = this.ScrollNeeded(pos);
			bool result;
			if (b.sqrMagnitude < 0.0001f)
			{
				result = false;
			}
			else if (maxDelta == 0f)
			{
				result = true;
			}
			else
			{
				if (b.magnitude > maxDelta)
				{
					b = b.normalized * maxDelta;
				}
				this.scrollPosition += b;
				this.apply = true;
				result = true;
			}
			return result;
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00038180 File Offset: 0x00036380
		private Vector2 ScrollNeeded(Rect pos)
		{
			Rect rect = this.visibleRect;
			rect.x += this.scrollPosition.x;
			rect.y += this.scrollPosition.y;
			float num = pos.width - this.visibleRect.width;
			if (num > 0f)
			{
				pos.width -= num;
				pos.x += num * 0.5f;
			}
			num = pos.height - this.visibleRect.height;
			if (num > 0f)
			{
				pos.height -= num;
				pos.y += num * 0.5f;
			}
			Vector2 zero = Vector2.zero;
			if (pos.xMax > rect.xMax)
			{
				zero.x += pos.xMax - rect.xMax;
			}
			else if (pos.xMin < rect.xMin)
			{
				zero.x -= rect.xMin - pos.xMin;
			}
			if (pos.yMax > rect.yMax)
			{
				zero.y += pos.yMax - rect.yMax;
			}
			else if (pos.yMin < rect.yMin)
			{
				zero.y -= rect.yMin - pos.yMin;
			}
			Rect rect2 = this.viewRect;
			rect2.width = Mathf.Max(rect2.width, this.visibleRect.width);
			rect2.height = Mathf.Max(rect2.height, this.visibleRect.height);
			zero.x = Mathf.Clamp(zero.x, rect2.xMin - this.scrollPosition.x, rect2.xMax - this.visibleRect.width - this.scrollPosition.x);
			zero.y = Mathf.Clamp(zero.y, rect2.yMin - this.scrollPosition.y, rect2.yMax - this.visibleRect.height - this.scrollPosition.y);
			return zero;
		}

		// Token: 0x040007B2 RID: 1970
		public Rect position;

		// Token: 0x040007B3 RID: 1971
		public Rect visibleRect;

		// Token: 0x040007B4 RID: 1972
		public Rect viewRect;

		// Token: 0x040007B5 RID: 1973
		public Vector2 scrollPosition;

		// Token: 0x040007B6 RID: 1974
		public bool apply;
	}
}
