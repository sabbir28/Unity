using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x02000218 RID: 536
	[RequiredByNativeCode]
	public class AnimatorControllerPlayable : AnimationPlayable
	{
		// Token: 0x060023C5 RID: 9157 RVA: 0x00028F5C File Offset: 0x0002715C
		public static implicit operator PlayableHandle(AnimatorControllerPlayable b)
		{
			return b.handle;
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00028F78 File Offset: 0x00027178
		private static RuntimeAnimatorController GetAnimatorControllerInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetAnimatorControllerInternal(ref handle);
		}

		// Token: 0x060023C7 RID: 9159
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RuntimeAnimatorController INTERNAL_CALL_GetAnimatorControllerInternal(ref PlayableHandle handle);

		// Token: 0x060023C8 RID: 9160 RVA: 0x00028F94 File Offset: 0x00027194
		public float GetFloat(string name)
		{
			return AnimatorControllerPlayable.GetFloatString(ref this.handle, name);
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00028FB8 File Offset: 0x000271B8
		public float GetFloat(int id)
		{
			return AnimatorControllerPlayable.GetFloatID(ref this.handle, id);
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00028FDC File Offset: 0x000271DC
		public void SetFloat(string name, float value)
		{
			AnimatorControllerPlayable.SetFloatString(ref this.handle, name, value);
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x00028FEC File Offset: 0x000271EC
		public void SetFloat(int id, float value)
		{
			AnimatorControllerPlayable.SetFloatID(ref this.handle, id, value);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x00028FFC File Offset: 0x000271FC
		public bool GetBool(string name)
		{
			return AnimatorControllerPlayable.GetBoolString(ref this.handle, name);
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x00029020 File Offset: 0x00027220
		public bool GetBool(int id)
		{
			return AnimatorControllerPlayable.GetBoolID(ref this.handle, id);
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x00029044 File Offset: 0x00027244
		public void SetBool(string name, bool value)
		{
			AnimatorControllerPlayable.SetBoolString(ref this.handle, name, value);
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x00029054 File Offset: 0x00027254
		public void SetBool(int id, bool value)
		{
			AnimatorControllerPlayable.SetBoolID(ref this.handle, id, value);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00029064 File Offset: 0x00027264
		public int GetInteger(string name)
		{
			return AnimatorControllerPlayable.GetIntegerString(ref this.handle, name);
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x00029088 File Offset: 0x00027288
		public int GetInteger(int id)
		{
			return AnimatorControllerPlayable.GetIntegerID(ref this.handle, id);
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x000290AC File Offset: 0x000272AC
		public void SetInteger(string name, int value)
		{
			AnimatorControllerPlayable.SetIntegerString(ref this.handle, name, value);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x000290BC File Offset: 0x000272BC
		public void SetInteger(int id, int value)
		{
			AnimatorControllerPlayable.SetIntegerID(ref this.handle, id, value);
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x000290CC File Offset: 0x000272CC
		public void SetTrigger(string name)
		{
			AnimatorControllerPlayable.SetTriggerString(ref this.handle, name);
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x000290DC File Offset: 0x000272DC
		public void SetTrigger(int id)
		{
			AnimatorControllerPlayable.SetTriggerID(ref this.handle, id);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000290EC File Offset: 0x000272EC
		public void ResetTrigger(string name)
		{
			AnimatorControllerPlayable.ResetTriggerString(ref this.handle, name);
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x000290FC File Offset: 0x000272FC
		public void ResetTrigger(int id)
		{
			AnimatorControllerPlayable.ResetTriggerID(ref this.handle, id);
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0002910C File Offset: 0x0002730C
		public bool IsParameterControlledByCurve(string name)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveString(ref this.handle, name);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00029130 File Offset: 0x00027330
		public bool IsParameterControlledByCurve(int id)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveID(ref this.handle, id);
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x00029154 File Offset: 0x00027354
		public int layerCount
		{
			get
			{
				return AnimatorControllerPlayable.GetLayerCountInternal(ref this.handle);
			}
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00029174 File Offset: 0x00027374
		private static int GetLayerCountInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetLayerCountInternal(ref handle);
		}

		// Token: 0x060023DC RID: 9180
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetLayerCountInternal(ref PlayableHandle handle);

		// Token: 0x060023DD RID: 9181 RVA: 0x00029190 File Offset: 0x00027390
		private static string GetLayerNameInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetLayerNameInternal(ref handle, layerIndex);
		}

		// Token: 0x060023DE RID: 9182
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string INTERNAL_CALL_GetLayerNameInternal(ref PlayableHandle handle, int layerIndex);

		// Token: 0x060023DF RID: 9183 RVA: 0x000291AC File Offset: 0x000273AC
		public string GetLayerName(int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerNameInternal(ref this.handle, layerIndex);
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x000291D0 File Offset: 0x000273D0
		private static int GetLayerIndexInternal(ref PlayableHandle handle, string layerName)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetLayerIndexInternal(ref handle, layerName);
		}

		// Token: 0x060023E1 RID: 9185
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetLayerIndexInternal(ref PlayableHandle handle, string layerName);

		// Token: 0x060023E2 RID: 9186 RVA: 0x000291EC File Offset: 0x000273EC
		public int GetLayerIndex(string layerName)
		{
			return AnimatorControllerPlayable.GetLayerIndexInternal(ref this.handle, layerName);
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00029210 File Offset: 0x00027410
		private static float GetLayerWeightInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetLayerWeightInternal(ref handle, layerIndex);
		}

		// Token: 0x060023E4 RID: 9188
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetLayerWeightInternal(ref PlayableHandle handle, int layerIndex);

		// Token: 0x060023E5 RID: 9189 RVA: 0x0002922C File Offset: 0x0002742C
		public float GetLayerWeight(int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerWeightInternal(ref this.handle, layerIndex);
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00029250 File Offset: 0x00027450
		private static void SetLayerWeightInternal(ref PlayableHandle handle, int layerIndex, float weight)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetLayerWeightInternal(ref handle, layerIndex, weight);
		}

		// Token: 0x060023E7 RID: 9191
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetLayerWeightInternal(ref PlayableHandle handle, int layerIndex, float weight);

		// Token: 0x060023E8 RID: 9192 RVA: 0x0002925C File Offset: 0x0002745C
		public void SetLayerWeight(int layerIndex, float weight)
		{
			AnimatorControllerPlayable.SetLayerWeightInternal(ref this.handle, layerIndex, weight);
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x0002926C File Offset: 0x0002746C
		private static AnimatorStateInfo GetCurrentAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetCurrentAnimatorStateInfoInternal(ref handle, layerIndex);
		}

		// Token: 0x060023EA RID: 9194
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorStateInfo INTERNAL_CALL_GetCurrentAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex);

		// Token: 0x060023EB RID: 9195 RVA: 0x00029288 File Offset: 0x00027488
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal(ref this.handle, layerIndex);
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x000292AC File Offset: 0x000274AC
		private static AnimatorStateInfo GetNextAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetNextAnimatorStateInfoInternal(ref handle, layerIndex);
		}

		// Token: 0x060023ED RID: 9197
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorStateInfo INTERNAL_CALL_GetNextAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex);

		// Token: 0x060023EE RID: 9198 RVA: 0x000292C8 File Offset: 0x000274C8
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal(ref this.handle, layerIndex);
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x000292EC File Offset: 0x000274EC
		private static AnimatorTransitionInfo GetAnimatorTransitionInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetAnimatorTransitionInfoInternal(ref handle, layerIndex);
		}

		// Token: 0x060023F0 RID: 9200
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorTransitionInfo INTERNAL_CALL_GetAnimatorTransitionInfoInternal(ref PlayableHandle handle, int layerIndex);

		// Token: 0x060023F1 RID: 9201 RVA: 0x00029308 File Offset: 0x00027508
		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal(ref this.handle, layerIndex);
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x0002932C File Offset: 0x0002752C
		private static AnimatorClipInfo[] GetCurrentAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetCurrentAnimatorClipInfoInternal(ref handle, layerIndex);
		}

		// Token: 0x060023F3 RID: 9203
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorClipInfo[] INTERNAL_CALL_GetCurrentAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex);

		// Token: 0x060023F4 RID: 9204 RVA: 0x00029348 File Offset: 0x00027548
		public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternal(ref this.handle, layerIndex);
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x0002936C File Offset: 0x0002756C
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			if (clips == null)
			{
				throw new ArgumentNullException("clips");
			}
			this.GetAnimatorClipInfoInternal(ref this.handle, layerIndex, true, clips);
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x00029390 File Offset: 0x00027590
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			if (clips == null)
			{
				throw new ArgumentNullException("clips");
			}
			this.GetAnimatorClipInfoInternal(ref this.handle, layerIndex, false, clips);
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x000293B4 File Offset: 0x000275B4
		private void GetAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex, bool isCurrent, object clips)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_GetAnimatorClipInfoInternal(this, ref handle, layerIndex, isCurrent, clips);
		}

		// Token: 0x060023F8 RID: 9208
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetAnimatorClipInfoInternal(AnimatorControllerPlayable self, ref PlayableHandle handle, int layerIndex, bool isCurrent, object clips);

		// Token: 0x060023F9 RID: 9209 RVA: 0x000293C4 File Offset: 0x000275C4
		private static int GetAnimatorClipInfoCountInternal(ref PlayableHandle handle, int layerIndex, bool current)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetAnimatorClipInfoCountInternal(ref handle, layerIndex, current);
		}

		// Token: 0x060023FA RID: 9210
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetAnimatorClipInfoCountInternal(ref PlayableHandle handle, int layerIndex, bool current);

		// Token: 0x060023FB RID: 9211 RVA: 0x000293E4 File Offset: 0x000275E4
		public int GetCurrentAnimatorClipInfoCount(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternal(ref this.handle, layerIndex, true);
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00029408 File Offset: 0x00027608
		public int GetNextAnimatorClipInfoCount(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternal(ref this.handle, layerIndex, false);
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x0002942C File Offset: 0x0002762C
		private static AnimatorClipInfo[] GetNextAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetNextAnimatorClipInfoInternal(ref handle, layerIndex);
		}

		// Token: 0x060023FE RID: 9214
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorClipInfo[] INTERNAL_CALL_GetNextAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex);

		// Token: 0x060023FF RID: 9215 RVA: 0x00029448 File Offset: 0x00027648
		public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetNextAnimatorClipInfoInternal(ref this.handle, layerIndex);
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0002946C File Offset: 0x0002766C
		internal string ResolveHash(int hash)
		{
			return AnimatorControllerPlayable.ResolveHashInternal(ref this.handle, hash);
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00029490 File Offset: 0x00027690
		private static string ResolveHashInternal(ref PlayableHandle handle, int hash)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_ResolveHashInternal(ref handle, hash);
		}

		// Token: 0x06002402 RID: 9218
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string INTERNAL_CALL_ResolveHashInternal(ref PlayableHandle handle, int hash);

		// Token: 0x06002403 RID: 9219 RVA: 0x000294AC File Offset: 0x000276AC
		private static bool IsInTransitionInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_IsInTransitionInternal(ref handle, layerIndex);
		}

		// Token: 0x06002404 RID: 9220
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsInTransitionInternal(ref PlayableHandle handle, int layerIndex);

		// Token: 0x06002405 RID: 9221 RVA: 0x000294C8 File Offset: 0x000276C8
		public bool IsInTransition(int layerIndex)
		{
			return AnimatorControllerPlayable.IsInTransitionInternal(ref this.handle, layerIndex);
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x000294EC File Offset: 0x000276EC
		private static int GetParameterCountInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetParameterCountInternal(ref handle);
		}

		// Token: 0x06002407 RID: 9223
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetParameterCountInternal(ref PlayableHandle handle);

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x00029508 File Offset: 0x00027708
		public int parameterCount
		{
			get
			{
				return AnimatorControllerPlayable.GetParameterCountInternal(ref this.handle);
			}
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00029528 File Offset: 0x00027728
		private static AnimatorControllerParameter[] GetParametersArrayInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetParametersArrayInternal(ref handle);
		}

		// Token: 0x0600240A RID: 9226
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorControllerParameter[] INTERNAL_CALL_GetParametersArrayInternal(ref PlayableHandle handle);

		// Token: 0x0600240B RID: 9227 RVA: 0x00029544 File Offset: 0x00027744
		public AnimatorControllerParameter GetParameter(int index)
		{
			AnimatorControllerParameter[] parametersArrayInternal = AnimatorControllerPlayable.GetParametersArrayInternal(ref this.handle);
			if (index < 0 && index >= parametersArrayInternal.Length)
			{
				throw new IndexOutOfRangeException("index");
			}
			return parametersArrayInternal[index];
		}

		// Token: 0x0600240C RID: 9228
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int StringToHash(string name);

		// Token: 0x0600240D RID: 9229 RVA: 0x00029584 File Offset: 0x00027784
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer)
		{
			float fixedTime = 0f;
			this.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x000295A4 File Offset: 0x000277A4
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(string stateName, float transitionDuration)
		{
			float fixedTime = 0f;
			int layer = -1;
			this.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x000295C4 File Offset: 0x000277C4
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, fixedTime);
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x000295DC File Offset: 0x000277DC
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer)
		{
			float fixedTime = 0f;
			this.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x000295FC File Offset: 0x000277FC
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration)
		{
			float fixedTime = 0f;
			int layer = -1;
			this.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0002961C File Offset: 0x0002781C
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00029630 File Offset: 0x00027830
		private static void CrossFadeInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInFixedTimeInternal(ref handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00029640 File Offset: 0x00027840
		[ExcludeFromDocs]
		private static void CrossFadeInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer)
		{
			float fixedTime = 0f;
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInFixedTimeInternal(ref handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00029660 File Offset: 0x00027860
		[ExcludeFromDocs]
		private static void CrossFadeInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration)
		{
			float fixedTime = 0f;
			int layer = -1;
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInFixedTimeInternal(ref handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x06002416 RID: 9238
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CrossFadeInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float fixedTime);

		// Token: 0x06002417 RID: 9239 RVA: 0x00029680 File Offset: 0x00027880
		[ExcludeFromDocs]
		public void CrossFade(string stateName, float transitionDuration, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.CrossFade(stateName, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x000296A0 File Offset: 0x000278A0
		[ExcludeFromDocs]
		public void CrossFade(string stateName, float transitionDuration)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.CrossFade(stateName, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x000296C0 File Offset: 0x000278C0
		public void CrossFade(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, normalizedTime);
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x000296D8 File Offset: 0x000278D8
		[ExcludeFromDocs]
		public void CrossFade(int stateNameHash, float transitionDuration, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.CrossFade(stateNameHash, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x000296F8 File Offset: 0x000278F8
		[ExcludeFromDocs]
		public void CrossFade(int stateNameHash, float transitionDuration)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.CrossFade(stateNameHash, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00029718 File Offset: 0x00027918
		public void CrossFade(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x0002972C File Offset: 0x0002792C
		private static void CrossFadeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInternal(ref handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x0002973C File Offset: 0x0002793C
		[ExcludeFromDocs]
		private static void CrossFadeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInternal(ref handle, stateNameHash, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x0002975C File Offset: 0x0002795C
		[ExcludeFromDocs]
		private static void CrossFadeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInternal(ref handle, stateNameHash, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x06002420 RID: 9248
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CrossFadeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float normalizedTime);

		// Token: 0x06002421 RID: 9249 RVA: 0x0002977C File Offset: 0x0002797C
		[ExcludeFromDocs]
		public void PlayInFixedTime(string stateName, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.PlayInFixedTime(stateName, layer, negativeInfinity);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0002979C File Offset: 0x0002799C
		[ExcludeFromDocs]
		public void PlayInFixedTime(string stateName)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.PlayInFixedTime(stateName, layer, negativeInfinity);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x000297BC File Offset: 0x000279BC
		public void PlayInFixedTime(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.handle, AnimatorControllerPlayable.StringToHash(stateName), layer, fixedTime);
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x000297D4 File Offset: 0x000279D4
		[ExcludeFromDocs]
		public void PlayInFixedTime(int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.PlayInFixedTime(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x000297F4 File Offset: 0x000279F4
		[ExcludeFromDocs]
		public void PlayInFixedTime(int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.PlayInFixedTime(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00029814 File Offset: 0x00027A14
		public void PlayInFixedTime(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.handle, stateNameHash, layer, fixedTime);
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00029828 File Offset: 0x00027A28
		private static void PlayInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInFixedTimeInternal(ref handle, stateNameHash, layer, fixedTime);
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00029834 File Offset: 0x00027A34
		[ExcludeFromDocs]
		private static void PlayInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInFixedTimeInternal(ref handle, stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00029854 File Offset: 0x00027A54
		[ExcludeFromDocs]
		private static void PlayInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInFixedTimeInternal(ref handle, stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x0600242A RID: 9258
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_PlayInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, int layer, float fixedTime);

		// Token: 0x0600242B RID: 9259 RVA: 0x00029874 File Offset: 0x00027A74
		[ExcludeFromDocs]
		public void Play(string stateName, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.Play(stateName, layer, negativeInfinity);
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00029894 File Offset: 0x00027A94
		[ExcludeFromDocs]
		public void Play(string stateName)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.Play(stateName, layer, negativeInfinity);
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x000298B4 File Offset: 0x00027AB4
		public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.handle, AnimatorControllerPlayable.StringToHash(stateName), layer, normalizedTime);
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x000298CC File Offset: 0x00027ACC
		[ExcludeFromDocs]
		public void Play(int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.Play(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x000298EC File Offset: 0x00027AEC
		[ExcludeFromDocs]
		public void Play(int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.Play(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0002990C File Offset: 0x00027B0C
		public void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.handle, stateNameHash, layer, normalizedTime);
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00029920 File Offset: 0x00027B20
		private static void PlayInternal(ref PlayableHandle handle, int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInternal(ref handle, stateNameHash, layer, normalizedTime);
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x0002992C File Offset: 0x00027B2C
		[ExcludeFromDocs]
		private static void PlayInternal(ref PlayableHandle handle, int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInternal(ref handle, stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x0002994C File Offset: 0x00027B4C
		[ExcludeFromDocs]
		private static void PlayInternal(ref PlayableHandle handle, int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInternal(ref handle, stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x06002434 RID: 9268
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_PlayInternal(ref PlayableHandle handle, int stateNameHash, int layer, float normalizedTime);

		// Token: 0x06002435 RID: 9269 RVA: 0x0002996C File Offset: 0x00027B6C
		public bool HasState(int layerIndex, int stateID)
		{
			return AnimatorControllerPlayable.HasStateInternal(ref this.handle, layerIndex, stateID);
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x00029990 File Offset: 0x00027B90
		private static bool HasStateInternal(ref PlayableHandle handle, int layerIndex, int stateID)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_HasStateInternal(ref handle, layerIndex, stateID);
		}

		// Token: 0x06002437 RID: 9271
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_HasStateInternal(ref PlayableHandle handle, int layerIndex, int stateID);

		// Token: 0x06002438 RID: 9272 RVA: 0x000299B0 File Offset: 0x00027BB0
		private static void SetFloatString(ref PlayableHandle handle, string name, float value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetFloatString(ref handle, name, value);
		}

		// Token: 0x06002439 RID: 9273
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetFloatString(ref PlayableHandle handle, string name, float value);

		// Token: 0x0600243A RID: 9274 RVA: 0x000299BC File Offset: 0x00027BBC
		private static void SetFloatID(ref PlayableHandle handle, int id, float value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetFloatID(ref handle, id, value);
		}

		// Token: 0x0600243B RID: 9275
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetFloatID(ref PlayableHandle handle, int id, float value);

		// Token: 0x0600243C RID: 9276 RVA: 0x000299C8 File Offset: 0x00027BC8
		private static float GetFloatString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetFloatString(ref handle, name);
		}

		// Token: 0x0600243D RID: 9277
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetFloatString(ref PlayableHandle handle, string name);

		// Token: 0x0600243E RID: 9278 RVA: 0x000299E4 File Offset: 0x00027BE4
		private static float GetFloatID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetFloatID(ref handle, id);
		}

		// Token: 0x0600243F RID: 9279
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetFloatID(ref PlayableHandle handle, int id);

		// Token: 0x06002440 RID: 9280 RVA: 0x00029A00 File Offset: 0x00027C00
		private static void SetBoolString(ref PlayableHandle handle, string name, bool value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetBoolString(ref handle, name, value);
		}

		// Token: 0x06002441 RID: 9281
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetBoolString(ref PlayableHandle handle, string name, bool value);

		// Token: 0x06002442 RID: 9282 RVA: 0x00029A0C File Offset: 0x00027C0C
		private static void SetBoolID(ref PlayableHandle handle, int id, bool value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetBoolID(ref handle, id, value);
		}

		// Token: 0x06002443 RID: 9283
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetBoolID(ref PlayableHandle handle, int id, bool value);

		// Token: 0x06002444 RID: 9284 RVA: 0x00029A18 File Offset: 0x00027C18
		private static bool GetBoolString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetBoolString(ref handle, name);
		}

		// Token: 0x06002445 RID: 9285
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_GetBoolString(ref PlayableHandle handle, string name);

		// Token: 0x06002446 RID: 9286 RVA: 0x00029A34 File Offset: 0x00027C34
		private static bool GetBoolID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetBoolID(ref handle, id);
		}

		// Token: 0x06002447 RID: 9287
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_GetBoolID(ref PlayableHandle handle, int id);

		// Token: 0x06002448 RID: 9288 RVA: 0x00029A50 File Offset: 0x00027C50
		private static void SetIntegerString(ref PlayableHandle handle, string name, int value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetIntegerString(ref handle, name, value);
		}

		// Token: 0x06002449 RID: 9289
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetIntegerString(ref PlayableHandle handle, string name, int value);

		// Token: 0x0600244A RID: 9290 RVA: 0x00029A5C File Offset: 0x00027C5C
		private static void SetIntegerID(ref PlayableHandle handle, int id, int value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetIntegerID(ref handle, id, value);
		}

		// Token: 0x0600244B RID: 9291
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetIntegerID(ref PlayableHandle handle, int id, int value);

		// Token: 0x0600244C RID: 9292 RVA: 0x00029A68 File Offset: 0x00027C68
		private static int GetIntegerString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetIntegerString(ref handle, name);
		}

		// Token: 0x0600244D RID: 9293
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetIntegerString(ref PlayableHandle handle, string name);

		// Token: 0x0600244E RID: 9294 RVA: 0x00029A84 File Offset: 0x00027C84
		private static int GetIntegerID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetIntegerID(ref handle, id);
		}

		// Token: 0x0600244F RID: 9295
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetIntegerID(ref PlayableHandle handle, int id);

		// Token: 0x06002450 RID: 9296 RVA: 0x00029AA0 File Offset: 0x00027CA0
		private static void SetTriggerString(ref PlayableHandle handle, string name)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetTriggerString(ref handle, name);
		}

		// Token: 0x06002451 RID: 9297
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTriggerString(ref PlayableHandle handle, string name);

		// Token: 0x06002452 RID: 9298 RVA: 0x00029AAC File Offset: 0x00027CAC
		private static void SetTriggerID(ref PlayableHandle handle, int id)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetTriggerID(ref handle, id);
		}

		// Token: 0x06002453 RID: 9299
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTriggerID(ref PlayableHandle handle, int id);

		// Token: 0x06002454 RID: 9300 RVA: 0x00029AB8 File Offset: 0x00027CB8
		private static void ResetTriggerString(ref PlayableHandle handle, string name)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_ResetTriggerString(ref handle, name);
		}

		// Token: 0x06002455 RID: 9301
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetTriggerString(ref PlayableHandle handle, string name);

		// Token: 0x06002456 RID: 9302 RVA: 0x00029AC4 File Offset: 0x00027CC4
		private static void ResetTriggerID(ref PlayableHandle handle, int id)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_ResetTriggerID(ref handle, id);
		}

		// Token: 0x06002457 RID: 9303
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetTriggerID(ref PlayableHandle handle, int id);

		// Token: 0x06002458 RID: 9304 RVA: 0x00029AD0 File Offset: 0x00027CD0
		private static bool IsParameterControlledByCurveString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_IsParameterControlledByCurveString(ref handle, name);
		}

		// Token: 0x06002459 RID: 9305
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsParameterControlledByCurveString(ref PlayableHandle handle, string name);

		// Token: 0x0600245A RID: 9306 RVA: 0x00029AEC File Offset: 0x00027CEC
		private static bool IsParameterControlledByCurveID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_IsParameterControlledByCurveID(ref handle, id);
		}

		// Token: 0x0600245B RID: 9307
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsParameterControlledByCurveID(ref PlayableHandle handle, int id);
	}
}
