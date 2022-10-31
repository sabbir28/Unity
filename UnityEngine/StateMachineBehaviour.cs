using System;
using UnityEngine.Experimental.Director;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001E6 RID: 486
	[RequiredByNativeCode]
	public abstract class StateMachineBehaviour : ScriptableObject
	{
		// Token: 0x06002158 RID: 8536 RVA: 0x00026E9C File Offset: 0x0002509C
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00026EA0 File Offset: 0x000250A0
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00026EA4 File Offset: 0x000250A4
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00026EA8 File Offset: 0x000250A8
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00026EAC File Offset: 0x000250AC
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00026EB0 File Offset: 0x000250B0
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
		{
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00026EB4 File Offset: 0x000250B4
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00026EB8 File Offset: 0x000250B8
		public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00026EBC File Offset: 0x000250BC
		public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x00026EC0 File Offset: 0x000250C0
		public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00026EC4 File Offset: 0x000250C4
		public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00026EC8 File Offset: 0x000250C8
		public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00026ECC File Offset: 0x000250CC
		public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
		{
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00026ED0 File Offset: 0x000250D0
		public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
		{
		}
	}
}
