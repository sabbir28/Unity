using System;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class AndroidJavaClass : AndroidJavaObject
	{
		// Token: 0x06000024 RID: 36 RVA: 0x0000394C File Offset: 0x00001B4C
		public AndroidJavaClass(string className)
		{
			this._AndroidJavaClass(className);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000395C File Offset: 0x00001B5C
		internal AndroidJavaClass(IntPtr jclass)
		{
			if (jclass == IntPtr.Zero)
			{
				throw new Exception("JNI: Init'd AndroidJavaClass with null ptr!");
			}
			this.m_jclass = AndroidJNI.NewGlobalRef(jclass);
			this.m_jobject = IntPtr.Zero;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003998 File Offset: 0x00001B98
		private void _AndroidJavaClass(string className)
		{
			base.DebugPrint("Creating AndroidJavaClass from " + className);
			using (AndroidJavaObject androidJavaObject = AndroidJavaObject.FindClass(className))
			{
				this.m_jclass = AndroidJNI.NewGlobalRef(androidJavaObject.GetRawObject());
				this.m_jobject = IntPtr.Zero;
			}
		}
	}
}
