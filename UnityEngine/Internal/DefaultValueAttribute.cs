using System;

namespace UnityEngine.Internal
{
	// Token: 0x02000419 RID: 1049
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
	[Serializable]
	public class DefaultValueAttribute : Attribute
	{
		// Token: 0x06003479 RID: 13433 RVA: 0x00052E30 File Offset: 0x00051030
		public DefaultValueAttribute(string value)
		{
			this.DefaultValue = value;
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x0600347A RID: 13434 RVA: 0x00052E40 File Offset: 0x00051040
		public object Value
		{
			get
			{
				return this.DefaultValue;
			}
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00052E5C File Offset: 0x0005105C
		public override bool Equals(object obj)
		{
			DefaultValueAttribute defaultValueAttribute = obj as DefaultValueAttribute;
			bool result;
			if (defaultValueAttribute == null)
			{
				result = false;
			}
			else if (this.DefaultValue == null)
			{
				result = (defaultValueAttribute.Value == null);
			}
			else
			{
				result = this.DefaultValue.Equals(defaultValueAttribute.Value);
			}
			return result;
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x00052EB0 File Offset: 0x000510B0
		public override int GetHashCode()
		{
			int hashCode;
			if (this.DefaultValue == null)
			{
				hashCode = base.GetHashCode();
			}
			else
			{
				hashCode = this.DefaultValue.GetHashCode();
			}
			return hashCode;
		}

		// Token: 0x04000F1F RID: 3871
		private object DefaultValue;
	}
}
