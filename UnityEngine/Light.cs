using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000073 RID: 115
	[RequireComponent(typeof(Transform))]
	public sealed class Light : Behaviour
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000821 RID: 2081
		// (set) Token: 0x06000822 RID: 2082
		public extern LightType type { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x0000A184 File Offset: 0x00008384
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x0000A1A4 File Offset: 0x000083A4
		public Color color
		{
			get
			{
				Color result;
				this.INTERNAL_get_color(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_color(ref value);
			}
		}

		// Token: 0x06000825 RID: 2085
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x06000826 RID: 2086
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000827 RID: 2087
		// (set) Token: 0x06000828 RID: 2088
		public extern float colorTemperature { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000829 RID: 2089
		// (set) Token: 0x0600082A RID: 2090
		public extern float intensity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600082B RID: 2091
		// (set) Token: 0x0600082C RID: 2092
		public extern float bounceIntensity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600082D RID: 2093
		// (set) Token: 0x0600082E RID: 2094
		public extern LightShadows shadows { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600082F RID: 2095
		// (set) Token: 0x06000830 RID: 2096
		public extern float shadowStrength { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000831 RID: 2097
		// (set) Token: 0x06000832 RID: 2098
		public extern LightShadowResolution shadowResolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000833 RID: 2099
		// (set) Token: 0x06000834 RID: 2100
		public extern int shadowCustomResolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000835 RID: 2101
		// (set) Token: 0x06000836 RID: 2102
		public extern float shadowBias { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000837 RID: 2103
		// (set) Token: 0x06000838 RID: 2104
		public extern float shadowNormalBias { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000839 RID: 2105
		// (set) Token: 0x0600083A RID: 2106
		public extern float shadowNearPlane { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600083B RID: 2107
		// (set) Token: 0x0600083C RID: 2108
		[Obsolete("Shadow softness is removed in Unity 5.0+")]
		public extern float shadowSoftness { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600083D RID: 2109
		// (set) Token: 0x0600083E RID: 2110
		[Obsolete("Shadow softness is removed in Unity 5.0+")]
		public extern float shadowSoftnessFade { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600083F RID: 2111
		// (set) Token: 0x06000840 RID: 2112
		public extern float range { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000841 RID: 2113
		// (set) Token: 0x06000842 RID: 2114
		public extern float spotAngle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000843 RID: 2115
		// (set) Token: 0x06000844 RID: 2116
		public extern float cookieSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000845 RID: 2117
		// (set) Token: 0x06000846 RID: 2118
		public extern Texture cookie { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000847 RID: 2119
		// (set) Token: 0x06000848 RID: 2120
		public extern Flare flare { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000849 RID: 2121
		// (set) Token: 0x0600084A RID: 2122
		public extern LightRenderMode renderMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600084B RID: 2123
		// (set) Token: 0x0600084C RID: 2124
		public extern bool alreadyLightmapped { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0000A1B0 File Offset: 0x000083B0
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0000A1CC File Offset: 0x000083CC
		[Obsolete("bakedIndex has been removed please use isBaked instead.")]
		public int bakedIndex
		{
			get
			{
				return this.m_BakedIndex;
			}
			set
			{
				this.m_BakedIndex = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600084F RID: 2127
		public extern bool isBaked { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000850 RID: 2128
		// (set) Token: 0x06000851 RID: 2129
		public extern int cullingMask { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000852 RID: 2130 RVA: 0x0000A1D8 File Offset: 0x000083D8
		public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer)
		{
			this.AddCommandBuffer(evt, buffer, ShadowMapPass.All);
		}

		// Token: 0x06000853 RID: 2131
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask);

		// Token: 0x06000854 RID: 2132
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer);

		// Token: 0x06000855 RID: 2133
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveCommandBuffers(LightEvent evt);

		// Token: 0x06000856 RID: 2134
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveAllCommandBuffers();

		// Token: 0x06000857 RID: 2135
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern CommandBuffer[] GetCommandBuffers(LightEvent evt);

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000858 RID: 2136
		public extern int commandBufferCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000859 RID: 2137
		// (set) Token: 0x0600085A RID: 2138
		public static extern int pixelLightCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600085B RID: 2139
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Light[] GetLights(LightType type, int layer);

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0000A1E8 File Offset: 0x000083E8
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x0000A204 File Offset: 0x00008404
		[Obsolete("light.shadowConstantBias was removed, use light.shadowBias", true)]
		public float shadowConstantBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x0000A208 File Offset: 0x00008408
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x0000A224 File Offset: 0x00008424
		[Obsolete("light.shadowObjectSizeBias was removed, use light.shadowBias", true)]
		public float shadowObjectSizeBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0000A228 File Offset: 0x00008428
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x0000A240 File Offset: 0x00008440
		[Obsolete("light.attenuate was removed; all lights always attenuate now", true)]
		public bool attenuate
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x040000B9 RID: 185
		private int m_BakedIndex;
	}
}
