using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x020000DE RID: 222
	[UsedByNativeCode]
	internal struct PlayableOutput
	{
		// Token: 0x0600105B RID: 4187
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsValidInternal(ref PlayableOutput output);

		// Token: 0x0600105C RID: 4188
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Object GetInternalReferenceObject(ref PlayableOutput output);

		// Token: 0x0600105D RID: 4189
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetInternalReferenceObject(ref PlayableOutput output, Object target);

		// Token: 0x0600105E RID: 4190
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Object GetInternalUserData(ref PlayableOutput output);

		// Token: 0x0600105F RID: 4191
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void SetInternalUserData(ref PlayableOutput output, [Writable] Object target);

		// Token: 0x06001060 RID: 4192 RVA: 0x000162AC File Offset: 0x000144AC
		internal static PlayableHandle InternalGetSourcePlayable(ref PlayableOutput output)
		{
			PlayableHandle result;
			PlayableOutput.INTERNAL_CALL_InternalGetSourcePlayable(ref output, out result);
			return result;
		}

		// Token: 0x06001061 RID: 4193
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_InternalGetSourcePlayable(ref PlayableOutput output, out PlayableHandle value);

		// Token: 0x06001062 RID: 4194 RVA: 0x000162CC File Offset: 0x000144CC
		internal static void InternalSetSourcePlayable(ref PlayableOutput output, ref PlayableHandle target)
		{
			PlayableOutput.INTERNAL_CALL_InternalSetSourcePlayable(ref output, ref target);
		}

		// Token: 0x06001063 RID: 4195
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_InternalSetSourcePlayable(ref PlayableOutput output, ref PlayableHandle target);

		// Token: 0x06001064 RID: 4196
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int InternalGetSourceInputPort(ref PlayableOutput output);

		// Token: 0x06001065 RID: 4197
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalSetSourceInputPort(ref PlayableOutput output, int port);

		// Token: 0x06001066 RID: 4198
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalSetWeight(ref PlayableOutput output, float weight);

		// Token: 0x06001067 RID: 4199
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float InternalGetWeight(ref PlayableOutput output);

		// Token: 0x04000206 RID: 518
		internal IntPtr m_Handle;

		// Token: 0x04000207 RID: 519
		internal int m_Version;
	}
}
