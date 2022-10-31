using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D7 RID: 215
	public sealed class UnityEventQueueSystem
	{
		// Token: 0x06000FC3 RID: 4035 RVA: 0x0001566C File Offset: 0x0001386C
		public static string GenerateEventIdForPayload(string eventPayloadName)
		{
			byte[] array = Guid.NewGuid().ToByteArray();
			return string.Format("REGISTER_EVENT_ID(0x{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}{5:X2}{6:X2}{7:X2}ULL,0x{8:X2}{9:X2}{10:X2}{11:X2}{12:X2}{13:X2}{14:X2}{15:X2}ULL,{16})", new object[]
			{
				array[0],
				array[1],
				array[2],
				array[3],
				array[4],
				array[5],
				array[6],
				array[7],
				array[8],
				array[9],
				array[10],
				array[11],
				array[12],
				array[13],
				array[14],
				array[15],
				eventPayloadName
			});
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00015764 File Offset: 0x00013964
		public static IntPtr GetGlobalEventQueue()
		{
			IntPtr result;
			UnityEventQueueSystem.INTERNAL_CALL_GetGlobalEventQueue(out result);
			return result;
		}

		// Token: 0x06000FC5 RID: 4037
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetGlobalEventQueue(out IntPtr value);
	}
}
