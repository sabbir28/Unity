using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000207 RID: 519
	public sealed class AvatarBuilder
	{
		// Token: 0x06002358 RID: 9048 RVA: 0x00028B48 File Offset: 0x00026D48
		public static Avatar BuildHumanAvatar(GameObject go, HumanDescription humanDescription)
		{
			if (go == null)
			{
				throw new NullReferenceException();
			}
			return AvatarBuilder.BuildHumanAvatarMono(go, humanDescription);
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00028B78 File Offset: 0x00026D78
		private static Avatar BuildHumanAvatarMono(GameObject go, HumanDescription monoHumanDescription)
		{
			return AvatarBuilder.INTERNAL_CALL_BuildHumanAvatarMono(go, ref monoHumanDescription);
		}

		// Token: 0x0600235A RID: 9050
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Avatar INTERNAL_CALL_BuildHumanAvatarMono(GameObject go, ref HumanDescription monoHumanDescription);

		// Token: 0x0600235B RID: 9051
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Avatar BuildGenericAvatar(GameObject go, string rootMotionTransformName);
	}
}
