using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000048 RID: 72
	public sealed class LensFlare : Behaviour
	{
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000530 RID: 1328
		// (set) Token: 0x06000531 RID: 1329
		public extern Flare flare { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000532 RID: 1330
		// (set) Token: 0x06000533 RID: 1331
		public extern float brightness { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000534 RID: 1332
		// (set) Token: 0x06000535 RID: 1333
		public extern float fadeSpeed { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00007758 File Offset: 0x00005958
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00007778 File Offset: 0x00005978
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

		// Token: 0x06000538 RID: 1336
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_color(out Color value);

		// Token: 0x06000539 RID: 1337
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_color(ref Color value);
	}
}
