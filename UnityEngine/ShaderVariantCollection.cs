using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000AE RID: 174
	public sealed class ShaderVariantCollection : Object
	{
		// Token: 0x06000D83 RID: 3459 RVA: 0x00011CFC File Offset: 0x0000FEFC
		public ShaderVariantCollection()
		{
			ShaderVariantCollection.Internal_Create(this);
		}

		// Token: 0x06000D84 RID: 3460
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] ShaderVariantCollection mono);

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000D85 RID: 3461
		public extern int shaderCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000D86 RID: 3462
		public extern int variantCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000D87 RID: 3463 RVA: 0x00011D0C File Offset: 0x0000FF0C
		public bool Add(ShaderVariantCollection.ShaderVariant variant)
		{
			return this.AddInternal(variant.shader, variant.passType, variant.keywords);
		}

		// Token: 0x06000D88 RID: 3464
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddInternal(Shader shader, PassType passType, string[] keywords);

		// Token: 0x06000D89 RID: 3465 RVA: 0x00011D3C File Offset: 0x0000FF3C
		public bool Remove(ShaderVariantCollection.ShaderVariant variant)
		{
			return this.RemoveInternal(variant.shader, variant.passType, variant.keywords);
		}

		// Token: 0x06000D8A RID: 3466
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool RemoveInternal(Shader shader, PassType passType, string[] keywords);

		// Token: 0x06000D8B RID: 3467 RVA: 0x00011D6C File Offset: 0x0000FF6C
		public bool Contains(ShaderVariantCollection.ShaderVariant variant)
		{
			return this.ContainsInternal(variant.shader, variant.passType, variant.keywords);
		}

		// Token: 0x06000D8C RID: 3468
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool ContainsInternal(Shader shader, PassType passType, string[] keywords);

		// Token: 0x06000D8D RID: 3469
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear();

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000D8E RID: 3470
		public extern bool isWarmedUp { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000D8F RID: 3471
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void WarmUp();

		// Token: 0x020000AF RID: 175
		public struct ShaderVariant
		{
			// Token: 0x06000D90 RID: 3472 RVA: 0x00011D9C File Offset: 0x0000FF9C
			public ShaderVariant(Shader shader, PassType passType, params string[] keywords)
			{
				this.shader = shader;
				this.passType = passType;
				this.keywords = keywords;
				ShaderVariantCollection.ShaderVariant.Internal_CheckVariant(shader, passType, keywords);
			}

			// Token: 0x06000D91 RID: 3473
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			private static extern void Internal_CheckVariant(Shader shader, PassType passType, string[] keywords);

			// Token: 0x0400015E RID: 350
			public Shader shader;

			// Token: 0x0400015F RID: 351
			public PassType passType;

			// Token: 0x04000160 RID: 352
			public string[] keywords;
		}
	}
}
