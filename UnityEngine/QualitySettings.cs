using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000043 RID: 67
	public sealed class QualitySettings : Object
	{
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004D6 RID: 1238
		public static extern string[] names { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060004D7 RID: 1239
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetQualityLevel();

		// Token: 0x060004D8 RID: 1240
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetQualityLevel(int index, [DefaultValue("true")] bool applyExpensiveChanges);

		// Token: 0x060004D9 RID: 1241 RVA: 0x00007668 File Offset: 0x00005868
		[ExcludeFromDocs]
		public static void SetQualityLevel(int index)
		{
			bool applyExpensiveChanges = true;
			QualitySettings.SetQualityLevel(index, applyExpensiveChanges);
		}

		// Token: 0x060004DA RID: 1242
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void IncreaseLevel([DefaultValue("false")] bool applyExpensiveChanges);

		// Token: 0x060004DB RID: 1243 RVA: 0x00007680 File Offset: 0x00005880
		[ExcludeFromDocs]
		public static void IncreaseLevel()
		{
			bool applyExpensiveChanges = false;
			QualitySettings.IncreaseLevel(applyExpensiveChanges);
		}

		// Token: 0x060004DC RID: 1244
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DecreaseLevel([DefaultValue("false")] bool applyExpensiveChanges);

		// Token: 0x060004DD RID: 1245 RVA: 0x00007698 File Offset: 0x00005898
		[ExcludeFromDocs]
		public static void DecreaseLevel()
		{
			bool applyExpensiveChanges = false;
			QualitySettings.DecreaseLevel(applyExpensiveChanges);
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004DE RID: 1246
		// (set) Token: 0x060004DF RID: 1247
		public static extern int pixelLightCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004E0 RID: 1248
		// (set) Token: 0x060004E1 RID: 1249
		public static extern ShadowQuality shadows { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004E2 RID: 1250
		// (set) Token: 0x060004E3 RID: 1251
		public static extern ShadowProjection shadowProjection { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004E4 RID: 1252
		// (set) Token: 0x060004E5 RID: 1253
		public static extern int shadowCascades { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004E6 RID: 1254
		// (set) Token: 0x060004E7 RID: 1255
		public static extern float shadowDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004E8 RID: 1256
		// (set) Token: 0x060004E9 RID: 1257
		public static extern ShadowResolution shadowResolution { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004EA RID: 1258
		// (set) Token: 0x060004EB RID: 1259
		public static extern float shadowNearPlaneOffset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004EC RID: 1260
		// (set) Token: 0x060004ED RID: 1261
		public static extern float shadowCascade2Split { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x000076B0 File Offset: 0x000058B0
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x000076D0 File Offset: 0x000058D0
		public static Vector3 shadowCascade4Split
		{
			get
			{
				Vector3 result;
				QualitySettings.INTERNAL_get_shadowCascade4Split(out result);
				return result;
			}
			set
			{
				QualitySettings.INTERNAL_set_shadowCascade4Split(ref value);
			}
		}

		// Token: 0x060004F0 RID: 1264
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_shadowCascade4Split(out Vector3 value);

		// Token: 0x060004F1 RID: 1265
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_shadowCascade4Split(ref Vector3 value);

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004F2 RID: 1266
		// (set) Token: 0x060004F3 RID: 1267
		public static extern int masterTextureLimit { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004F4 RID: 1268
		// (set) Token: 0x060004F5 RID: 1269
		public static extern AnisotropicFiltering anisotropicFiltering { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004F6 RID: 1270
		// (set) Token: 0x060004F7 RID: 1271
		public static extern float lodBias { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004F8 RID: 1272
		// (set) Token: 0x060004F9 RID: 1273
		public static extern int maximumLODLevel { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004FA RID: 1274
		// (set) Token: 0x060004FB RID: 1275
		public static extern int particleRaycastBudget { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004FC RID: 1276
		// (set) Token: 0x060004FD RID: 1277
		public static extern bool softParticles { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004FE RID: 1278
		// (set) Token: 0x060004FF RID: 1279
		public static extern bool softVegetation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000500 RID: 1280
		// (set) Token: 0x06000501 RID: 1281
		public static extern bool realtimeReflectionProbes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000502 RID: 1282
		// (set) Token: 0x06000503 RID: 1283
		public static extern bool billboardsFaceCameraPosition { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000504 RID: 1284
		// (set) Token: 0x06000505 RID: 1285
		public static extern int maxQueuedFrames { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000506 RID: 1286
		// (set) Token: 0x06000507 RID: 1287
		public static extern int vSyncCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000508 RID: 1288
		// (set) Token: 0x06000509 RID: 1289
		public static extern int antiAliasing { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600050A RID: 1290
		public static extern ColorSpace desiredColorSpace { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600050B RID: 1291
		public static extern ColorSpace activeColorSpace { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600050C RID: 1292
		// (set) Token: 0x0600050D RID: 1293
		public static extern BlendWeights blendWeights { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600050E RID: 1294
		// (set) Token: 0x0600050F RID: 1295
		public static extern int asyncUploadTimeSlice { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000510 RID: 1296
		// (set) Token: 0x06000511 RID: 1297
		public static extern int asyncUploadBufferSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000076DC File Offset: 0x000058DC
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x000076F8 File Offset: 0x000058F8
		[Obsolete("Use GetQualityLevel and SetQualityLevel", false)]
		public static QualityLevel currentLevel
		{
			get
			{
				return (QualityLevel)QualitySettings.GetQualityLevel();
			}
			set
			{
				QualitySettings.SetQualityLevel((int)value, true);
			}
		}
	}
}
