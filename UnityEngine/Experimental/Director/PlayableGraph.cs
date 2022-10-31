using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x020000DD RID: 221
	[UsedByNativeCode]
	public struct PlayableGraph
	{
		// Token: 0x06001027 RID: 4135 RVA: 0x00015F00 File Offset: 0x00014100
		public bool IsValid()
		{
			return PlayableGraph.IsValidInternal(ref this);
		}

		// Token: 0x06001028 RID: 4136
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsValidInternal(ref PlayableGraph graph);

		// Token: 0x06001029 RID: 4137 RVA: 0x00015F1C File Offset: 0x0001411C
		public static PlayableGraph CreateGraph()
		{
			PlayableGraph result = default(PlayableGraph);
			PlayableGraph.InternalCreate(ref result);
			return result;
		}

		// Token: 0x0600102A RID: 4138
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalCreate(ref PlayableGraph graph);

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x00015F44 File Offset: 0x00014144
		public bool isDone
		{
			get
			{
				return PlayableGraph.InternalIsDone(ref this);
			}
		}

		// Token: 0x0600102C RID: 4140
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool InternalIsDone(ref PlayableGraph graph);

		// Token: 0x0600102D RID: 4141 RVA: 0x00015F60 File Offset: 0x00014160
		public void Play()
		{
			PlayableGraph.InternalPlay(ref this);
		}

		// Token: 0x0600102E RID: 4142
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalPlay(ref PlayableGraph graph);

		// Token: 0x0600102F RID: 4143 RVA: 0x00015F6C File Offset: 0x0001416C
		public void Stop()
		{
			PlayableGraph.InternalStop(ref this);
		}

		// Token: 0x06001030 RID: 4144
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalStop(ref PlayableGraph graph);

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00015F78 File Offset: 0x00014178
		public int playableCount
		{
			get
			{
				return PlayableGraph.InternalPlayableCount(ref this);
			}
		}

		// Token: 0x06001032 RID: 4146
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int InternalPlayableCount(ref PlayableGraph graph);

		// Token: 0x06001033 RID: 4147 RVA: 0x00015F94 File Offset: 0x00014194
		public ScriptPlayableOutput CreateScriptOutput(string name)
		{
			ScriptPlayableOutput scriptPlayableOutput = default(ScriptPlayableOutput);
			ScriptPlayableOutput result;
			if (!PlayableGraph.InternalCreateScriptOutput(ref this, name, out scriptPlayableOutput.m_Output))
			{
				result = ScriptPlayableOutput.Null;
			}
			else
			{
				result = scriptPlayableOutput;
			}
			return result;
		}

		// Token: 0x06001034 RID: 4148
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool InternalCreateScriptOutput(ref PlayableGraph graph, string name, out PlayableOutput output);

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x00015FD0 File Offset: 0x000141D0
		public int scriptOutputCount
		{
			get
			{
				return PlayableGraph.internalScriptOutputCount(ref this);
			}
		}

		// Token: 0x06001036 RID: 4150
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int internalScriptOutputCount(ref PlayableGraph graph);

		// Token: 0x06001037 RID: 4151 RVA: 0x00015FEC File Offset: 0x000141EC
		public ScriptPlayableOutput GetScriptOutput(int index)
		{
			ScriptPlayableOutput scriptPlayableOutput = default(ScriptPlayableOutput);
			ScriptPlayableOutput result;
			if (!PlayableGraph.InternalGetScriptOutput(ref this, index, out scriptPlayableOutput.m_Output))
			{
				result = ScriptPlayableOutput.Null;
			}
			else
			{
				result = scriptPlayableOutput;
			}
			return result;
		}

		// Token: 0x06001038 RID: 4152
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool InternalGetScriptOutput(ref PlayableGraph graph, int index, out PlayableOutput output);

		// Token: 0x06001039 RID: 4153 RVA: 0x00016028 File Offset: 0x00014228
		public PlayableHandle CreatePlayable()
		{
			PlayableHandle @null = PlayableHandle.Null;
			PlayableHandle result;
			if (!PlayableGraph.InternalCreatePlayable(ref this, ref @null))
			{
				result = PlayableHandle.Null;
			}
			else
			{
				result = @null;
			}
			return result;
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0001605C File Offset: 0x0001425C
		[ExcludeFromDocs]
		public PlayableHandle CreateGenericMixerPlayable()
		{
			int inputCount = 0;
			return this.CreateGenericMixerPlayable(inputCount);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0001607C File Offset: 0x0001427C
		public PlayableHandle CreateGenericMixerPlayable([DefaultValue("0")] int inputCount)
		{
			PlayableHandle @null = PlayableHandle.Null;
			PlayableHandle result;
			if (!PlayableGraph.InternalCreatePlayable(ref this, ref @null))
			{
				result = PlayableHandle.Null;
			}
			else
			{
				@null.inputCount = inputCount;
				result = @null;
			}
			return result;
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x000160B8 File Offset: 0x000142B8
		public PlayableHandle CreateScriptPlayable<T>() where T : ScriptPlayable, new()
		{
			PlayableHandle @null = PlayableHandle.Null;
			ScriptPlayable scriptPlayable = PlayableGraph.InternalCreateScriptPlayable(ref this, ref @null, typeof(T)) as ScriptPlayable;
			PlayableHandle result;
			if (scriptPlayable == null)
			{
				result = PlayableHandle.Null;
			}
			else
			{
				scriptPlayable.handle = @null;
				result = @null;
			}
			return result;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00016104 File Offset: 0x00014304
		private static bool InternalCreatePlayable(ref PlayableGraph graph, ref PlayableHandle handle)
		{
			return PlayableGraph.INTERNAL_CALL_InternalCreatePlayable(ref graph, ref handle);
		}

		// Token: 0x0600103E RID: 4158
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_InternalCreatePlayable(ref PlayableGraph graph, ref PlayableHandle handle);

		// Token: 0x0600103F RID: 4159 RVA: 0x00016120 File Offset: 0x00014320
		private static object InternalCreateScriptPlayable(ref PlayableGraph graph, ref PlayableHandle handle, Type type)
		{
			return PlayableGraph.INTERNAL_CALL_InternalCreateScriptPlayable(ref graph, ref handle, type);
		}

		// Token: 0x06001040 RID: 4160
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object INTERNAL_CALL_InternalCreateScriptPlayable(ref PlayableGraph graph, ref PlayableHandle handle, Type type);

		// Token: 0x06001041 RID: 4161 RVA: 0x00016140 File Offset: 0x00014340
		public void Destroy()
		{
			PlayableGraph.DestroyInternal(ref this);
		}

		// Token: 0x06001042 RID: 4162
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DestroyInternal(ref PlayableGraph graph);

		// Token: 0x06001043 RID: 4163 RVA: 0x0001614C File Offset: 0x0001434C
		public bool Connect(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort)
		{
			return PlayableGraph.ConnectInternal(ref this, source, sourceOutputPort, destination, destinationInputPort);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0001616C File Offset: 0x0001436C
		public bool Connect(Playable source, int sourceOutputPort, Playable destination, int destinationInputPort)
		{
			return PlayableGraph.ConnectInternal(ref this, source.handle, sourceOutputPort, destination.handle, destinationInputPort);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00016198 File Offset: 0x00014398
		private static bool ConnectInternal(ref PlayableGraph graph, PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort)
		{
			return PlayableGraph.INTERNAL_CALL_ConnectInternal(ref graph, ref source, sourceOutputPort, ref destination, destinationInputPort);
		}

		// Token: 0x06001046 RID: 4166
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_ConnectInternal(ref PlayableGraph graph, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort);

		// Token: 0x06001047 RID: 4167 RVA: 0x000161BC File Offset: 0x000143BC
		public void Disconnect(Playable playable, int inputPort)
		{
			PlayableHandle handle = playable.handle;
			PlayableGraph.DisconnectInternal(ref this, ref handle, inputPort);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x000161DC File Offset: 0x000143DC
		public void Disconnect(PlayableHandle playable, int inputPort)
		{
			PlayableGraph.DisconnectInternal(ref this, ref playable, inputPort);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x000161E8 File Offset: 0x000143E8
		private static void DisconnectInternal(ref PlayableGraph graph, ref PlayableHandle playable, int inputPort)
		{
			PlayableGraph.INTERNAL_CALL_DisconnectInternal(ref graph, ref playable, inputPort);
		}

		// Token: 0x0600104A RID: 4170
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DisconnectInternal(ref PlayableGraph graph, ref PlayableHandle playable, int inputPort);

		// Token: 0x0600104B RID: 4171 RVA: 0x000161F4 File Offset: 0x000143F4
		public void DestroyPlayable(PlayableHandle playable)
		{
			PlayableGraph.InternalDestroyPlayable(ref this, ref playable);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00016200 File Offset: 0x00014400
		private static void InternalDestroyPlayable(ref PlayableGraph graph, ref PlayableHandle playable)
		{
			PlayableGraph.INTERNAL_CALL_InternalDestroyPlayable(ref graph, ref playable);
		}

		// Token: 0x0600104D RID: 4173
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_InternalDestroyPlayable(ref PlayableGraph graph, ref PlayableHandle playable);

		// Token: 0x0600104E RID: 4174 RVA: 0x0001620C File Offset: 0x0001440C
		public void DestroyOutput(ScriptPlayableOutput output)
		{
			PlayableGraph.InternalDestroyOutput(ref this, ref output.m_Output);
		}

		// Token: 0x0600104F RID: 4175
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InternalDestroyOutput(ref PlayableGraph graph, ref PlayableOutput output);

		// Token: 0x06001050 RID: 4176 RVA: 0x0001621C File Offset: 0x0001441C
		public void DestroySubgraph(PlayableHandle playable)
		{
			PlayableGraph.InternalDestroySubgraph(ref this, playable);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00016228 File Offset: 0x00014428
		private static void InternalDestroySubgraph(ref PlayableGraph graph, PlayableHandle playable)
		{
			PlayableGraph.INTERNAL_CALL_InternalDestroySubgraph(ref graph, ref playable);
		}

		// Token: 0x06001052 RID: 4178
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_InternalDestroySubgraph(ref PlayableGraph graph, ref PlayableHandle playable);

		// Token: 0x06001053 RID: 4179 RVA: 0x00016234 File Offset: 0x00014434
		[ExcludeFromDocs]
		public void Evaluate()
		{
			float deltaTime = 0f;
			this.Evaluate(deltaTime);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00016250 File Offset: 0x00014450
		public void Evaluate([DefaultValue("0")] float deltaTime)
		{
			PlayableGraph.InternalEvaluate(ref this, deltaTime);
		}

		// Token: 0x06001055 RID: 4181
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void InternalEvaluate(ref PlayableGraph graph, float deltaTime);

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x0001625C File Offset: 0x0001445C
		public int rootPlayableCount
		{
			get
			{
				return PlayableGraph.InternalRootPlayableCount(ref this);
			}
		}

		// Token: 0x06001057 RID: 4183
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int InternalRootPlayableCount(ref PlayableGraph graph);

		// Token: 0x06001058 RID: 4184 RVA: 0x00016278 File Offset: 0x00014478
		public PlayableHandle GetRootPlayable(int index)
		{
			PlayableHandle @null = PlayableHandle.Null;
			PlayableGraph.InternalGetRootPlayable(index, ref this, ref @null);
			return @null;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x000162A0 File Offset: 0x000144A0
		internal static void InternalGetRootPlayable(int index, ref PlayableGraph graph, ref PlayableHandle handle)
		{
			PlayableGraph.INTERNAL_CALL_InternalGetRootPlayable(index, ref graph, ref handle);
		}

		// Token: 0x0600105A RID: 4186
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_InternalGetRootPlayable(int index, ref PlayableGraph graph, ref PlayableHandle handle);

		// Token: 0x04000204 RID: 516
		internal IntPtr m_Handle;

		// Token: 0x04000205 RID: 517
		internal int m_Version;
	}
}
