using System;

namespace UnityEngine
{
	// Token: 0x0200011C RID: 284
	[Flags]
	[Obsolete("ParticleSystemVertexStreams is deprecated. Please use ParticleSystemVertexStream instead.")]
	public enum ParticleSystemVertexStreams
	{
		// Token: 0x040002DE RID: 734
		Position = 1,
		// Token: 0x040002DF RID: 735
		Normal = 2,
		// Token: 0x040002E0 RID: 736
		Tangent = 4,
		// Token: 0x040002E1 RID: 737
		Color = 8,
		// Token: 0x040002E2 RID: 738
		UV = 16,
		// Token: 0x040002E3 RID: 739
		UV2BlendAndFrame = 32,
		// Token: 0x040002E4 RID: 740
		CenterAndVertexID = 64,
		// Token: 0x040002E5 RID: 741
		Size = 128,
		// Token: 0x040002E6 RID: 742
		Rotation = 256,
		// Token: 0x040002E7 RID: 743
		Velocity = 512,
		// Token: 0x040002E8 RID: 744
		Lifetime = 1024,
		// Token: 0x040002E9 RID: 745
		Custom1 = 2048,
		// Token: 0x040002EA RID: 746
		Custom2 = 4096,
		// Token: 0x040002EB RID: 747
		Random = 8192,
		// Token: 0x040002EC RID: 748
		None = 0,
		// Token: 0x040002ED RID: 749
		All = 2147483647
	}
}
