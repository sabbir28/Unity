using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000075 RID: 117
	public sealed class LightProbeProxyVolume : Behaviour
	{
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0000A254 File Offset: 0x00008454
		public Bounds boundsGlobal
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_boundsGlobal(out result);
				return result;
			}
		}

		// Token: 0x06000867 RID: 2151
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_boundsGlobal(out Bounds value);

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0000A274 File Offset: 0x00008474
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x0000A294 File Offset: 0x00008494
		public Vector3 sizeCustom
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_sizeCustom(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_sizeCustom(ref value);
			}
		}

		// Token: 0x0600086A RID: 2154
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_sizeCustom(out Vector3 value);

		// Token: 0x0600086B RID: 2155
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_sizeCustom(ref Vector3 value);

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0000A2A0 File Offset: 0x000084A0
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x0000A2C0 File Offset: 0x000084C0
		public Vector3 originCustom
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_originCustom(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_originCustom(ref value);
			}
		}

		// Token: 0x0600086E RID: 2158
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_originCustom(out Vector3 value);

		// Token: 0x0600086F RID: 2159
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_originCustom(ref Vector3 value);

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000870 RID: 2160
		// (set) Token: 0x06000871 RID: 2161
		public extern LightProbeProxyVolume.BoundingBoxMode boundingBoxMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000872 RID: 2162
		// (set) Token: 0x06000873 RID: 2163
		public extern LightProbeProxyVolume.ResolutionMode resolutionMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000874 RID: 2164
		// (set) Token: 0x06000875 RID: 2165
		public extern LightProbeProxyVolume.ProbePositionMode probePositionMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000876 RID: 2166
		// (set) Token: 0x06000877 RID: 2167
		public extern LightProbeProxyVolume.RefreshMode refreshMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000878 RID: 2168
		// (set) Token: 0x06000879 RID: 2169
		public extern float probeDensity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600087A RID: 2170
		// (set) Token: 0x0600087B RID: 2171
		public extern int gridResolutionX { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600087C RID: 2172
		// (set) Token: 0x0600087D RID: 2173
		public extern int gridResolutionY { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600087E RID: 2174
		// (set) Token: 0x0600087F RID: 2175
		public extern int gridResolutionZ { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000880 RID: 2176
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Update();

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000881 RID: 2177
		public static extern bool isFeatureSupported { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x02000076 RID: 118
		public enum ResolutionMode
		{
			// Token: 0x040000BB RID: 187
			Automatic,
			// Token: 0x040000BC RID: 188
			Custom
		}

		// Token: 0x02000077 RID: 119
		public enum BoundingBoxMode
		{
			// Token: 0x040000BE RID: 190
			AutomaticLocal,
			// Token: 0x040000BF RID: 191
			AutomaticWorld,
			// Token: 0x040000C0 RID: 192
			Custom
		}

		// Token: 0x02000078 RID: 120
		public enum ProbePositionMode
		{
			// Token: 0x040000C2 RID: 194
			CellCorner,
			// Token: 0x040000C3 RID: 195
			CellCenter
		}

		// Token: 0x02000079 RID: 121
		public enum RefreshMode
		{
			// Token: 0x040000C5 RID: 197
			Automatic,
			// Token: 0x040000C6 RID: 198
			EveryFrame,
			// Token: 0x040000C7 RID: 199
			ViaScripting
		}
	}
}
