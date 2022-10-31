using System;
using System.Collections;
using System.Reflection;
using System.Security;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000327 RID: 807
	[RequiredByNativeCode]
	internal class SetupCoroutine
	{
		// Token: 0x060030DE RID: 12510 RVA: 0x0004A488 File Offset: 0x00048688
		[RequiredByNativeCode]
		[SecuritySafeCritical]
		public unsafe static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress)
		{
			if (returnValueAddress == IntPtr.Zero)
			{
				throw new ArgumentException("Return value address cannot be 0.", "returnValueAddress");
			}
			*(byte*)((void*)returnValueAddress) = (enumerator.MoveNext() ? 1 : 0);
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x0004A4B8 File Offset: 0x000486B8
		[RequiredByNativeCode]
		public static object InvokeMember(object behaviour, string name, object variable)
		{
			object[] args = null;
			if (variable != null)
			{
				args = new object[]
				{
					variable
				};
			}
			return behaviour.GetType().InvokeMember(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, behaviour, args, null, null, null);
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x0004A4FC File Offset: 0x000486FC
		public static object InvokeStatic(Type klass, string name, object variable)
		{
			object[] args = null;
			if (variable != null)
			{
				args = new object[]
				{
					variable
				};
			}
			return klass.InvokeMember(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, null, args, null, null, null);
		}
	}
}
