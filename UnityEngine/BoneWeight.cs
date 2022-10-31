using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020003A6 RID: 934
	[UsedByNativeCode]
	public struct BoneWeight
	{
		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x0004C7B4 File Offset: 0x0004A9B4
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x0004C7D0 File Offset: 0x0004A9D0
		public float weight0
		{
			get
			{
				return this.m_Weight0;
			}
			set
			{
				this.m_Weight0 = value;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x0004C7DC File Offset: 0x0004A9DC
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x0004C7F8 File Offset: 0x0004A9F8
		public float weight1
		{
			get
			{
				return this.m_Weight1;
			}
			set
			{
				this.m_Weight1 = value;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x0004C804 File Offset: 0x0004AA04
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x0004C820 File Offset: 0x0004AA20
		public float weight2
		{
			get
			{
				return this.m_Weight2;
			}
			set
			{
				this.m_Weight2 = value;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x0004C82C File Offset: 0x0004AA2C
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x0004C848 File Offset: 0x0004AA48
		public float weight3
		{
			get
			{
				return this.m_Weight3;
			}
			set
			{
				this.m_Weight3 = value;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x0004C854 File Offset: 0x0004AA54
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x0004C870 File Offset: 0x0004AA70
		public int boneIndex0
		{
			get
			{
				return this.m_BoneIndex0;
			}
			set
			{
				this.m_BoneIndex0 = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x0004C87C File Offset: 0x0004AA7C
		// (set) Token: 0x060031D7 RID: 12759 RVA: 0x0004C898 File Offset: 0x0004AA98
		public int boneIndex1
		{
			get
			{
				return this.m_BoneIndex1;
			}
			set
			{
				this.m_BoneIndex1 = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x0004C8A4 File Offset: 0x0004AAA4
		// (set) Token: 0x060031D9 RID: 12761 RVA: 0x0004C8C0 File Offset: 0x0004AAC0
		public int boneIndex2
		{
			get
			{
				return this.m_BoneIndex2;
			}
			set
			{
				this.m_BoneIndex2 = value;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060031DA RID: 12762 RVA: 0x0004C8CC File Offset: 0x0004AACC
		// (set) Token: 0x060031DB RID: 12763 RVA: 0x0004C8E8 File Offset: 0x0004AAE8
		public int boneIndex3
		{
			get
			{
				return this.m_BoneIndex3;
			}
			set
			{
				this.m_BoneIndex3 = value;
			}
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x0004C8F4 File Offset: 0x0004AAF4
		public override int GetHashCode()
		{
			return this.boneIndex0.GetHashCode() ^ this.boneIndex1.GetHashCode() << 2 ^ this.boneIndex2.GetHashCode() >> 2 ^ this.boneIndex3.GetHashCode() >> 1 ^ this.weight0.GetHashCode() << 5 ^ this.weight1.GetHashCode() << 4 ^ this.weight2.GetHashCode() >> 4 ^ this.weight3.GetHashCode() >> 3;
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x0004C9C4 File Offset: 0x0004ABC4
		public override bool Equals(object other)
		{
			bool result;
			if (!(other is BoneWeight))
			{
				result = false;
			}
			else
			{
				BoneWeight boneWeight = (BoneWeight)other;
				bool flag;
				if (this.boneIndex0.Equals(boneWeight.boneIndex0) && this.boneIndex1.Equals(boneWeight.boneIndex1) && this.boneIndex2.Equals(boneWeight.boneIndex2) && this.boneIndex3.Equals(boneWeight.boneIndex3))
				{
					Vector4 vector = new Vector4(this.weight0, this.weight1, this.weight2, this.weight3);
					flag = vector.Equals(new Vector4(boneWeight.weight0, boneWeight.weight1, boneWeight.weight2, boneWeight.weight3));
				}
				else
				{
					flag = false;
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x0004CAB4 File Offset: 0x0004ACB4
		public static bool operator ==(BoneWeight lhs, BoneWeight rhs)
		{
			return lhs.boneIndex0 == rhs.boneIndex0 && lhs.boneIndex1 == rhs.boneIndex1 && lhs.boneIndex2 == rhs.boneIndex2 && lhs.boneIndex3 == rhs.boneIndex3 && new Vector4(lhs.weight0, lhs.weight1, lhs.weight2, lhs.weight3) == new Vector4(rhs.weight0, rhs.weight1, rhs.weight2, rhs.weight3);
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x0004CB60 File Offset: 0x0004AD60
		public static bool operator !=(BoneWeight lhs, BoneWeight rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000E57 RID: 3671
		private float m_Weight0;

		// Token: 0x04000E58 RID: 3672
		private float m_Weight1;

		// Token: 0x04000E59 RID: 3673
		private float m_Weight2;

		// Token: 0x04000E5A RID: 3674
		private float m_Weight3;

		// Token: 0x04000E5B RID: 3675
		private int m_BoneIndex0;

		// Token: 0x04000E5C RID: 3676
		private int m_BoneIndex1;

		// Token: 0x04000E5D RID: 3677
		private int m_BoneIndex2;

		// Token: 0x04000E5E RID: 3678
		private int m_BoneIndex3;
	}
}
