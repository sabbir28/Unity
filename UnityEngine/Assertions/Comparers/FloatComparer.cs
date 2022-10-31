using System;
using System.Collections.Generic;

namespace UnityEngine.Assertions.Comparers
{
	// Token: 0x020003FC RID: 1020
	public class FloatComparer : IEqualityComparer<float>
	{
		// Token: 0x06003415 RID: 13333 RVA: 0x0005271C File Offset: 0x0005091C
		public FloatComparer() : this(1E-05f, false)
		{
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x0005272C File Offset: 0x0005092C
		public FloatComparer(bool relative) : this(1E-05f, relative)
		{
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x0005273C File Offset: 0x0005093C
		public FloatComparer(float error) : this(error, false)
		{
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00052748 File Offset: 0x00050948
		public FloatComparer(float error, bool relative)
		{
			this.m_Error = error;
			this.m_Relative = relative;
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00052760 File Offset: 0x00050960
		public bool Equals(float a, float b)
		{
			return (!this.m_Relative) ? FloatComparer.AreEqual(a, b, this.m_Error) : FloatComparer.AreEqualRelative(a, b, this.m_Error);
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x000527A0 File Offset: 0x000509A0
		public int GetHashCode(float obj)
		{
			return base.GetHashCode();
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x000527BC File Offset: 0x000509BC
		public static bool AreEqual(float expected, float actual, float error)
		{
			return Math.Abs(actual - expected) <= error;
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x000527E0 File Offset: 0x000509E0
		public static bool AreEqualRelative(float expected, float actual, float error)
		{
			bool result;
			if (expected == actual)
			{
				result = true;
			}
			else
			{
				float num = Math.Abs(expected);
				float num2 = Math.Abs(actual);
				float num3 = Math.Abs((actual - expected) / ((num <= num2) ? num2 : num));
				result = (num3 <= error);
			}
			return result;
		}

		// Token: 0x04000EF1 RID: 3825
		private readonly float m_Error;

		// Token: 0x04000EF2 RID: 3826
		private readonly bool m_Relative;

		// Token: 0x04000EF3 RID: 3827
		public static readonly FloatComparer s_ComparerWithDefaultTolerance = new FloatComparer(1E-05f);

		// Token: 0x04000EF4 RID: 3828
		public const float kEpsilon = 1E-05f;
	}
}
