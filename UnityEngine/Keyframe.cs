using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000082 RID: 130
	[RequiredByNativeCode]
	public struct Keyframe
	{
		// Token: 0x060009A9 RID: 2473 RVA: 0x0000E31C File Offset: 0x0000C51C
		public Keyframe(float time, float value)
		{
			this.m_Time = time;
			this.m_Value = value;
			this.m_InTangent = 0f;
			this.m_OutTangent = 0f;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0000E344 File Offset: 0x0000C544
		public Keyframe(float time, float value, float inTangent, float outTangent)
		{
			this.m_Time = time;
			this.m_Value = value;
			this.m_InTangent = inTangent;
			this.m_OutTangent = outTangent;
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0000E364 File Offset: 0x0000C564
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x0000E380 File Offset: 0x0000C580
		public float time
		{
			get
			{
				return this.m_Time;
			}
			set
			{
				this.m_Time = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0000E38C File Offset: 0x0000C58C
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		public float value
		{
			get
			{
				return this.m_Value;
			}
			set
			{
				this.m_Value = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		public float inTangent
		{
			get
			{
				return this.m_InTangent;
			}
			set
			{
				this.m_InTangent = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0000E3DC File Offset: 0x0000C5DC
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x0000E3F8 File Offset: 0x0000C5F8
		public float outTangent
		{
			get
			{
				return this.m_OutTangent;
			}
			set
			{
				this.m_OutTangent = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0000E404 File Offset: 0x0000C604
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x0000E41C File Offset: 0x0000C61C
		public int tangentMode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x040000F0 RID: 240
		private float m_Time;

		// Token: 0x040000F1 RID: 241
		private float m_Value;

		// Token: 0x040000F2 RID: 242
		private float m_InTangent;

		// Token: 0x040000F3 RID: 243
		private float m_OutTangent;
	}
}
