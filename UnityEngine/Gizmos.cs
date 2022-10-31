using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200003B RID: 59
	public sealed class Gizmos
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x00007098 File Offset: 0x00005298
		public static void DrawRay(Ray r)
		{
			Gizmos.DrawLine(r.origin, r.origin + r.direction);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000070BC File Offset: 0x000052BC
		public static void DrawRay(Vector3 from, Vector3 direction)
		{
			Gizmos.DrawLine(from, from + direction);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000070CC File Offset: 0x000052CC
		public static void DrawLine(Vector3 from, Vector3 to)
		{
			Gizmos.INTERNAL_CALL_DrawLine(ref from, ref to);
		}

		// Token: 0x0600044A RID: 1098
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawLine(ref Vector3 from, ref Vector3 to);

		// Token: 0x0600044B RID: 1099 RVA: 0x000070D8 File Offset: 0x000052D8
		public static void DrawWireSphere(Vector3 center, float radius)
		{
			Gizmos.INTERNAL_CALL_DrawWireSphere(ref center, radius);
		}

		// Token: 0x0600044C RID: 1100
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawWireSphere(ref Vector3 center, float radius);

		// Token: 0x0600044D RID: 1101 RVA: 0x000070E4 File Offset: 0x000052E4
		public static void DrawSphere(Vector3 center, float radius)
		{
			Gizmos.INTERNAL_CALL_DrawSphere(ref center, radius);
		}

		// Token: 0x0600044E RID: 1102
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawSphere(ref Vector3 center, float radius);

		// Token: 0x0600044F RID: 1103 RVA: 0x000070F0 File Offset: 0x000052F0
		public static void DrawWireCube(Vector3 center, Vector3 size)
		{
			Gizmos.INTERNAL_CALL_DrawWireCube(ref center, ref size);
		}

		// Token: 0x06000450 RID: 1104
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawWireCube(ref Vector3 center, ref Vector3 size);

		// Token: 0x06000451 RID: 1105 RVA: 0x000070FC File Offset: 0x000052FC
		public static void DrawCube(Vector3 center, Vector3 size)
		{
			Gizmos.INTERNAL_CALL_DrawCube(ref center, ref size);
		}

		// Token: 0x06000452 RID: 1106
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawCube(ref Vector3 center, ref Vector3 size);

		// Token: 0x06000453 RID: 1107 RVA: 0x00007108 File Offset: 0x00005308
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawMesh(mesh, position, rotation, one);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00007128 File Offset: 0x00005328
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawMesh(mesh, position, identity, one);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000714C File Offset: 0x0000534C
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawMesh(mesh, zero, identity, one);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00007178 File Offset: 0x00005378
		public static void DrawMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
			Gizmos.DrawMesh(mesh, -1, position, rotation, scale);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00007188 File Offset: 0x00005388
		public static void DrawMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
			Gizmos.INTERNAL_CALL_DrawMesh(mesh, submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00007198 File Offset: 0x00005398
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.INTERNAL_CALL_DrawMesh(mesh, submeshIndex, ref position, ref rotation, ref one);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000071BC File Offset: 0x000053BC
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.INTERNAL_CALL_DrawMesh(mesh, submeshIndex, ref position, ref identity, ref one);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000071E4 File Offset: 0x000053E4
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.INTERNAL_CALL_DrawMesh(mesh, submeshIndex, ref zero, ref identity, ref one);
		}

		// Token: 0x0600045B RID: 1115
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawMesh(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale);

		// Token: 0x0600045C RID: 1116 RVA: 0x00007214 File Offset: 0x00005414
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.DrawWireMesh(mesh, position, rotation, one);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00007234 File Offset: 0x00005434
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.DrawWireMesh(mesh, position, identity, one);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00007258 File Offset: 0x00005458
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.DrawWireMesh(mesh, zero, identity, one);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00007284 File Offset: 0x00005484
		public static void DrawWireMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
			Gizmos.DrawWireMesh(mesh, -1, position, rotation, scale);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00007294 File Offset: 0x00005494
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
			Gizmos.INTERNAL_CALL_DrawWireMesh(mesh, submeshIndex, ref position, ref rotation, ref scale);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000072A4 File Offset: 0x000054A4
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
			Vector3 one = Vector3.one;
			Gizmos.INTERNAL_CALL_DrawWireMesh(mesh, submeshIndex, ref position, ref rotation, ref one);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000072C8 File Offset: 0x000054C8
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Gizmos.INTERNAL_CALL_DrawWireMesh(mesh, submeshIndex, ref position, ref identity, ref one);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000072F0 File Offset: 0x000054F0
		[ExcludeFromDocs]
		public static void DrawWireMesh(Mesh mesh, int submeshIndex)
		{
			Vector3 one = Vector3.one;
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			Gizmos.INTERNAL_CALL_DrawWireMesh(mesh, submeshIndex, ref zero, ref identity, ref one);
		}

		// Token: 0x06000464 RID: 1124
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawWireMesh(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale);

		// Token: 0x06000465 RID: 1125 RVA: 0x00007320 File Offset: 0x00005520
		public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling)
		{
			Gizmos.INTERNAL_CALL_DrawIcon(ref center, name, allowScaling);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000732C File Offset: 0x0000552C
		[ExcludeFromDocs]
		public static void DrawIcon(Vector3 center, string name)
		{
			bool allowScaling = true;
			Gizmos.INTERNAL_CALL_DrawIcon(ref center, name, allowScaling);
		}

		// Token: 0x06000467 RID: 1127
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawIcon(ref Vector3 center, string name, bool allowScaling);

		// Token: 0x06000468 RID: 1128 RVA: 0x00007348 File Offset: 0x00005548
		[ExcludeFromDocs]
		public static void DrawGUITexture(Rect screenRect, Texture texture)
		{
			Material mat = null;
			Gizmos.DrawGUITexture(screenRect, texture, mat);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00007360 File Offset: 0x00005560
		public static void DrawGUITexture(Rect screenRect, Texture texture, [DefaultValue("null")] Material mat)
		{
			Gizmos.DrawGUITexture(screenRect, texture, 0, 0, 0, 0, mat);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00007370 File Offset: 0x00005570
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue("null")] Material mat)
		{
			Gizmos.INTERNAL_CALL_DrawGUITexture(ref screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00007384 File Offset: 0x00005584
		[ExcludeFromDocs]
		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{
			Material mat = null;
			Gizmos.INTERNAL_CALL_DrawGUITexture(ref screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, mat);
		}

		// Token: 0x0600046C RID: 1132
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawGUITexture(ref Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat);

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x000073A4 File Offset: 0x000055A4
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x000073C4 File Offset: 0x000055C4
		public static Color color
		{
			get
			{
				Color result;
				Gizmos.INTERNAL_get_color(out result);
				return result;
			}
			set
			{
				Gizmos.INTERNAL_set_color(ref value);
			}
		}

		// Token: 0x0600046F RID: 1135
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_color(out Color value);

		// Token: 0x06000470 RID: 1136
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_color(ref Color value);

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x000073D0 File Offset: 0x000055D0
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x000073F0 File Offset: 0x000055F0
		public static Matrix4x4 matrix
		{
			get
			{
				Matrix4x4 result;
				Gizmos.INTERNAL_get_matrix(out result);
				return result;
			}
			set
			{
				Gizmos.INTERNAL_set_matrix(ref value);
			}
		}

		// Token: 0x06000473 RID: 1139
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_matrix(out Matrix4x4 value);

		// Token: 0x06000474 RID: 1140
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_matrix(ref Matrix4x4 value);

		// Token: 0x06000475 RID: 1141 RVA: 0x000073FC File Offset: 0x000055FC
		public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
			Gizmos.INTERNAL_CALL_DrawFrustum(ref center, fov, maxRange, minRange, aspect);
		}

		// Token: 0x06000476 RID: 1142
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DrawFrustum(ref Vector3 center, float fov, float maxRange, float minRange, float aspect);
	}
}
