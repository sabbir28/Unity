using System;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x020000DC RID: 220
	[RequiredByNativeCode]
	public abstract class ScriptPlayable : Playable
	{
		// Token: 0x06001021 RID: 4129 RVA: 0x00015EE8 File Offset: 0x000140E8
		public virtual void OnGraphStart()
		{
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00015EEC File Offset: 0x000140EC
		public virtual void OnGraphStop()
		{
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00015EF0 File Offset: 0x000140F0
		public virtual void OnDestroy()
		{
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00015EF4 File Offset: 0x000140F4
		public virtual void PrepareFrame(FrameData info)
		{
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00015EF8 File Offset: 0x000140F8
		public virtual void ProcessFrame(FrameData info, object playerData)
		{
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00015EFC File Offset: 0x000140FC
		public virtual void OnPlayStateChanged(FrameData info, PlayState newState)
		{
		}
	}
}
