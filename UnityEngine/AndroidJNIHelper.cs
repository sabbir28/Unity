using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[UsedByNativeCode]
	public sealed class AndroidJNIHelper
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00003A00 File Offset: 0x00001C00
		private AndroidJNIHelper()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000028 RID: 40
		// (set) Token: 0x06000029 RID: 41
		public static extern bool debug { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600002A RID: 42 RVA: 0x00003A0C File Offset: 0x00001C0C
		[ExcludeFromDocs]
		public static IntPtr GetConstructorID(IntPtr javaClass)
		{
			string signature = "";
			return AndroidJNIHelper.GetConstructorID(javaClass, signature);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003A30 File Offset: 0x00001C30
		public static IntPtr GetConstructorID(IntPtr javaClass, [DefaultValue("\"\"")] string signature)
		{
			return _AndroidJNIHelper.GetConstructorID(javaClass, signature);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003A4C File Offset: 0x00001C4C
		[ExcludeFromDocs]
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature)
		{
			bool isStatic = false;
			return AndroidJNIHelper.GetMethodID(javaClass, methodName, signature, isStatic);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003A6C File Offset: 0x00001C6C
		[ExcludeFromDocs]
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName)
		{
			bool isStatic = false;
			string signature = "";
			return AndroidJNIHelper.GetMethodID(javaClass, methodName, signature, isStatic);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003A94 File Offset: 0x00001C94
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue("\"\"")] string signature, [DefaultValue("false")] bool isStatic)
		{
			return _AndroidJNIHelper.GetMethodID(javaClass, methodName, signature, isStatic);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003AB4 File Offset: 0x00001CB4
		[ExcludeFromDocs]
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature)
		{
			bool isStatic = false;
			return AndroidJNIHelper.GetFieldID(javaClass, fieldName, signature, isStatic);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003AD4 File Offset: 0x00001CD4
		[ExcludeFromDocs]
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName)
		{
			bool isStatic = false;
			string signature = "";
			return AndroidJNIHelper.GetFieldID(javaClass, fieldName, signature, isStatic);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003AFC File Offset: 0x00001CFC
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue("\"\"")] string signature, [DefaultValue("false")] bool isStatic)
		{
			return _AndroidJNIHelper.GetFieldID(javaClass, fieldName, signature, isStatic);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003B1C File Offset: 0x00001D1C
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			return _AndroidJNIHelper.CreateJavaRunnable(jrunnable);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003B38 File Offset: 0x00001D38
		[ThreadAndSerializationSafe]
		public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy)
		{
			IntPtr result;
			AndroidJNIHelper.INTERNAL_CALL_CreateJavaProxy(proxy, out result);
			return result;
		}

		// Token: 0x06000034 RID: 52
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CreateJavaProxy(AndroidJavaProxy proxy, out IntPtr value);

		// Token: 0x06000035 RID: 53 RVA: 0x00003B58 File Offset: 0x00001D58
		public static IntPtr ConvertToJNIArray(Array array)
		{
			return _AndroidJNIHelper.ConvertToJNIArray(array);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003B74 File Offset: 0x00001D74
		public static jvalue[] CreateJNIArgArray(object[] args)
		{
			return _AndroidJNIHelper.CreateJNIArgArray(args);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003B90 File Offset: 0x00001D90
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs)
		{
			_AndroidJNIHelper.DeleteJNIArgArray(args, jniArgs);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003B9C File Offset: 0x00001D9C
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
		{
			return _AndroidJNIHelper.GetConstructorID(jclass, args);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003BB8 File Offset: 0x00001DB8
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return _AndroidJNIHelper.GetMethodID(jclass, methodName, args, isStatic);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003BD8 File Offset: 0x00001DD8
		public static string GetSignature(object obj)
		{
			return _AndroidJNIHelper.GetSignature(obj);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003BF4 File Offset: 0x00001DF4
		public static string GetSignature(object[] args)
		{
			return _AndroidJNIHelper.GetSignature(args);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003C10 File Offset: 0x00001E10
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			return _AndroidJNIHelper.ConvertFromJNIArray<ArrayType>(array);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003C2C File Offset: 0x00001E2C
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return _AndroidJNIHelper.GetMethodID<ReturnType>(jclass, methodName, args, isStatic);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003C4C File Offset: 0x00001E4C
		public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			return _AndroidJNIHelper.GetFieldID<FieldType>(jclass, fieldName, isStatic);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003C6C File Offset: 0x00001E6C
		public static string GetSignature<ReturnType>(object[] args)
		{
			return _AndroidJNIHelper.GetSignature<ReturnType>(args);
		}
	}
}
