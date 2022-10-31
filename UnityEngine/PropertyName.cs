using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020003C6 RID: 966
	[UsedByNativeCode]
	public struct PropertyName
	{
		// Token: 0x06003270 RID: 12912 RVA: 0x0004D8AC File Offset: 0x0004BAAC
		public PropertyName(string name)
		{
			this = new PropertyName(PropertyNameUtils.PropertyNameFromString(name));
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x0004D8BC File Offset: 0x0004BABC
		public PropertyName(PropertyName other)
		{
			this.id = other.id;
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x0004D8CC File Offset: 0x0004BACC
		private PropertyName(int id)
		{
			this.id = id;
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x0004D8D8 File Offset: 0x0004BAD8
		public static bool IsNullOrEmpty(PropertyName prop)
		{
			return prop.id == 0;
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x0004D8F8 File Offset: 0x0004BAF8
		public static bool operator ==(PropertyName lhs, PropertyName rhs)
		{
			return lhs.id == rhs.id;
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x0004D920 File Offset: 0x0004BB20
		public static bool operator !=(PropertyName lhs, PropertyName rhs)
		{
			return lhs.id != rhs.id;
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x0004D948 File Offset: 0x0004BB48
		public override int GetHashCode()
		{
			return this.id;
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x0004D964 File Offset: 0x0004BB64
		public override bool Equals(object other)
		{
			return other is PropertyName && this == (PropertyName)other;
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x0004D998 File Offset: 0x0004BB98
		public static implicit operator PropertyName(string name)
		{
			return new PropertyName(name);
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x0004D9B4 File Offset: 0x0004BBB4
		public static implicit operator PropertyName(int id)
		{
			return new PropertyName(id);
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x0004D9D0 File Offset: 0x0004BBD0
		public override string ToString()
		{
			return string.Format("Unknown:{0}", this.id);
		}

		// Token: 0x04000E91 RID: 3729
		internal int id;
	}
}
