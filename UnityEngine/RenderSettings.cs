using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000042 RID: 66
	public sealed class RenderSettings : Object
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000493 RID: 1171
		// (set) Token: 0x06000494 RID: 1172
		public static extern bool fog { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000495 RID: 1173
		// (set) Token: 0x06000496 RID: 1174
		public static extern FogMode fogMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00007504 File Offset: 0x00005704
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00007524 File Offset: 0x00005724
		public static Color fogColor
		{
			get
			{
				Color result;
				RenderSettings.INTERNAL_get_fogColor(out result);
				return result;
			}
			set
			{
				RenderSettings.INTERNAL_set_fogColor(ref value);
			}
		}

		// Token: 0x06000499 RID: 1177
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_fogColor(out Color value);

		// Token: 0x0600049A RID: 1178
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_fogColor(ref Color value);

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600049B RID: 1179
		// (set) Token: 0x0600049C RID: 1180
		public static extern float fogDensity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600049D RID: 1181
		// (set) Token: 0x0600049E RID: 1182
		public static extern float fogStartDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600049F RID: 1183
		// (set) Token: 0x060004A0 RID: 1184
		public static extern float fogEndDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004A1 RID: 1185
		// (set) Token: 0x060004A2 RID: 1186
		public static extern AmbientMode ambientMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00007530 File Offset: 0x00005730
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00007550 File Offset: 0x00005750
		public static Color ambientSkyColor
		{
			get
			{
				Color result;
				RenderSettings.INTERNAL_get_ambientSkyColor(out result);
				return result;
			}
			set
			{
				RenderSettings.INTERNAL_set_ambientSkyColor(ref value);
			}
		}

		// Token: 0x060004A5 RID: 1189
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_ambientSkyColor(out Color value);

		// Token: 0x060004A6 RID: 1190
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_ambientSkyColor(ref Color value);

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0000755C File Offset: 0x0000575C
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0000757C File Offset: 0x0000577C
		public static Color ambientEquatorColor
		{
			get
			{
				Color result;
				RenderSettings.INTERNAL_get_ambientEquatorColor(out result);
				return result;
			}
			set
			{
				RenderSettings.INTERNAL_set_ambientEquatorColor(ref value);
			}
		}

		// Token: 0x060004A9 RID: 1193
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_ambientEquatorColor(out Color value);

		// Token: 0x060004AA RID: 1194
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_ambientEquatorColor(ref Color value);

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00007588 File Offset: 0x00005788
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x000075A8 File Offset: 0x000057A8
		public static Color ambientGroundColor
		{
			get
			{
				Color result;
				RenderSettings.INTERNAL_get_ambientGroundColor(out result);
				return result;
			}
			set
			{
				RenderSettings.INTERNAL_set_ambientGroundColor(ref value);
			}
		}

		// Token: 0x060004AD RID: 1197
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_ambientGroundColor(out Color value);

		// Token: 0x060004AE RID: 1198
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_ambientGroundColor(ref Color value);

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x000075B4 File Offset: 0x000057B4
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x000075D4 File Offset: 0x000057D4
		public static Color ambientLight
		{
			get
			{
				Color result;
				RenderSettings.INTERNAL_get_ambientLight(out result);
				return result;
			}
			set
			{
				RenderSettings.INTERNAL_set_ambientLight(ref value);
			}
		}

		// Token: 0x060004B1 RID: 1201
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_ambientLight(out Color value);

		// Token: 0x060004B2 RID: 1202
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_ambientLight(ref Color value);

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060004B3 RID: 1203
		// (set) Token: 0x060004B4 RID: 1204
		public static extern float ambientIntensity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x000075E0 File Offset: 0x000057E0
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00007600 File Offset: 0x00005800
		public static SphericalHarmonicsL2 ambientProbe
		{
			get
			{
				SphericalHarmonicsL2 result;
				RenderSettings.INTERNAL_get_ambientProbe(out result);
				return result;
			}
			set
			{
				RenderSettings.INTERNAL_set_ambientProbe(ref value);
			}
		}

		// Token: 0x060004B7 RID: 1207
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_ambientProbe(out SphericalHarmonicsL2 value);

		// Token: 0x060004B8 RID: 1208
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_ambientProbe(ref SphericalHarmonicsL2 value);

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0000760C File Offset: 0x0000580C
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x0000762C File Offset: 0x0000582C
		public static Color subtractiveShadowColor
		{
			get
			{
				Color result;
				RenderSettings.INTERNAL_get_subtractiveShadowColor(out result);
				return result;
			}
			set
			{
				RenderSettings.INTERNAL_set_subtractiveShadowColor(ref value);
			}
		}

		// Token: 0x060004BB RID: 1211
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_subtractiveShadowColor(out Color value);

		// Token: 0x060004BC RID: 1212
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_subtractiveShadowColor(ref Color value);

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060004BD RID: 1213
		// (set) Token: 0x060004BE RID: 1214
		public static extern float reflectionIntensity { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004BF RID: 1215
		// (set) Token: 0x060004C0 RID: 1216
		public static extern int reflectionBounces { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060004C1 RID: 1217
		// (set) Token: 0x060004C2 RID: 1218
		public static extern float haloStrength { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004C3 RID: 1219
		// (set) Token: 0x060004C4 RID: 1220
		public static extern float flareStrength { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060004C5 RID: 1221
		// (set) Token: 0x060004C6 RID: 1222
		public static extern float flareFadeSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060004C7 RID: 1223
		// (set) Token: 0x060004C8 RID: 1224
		public static extern Material skybox { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060004C9 RID: 1225
		// (set) Token: 0x060004CA RID: 1226
		public static extern Light sun { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060004CB RID: 1227
		// (set) Token: 0x060004CC RID: 1228
		public static extern DefaultReflectionMode defaultReflectionMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004CD RID: 1229
		// (set) Token: 0x060004CE RID: 1230
		public static extern int defaultReflectionResolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004CF RID: 1231
		// (set) Token: 0x060004D0 RID: 1232
		public static extern Cubemap customReflection { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060004D1 RID: 1233
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Reset();

		// Token: 0x060004D2 RID: 1234
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Object GetRenderSettings();

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00007638 File Offset: 0x00005838
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00007654 File Offset: 0x00005854
		[Obsolete("Use RenderSettings.ambientIntensity instead (UnityUpgradable) -> ambientIntensity", false)]
		public static float ambientSkyboxAmount
		{
			get
			{
				return RenderSettings.ambientIntensity;
			}
			set
			{
				RenderSettings.ambientIntensity = value;
			}
		}
	}
}
