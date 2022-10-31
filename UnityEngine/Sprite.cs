using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B9 RID: 185
	public sealed class Sprite : Object
	{
		// Token: 0x06000DB4 RID: 3508 RVA: 0x00012D9C File Offset: 0x00010F9C
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, [DefaultValue("100.0f")] float pixelsPerUnit, [DefaultValue("0")] uint extrude, [DefaultValue("SpriteMeshType.Tight")] SpriteMeshType meshType, [DefaultValue("Vector4.zero")] Vector4 border)
		{
			return Sprite.INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, meshType, ref border);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00012DC4 File Offset: 0x00010FC4
		[ExcludeFromDocs]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
		{
			Vector4 zero = Vector4.zero;
			return Sprite.INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, meshType, ref zero);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00012DF0 File Offset: 0x00010FF0
		[ExcludeFromDocs]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
		{
			Vector4 zero = Vector4.zero;
			SpriteMeshType meshType = SpriteMeshType.Tight;
			return Sprite.INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, meshType, ref zero);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00012E20 File Offset: 0x00011020
		[ExcludeFromDocs]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit)
		{
			Vector4 zero = Vector4.zero;
			SpriteMeshType meshType = SpriteMeshType.Tight;
			uint extrude = 0U;
			return Sprite.INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, meshType, ref zero);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00012E50 File Offset: 0x00011050
		[ExcludeFromDocs]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
		{
			Vector4 zero = Vector4.zero;
			SpriteMeshType meshType = SpriteMeshType.Tight;
			uint extrude = 0U;
			float pixelsPerUnit = 100f;
			return Sprite.INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, meshType, ref zero);
		}

		// Token: 0x06000DB9 RID: 3513
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Sprite INTERNAL_CALL_Create(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border);

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00012E88 File Offset: 0x00011088
		public Bounds bounds
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_bounds(out result);
				return result;
			}
		}

		// Token: 0x06000DBB RID: 3515
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x00012EA8 File Offset: 0x000110A8
		public Rect rect
		{
			get
			{
				Rect result;
				this.INTERNAL_get_rect(out result);
				return result;
			}
		}

		// Token: 0x06000DBD RID: 3517
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rect(out Rect value);

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000DBE RID: 3518
		public extern float pixelsPerUnit { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000DBF RID: 3519
		public extern Texture2D texture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000DC0 RID: 3520
		public extern Texture2D associatedAlphaSplitTexture { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00012EC8 File Offset: 0x000110C8
		public Rect textureRect
		{
			get
			{
				Rect result;
				this.INTERNAL_get_textureRect(out result);
				return result;
			}
		}

		// Token: 0x06000DC2 RID: 3522
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_textureRect(out Rect value);

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00012EE8 File Offset: 0x000110E8
		public Vector2 textureRectOffset
		{
			get
			{
				Vector2 result;
				Sprite.Internal_GetTextureRectOffset(this, out result);
				return result;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000DC4 RID: 3524
		public extern bool packed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000DC5 RID: 3525
		public extern SpritePackingMode packingMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000DC6 RID: 3526
		public extern SpritePackingRotation packingRotation { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000DC7 RID: 3527
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetTextureRectOffset(Sprite sprite, out Vector2 output);

		// Token: 0x06000DC8 RID: 3528
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetPivot(Sprite sprite, out Vector2 output);

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00012F08 File Offset: 0x00011108
		public Vector2 pivot
		{
			get
			{
				Vector2 result;
				Sprite.Internal_GetPivot(this, out result);
				return result;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00012F28 File Offset: 0x00011128
		public Vector4 border
		{
			get
			{
				Vector4 result;
				this.INTERNAL_get_border(out result);
				return result;
			}
		}

		// Token: 0x06000DCB RID: 3531
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_border(out Vector4 value);

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000DCC RID: 3532
		public extern Vector2[] vertices { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000DCD RID: 3533
		public extern ushort[] triangles { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000DCE RID: 3534
		public extern Vector2[] uv { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000DCF RID: 3535
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void OverrideGeometry(Vector2[] vertices, ushort[] triangles);
	}
}
