using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine
{
	// Token: 0x02000214 RID: 532
	[MovedFrom("UnityEditor.Animations")]
	public sealed class AvatarMask : Object
	{
		// Token: 0x0600237B RID: 9083 RVA: 0x00028C5C File Offset: 0x00026E5C
		public AvatarMask()
		{
			AvatarMask.Internal_Create(this);
		}

		// Token: 0x0600237C RID: 9084
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] AvatarMask mono);

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x00028C6C File Offset: 0x00026E6C
		[Obsolete("AvatarMask.humanoidBodyPartCount is deprecated. Use AvatarMaskBodyPart.LastBodyPart instead.")]
		private int humanoidBodyPartCount
		{
			get
			{
				return 13;
			}
		}

		// Token: 0x0600237E RID: 9086
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index);

		// Token: 0x0600237F RID: 9087
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetHumanoidBodyPartActive(AvatarMaskBodyPart index, bool value);

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06002380 RID: 9088
		// (set) Token: 0x06002381 RID: 9089
		public extern int transformCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002382 RID: 9090 RVA: 0x00028C84 File Offset: 0x00026E84
		[ExcludeFromDocs]
		public void AddTransformPath(Transform transform)
		{
			bool recursive = true;
			this.AddTransformPath(transform, recursive);
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00028C9C File Offset: 0x00026E9C
		public void AddTransformPath(Transform transform, [DefaultValue("true")] bool recursive)
		{
			if (transform == null)
			{
				throw new ArgumentNullException("transform");
			}
			this.Internal_AddTransformPath(transform, recursive);
		}

		// Token: 0x06002384 RID: 9092
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_AddTransformPath(Transform transform, bool recursive);

		// Token: 0x06002385 RID: 9093 RVA: 0x00028CC0 File Offset: 0x00026EC0
		[ExcludeFromDocs]
		public void RemoveTransformPath(Transform transform)
		{
			bool recursive = true;
			this.RemoveTransformPath(transform, recursive);
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x00028CD8 File Offset: 0x00026ED8
		public void RemoveTransformPath(Transform transform, [DefaultValue("true")] bool recursive)
		{
			if (transform == null)
			{
				throw new ArgumentNullException("transform");
			}
			this.Internal_RemoveTransformPath(transform, recursive);
		}

		// Token: 0x06002387 RID: 9095
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_RemoveTransformPath(Transform transform, bool recursive);

		// Token: 0x06002388 RID: 9096
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetTransformPath(int index);

		// Token: 0x06002389 RID: 9097
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTransformPath(int index, string path);

		// Token: 0x0600238A RID: 9098
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetTransformActive(int index);

		// Token: 0x0600238B RID: 9099
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTransformActive(int index, bool value);

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x0600238C RID: 9100
		internal extern bool hasFeetIK { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600238D RID: 9101 RVA: 0x00028CFC File Offset: 0x00026EFC
		internal void Copy(AvatarMask other)
		{
			for (AvatarMaskBodyPart avatarMaskBodyPart = AvatarMaskBodyPart.Root; avatarMaskBodyPart < AvatarMaskBodyPart.LastBodyPart; avatarMaskBodyPart++)
			{
				this.SetHumanoidBodyPartActive(avatarMaskBodyPart, other.GetHumanoidBodyPartActive(avatarMaskBodyPart));
			}
			this.transformCount = other.transformCount;
			for (int i = 0; i < other.transformCount; i++)
			{
				this.SetTransformPath(i, other.GetTransformPath(i));
				this.SetTransformActive(i, other.GetTransformActive(i));
			}
		}
	}
}
