using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.VR
{
	// Token: 0x020002DC RID: 732
	public static class VRStats
	{
		// Token: 0x06002EB9 RID: 11961
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool TryGetGPUTimeLastFrame(out float gpuTimeLastFrame);

		// Token: 0x06002EBA RID: 11962
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool TryGetDroppedFrameCount(out int droppedFrameCount);

		// Token: 0x06002EBB RID: 11963
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool TryGetFramePresentCount(out int framePresentCount);

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x000452CC File Offset: 0x000434CC
		[Obsolete("gpuTimeLastFrame is deprecated. Use VRStats.TryGetGPUTimeLastFrame instead.")]
		public static float gpuTimeLastFrame
		{
			get
			{
				float num;
				float result;
				if (VRStats.TryGetGPUTimeLastFrame(out num))
				{
					result = num;
				}
				else
				{
					result = 0f;
				}
				return result;
			}
		}
	}
}
