using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001FA RID: 506
	[UsedByNativeCode]
	public struct AnimatorClipInfo
	{
		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x000277DC File Offset: 0x000259DC
		public AnimationClip clip
		{
			get
			{
				return (this.m_ClipInstanceID == 0) ? null : AnimatorClipInfo.ClipInstanceToScriptingObject(this.m_ClipInstanceID);
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x00027810 File Offset: 0x00025A10
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		// Token: 0x06002211 RID: 8721
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimationClip ClipInstanceToScriptingObject(int instanceID);

		// Token: 0x04000562 RID: 1378
		private int m_ClipInstanceID;

		// Token: 0x04000563 RID: 1379
		private float m_Weight;
	}
}
