using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D6 RID: 214
	internal sealed class UnityLogWriter : TextWriter
	{
		// Token: 0x06000FBD RID: 4029
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WriteStringToUnityLog(string s);

		// Token: 0x06000FBE RID: 4030 RVA: 0x00015614 File Offset: 0x00013814
		public static void Init()
		{
			Console.SetOut(new UnityLogWriter());
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x00015624 File Offset: 0x00013824
		public override Encoding Encoding
		{
			get
			{
				return Encoding.UTF8;
			}
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00015640 File Offset: 0x00013840
		public override void Write(char value)
		{
			UnityLogWriter.WriteStringToUnityLog(value.ToString());
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00015658 File Offset: 0x00013858
		public override void Write(string s)
		{
			UnityLogWriter.WriteStringToUnityLog(s);
		}
	}
}
