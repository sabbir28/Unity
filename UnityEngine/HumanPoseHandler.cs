using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000216 RID: 534
	public sealed class HumanPoseHandler : IDisposable
	{
		// Token: 0x0600238F RID: 9103 RVA: 0x00028E28 File Offset: 0x00027028
		public HumanPoseHandler(Avatar avatar, Transform root)
		{
			this.m_Ptr = IntPtr.Zero;
			if (root == null)
			{
				throw new ArgumentNullException("HumanPoseHandler root Transform is null");
			}
			if (avatar == null)
			{
				throw new ArgumentNullException("HumanPoseHandler avatar is null");
			}
			if (!avatar.isValid)
			{
				throw new ArgumentException("HumanPoseHandler avatar is invalid");
			}
			if (!avatar.isHuman)
			{
				throw new ArgumentException("HumanPoseHandler avatar is not human");
			}
			this.Internal_HumanPoseHandler(avatar, root);
		}

		// Token: 0x06002390 RID: 9104
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Dispose();

		// Token: 0x06002391 RID: 9105
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_HumanPoseHandler(Avatar avatar, Transform root);

		// Token: 0x06002392 RID: 9106 RVA: 0x00028EAC File Offset: 0x000270AC
		private bool Internal_GetHumanPose(ref Vector3 bodyPosition, ref Quaternion bodyRotation, float[] muscles)
		{
			return HumanPoseHandler.INTERNAL_CALL_Internal_GetHumanPose(this, ref bodyPosition, ref bodyRotation, muscles);
		}

		// Token: 0x06002393 RID: 9107
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_GetHumanPose(HumanPoseHandler self, ref Vector3 bodyPosition, ref Quaternion bodyRotation, float[] muscles);

		// Token: 0x06002394 RID: 9108 RVA: 0x00028ECC File Offset: 0x000270CC
		public void GetHumanPose(ref HumanPose humanPose)
		{
			humanPose.Init();
			if (!this.Internal_GetHumanPose(ref humanPose.bodyPosition, ref humanPose.bodyRotation, humanPose.muscles))
			{
				Debug.LogWarning("HumanPoseHandler is not initialized properly");
			}
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00028F00 File Offset: 0x00027100
		private bool Internal_SetHumanPose(ref Vector3 bodyPosition, ref Quaternion bodyRotation, float[] muscles)
		{
			return HumanPoseHandler.INTERNAL_CALL_Internal_SetHumanPose(this, ref bodyPosition, ref bodyRotation, muscles);
		}

		// Token: 0x06002396 RID: 9110
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_SetHumanPose(HumanPoseHandler self, ref Vector3 bodyPosition, ref Quaternion bodyRotation, float[] muscles);

		// Token: 0x06002397 RID: 9111 RVA: 0x00028F20 File Offset: 0x00027120
		public void SetHumanPose(ref HumanPose humanPose)
		{
			humanPose.Init();
			if (!this.Internal_SetHumanPose(ref humanPose.bodyPosition, ref humanPose.bodyRotation, humanPose.muscles))
			{
				Debug.LogWarning("HumanPoseHandler is not initialized properly");
			}
		}

		// Token: 0x04000632 RID: 1586
		internal IntPtr m_Ptr;
	}
}
