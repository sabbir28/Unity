using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001D3 RID: 467
	[RequireComponent(typeof(Transform))]
	public sealed class AudioReverbZone : Behaviour
	{
		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x0600209C RID: 8348
		// (set) Token: 0x0600209D RID: 8349
		public extern float minDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x0600209E RID: 8350
		// (set) Token: 0x0600209F RID: 8351
		public extern float maxDistance { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060020A0 RID: 8352
		// (set) Token: 0x060020A1 RID: 8353
		public extern AudioReverbPreset reverbPreset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060020A2 RID: 8354
		// (set) Token: 0x060020A3 RID: 8355
		public extern int room { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060020A4 RID: 8356
		// (set) Token: 0x060020A5 RID: 8357
		public extern int roomHF { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060020A6 RID: 8358
		// (set) Token: 0x060020A7 RID: 8359
		public extern int roomLF { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060020A8 RID: 8360
		// (set) Token: 0x060020A9 RID: 8361
		public extern float decayTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060020AA RID: 8362
		// (set) Token: 0x060020AB RID: 8363
		public extern float decayHFRatio { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060020AC RID: 8364
		// (set) Token: 0x060020AD RID: 8365
		public extern int reflections { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060020AE RID: 8366
		// (set) Token: 0x060020AF RID: 8367
		public extern float reflectionsDelay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060020B0 RID: 8368
		// (set) Token: 0x060020B1 RID: 8369
		public extern int reverb { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060020B2 RID: 8370
		// (set) Token: 0x060020B3 RID: 8371
		public extern float reverbDelay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060020B4 RID: 8372
		// (set) Token: 0x060020B5 RID: 8373
		public extern float HFReference { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060020B6 RID: 8374
		// (set) Token: 0x060020B7 RID: 8375
		public extern float LFReference { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x00026A9C File Offset: 0x00024C9C
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x00026AB8 File Offset: 0x00024CB8
		[Obsolete("roomRolloffFactor is no longer supported.")]
		public float roomRolloffFactor
		{
			get
			{
				return 10f;
			}
			set
			{
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060020BA RID: 8378
		// (set) Token: 0x060020BB RID: 8379
		public extern float diffusion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060020BC RID: 8380
		// (set) Token: 0x060020BD RID: 8381
		public extern float density { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
