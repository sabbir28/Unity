using System;

namespace UnityEngineInternal
{
	// Token: 0x02000450 RID: 1104
	[AttributeUsage(AttributeTargets.Method)]
	[Serializable]
	public class TypeInferenceRuleAttribute : Attribute
	{
		// Token: 0x06003537 RID: 13623 RVA: 0x00054E40 File Offset: 0x00053040
		public TypeInferenceRuleAttribute(TypeInferenceRules rule) : this(rule.ToString())
		{
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00054E58 File Offset: 0x00053058
		public TypeInferenceRuleAttribute(string rule)
		{
			this._rule = rule;
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00054E68 File Offset: 0x00053068
		public override string ToString()
		{
			return this._rule;
		}

		// Token: 0x04000F9C RID: 3996
		private readonly string _rule;
	}
}
