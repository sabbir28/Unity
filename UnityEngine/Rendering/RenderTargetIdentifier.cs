using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000376 RID: 886
	public struct RenderTargetIdentifier
	{
		// Token: 0x0600310D RID: 12557 RVA: 0x0004AA18 File Offset: 0x00048C18
		public RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			this.m_Type = type;
			this.m_NameID = -1;
			this.m_InstanceID = 0;
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x0004AA30 File Offset: 0x00048C30
		public RenderTargetIdentifier(string name)
		{
			this.m_Type = BuiltinRenderTextureType.None;
			this.m_NameID = Shader.PropertyToID(name);
			this.m_InstanceID = 0;
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x0004AA50 File Offset: 0x00048C50
		public RenderTargetIdentifier(int nameID)
		{
			this.m_Type = BuiltinRenderTextureType.None;
			this.m_NameID = nameID;
			this.m_InstanceID = 0;
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x0004AA68 File Offset: 0x00048C68
		public RenderTargetIdentifier(Texture tex)
		{
			this.m_Type = ((!(tex == null) && !(tex is RenderTexture)) ? BuiltinRenderTextureType.BindableTexture : BuiltinRenderTextureType.None);
			this.m_NameID = -1;
			this.m_InstanceID = ((!tex) ? 0 : tex.GetInstanceID());
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x0004AAC0 File Offset: 0x00048CC0
		public static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			return new RenderTargetIdentifier(type);
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x0004AADC File Offset: 0x00048CDC
		public static implicit operator RenderTargetIdentifier(string name)
		{
			return new RenderTargetIdentifier(name);
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x0004AAF8 File Offset: 0x00048CF8
		public static implicit operator RenderTargetIdentifier(int nameID)
		{
			return new RenderTargetIdentifier(nameID);
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x0004AB14 File Offset: 0x00048D14
		public static implicit operator RenderTargetIdentifier(Texture tex)
		{
			return new RenderTargetIdentifier(tex);
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x0004AB30 File Offset: 0x00048D30
		public override string ToString()
		{
			return UnityString.Format("Type {0} NameID {1} InstanceID {2}", new object[]
			{
				this.m_Type,
				this.m_NameID,
				this.m_InstanceID
			});
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x0004AB80 File Offset: 0x00048D80
		public override int GetHashCode()
		{
			return (this.m_Type.GetHashCode() * 23 + this.m_NameID.GetHashCode()) * 23 + this.m_InstanceID.GetHashCode();
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x0004ABD0 File Offset: 0x00048DD0
		public override bool Equals(object obj)
		{
			bool result;
			if (!(obj is RenderTargetIdentifier))
			{
				result = false;
			}
			else
			{
				RenderTargetIdentifier renderTargetIdentifier = (RenderTargetIdentifier)obj;
				result = (this.m_Type == renderTargetIdentifier.m_Type && this.m_NameID == renderTargetIdentifier.m_NameID && this.m_InstanceID == renderTargetIdentifier.m_InstanceID);
			}
			return result;
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0004AC34 File Offset: 0x00048E34
		public bool Equals(RenderTargetIdentifier rhs)
		{
			return this.m_Type == rhs.m_Type && this.m_NameID == rhs.m_NameID && this.m_InstanceID == rhs.m_InstanceID;
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x0004AC80 File Offset: 0x00048E80
		public static bool operator ==(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			return lhs.m_Type == rhs.m_Type && lhs.m_NameID == rhs.m_NameID && lhs.m_InstanceID == rhs.m_InstanceID;
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x0004ACD0 File Offset: 0x00048ED0
		public static bool operator !=(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			return lhs.m_Type != rhs.m_Type || lhs.m_NameID != rhs.m_NameID || lhs.m_InstanceID != rhs.m_InstanceID;
		}

		// Token: 0x04000C85 RID: 3205
		private BuiltinRenderTextureType m_Type;

		// Token: 0x04000C86 RID: 3206
		private int m_NameID;

		// Token: 0x04000C87 RID: 3207
		private int m_InstanceID;
	}
}
