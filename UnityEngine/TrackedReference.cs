using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020003DB RID: 987
	[UsedByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public class TrackedReference
	{
		// Token: 0x060032E8 RID: 13032 RVA: 0x0004F184 File Offset: 0x0004D384
		protected TrackedReference()
		{
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x0004F190 File Offset: 0x0004D390
		public static bool operator ==(TrackedReference x, TrackedReference y)
		{
			bool result;
			if (y == null && x == null)
			{
				result = true;
			}
			else if (y == null)
			{
				result = (x.m_Ptr == IntPtr.Zero);
			}
			else if (x == null)
			{
				result = (y.m_Ptr == IntPtr.Zero);
			}
			else
			{
				result = (x.m_Ptr == y.m_Ptr);
			}
			return result;
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x0004F208 File Offset: 0x0004D408
		public static bool operator !=(TrackedReference x, TrackedReference y)
		{
			return !(x == y);
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x0004F228 File Offset: 0x0004D428
		public override bool Equals(object o)
		{
			return o as TrackedReference == this;
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x0004F24C File Offset: 0x0004D44C
		public override int GetHashCode()
		{
			return (int)this.m_Ptr;
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x0004F26C File Offset: 0x0004D46C
		public static implicit operator bool(TrackedReference exists)
		{
			return exists != null;
		}

		// Token: 0x04000EB6 RID: 3766
		internal IntPtr m_Ptr;
	}
}
