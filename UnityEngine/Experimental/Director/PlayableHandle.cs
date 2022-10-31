using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x020000DA RID: 218
	[UsedByNativeCode]
	public struct PlayableHandle
	{
		// Token: 0x06000FC7 RID: 4039 RVA: 0x0001578C File Offset: 0x0001398C
		public T GetObject<T>() where T : Playable
		{
			T result;
			if (!this.IsValid())
			{
				result = (T)((object)null);
			}
			else
			{
				Playable playable = PlayableHandle.GetScriptInstance(ref this) as Playable;
				if (playable != null)
				{
					result = (playable as T);
				}
				else
				{
					Type playableTypeOf = PlayableHandle.GetPlayableTypeOf(ref this);
					T t = (T)((object)Activator.CreateInstance(playableTypeOf));
					t.handle = this;
					PlayableHandle.SetScriptInstance(ref this, t);
					result = t;
				}
			}
			return result;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0001580C File Offset: 0x00013A0C
		public Playable GetObject()
		{
			return this.GetObject<Playable>();
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00015828 File Offset: 0x00013A28
		private static object GetScriptInstance(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_GetScriptInstance(ref playable);
		}

		// Token: 0x06000FCA RID: 4042
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object INTERNAL_CALL_GetScriptInstance(ref PlayableHandle playable);

		// Token: 0x06000FCB RID: 4043 RVA: 0x00015844 File Offset: 0x00013A44
		private static void SetScriptInstance(ref PlayableHandle playable, object scriptInstance)
		{
			PlayableHandle.INTERNAL_CALL_SetScriptInstance(ref playable, scriptInstance);
		}

		// Token: 0x06000FCC RID: 4044
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetScriptInstance(ref PlayableHandle playable, object scriptInstance);

		// Token: 0x06000FCD RID: 4045 RVA: 0x00015850 File Offset: 0x00013A50
		public bool IsValid()
		{
			return PlayableHandle.IsValidInternal(ref this);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0001586C File Offset: 0x00013A6C
		private static bool IsValidInternal(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_IsValidInternal(ref playable);
		}

		// Token: 0x06000FCF RID: 4047
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsValidInternal(ref PlayableHandle playable);

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00015888 File Offset: 0x00013A88
		internal static Type GetPlayableTypeOf(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_GetPlayableTypeOf(ref playable);
		}

		// Token: 0x06000FD1 RID: 4049
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Type INTERNAL_CALL_GetPlayableTypeOf(ref PlayableHandle playable);

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x000158A4 File Offset: 0x00013AA4
		public static PlayableHandle Null
		{
			get
			{
				return new PlayableHandle
				{
					m_Version = 10
				};
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x000158CC File Offset: 0x00013ACC
		public PlayableGraph graph
		{
			get
			{
				PlayableGraph result = default(PlayableGraph);
				PlayableHandle.GetGraphInternal(ref this, ref result);
				return result;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x000158F4 File Offset: 0x00013AF4
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00015910 File Offset: 0x00013B10
		public int inputCount
		{
			get
			{
				return PlayableHandle.GetInputCountInternal(ref this);
			}
			set
			{
				PlayableHandle.SetInputCountInternal(ref this, value);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0001591C File Offset: 0x00013B1C
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00015938 File Offset: 0x00013B38
		public int outputCount
		{
			get
			{
				return PlayableHandle.GetOutputCountInternal(ref this);
			}
			set
			{
				PlayableHandle.SetOutputCountInternal(ref this, value);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00015944 File Offset: 0x00013B44
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00015960 File Offset: 0x00013B60
		public PlayState playState
		{
			get
			{
				return PlayableHandle.GetPlayStateInternal(ref this);
			}
			set
			{
				PlayableHandle.SetPlayStateInternal(ref this, value);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0001596C File Offset: 0x00013B6C
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x00015988 File Offset: 0x00013B88
		public double speed
		{
			get
			{
				return PlayableHandle.GetSpeedInternal(ref this);
			}
			set
			{
				PlayableHandle.SetSpeedInternal(ref this, value);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00015994 File Offset: 0x00013B94
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x000159B0 File Offset: 0x00013BB0
		public double time
		{
			get
			{
				return PlayableHandle.GetTimeInternal(ref this);
			}
			set
			{
				PlayableHandle.SetTimeInternal(ref this, value);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x000159BC File Offset: 0x00013BBC
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x000159D8 File Offset: 0x00013BD8
		public bool isDone
		{
			get
			{
				return PlayableHandle.InternalGetDone(ref this);
			}
			set
			{
				PlayableHandle.InternalSetDone(ref this, value);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x000159E4 File Offset: 0x00013BE4
		internal bool canChangeInputs
		{
			get
			{
				return PlayableHandle.CanChangeInputsInternal(ref this);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00015A00 File Offset: 0x00013C00
		internal bool canSetWeights
		{
			get
			{
				return PlayableHandle.CanSetWeightsInternal(ref this);
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00015A1C File Offset: 0x00013C1C
		internal bool canDestroy
		{
			get
			{
				return PlayableHandle.CanDestroyInternal(ref this);
			}
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00015A38 File Offset: 0x00013C38
		private static bool CanChangeInputsInternal(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_CanChangeInputsInternal(ref playable);
		}

		// Token: 0x06000FE4 RID: 4068
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CanChangeInputsInternal(ref PlayableHandle playable);

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00015A54 File Offset: 0x00013C54
		private static bool CanSetWeightsInternal(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_CanSetWeightsInternal(ref playable);
		}

		// Token: 0x06000FE6 RID: 4070
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CanSetWeightsInternal(ref PlayableHandle playable);

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00015A70 File Offset: 0x00013C70
		private static bool CanDestroyInternal(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_CanDestroyInternal(ref playable);
		}

		// Token: 0x06000FE8 RID: 4072
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CanDestroyInternal(ref PlayableHandle playable);

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00015A8C File Offset: 0x00013C8C
		private static PlayState GetPlayStateInternal(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_GetPlayStateInternal(ref playable);
		}

		// Token: 0x06000FEA RID: 4074
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern PlayState INTERNAL_CALL_GetPlayStateInternal(ref PlayableHandle playable);

		// Token: 0x06000FEB RID: 4075 RVA: 0x00015AA8 File Offset: 0x00013CA8
		private static void SetPlayStateInternal(ref PlayableHandle playable, PlayState playState)
		{
			PlayableHandle.INTERNAL_CALL_SetPlayStateInternal(ref playable, playState);
		}

		// Token: 0x06000FEC RID: 4076
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetPlayStateInternal(ref PlayableHandle playable, PlayState playState);

		// Token: 0x06000FED RID: 4077 RVA: 0x00015AB4 File Offset: 0x00013CB4
		private static double GetSpeedInternal(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_GetSpeedInternal(ref playable);
		}

		// Token: 0x06000FEE RID: 4078
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double INTERNAL_CALL_GetSpeedInternal(ref PlayableHandle playable);

		// Token: 0x06000FEF RID: 4079 RVA: 0x00015AD0 File Offset: 0x00013CD0
		private static void SetSpeedInternal(ref PlayableHandle playable, double speed)
		{
			PlayableHandle.INTERNAL_CALL_SetSpeedInternal(ref playable, speed);
		}

		// Token: 0x06000FF0 RID: 4080
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetSpeedInternal(ref PlayableHandle playable, double speed);

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00015ADC File Offset: 0x00013CDC
		private static double GetTimeInternal(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_GetTimeInternal(ref playable);
		}

		// Token: 0x06000FF2 RID: 4082
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double INTERNAL_CALL_GetTimeInternal(ref PlayableHandle playable);

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00015AF8 File Offset: 0x00013CF8
		private static void SetTimeInternal(ref PlayableHandle playable, double time)
		{
			PlayableHandle.INTERNAL_CALL_SetTimeInternal(ref playable, time);
		}

		// Token: 0x06000FF4 RID: 4084
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTimeInternal(ref PlayableHandle playable, double time);

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00015B04 File Offset: 0x00013D04
		private static bool InternalGetDone(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_InternalGetDone(ref playable);
		}

		// Token: 0x06000FF6 RID: 4086
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_InternalGetDone(ref PlayableHandle playable);

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00015B20 File Offset: 0x00013D20
		private static void InternalSetDone(ref PlayableHandle playable, bool isDone)
		{
			PlayableHandle.INTERNAL_CALL_InternalSetDone(ref playable, isDone);
		}

		// Token: 0x06000FF8 RID: 4088
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_InternalSetDone(ref PlayableHandle playable, bool isDone);

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00015B2C File Offset: 0x00013D2C
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x00015B48 File Offset: 0x00013D48
		public double duration
		{
			get
			{
				return PlayableHandle.GetDurationInternal(ref this);
			}
			set
			{
				PlayableHandle.SetDurationInternal(ref this, value);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00015B54 File Offset: 0x00013D54
		private static double GetDurationInternal(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_GetDurationInternal(ref playable);
		}

		// Token: 0x06000FFC RID: 4092
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double INTERNAL_CALL_GetDurationInternal(ref PlayableHandle playable);

		// Token: 0x06000FFD RID: 4093 RVA: 0x00015B70 File Offset: 0x00013D70
		private static void SetDurationInternal(ref PlayableHandle playable, double duration)
		{
			PlayableHandle.INTERNAL_CALL_SetDurationInternal(ref playable, duration);
		}

		// Token: 0x06000FFE RID: 4094
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetDurationInternal(ref PlayableHandle playable, double duration);

		// Token: 0x06000FFF RID: 4095 RVA: 0x00015B7C File Offset: 0x00013D7C
		private static void GetGraphInternal(ref PlayableHandle playable, ref PlayableGraph graph)
		{
			PlayableHandle.INTERNAL_CALL_GetGraphInternal(ref playable, ref graph);
		}

		// Token: 0x06001000 RID: 4096
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetGraphInternal(ref PlayableHandle playable, ref PlayableGraph graph);

		// Token: 0x06001001 RID: 4097 RVA: 0x00015B88 File Offset: 0x00013D88
		private static int GetInputCountInternal(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_GetInputCountInternal(ref playable);
		}

		// Token: 0x06001002 RID: 4098
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetInputCountInternal(ref PlayableHandle playable);

		// Token: 0x06001003 RID: 4099 RVA: 0x00015BA4 File Offset: 0x00013DA4
		private static void SetInputCountInternal(ref PlayableHandle playable, int count)
		{
			PlayableHandle.INTERNAL_CALL_SetInputCountInternal(ref playable, count);
		}

		// Token: 0x06001004 RID: 4100
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetInputCountInternal(ref PlayableHandle playable, int count);

		// Token: 0x06001005 RID: 4101 RVA: 0x00015BB0 File Offset: 0x00013DB0
		private static int GetOutputCountInternal(ref PlayableHandle playable)
		{
			return PlayableHandle.INTERNAL_CALL_GetOutputCountInternal(ref playable);
		}

		// Token: 0x06001006 RID: 4102
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetOutputCountInternal(ref PlayableHandle playable);

		// Token: 0x06001007 RID: 4103 RVA: 0x00015BCC File Offset: 0x00013DCC
		private static void SetOutputCountInternal(ref PlayableHandle playable, int count)
		{
			PlayableHandle.INTERNAL_CALL_SetOutputCountInternal(ref playable, count);
		}

		// Token: 0x06001008 RID: 4104
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetOutputCountInternal(ref PlayableHandle playable, int count);

		// Token: 0x06001009 RID: 4105 RVA: 0x00015BD8 File Offset: 0x00013DD8
		public PlayableHandle GetInput(int inputPort)
		{
			return PlayableHandle.GetInputInternal(ref this, inputPort);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00015BF4 File Offset: 0x00013DF4
		private static PlayableHandle GetInputInternal(ref PlayableHandle playable, int index)
		{
			PlayableHandle result;
			PlayableHandle.INTERNAL_CALL_GetInputInternal(ref playable, index, out result);
			return result;
		}

		// Token: 0x0600100B RID: 4107
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetInputInternal(ref PlayableHandle playable, int index, out PlayableHandle value);

		// Token: 0x0600100C RID: 4108 RVA: 0x00015C14 File Offset: 0x00013E14
		public PlayableHandle GetOutput(int outputPort)
		{
			return PlayableHandle.GetOutputInternal(ref this, outputPort);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00015C30 File Offset: 0x00013E30
		private static PlayableHandle GetOutputInternal(ref PlayableHandle playable, int index)
		{
			PlayableHandle result;
			PlayableHandle.INTERNAL_CALL_GetOutputInternal(ref playable, index, out result);
			return result;
		}

		// Token: 0x0600100E RID: 4110
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetOutputInternal(ref PlayableHandle playable, int index, out PlayableHandle value);

		// Token: 0x0600100F RID: 4111 RVA: 0x00015C50 File Offset: 0x00013E50
		private static void SetInputWeightFromIndexInternal(ref PlayableHandle playable, int index, float weight)
		{
			PlayableHandle.INTERNAL_CALL_SetInputWeightFromIndexInternal(ref playable, index, weight);
		}

		// Token: 0x06001010 RID: 4112
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetInputWeightFromIndexInternal(ref PlayableHandle playable, int index, float weight);

		// Token: 0x06001011 RID: 4113 RVA: 0x00015C5C File Offset: 0x00013E5C
		public bool SetInputWeight(int inputIndex, float weight)
		{
			bool result;
			if (this.CheckInputBounds(inputIndex))
			{
				PlayableHandle.SetInputWeightFromIndexInternal(ref this, inputIndex, weight);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00015C90 File Offset: 0x00013E90
		private static float GetInputWeightFromIndexInternal(ref PlayableHandle playable, int index)
		{
			return PlayableHandle.INTERNAL_CALL_GetInputWeightFromIndexInternal(ref playable, index);
		}

		// Token: 0x06001013 RID: 4115
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetInputWeightFromIndexInternal(ref PlayableHandle playable, int index);

		// Token: 0x06001014 RID: 4116 RVA: 0x00015CAC File Offset: 0x00013EAC
		public float GetInputWeight(int inputIndex)
		{
			float result;
			if (this.CheckInputBounds(inputIndex))
			{
				result = PlayableHandle.GetInputWeightFromIndexInternal(ref this, inputIndex);
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00015CE0 File Offset: 0x00013EE0
		public void Destroy()
		{
			this.graph.DestroyPlayable(this);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00015D04 File Offset: 0x00013F04
		public static bool operator ==(PlayableHandle x, PlayableHandle y)
		{
			return PlayableHandle.CompareVersion(x, y);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00015D20 File Offset: 0x00013F20
		public static bool operator !=(PlayableHandle x, PlayableHandle y)
		{
			return !PlayableHandle.CompareVersion(x, y);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00015D40 File Offset: 0x00013F40
		public override bool Equals(object p)
		{
			return p is PlayableHandle && PlayableHandle.CompareVersion(this, (PlayableHandle)p);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00015D78 File Offset: 0x00013F78
		public override int GetHashCode()
		{
			return this.m_Handle.GetHashCode() ^ this.m_Version.GetHashCode();
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00015DB0 File Offset: 0x00013FB0
		internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
		{
			return lhs.m_Handle == rhs.m_Handle && lhs.m_Version == rhs.m_Version;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00015DF0 File Offset: 0x00013FF0
		internal bool CheckInputBounds(int inputIndex)
		{
			return this.CheckInputBounds(inputIndex, false);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00015E10 File Offset: 0x00014010
		internal bool CheckInputBounds(int inputIndex, bool acceptAny)
		{
			bool result;
			if (inputIndex == -1 && acceptAny)
			{
				result = true;
			}
			else
			{
				if (inputIndex < 0)
				{
					throw new IndexOutOfRangeException("Index must be greater than 0");
				}
				if (this.inputCount <= inputIndex)
				{
					throw new IndexOutOfRangeException(string.Concat(new object[]
					{
						"inputIndex ",
						inputIndex,
						" is greater than the number of available inputs (",
						this.inputCount,
						")."
					}));
				}
				result = true;
			}
			return result;
		}

		// Token: 0x04000201 RID: 513
		internal IntPtr m_Handle;

		// Token: 0x04000202 RID: 514
		internal int m_Version;
	}
}
