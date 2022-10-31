using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001D9 RID: 473
	[RequireComponent(typeof(AudioBehaviour))]
	public sealed class AudioReverbFilter : Behaviour
	{
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060020E8 RID: 8424
		// (set) Token: 0x060020E9 RID: 8425
		public extern AudioReverbPreset reverbPreset { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060020EA RID: 8426
		// (set) Token: 0x060020EB RID: 8427
		public extern float dryLevel { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060020EC RID: 8428
		// (set) Token: 0x060020ED RID: 8429
		public extern float room { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060020EE RID: 8430
		// (set) Token: 0x060020EF RID: 8431
		public extern float roomHF { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x00026AEC File Offset: 0x00024CEC
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x00026B08 File Offset: 0x00024D08
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

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060020F2 RID: 8434
		// (set) Token: 0x060020F3 RID: 8435
		public extern float decayTime { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060020F4 RID: 8436
		// (set) Token: 0x060020F5 RID: 8437
		public extern float decayHFRatio { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060020F6 RID: 8438
		// (set) Token: 0x060020F7 RID: 8439
		public extern float reflectionsLevel { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060020F8 RID: 8440
		// (set) Token: 0x060020F9 RID: 8441
		public extern float reflectionsDelay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060020FA RID: 8442
		// (set) Token: 0x060020FB RID: 8443
		public extern float reverbLevel { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060020FC RID: 8444
		// (set) Token: 0x060020FD RID: 8445
		public extern float reverbDelay { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060020FE RID: 8446
		// (set) Token: 0x060020FF RID: 8447
		public extern float diffusion { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06002100 RID: 8448
		// (set) Token: 0x06002101 RID: 8449
		public extern float density { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06002102 RID: 8450
		// (set) Token: 0x06002103 RID: 8451
		public extern float hfReference { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06002104 RID: 8452
		// (set) Token: 0x06002105 RID: 8453
		public extern float roomLF { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06002106 RID: 8454
		// (set) Token: 0x06002107 RID: 8455
		public extern float lfReference { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
