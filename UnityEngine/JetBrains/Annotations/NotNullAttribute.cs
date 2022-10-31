using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000389 RID: 905
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = false, Inherited = true)]
	public sealed class NotNullAttribute : Attribute
	{
	}
}
