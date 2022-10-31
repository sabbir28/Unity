using System;
using System.Collections.Generic;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x02000217 RID: 535
	public interface IAnimatorControllerPlayable
	{
		// Token: 0x06002398 RID: 9112
		float GetFloat(string name);

		// Token: 0x06002399 RID: 9113
		float GetFloat(int id);

		// Token: 0x0600239A RID: 9114
		void SetFloat(string name, float value);

		// Token: 0x0600239B RID: 9115
		void SetFloat(int id, float value);

		// Token: 0x0600239C RID: 9116
		bool GetBool(string name);

		// Token: 0x0600239D RID: 9117
		bool GetBool(int id);

		// Token: 0x0600239E RID: 9118
		void SetBool(string name, bool value);

		// Token: 0x0600239F RID: 9119
		void SetBool(int id, bool value);

		// Token: 0x060023A0 RID: 9120
		int GetInteger(string name);

		// Token: 0x060023A1 RID: 9121
		int GetInteger(int id);

		// Token: 0x060023A2 RID: 9122
		void SetInteger(string name, int value);

		// Token: 0x060023A3 RID: 9123
		void SetInteger(int id, int value);

		// Token: 0x060023A4 RID: 9124
		void SetTrigger(string name);

		// Token: 0x060023A5 RID: 9125
		void SetTrigger(int id);

		// Token: 0x060023A6 RID: 9126
		void ResetTrigger(string name);

		// Token: 0x060023A7 RID: 9127
		void ResetTrigger(int id);

		// Token: 0x060023A8 RID: 9128
		bool IsParameterControlledByCurve(string name);

		// Token: 0x060023A9 RID: 9129
		bool IsParameterControlledByCurve(int id);

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x060023AA RID: 9130
		int layerCount { get; }

		// Token: 0x060023AB RID: 9131
		string GetLayerName(int layerIndex);

		// Token: 0x060023AC RID: 9132
		int GetLayerIndex(string layerName);

		// Token: 0x060023AD RID: 9133
		float GetLayerWeight(int layerIndex);

		// Token: 0x060023AE RID: 9134
		void SetLayerWeight(int layerIndex, float weight);

		// Token: 0x060023AF RID: 9135
		AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);

		// Token: 0x060023B0 RID: 9136
		AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);

		// Token: 0x060023B1 RID: 9137
		AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);

		// Token: 0x060023B2 RID: 9138
		AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);

		// Token: 0x060023B3 RID: 9139
		AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);

		// Token: 0x060023B4 RID: 9140
		int GetCurrentAnimatorClipInfoCount(int layerIndex);

		// Token: 0x060023B5 RID: 9141
		void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);

		// Token: 0x060023B6 RID: 9142
		int GetNextAnimatorClipInfoCount(int layerIndex);

		// Token: 0x060023B7 RID: 9143
		void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);

		// Token: 0x060023B8 RID: 9144
		bool IsInTransition(int layerIndex);

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x060023B9 RID: 9145
		int parameterCount { get; }

		// Token: 0x060023BA RID: 9146
		AnimatorControllerParameter GetParameter(int index);

		// Token: 0x060023BB RID: 9147
		void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer, float fixedTime);

		// Token: 0x060023BC RID: 9148
		void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer, float fixedTime);

		// Token: 0x060023BD RID: 9149
		void CrossFade(string stateName, float transitionDuration, int layer, float normalizedTime);

		// Token: 0x060023BE RID: 9150
		void CrossFade(int stateNameHash, float transitionDuration, int layer, float normalizedTime);

		// Token: 0x060023BF RID: 9151
		void PlayInFixedTime(string stateName, int layer, float fixedTime);

		// Token: 0x060023C0 RID: 9152
		void PlayInFixedTime(int stateNameHash, int layer, float fixedTime);

		// Token: 0x060023C1 RID: 9153
		void Play(string stateName, int layer, float normalizedTime);

		// Token: 0x060023C2 RID: 9154
		void Play(int stateNameHash, int layer, float normalizedTime);

		// Token: 0x060023C3 RID: 9155
		bool HasState(int layerIndex, int stateID);
	}
}
