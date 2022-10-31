using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000211 RID: 529
	public sealed class Avatar : Object
	{
		// Token: 0x0600235E RID: 9054 RVA: 0x00028BA0 File Offset: 0x00026DA0
		private Avatar()
		{
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600235F RID: 9055
		public extern bool isValid { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06002360 RID: 9056
		public extern bool isHuman { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002361 RID: 9057
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetMuscleMinMax(int muscleId, float min, float max);

		// Token: 0x06002362 RID: 9058
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetParameter(int parameterId, float value);

		// Token: 0x06002363 RID: 9059
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern float GetAxisLength(int humanId);

		// Token: 0x06002364 RID: 9060 RVA: 0x00028BAC File Offset: 0x00026DAC
		internal Quaternion GetPreRotation(int humanId)
		{
			Quaternion result;
			Avatar.INTERNAL_CALL_GetPreRotation(this, humanId, out result);
			return result;
		}

		// Token: 0x06002365 RID: 9061
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPreRotation(Avatar self, int humanId, out Quaternion value);

		// Token: 0x06002366 RID: 9062 RVA: 0x00028BCC File Offset: 0x00026DCC
		internal Quaternion GetPostRotation(int humanId)
		{
			Quaternion result;
			Avatar.INTERNAL_CALL_GetPostRotation(this, humanId, out result);
			return result;
		}

		// Token: 0x06002367 RID: 9063
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPostRotation(Avatar self, int humanId, out Quaternion value);

		// Token: 0x06002368 RID: 9064 RVA: 0x00028BEC File Offset: 0x00026DEC
		internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
		{
			Quaternion result;
			Avatar.INTERNAL_CALL_GetZYPostQ(this, humanId, ref parentQ, ref q, out result);
			return result;
		}

		// Token: 0x06002369 RID: 9065
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetZYPostQ(Avatar self, int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion value);

		// Token: 0x0600236A RID: 9066 RVA: 0x00028C10 File Offset: 0x00026E10
		internal Quaternion GetZYRoll(int humanId, Vector3 uvw)
		{
			Quaternion result;
			Avatar.INTERNAL_CALL_GetZYRoll(this, humanId, ref uvw, out result);
			return result;
		}

		// Token: 0x0600236B RID: 9067
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetZYRoll(Avatar self, int humanId, ref Vector3 uvw, out Quaternion value);

		// Token: 0x0600236C RID: 9068 RVA: 0x00028C34 File Offset: 0x00026E34
		internal Vector3 GetLimitSign(int humanId)
		{
			Vector3 result;
			Avatar.INTERNAL_CALL_GetLimitSign(this, humanId, out result);
			return result;
		}

		// Token: 0x0600236D RID: 9069
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetLimitSign(Avatar self, int humanId, out Vector3 value);
	}
}
