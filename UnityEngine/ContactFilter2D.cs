using System;

namespace UnityEngine
{
	// Token: 0x02000178 RID: 376
	[Serializable]
	public struct ContactFilter2D
	{
		// Token: 0x06001BF4 RID: 7156 RVA: 0x00023254 File Offset: 0x00021454
		public ContactFilter2D NoFilter()
		{
			this.useTriggers = true;
			this.useLayerMask = false;
			this.layerMask = -1;
			this.useDepth = false;
			this.useOutsideDepth = false;
			this.minDepth = float.NegativeInfinity;
			this.maxDepth = float.PositiveInfinity;
			this.useNormalAngle = false;
			this.useOutsideNormalAngle = false;
			this.minNormalAngle = 0f;
			this.maxNormalAngle = 359.9999f;
			return this;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x000232D4 File Offset: 0x000214D4
		private void CheckConsistency()
		{
			this.minDepth = ((this.minDepth != float.NegativeInfinity && this.minDepth != float.PositiveInfinity && !float.IsNaN(this.minDepth)) ? this.minDepth : float.MinValue);
			this.maxDepth = ((this.maxDepth != float.NegativeInfinity && this.maxDepth != float.PositiveInfinity && !float.IsNaN(this.maxDepth)) ? this.maxDepth : float.MaxValue);
			if (this.minDepth > this.maxDepth)
			{
				float num = this.minDepth;
				this.minDepth = this.maxDepth;
				this.maxDepth = num;
			}
			this.minNormalAngle = ((!float.IsNaN(this.minNormalAngle)) ? Mathf.Clamp(this.minNormalAngle, 0f, 359.9999f) : 0f);
			this.maxNormalAngle = ((!float.IsNaN(this.maxNormalAngle)) ? Mathf.Clamp(this.maxNormalAngle, 0f, 359.9999f) : 359.9999f);
			if (this.minNormalAngle > this.maxNormalAngle)
			{
				float num2 = this.minNormalAngle;
				this.minNormalAngle = this.maxNormalAngle;
				this.maxNormalAngle = num2;
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00023434 File Offset: 0x00021634
		public void ClearLayerMask()
		{
			this.useLayerMask = false;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00023440 File Offset: 0x00021640
		public void SetLayerMask(LayerMask layerMask)
		{
			this.layerMask = layerMask;
			this.useLayerMask = true;
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00023454 File Offset: 0x00021654
		public void ClearDepth()
		{
			this.useDepth = false;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00023460 File Offset: 0x00021660
		public void SetDepth(float minDepth, float maxDepth)
		{
			this.minDepth = minDepth;
			this.maxDepth = maxDepth;
			this.useDepth = true;
			this.CheckConsistency();
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00023480 File Offset: 0x00021680
		public void ClearNormalAngle()
		{
			this.useNormalAngle = false;
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0002348C File Offset: 0x0002168C
		public void SetNormalAngle(float minNormalAngle, float maxNormalAngle)
		{
			this.minNormalAngle = minNormalAngle;
			this.maxNormalAngle = maxNormalAngle;
			this.useNormalAngle = true;
			this.CheckConsistency();
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x000234AC File Offset: 0x000216AC
		public bool isFiltering
		{
			get
			{
				return !this.useTriggers || this.useLayerMask || this.useDepth || this.useNormalAngle;
			}
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x000234EC File Offset: 0x000216EC
		public bool IsFilteringTrigger(Collider2D collider)
		{
			return !this.useTriggers && collider.isTrigger;
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00023518 File Offset: 0x00021718
		public bool IsFilteringLayerMask(GameObject obj)
		{
			return this.useLayerMask && (this.layerMask & 1 << obj.layer) == 0;
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x00023558 File Offset: 0x00021758
		public bool IsFilteringDepth(GameObject obj)
		{
			bool result;
			if (!this.useDepth)
			{
				result = false;
			}
			else
			{
				if (this.minDepth > this.maxDepth)
				{
					float num = this.minDepth;
					this.minDepth = this.maxDepth;
					this.maxDepth = num;
				}
				float z = obj.transform.position.z;
				bool flag = z < this.minDepth || z > this.maxDepth;
				if (this.useOutsideDepth)
				{
					result = !flag;
				}
				else
				{
					result = flag;
				}
			}
			return result;
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x000235F4 File Offset: 0x000217F4
		public bool IsFilteringNormalAngle(Vector2 normal)
		{
			float angle = Mathf.Atan2(normal.y, normal.x) * 57.29578f;
			return this.IsFilteringNormalAngle(angle);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0002362C File Offset: 0x0002182C
		public bool IsFilteringNormalAngle(float angle)
		{
			angle -= Mathf.Floor(angle / 359.9999f) * 359.9999f;
			float num = Mathf.Clamp(this.minNormalAngle, 0f, 359.9999f);
			float num2 = Mathf.Clamp(this.maxNormalAngle, 0f, 359.9999f);
			if (num > num2)
			{
				float num3 = num;
				num = num2;
				num2 = num3;
			}
			bool flag = angle < num || angle > num2;
			bool result;
			if (this.useOutsideNormalAngle)
			{
				result = !flag;
			}
			else
			{
				result = flag;
			}
			return result;
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x000236BC File Offset: 0x000218BC
		internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth)
		{
			ContactFilter2D result = default(ContactFilter2D);
			result.useTriggers = Physics2D.queriesHitTriggers;
			result.SetLayerMask(layerMask);
			result.SetDepth(minDepth, maxDepth);
			return result;
		}

		// Token: 0x0400041B RID: 1051
		public bool useTriggers;

		// Token: 0x0400041C RID: 1052
		public bool useLayerMask;

		// Token: 0x0400041D RID: 1053
		public bool useDepth;

		// Token: 0x0400041E RID: 1054
		public bool useOutsideDepth;

		// Token: 0x0400041F RID: 1055
		public bool useNormalAngle;

		// Token: 0x04000420 RID: 1056
		public bool useOutsideNormalAngle;

		// Token: 0x04000421 RID: 1057
		public LayerMask layerMask;

		// Token: 0x04000422 RID: 1058
		public float minDepth;

		// Token: 0x04000423 RID: 1059
		public float maxDepth;

		// Token: 0x04000424 RID: 1060
		public float minNormalAngle;

		// Token: 0x04000425 RID: 1061
		public float maxNormalAngle;

		// Token: 0x04000426 RID: 1062
		public const float NormalAngleUpperLimit = 359.9999f;
	}
}
