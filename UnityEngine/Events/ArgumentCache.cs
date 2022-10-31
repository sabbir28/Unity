using System;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x020003DE RID: 990
	[Serializable]
	internal class ArgumentCache : ISerializationCallbackReceiver
	{
		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x060032F1 RID: 13041 RVA: 0x0004F2BC File Offset: 0x0004D4BC
		// (set) Token: 0x060032F2 RID: 13042 RVA: 0x0004F2D8 File Offset: 0x0004D4D8
		public Object unityObjectArgument
		{
			get
			{
				return this.m_ObjectArgument;
			}
			set
			{
				this.m_ObjectArgument = value;
				this.m_ObjectArgumentAssemblyTypeName = ((!(value != null)) ? string.Empty : value.GetType().AssemblyQualifiedName);
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x060032F3 RID: 13043 RVA: 0x0004F30C File Offset: 0x0004D50C
		public string unityObjectArgumentAssemblyTypeName
		{
			get
			{
				return this.m_ObjectArgumentAssemblyTypeName;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x0004F328 File Offset: 0x0004D528
		// (set) Token: 0x060032F5 RID: 13045 RVA: 0x0004F344 File Offset: 0x0004D544
		public int intArgument
		{
			get
			{
				return this.m_IntArgument;
			}
			set
			{
				this.m_IntArgument = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x0004F350 File Offset: 0x0004D550
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x0004F36C File Offset: 0x0004D56C
		public float floatArgument
		{
			get
			{
				return this.m_FloatArgument;
			}
			set
			{
				this.m_FloatArgument = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060032F8 RID: 13048 RVA: 0x0004F378 File Offset: 0x0004D578
		// (set) Token: 0x060032F9 RID: 13049 RVA: 0x0004F394 File Offset: 0x0004D594
		public string stringArgument
		{
			get
			{
				return this.m_StringArgument;
			}
			set
			{
				this.m_StringArgument = value;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x060032FA RID: 13050 RVA: 0x0004F3A0 File Offset: 0x0004D5A0
		// (set) Token: 0x060032FB RID: 13051 RVA: 0x0004F3BC File Offset: 0x0004D5BC
		public bool boolArgument
		{
			get
			{
				return this.m_BoolArgument;
			}
			set
			{
				this.m_BoolArgument = value;
			}
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x0004F3C8 File Offset: 0x0004D5C8
		private void TidyAssemblyTypeName()
		{
			if (!string.IsNullOrEmpty(this.m_ObjectArgumentAssemblyTypeName))
			{
				int num = int.MaxValue;
				int num2 = this.m_ObjectArgumentAssemblyTypeName.IndexOf(", Version=");
				if (num2 != -1)
				{
					num = Math.Min(num2, num);
				}
				num2 = this.m_ObjectArgumentAssemblyTypeName.IndexOf(", Culture=");
				if (num2 != -1)
				{
					num = Math.Min(num2, num);
				}
				num2 = this.m_ObjectArgumentAssemblyTypeName.IndexOf(", PublicKeyToken=");
				if (num2 != -1)
				{
					num = Math.Min(num2, num);
				}
				if (num != 2147483647)
				{
					this.m_ObjectArgumentAssemblyTypeName = this.m_ObjectArgumentAssemblyTypeName.Substring(0, num);
				}
			}
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x0004F474 File Offset: 0x0004D674
		public void OnBeforeSerialize()
		{
			this.TidyAssemblyTypeName();
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x0004F480 File Offset: 0x0004D680
		public void OnAfterDeserialize()
		{
			this.TidyAssemblyTypeName();
		}

		// Token: 0x04000EC0 RID: 3776
		[FormerlySerializedAs("objectArgument")]
		[SerializeField]
		private Object m_ObjectArgument;

		// Token: 0x04000EC1 RID: 3777
		[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
		[SerializeField]
		private string m_ObjectArgumentAssemblyTypeName;

		// Token: 0x04000EC2 RID: 3778
		[FormerlySerializedAs("intArgument")]
		[SerializeField]
		private int m_IntArgument;

		// Token: 0x04000EC3 RID: 3779
		[FormerlySerializedAs("floatArgument")]
		[SerializeField]
		private float m_FloatArgument;

		// Token: 0x04000EC4 RID: 3780
		[FormerlySerializedAs("stringArgument")]
		[SerializeField]
		private string m_StringArgument;

		// Token: 0x04000EC5 RID: 3781
		[SerializeField]
		private bool m_BoolArgument;
	}
}
