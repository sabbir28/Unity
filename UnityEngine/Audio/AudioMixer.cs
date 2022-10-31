using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	// Token: 0x020001DC RID: 476
	public class AudioMixer : Object
	{
		// Token: 0x0600210F RID: 8463 RVA: 0x00026B14 File Offset: 0x00024D14
		internal AudioMixer()
		{
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06002110 RID: 8464
		// (set) Token: 0x06002111 RID: 8465
		public extern AudioMixerGroup outputAudioMixerGroup { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002112 RID: 8466
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AudioMixerGroup[] FindMatchingGroups(string subPath);

		// Token: 0x06002113 RID: 8467
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AudioMixerSnapshot FindSnapshot(string name);

		// Token: 0x06002114 RID: 8468 RVA: 0x00026B20 File Offset: 0x00024D20
		private void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach)
		{
			if (snapshot == null)
			{
				throw new ArgumentException("null Snapshot passed to AudioMixer.TransitionToSnapshot of AudioMixer '" + base.name + "'");
			}
			if (snapshot.audioMixer != this)
			{
				throw new ArgumentException(string.Concat(new string[]
				{
					"Snapshot '",
					snapshot.name,
					"' passed to AudioMixer.TransitionToSnapshot is not a snapshot from AudioMixer '",
					base.name,
					"'"
				}));
			}
			snapshot.TransitionTo(timeToReach);
		}

		// Token: 0x06002115 RID: 8469
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void TransitionToSnapshots(AudioMixerSnapshot[] snapshots, float[] weights, float timeToReach);

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06002116 RID: 8470
		// (set) Token: 0x06002117 RID: 8471
		public extern AudioMixerUpdateMode updateMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002118 RID: 8472
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SetFloat(string name, float value);

		// Token: 0x06002119 RID: 8473
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool ClearFloat(string name);

		// Token: 0x0600211A RID: 8474
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetFloat(string name, out float value);
	}
}
