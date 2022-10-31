using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Director;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000200 RID: 512
	[UsedByNativeCode]
	public sealed class Animator : Behaviour
	{
		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x0600222C RID: 8748
		public extern bool isOptimizable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x0600222D RID: 8749
		public extern bool isHuman { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x0600222E RID: 8750
		public extern bool hasRootMotion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600222F RID: 8751
		internal extern bool isRootPositionOrRotationControlledByCurves { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002230 RID: 8752
		public extern float humanScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002231 RID: 8753
		public extern bool isInitialized { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002232 RID: 8754 RVA: 0x00027B30 File Offset: 0x00025D30
		public float GetFloat(string name)
		{
			return this.GetFloatString(name);
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x00027B4C File Offset: 0x00025D4C
		public float GetFloat(int id)
		{
			return this.GetFloatID(id);
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x00027B68 File Offset: 0x00025D68
		public void SetFloat(string name, float value)
		{
			this.SetFloatString(name, value);
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x00027B74 File Offset: 0x00025D74
		public void SetFloat(string name, float value, float dampTime, float deltaTime)
		{
			this.SetFloatStringDamp(name, value, dampTime, deltaTime);
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x00027B84 File Offset: 0x00025D84
		public void SetFloat(int id, float value)
		{
			this.SetFloatID(id, value);
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00027B90 File Offset: 0x00025D90
		public void SetFloat(int id, float value, float dampTime, float deltaTime)
		{
			this.SetFloatIDDamp(id, value, dampTime, deltaTime);
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00027BA0 File Offset: 0x00025DA0
		public bool GetBool(string name)
		{
			return this.GetBoolString(name);
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x00027BBC File Offset: 0x00025DBC
		public bool GetBool(int id)
		{
			return this.GetBoolID(id);
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00027BD8 File Offset: 0x00025DD8
		public void SetBool(string name, bool value)
		{
			this.SetBoolString(name, value);
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00027BE4 File Offset: 0x00025DE4
		public void SetBool(int id, bool value)
		{
			this.SetBoolID(id, value);
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00027BF0 File Offset: 0x00025DF0
		public int GetInteger(string name)
		{
			return this.GetIntegerString(name);
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00027C0C File Offset: 0x00025E0C
		public int GetInteger(int id)
		{
			return this.GetIntegerID(id);
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00027C28 File Offset: 0x00025E28
		public void SetInteger(string name, int value)
		{
			this.SetIntegerString(name, value);
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00027C34 File Offset: 0x00025E34
		public void SetInteger(int id, int value)
		{
			this.SetIntegerID(id, value);
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00027C40 File Offset: 0x00025E40
		public void SetTrigger(string name)
		{
			this.SetTriggerString(name);
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00027C4C File Offset: 0x00025E4C
		public void SetTrigger(int id)
		{
			this.SetTriggerID(id);
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00027C58 File Offset: 0x00025E58
		public void ResetTrigger(string name)
		{
			this.ResetTriggerString(name);
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00027C64 File Offset: 0x00025E64
		public void ResetTrigger(int id)
		{
			this.ResetTriggerID(id);
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00027C70 File Offset: 0x00025E70
		public bool IsParameterControlledByCurve(string name)
		{
			return this.IsParameterControlledByCurveString(name);
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00027C8C File Offset: 0x00025E8C
		public bool IsParameterControlledByCurve(int id)
		{
			return this.IsParameterControlledByCurveID(id);
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x00027CA8 File Offset: 0x00025EA8
		public Vector3 deltaPosition
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_deltaPosition(out result);
				return result;
			}
		}

		// Token: 0x06002247 RID: 8775
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_deltaPosition(out Vector3 value);

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x00027CC8 File Offset: 0x00025EC8
		public Quaternion deltaRotation
		{
			get
			{
				Quaternion result;
				this.INTERNAL_get_deltaRotation(out result);
				return result;
			}
		}

		// Token: 0x06002249 RID: 8777
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_deltaRotation(out Quaternion value);

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x00027CE8 File Offset: 0x00025EE8
		public Vector3 velocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_velocity(out result);
				return result;
			}
		}

		// Token: 0x0600224B RID: 8779
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x00027D08 File Offset: 0x00025F08
		public Vector3 angularVelocity
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_angularVelocity(out result);
				return result;
			}
		}

		// Token: 0x0600224D RID: 8781
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularVelocity(out Vector3 value);

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x00027D28 File Offset: 0x00025F28
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x00027D48 File Offset: 0x00025F48
		public Vector3 rootPosition
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_rootPosition(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_rootPosition(ref value);
			}
		}

		// Token: 0x06002250 RID: 8784
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rootPosition(out Vector3 value);

		// Token: 0x06002251 RID: 8785
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rootPosition(ref Vector3 value);

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x00027D54 File Offset: 0x00025F54
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x00027D74 File Offset: 0x00025F74
		public Quaternion rootRotation
		{
			get
			{
				Quaternion result;
				this.INTERNAL_get_rootRotation(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_rootRotation(ref value);
			}
		}

		// Token: 0x06002254 RID: 8788
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rootRotation(out Quaternion value);

		// Token: 0x06002255 RID: 8789
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rootRotation(ref Quaternion value);

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002256 RID: 8790
		// (set) Token: 0x06002257 RID: 8791
		public extern bool applyRootMotion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002258 RID: 8792
		// (set) Token: 0x06002259 RID: 8793
		public extern bool linearVelocityBlending { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x00027D80 File Offset: 0x00025F80
		// (set) Token: 0x0600225B RID: 8795 RVA: 0x00027DA0 File Offset: 0x00025FA0
		[Obsolete("Use Animator.updateMode instead")]
		public bool animatePhysics
		{
			get
			{
				return this.updateMode == AnimatorUpdateMode.AnimatePhysics;
			}
			set
			{
				this.updateMode = ((!value) ? AnimatorUpdateMode.Normal : AnimatorUpdateMode.AnimatePhysics);
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x0600225C RID: 8796
		// (set) Token: 0x0600225D RID: 8797
		public extern AnimatorUpdateMode updateMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x0600225E RID: 8798
		public extern bool hasTransformHierarchy { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600225F RID: 8799
		// (set) Token: 0x06002260 RID: 8800
		internal extern bool allowConstantClipSamplingOptimization { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06002261 RID: 8801
		public extern float gravityWeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x00027DB8 File Offset: 0x00025FB8
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x00027DDC File Offset: 0x00025FDC
		public Vector3 bodyPosition
		{
			get
			{
				this.CheckIfInIKPass();
				return this.GetBodyPositionInternal();
			}
			set
			{
				this.CheckIfInIKPass();
				this.SetBodyPositionInternal(value);
			}
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00027DEC File Offset: 0x00025FEC
		internal Vector3 GetBodyPositionInternal()
		{
			Vector3 result;
			Animator.INTERNAL_CALL_GetBodyPositionInternal(this, out result);
			return result;
		}

		// Token: 0x06002265 RID: 8805
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetBodyPositionInternal(Animator self, out Vector3 value);

		// Token: 0x06002266 RID: 8806 RVA: 0x00027E0C File Offset: 0x0002600C
		internal void SetBodyPositionInternal(Vector3 bodyPosition)
		{
			Animator.INTERNAL_CALL_SetBodyPositionInternal(this, ref bodyPosition);
		}

		// Token: 0x06002267 RID: 8807
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetBodyPositionInternal(Animator self, ref Vector3 bodyPosition);

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x00027E18 File Offset: 0x00026018
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x00027E3C File Offset: 0x0002603C
		public Quaternion bodyRotation
		{
			get
			{
				this.CheckIfInIKPass();
				return this.GetBodyRotationInternal();
			}
			set
			{
				this.CheckIfInIKPass();
				this.SetBodyRotationInternal(value);
			}
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00027E4C File Offset: 0x0002604C
		internal Quaternion GetBodyRotationInternal()
		{
			Quaternion result;
			Animator.INTERNAL_CALL_GetBodyRotationInternal(this, out result);
			return result;
		}

		// Token: 0x0600226B RID: 8811
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetBodyRotationInternal(Animator self, out Quaternion value);

		// Token: 0x0600226C RID: 8812 RVA: 0x00027E6C File Offset: 0x0002606C
		internal void SetBodyRotationInternal(Quaternion bodyRotation)
		{
			Animator.INTERNAL_CALL_SetBodyRotationInternal(this, ref bodyRotation);
		}

		// Token: 0x0600226D RID: 8813
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetBodyRotationInternal(Animator self, ref Quaternion bodyRotation);

		// Token: 0x0600226E RID: 8814 RVA: 0x00027E78 File Offset: 0x00026078
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetIKPositionInternal(goal);
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00027E9C File Offset: 0x0002609C
		internal Vector3 GetIKPositionInternal(AvatarIKGoal goal)
		{
			Vector3 result;
			Animator.INTERNAL_CALL_GetIKPositionInternal(this, goal, out result);
			return result;
		}

		// Token: 0x06002270 RID: 8816
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetIKPositionInternal(Animator self, AvatarIKGoal goal, out Vector3 value);

		// Token: 0x06002271 RID: 8817 RVA: 0x00027EBC File Offset: 0x000260BC
		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition)
		{
			this.CheckIfInIKPass();
			this.SetIKPositionInternal(goal, goalPosition);
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00027ED0 File Offset: 0x000260D0
		internal void SetIKPositionInternal(AvatarIKGoal goal, Vector3 goalPosition)
		{
			Animator.INTERNAL_CALL_SetIKPositionInternal(this, goal, ref goalPosition);
		}

		// Token: 0x06002273 RID: 8819
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetIKPositionInternal(Animator self, AvatarIKGoal goal, ref Vector3 goalPosition);

		// Token: 0x06002274 RID: 8820 RVA: 0x00027EDC File Offset: 0x000260DC
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetIKRotationInternal(goal);
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00027F00 File Offset: 0x00026100
		internal Quaternion GetIKRotationInternal(AvatarIKGoal goal)
		{
			Quaternion result;
			Animator.INTERNAL_CALL_GetIKRotationInternal(this, goal, out result);
			return result;
		}

		// Token: 0x06002276 RID: 8822
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetIKRotationInternal(Animator self, AvatarIKGoal goal, out Quaternion value);

		// Token: 0x06002277 RID: 8823 RVA: 0x00027F20 File Offset: 0x00026120
		public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation)
		{
			this.CheckIfInIKPass();
			this.SetIKRotationInternal(goal, goalRotation);
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00027F34 File Offset: 0x00026134
		internal void SetIKRotationInternal(AvatarIKGoal goal, Quaternion goalRotation)
		{
			Animator.INTERNAL_CALL_SetIKRotationInternal(this, goal, ref goalRotation);
		}

		// Token: 0x06002279 RID: 8825
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetIKRotationInternal(Animator self, AvatarIKGoal goal, ref Quaternion goalRotation);

		// Token: 0x0600227A RID: 8826 RVA: 0x00027F40 File Offset: 0x00026140
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetIKPositionWeightInternal(goal);
		}

		// Token: 0x0600227B RID: 8827
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern float GetIKPositionWeightInternal(AvatarIKGoal goal);

		// Token: 0x0600227C RID: 8828 RVA: 0x00027F64 File Offset: 0x00026164
		public void SetIKPositionWeight(AvatarIKGoal goal, float value)
		{
			this.CheckIfInIKPass();
			this.SetIKPositionWeightInternal(goal, value);
		}

		// Token: 0x0600227D RID: 8829
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetIKPositionWeightInternal(AvatarIKGoal goal, float value);

		// Token: 0x0600227E RID: 8830 RVA: 0x00027F78 File Offset: 0x00026178
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetIKRotationWeightInternal(goal);
		}

		// Token: 0x0600227F RID: 8831
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern float GetIKRotationWeightInternal(AvatarIKGoal goal);

		// Token: 0x06002280 RID: 8832 RVA: 0x00027F9C File Offset: 0x0002619C
		public void SetIKRotationWeight(AvatarIKGoal goal, float value)
		{
			this.CheckIfInIKPass();
			this.SetIKRotationWeightInternal(goal, value);
		}

		// Token: 0x06002281 RID: 8833
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetIKRotationWeightInternal(AvatarIKGoal goal, float value);

		// Token: 0x06002282 RID: 8834 RVA: 0x00027FB0 File Offset: 0x000261B0
		public Vector3 GetIKHintPosition(AvatarIKHint hint)
		{
			this.CheckIfInIKPass();
			return this.GetIKHintPositionInternal(hint);
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00027FD4 File Offset: 0x000261D4
		internal Vector3 GetIKHintPositionInternal(AvatarIKHint hint)
		{
			Vector3 result;
			Animator.INTERNAL_CALL_GetIKHintPositionInternal(this, hint, out result);
			return result;
		}

		// Token: 0x06002284 RID: 8836
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetIKHintPositionInternal(Animator self, AvatarIKHint hint, out Vector3 value);

		// Token: 0x06002285 RID: 8837 RVA: 0x00027FF4 File Offset: 0x000261F4
		public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition)
		{
			this.CheckIfInIKPass();
			this.SetIKHintPositionInternal(hint, hintPosition);
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x00028008 File Offset: 0x00026208
		internal void SetIKHintPositionInternal(AvatarIKHint hint, Vector3 hintPosition)
		{
			Animator.INTERNAL_CALL_SetIKHintPositionInternal(this, hint, ref hintPosition);
		}

		// Token: 0x06002287 RID: 8839
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetIKHintPositionInternal(Animator self, AvatarIKHint hint, ref Vector3 hintPosition);

		// Token: 0x06002288 RID: 8840 RVA: 0x00028014 File Offset: 0x00026214
		public float GetIKHintPositionWeight(AvatarIKHint hint)
		{
			this.CheckIfInIKPass();
			return this.GetHintWeightPositionInternal(hint);
		}

		// Token: 0x06002289 RID: 8841
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern float GetHintWeightPositionInternal(AvatarIKHint hint);

		// Token: 0x0600228A RID: 8842 RVA: 0x00028038 File Offset: 0x00026238
		public void SetIKHintPositionWeight(AvatarIKHint hint, float value)
		{
			this.CheckIfInIKPass();
			this.SetIKHintPositionWeightInternal(hint, value);
		}

		// Token: 0x0600228B RID: 8843
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetIKHintPositionWeightInternal(AvatarIKHint hint, float value);

		// Token: 0x0600228C RID: 8844 RVA: 0x0002804C File Offset: 0x0002624C
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
			this.CheckIfInIKPass();
			this.SetLookAtPositionInternal(lookAtPosition);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x0002805C File Offset: 0x0002625C
		internal void SetLookAtPositionInternal(Vector3 lookAtPosition)
		{
			Animator.INTERNAL_CALL_SetLookAtPositionInternal(this, ref lookAtPosition);
		}

		// Token: 0x0600228E RID: 8846
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetLookAtPositionInternal(Animator self, ref Vector3 lookAtPosition);

		// Token: 0x0600228F RID: 8847 RVA: 0x00028068 File Offset: 0x00026268
		[ExcludeFromDocs]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
			float clampWeight = 0.5f;
			this.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00028088 File Offset: 0x00026288
		[ExcludeFromDocs]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
			float clampWeight = 0.5f;
			float eyesWeight = 0f;
			this.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000280B0 File Offset: 0x000262B0
		[ExcludeFromDocs]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
			float clampWeight = 0.5f;
			float eyesWeight = 0f;
			float headWeight = 1f;
			this.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000280DC File Offset: 0x000262DC
		[ExcludeFromDocs]
		public void SetLookAtWeight(float weight)
		{
			float clampWeight = 0.5f;
			float eyesWeight = 0f;
			float headWeight = 1f;
			float bodyWeight = 0f;
			this.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00028110 File Offset: 0x00026310
		public void SetLookAtWeight(float weight, [DefaultValue("0.00f")] float bodyWeight, [DefaultValue("1.00f")] float headWeight, [DefaultValue("0.00f")] float eyesWeight, [DefaultValue("0.50f")] float clampWeight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06002294 RID: 8852
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetLookAtWeightInternal(float weight, [DefaultValue("0.00f")] float bodyWeight, [DefaultValue("1.00f")] float headWeight, [DefaultValue("0.00f")] float eyesWeight, [DefaultValue("0.50f")] float clampWeight);

		// Token: 0x06002295 RID: 8853 RVA: 0x00028128 File Offset: 0x00026328
		[ExcludeFromDocs]
		internal void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
			float clampWeight = 0.5f;
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00028148 File Offset: 0x00026348
		[ExcludeFromDocs]
		internal void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight)
		{
			float clampWeight = 0.5f;
			float eyesWeight = 0f;
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00028170 File Offset: 0x00026370
		[ExcludeFromDocs]
		internal void SetLookAtWeightInternal(float weight, float bodyWeight)
		{
			float clampWeight = 0.5f;
			float eyesWeight = 0f;
			float headWeight = 1f;
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x0002819C File Offset: 0x0002639C
		[ExcludeFromDocs]
		internal void SetLookAtWeightInternal(float weight)
		{
			float clampWeight = 0.5f;
			float eyesWeight = 0f;
			float headWeight = 1f;
			float bodyWeight = 0f;
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x000281D0 File Offset: 0x000263D0
		public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation)
		{
			this.CheckIfInIKPass();
			this.SetBoneLocalRotationInternal((int)humanBoneId, rotation);
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x000281E4 File Offset: 0x000263E4
		internal void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation)
		{
			Animator.INTERNAL_CALL_SetBoneLocalRotationInternal(this, humanBoneId, ref rotation);
		}

		// Token: 0x0600229B RID: 8859
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetBoneLocalRotationInternal(Animator self, int humanBoneId, ref Quaternion rotation);

		// Token: 0x0600229C RID: 8860
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern ScriptableObject GetBehaviour(Type type);

		// Token: 0x0600229D RID: 8861 RVA: 0x000281F0 File Offset: 0x000263F0
		public T GetBehaviour<T>() where T : StateMachineBehaviour
		{
			return this.GetBehaviour(typeof(T)) as T;
		}

		// Token: 0x0600229E RID: 8862
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern ScriptableObject[] GetBehaviours(Type type);

		// Token: 0x0600229F RID: 8863 RVA: 0x00028220 File Offset: 0x00026420
		internal static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects) where T : StateMachineBehaviour
		{
			T[] result;
			if (rawObjects == null)
			{
				result = null;
			}
			else
			{
				T[] array = new T[rawObjects.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (T)((object)rawObjects[i]);
				}
				result = array;
			}
			return result;
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00028270 File Offset: 0x00026470
		public T[] GetBehaviours<T>() where T : StateMachineBehaviour
		{
			return Animator.ConvertStateMachineBehaviour<T>(this.GetBehaviours(typeof(T)));
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060022A1 RID: 8865
		// (set) Token: 0x060022A2 RID: 8866
		public extern bool stabilizeFeet { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060022A3 RID: 8867
		public extern int layerCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060022A4 RID: 8868
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetLayerName(int layerIndex);

		// Token: 0x060022A5 RID: 8869
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetLayerIndex(string layerName);

		// Token: 0x060022A6 RID: 8870
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetLayerWeight(int layerIndex);

		// Token: 0x060022A7 RID: 8871
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetLayerWeight(int layerIndex, float weight);

		// Token: 0x060022A8 RID: 8872
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);

		// Token: 0x060022A9 RID: 8873
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);

		// Token: 0x060022AA RID: 8874
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);

		// Token: 0x060022AB RID: 8875
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetCurrentAnimatorClipInfoCount(int layerIndex);

		// Token: 0x060022AC RID: 8876
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);

		// Token: 0x060022AD RID: 8877 RVA: 0x0002829C File Offset: 0x0002649C
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			if (clips == null)
			{
				throw new ArgumentNullException("clips");
			}
			this.GetAnimatorClipInfoInternal(layerIndex, true, clips);
		}

		// Token: 0x060022AE RID: 8878
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips);

		// Token: 0x060022AF RID: 8879
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetNextAnimatorClipInfoCount(int layerIndex);

		// Token: 0x060022B0 RID: 8880
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);

		// Token: 0x060022B1 RID: 8881 RVA: 0x000282BC File Offset: 0x000264BC
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			if (clips == null)
			{
				throw new ArgumentNullException("clips");
			}
			this.GetAnimatorClipInfoInternal(layerIndex, false, clips);
		}

		// Token: 0x060022B2 RID: 8882
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsInTransition(int layerIndex);

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060022B3 RID: 8883
		public extern AnimatorControllerParameter[] parameters { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060022B4 RID: 8884
		public extern int parameterCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060022B5 RID: 8885 RVA: 0x000282DC File Offset: 0x000264DC
		public AnimatorControllerParameter GetParameter(int index)
		{
			AnimatorControllerParameter[] parameters = this.parameters;
			if (index < 0 && index >= this.parameters.Length)
			{
				throw new IndexOutOfRangeException("Index must be between 0 and " + this.parameters.Length);
			}
			return parameters[index];
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060022B6 RID: 8886
		// (set) Token: 0x060022B7 RID: 8887
		public extern float feetPivotActive { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060022B8 RID: 8888
		public extern float pivotWeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x00028330 File Offset: 0x00026530
		public Vector3 pivotPosition
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_pivotPosition(out result);
				return result;
			}
		}

		// Token: 0x060022BA RID: 8890
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pivotPosition(out Vector3 value);

		// Token: 0x060022BB RID: 8891 RVA: 0x00028350 File Offset: 0x00026550
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [DefaultValue("1")] float targetNormalizedTime)
		{
			Animator.INTERNAL_CALL_MatchTarget(this, ref matchPosition, ref matchRotation, targetBodyPart, ref weightMask, startNormalizedTime, targetNormalizedTime);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00028364 File Offset: 0x00026564
		[ExcludeFromDocs]
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime)
		{
			float targetNormalizedTime = 1f;
			Animator.INTERNAL_CALL_MatchTarget(this, ref matchPosition, ref matchRotation, targetBodyPart, ref weightMask, startNormalizedTime, targetNormalizedTime);
		}

		// Token: 0x060022BD RID: 8893
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MatchTarget(Animator self, ref Vector3 matchPosition, ref Quaternion matchRotation, AvatarTarget targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime);

		// Token: 0x060022BE RID: 8894
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InterruptMatchTarget([DefaultValue("true")] bool completeMatch);

		// Token: 0x060022BF RID: 8895 RVA: 0x00028388 File Offset: 0x00026588
		[ExcludeFromDocs]
		public void InterruptMatchTarget()
		{
			bool completeMatch = true;
			this.InterruptMatchTarget(completeMatch);
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060022C0 RID: 8896
		public extern bool isMatchingTarget { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060022C1 RID: 8897
		// (set) Token: 0x060022C2 RID: 8898
		public extern float speed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060022C3 RID: 8899 RVA: 0x000283A0 File Offset: 0x000265A0
		[Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
		public void ForceStateNormalizedTime(float normalizedTime)
		{
			this.Play(0, 0, normalizedTime);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000283AC File Offset: 0x000265AC
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer)
		{
			float fixedTime = 0f;
			this.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x000283CC File Offset: 0x000265CC
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(string stateName, float transitionDuration)
		{
			float fixedTime = 0f;
			int layer = -1;
			this.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x000283EC File Offset: 0x000265EC
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime)
		{
			this.CrossFadeInFixedTime(Animator.StringToHash(stateName), transitionDuration, layer, fixedTime);
		}

		// Token: 0x060022C7 RID: 8903
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime);

		// Token: 0x060022C8 RID: 8904 RVA: 0x00028400 File Offset: 0x00026600
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer)
		{
			float fixedTime = 0f;
			this.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x00028420 File Offset: 0x00026620
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration)
		{
			float fixedTime = 0f;
			int layer = -1;
			this.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00028440 File Offset: 0x00026640
		[ExcludeFromDocs]
		public void CrossFade(string stateName, float transitionDuration, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.CrossFade(stateName, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00028460 File Offset: 0x00026660
		[ExcludeFromDocs]
		public void CrossFade(string stateName, float transitionDuration)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.CrossFade(stateName, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00028480 File Offset: 0x00026680
		public void CrossFade(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			this.CrossFade(Animator.StringToHash(stateName), transitionDuration, layer, normalizedTime);
		}

		// Token: 0x060022CD RID: 8909
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CrossFade(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);

		// Token: 0x060022CE RID: 8910 RVA: 0x00028494 File Offset: 0x00026694
		[ExcludeFromDocs]
		public void CrossFade(int stateNameHash, float transitionDuration, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.CrossFade(stateNameHash, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x000284B4 File Offset: 0x000266B4
		[ExcludeFromDocs]
		public void CrossFade(int stateNameHash, float transitionDuration)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.CrossFade(stateNameHash, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x000284D4 File Offset: 0x000266D4
		[ExcludeFromDocs]
		public void PlayInFixedTime(string stateName, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.PlayInFixedTime(stateName, layer, negativeInfinity);
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x000284F4 File Offset: 0x000266F4
		[ExcludeFromDocs]
		public void PlayInFixedTime(string stateName)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.PlayInFixedTime(stateName, layer, negativeInfinity);
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00028514 File Offset: 0x00026714
		public void PlayInFixedTime(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime)
		{
			this.PlayInFixedTime(Animator.StringToHash(stateName), layer, fixedTime);
		}

		// Token: 0x060022D3 RID: 8915
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void PlayInFixedTime(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime);

		// Token: 0x060022D4 RID: 8916 RVA: 0x00028528 File Offset: 0x00026728
		[ExcludeFromDocs]
		public void PlayInFixedTime(int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.PlayInFixedTime(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00028548 File Offset: 0x00026748
		[ExcludeFromDocs]
		public void PlayInFixedTime(int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.PlayInFixedTime(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00028568 File Offset: 0x00026768
		[ExcludeFromDocs]
		public void Play(string stateName, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.Play(stateName, layer, negativeInfinity);
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00028588 File Offset: 0x00026788
		[ExcludeFromDocs]
		public void Play(string stateName)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.Play(stateName, layer, negativeInfinity);
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x000285A8 File Offset: 0x000267A8
		public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			this.Play(Animator.StringToHash(stateName), layer, normalizedTime);
		}

		// Token: 0x060022D9 RID: 8921
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);

		// Token: 0x060022DA RID: 8922 RVA: 0x000285BC File Offset: 0x000267BC
		[ExcludeFromDocs]
		public void Play(int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.Play(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x000285DC File Offset: 0x000267DC
		[ExcludeFromDocs]
		public void Play(int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int layer = -1;
			this.Play(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x060022DC RID: 8924
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime);

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x000285FC File Offset: 0x000267FC
		public Vector3 targetPosition
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_targetPosition(out result);
				return result;
			}
		}

		// Token: 0x060022DE RID: 8926
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetPosition(out Vector3 value);

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x0002861C File Offset: 0x0002681C
		public Quaternion targetRotation
		{
			get
			{
				Quaternion result;
				this.INTERNAL_get_targetRotation(out result);
				return result;
			}
		}

		// Token: 0x060022E0 RID: 8928
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetRotation(out Quaternion value);

		// Token: 0x060022E1 RID: 8929
		[Obsolete("use mask and layers to control subset of transfroms in a skeleton", true)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsControlled(Transform transform);

		// Token: 0x060022E2 RID: 8930
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool IsBoneTransform(Transform transform);

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060022E3 RID: 8931
		internal extern Transform avatarRoot { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060022E4 RID: 8932 RVA: 0x0002863C File Offset: 0x0002683C
		public Transform GetBoneTransform(HumanBodyBones humanBoneId)
		{
			return this.GetBoneTransformInternal((int)humanBoneId);
		}

		// Token: 0x060022E5 RID: 8933
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Transform GetBoneTransformInternal(int humanBoneId);

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060022E6 RID: 8934
		// (set) Token: 0x060022E7 RID: 8935
		public extern AnimatorCullingMode cullingMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060022E8 RID: 8936
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StartPlayback();

		// Token: 0x060022E9 RID: 8937
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StopPlayback();

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060022EA RID: 8938
		// (set) Token: 0x060022EB RID: 8939
		public extern float playbackTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060022EC RID: 8940
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StartRecording(int frameCount);

		// Token: 0x060022ED RID: 8941
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StopRecording();

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060022EE RID: 8942
		// (set) Token: 0x060022EF RID: 8943
		public extern float recorderStartTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x060022F0 RID: 8944
		// (set) Token: 0x060022F1 RID: 8945
		public extern float recorderStopTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060022F2 RID: 8946
		public extern AnimatorRecorderMode recorderMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060022F3 RID: 8947
		// (set) Token: 0x060022F4 RID: 8948
		public extern RuntimeAnimatorController runtimeAnimatorController { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060022F5 RID: 8949
		public extern bool hasBoundPlayables { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060022F6 RID: 8950
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool HasState(int layerIndex, int stateID);

		// Token: 0x060022F7 RID: 8951
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int StringToHash(string name);

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060022F8 RID: 8952
		// (set) Token: 0x060022F9 RID: 8953
		public extern Avatar avatar { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060022FA RID: 8954
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern string GetStats();

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x00028658 File Offset: 0x00026858
		public PlayableGraph playableGraph
		{
			get
			{
				PlayableGraph result = default(PlayableGraph);
				this.InternalGetCurrentGraph(ref result);
				return result;
			}
		}

		// Token: 0x060022FC RID: 8956
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalGetCurrentGraph(ref PlayableGraph graph);

		// Token: 0x060022FD RID: 8957 RVA: 0x00028680 File Offset: 0x00026880
		private void CheckIfInIKPass()
		{
			if (this.logWarnings && !this.CheckIfInIKPassInternal())
			{
				Debug.LogWarning("Setting and getting Body Position/Rotation, IK Goals, Lookat and BoneLocalRotation should only be done in OnAnimatorIK or OnStateIK");
			}
		}

		// Token: 0x060022FE RID: 8958
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool CheckIfInIKPassInternal();

		// Token: 0x060022FF RID: 8959
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatString(string name, float value);

		// Token: 0x06002300 RID: 8960
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatID(int id, float value);

		// Token: 0x06002301 RID: 8961
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern float GetFloatString(string name);

		// Token: 0x06002302 RID: 8962
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern float GetFloatID(int id);

		// Token: 0x06002303 RID: 8963
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetBoolString(string name, bool value);

		// Token: 0x06002304 RID: 8964
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetBoolID(int id, bool value);

		// Token: 0x06002305 RID: 8965
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool GetBoolString(string name);

		// Token: 0x06002306 RID: 8966
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool GetBoolID(int id);

		// Token: 0x06002307 RID: 8967
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetIntegerString(string name, int value);

		// Token: 0x06002308 RID: 8968
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetIntegerID(int id, int value);

		// Token: 0x06002309 RID: 8969
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetIntegerString(string name);

		// Token: 0x0600230A RID: 8970
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetIntegerID(int id);

		// Token: 0x0600230B RID: 8971
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTriggerString(string name);

		// Token: 0x0600230C RID: 8972
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTriggerID(int id);

		// Token: 0x0600230D RID: 8973
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ResetTriggerString(string name);

		// Token: 0x0600230E RID: 8974
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ResetTriggerID(int id);

		// Token: 0x0600230F RID: 8975
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool IsParameterControlledByCurveString(string name);

		// Token: 0x06002310 RID: 8976
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool IsParameterControlledByCurveID(int id);

		// Token: 0x06002311 RID: 8977
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime);

		// Token: 0x06002312 RID: 8978
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime);

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002313 RID: 8979
		// (set) Token: 0x06002314 RID: 8980
		public extern bool layersAffectMassCenter { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002315 RID: 8981
		public extern float leftFeetBottomHeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002316 RID: 8982
		public extern float rightFeetBottomHeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002317 RID: 8983
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Update(float deltaTime);

		// Token: 0x06002318 RID: 8984
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Rebind();

		// Token: 0x06002319 RID: 8985
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ApplyBuiltinRootMotion();

		// Token: 0x0600231A RID: 8986
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern string ResolveHash(int hash);

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600231B RID: 8987
		// (set) Token: 0x0600231C RID: 8988
		public extern bool logWarnings { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x0600231D RID: 8989
		// (set) Token: 0x0600231E RID: 8990
		public extern bool fireEvents { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600231F RID: 8991 RVA: 0x000286A4 File Offset: 0x000268A4
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(string name)
		{
			return Vector3.zero;
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x000286C0 File Offset: 0x000268C0
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x000286DC File Offset: 0x000268DC
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(string name, Vector3 value)
		{
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x000286E0 File Offset: 0x000268E0
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(int id, Vector3 value)
		{
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x000286E4 File Offset: 0x000268E4
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(string name)
		{
			return Quaternion.identity;
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00028700 File Offset: 0x00026900
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(int id)
		{
			return Quaternion.identity;
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0002871C File Offset: 0x0002691C
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(string name, Quaternion value)
		{
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00028720 File Offset: 0x00026920
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(int id, Quaternion value)
		{
		}
	}
}
