using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public sealed class AndroidJNI
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00003C88 File Offset: 0x00001E88
		private AndroidJNI()
		{
		}

		// Token: 0x06000041 RID: 65
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int AttachCurrentThread();

		// Token: 0x06000042 RID: 66
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int DetachCurrentThread();

		// Token: 0x06000043 RID: 67
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetVersion();

		// Token: 0x06000044 RID: 68 RVA: 0x00003C94 File Offset: 0x00001E94
		[ThreadAndSerializationSafe]
		public static IntPtr FindClass(string name)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_FindClass(name, out result);
			return result;
		}

		// Token: 0x06000045 RID: 69
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_FindClass(string name, out IntPtr value);

		// Token: 0x06000046 RID: 70 RVA: 0x00003CB4 File Offset: 0x00001EB4
		[ThreadAndSerializationSafe]
		public static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_FromReflectedMethod(refMethod, out result);
			return result;
		}

		// Token: 0x06000047 RID: 71
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_FromReflectedMethod(IntPtr refMethod, out IntPtr value);

		// Token: 0x06000048 RID: 72 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[ThreadAndSerializationSafe]
		public static IntPtr FromReflectedField(IntPtr refField)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_FromReflectedField(refField, out result);
			return result;
		}

		// Token: 0x06000049 RID: 73
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_FromReflectedField(IntPtr refField, out IntPtr value);

		// Token: 0x0600004A RID: 74 RVA: 0x00003CF4 File Offset: 0x00001EF4
		[ThreadAndSerializationSafe]
		public static IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ToReflectedMethod(clazz, methodID, isStatic, out result);
			return result;
		}

		// Token: 0x0600004B RID: 75
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic, out IntPtr value);

		// Token: 0x0600004C RID: 76 RVA: 0x00003D14 File Offset: 0x00001F14
		[ThreadAndSerializationSafe]
		public static IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ToReflectedField(clazz, fieldID, isStatic, out result);
			return result;
		}

		// Token: 0x0600004D RID: 77
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic, out IntPtr value);

		// Token: 0x0600004E RID: 78 RVA: 0x00003D34 File Offset: 0x00001F34
		[ThreadAndSerializationSafe]
		public static IntPtr GetSuperclass(IntPtr clazz)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_GetSuperclass(clazz, out result);
			return result;
		}

		// Token: 0x0600004F RID: 79
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetSuperclass(IntPtr clazz, out IntPtr value);

		// Token: 0x06000050 RID: 80
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2);

		// Token: 0x06000051 RID: 81
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Throw(IntPtr obj);

		// Token: 0x06000052 RID: 82
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int ThrowNew(IntPtr clazz, string message);

		// Token: 0x06000053 RID: 83 RVA: 0x00003D54 File Offset: 0x00001F54
		[ThreadAndSerializationSafe]
		public static IntPtr ExceptionOccurred()
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ExceptionOccurred(out result);
			return result;
		}

		// Token: 0x06000054 RID: 84
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ExceptionOccurred(out IntPtr value);

		// Token: 0x06000055 RID: 85
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ExceptionDescribe();

		// Token: 0x06000056 RID: 86
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ExceptionClear();

		// Token: 0x06000057 RID: 87
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FatalError(string message);

		// Token: 0x06000058 RID: 88
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int PushLocalFrame(int capacity);

		// Token: 0x06000059 RID: 89 RVA: 0x00003D74 File Offset: 0x00001F74
		[ThreadAndSerializationSafe]
		public static IntPtr PopLocalFrame(IntPtr ptr)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_PopLocalFrame(ptr, out result);
			return result;
		}

		// Token: 0x0600005A RID: 90
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_PopLocalFrame(IntPtr ptr, out IntPtr value);

		// Token: 0x0600005B RID: 91 RVA: 0x00003D94 File Offset: 0x00001F94
		[ThreadAndSerializationSafe]
		public static IntPtr NewGlobalRef(IntPtr obj)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewGlobalRef(obj, out result);
			return result;
		}

		// Token: 0x0600005C RID: 92
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewGlobalRef(IntPtr obj, out IntPtr value);

		// Token: 0x0600005D RID: 93
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeleteGlobalRef(IntPtr obj);

		// Token: 0x0600005E RID: 94 RVA: 0x00003DB4 File Offset: 0x00001FB4
		[ThreadAndSerializationSafe]
		public static IntPtr NewLocalRef(IntPtr obj)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewLocalRef(obj, out result);
			return result;
		}

		// Token: 0x0600005F RID: 95
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewLocalRef(IntPtr obj, out IntPtr value);

		// Token: 0x06000060 RID: 96
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeleteLocalRef(IntPtr obj);

		// Token: 0x06000061 RID: 97
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSameObject(IntPtr obj1, IntPtr obj2);

		// Token: 0x06000062 RID: 98
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int EnsureLocalCapacity(int capacity);

		// Token: 0x06000063 RID: 99 RVA: 0x00003DD4 File Offset: 0x00001FD4
		[ThreadAndSerializationSafe]
		public static IntPtr AllocObject(IntPtr clazz)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_AllocObject(clazz, out result);
			return result;
		}

		// Token: 0x06000064 RID: 100
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AllocObject(IntPtr clazz, out IntPtr value);

		// Token: 0x06000065 RID: 101 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[ThreadAndSerializationSafe]
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewObject(clazz, methodID, args, out result);
			return result;
		}

		// Token: 0x06000066 RID: 102
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args, out IntPtr value);

		// Token: 0x06000067 RID: 103 RVA: 0x00003E14 File Offset: 0x00002014
		[ThreadAndSerializationSafe]
		public static IntPtr GetObjectClass(IntPtr obj)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_GetObjectClass(obj, out result);
			return result;
		}

		// Token: 0x06000068 RID: 104
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetObjectClass(IntPtr obj, out IntPtr value);

		// Token: 0x06000069 RID: 105
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsInstanceOf(IntPtr obj, IntPtr clazz);

		// Token: 0x0600006A RID: 106 RVA: 0x00003E34 File Offset: 0x00002034
		[ThreadAndSerializationSafe]
		public static IntPtr GetMethodID(IntPtr clazz, string name, string sig)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_GetMethodID(clazz, name, sig, out result);
			return result;
		}

		// Token: 0x0600006B RID: 107
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetMethodID(IntPtr clazz, string name, string sig, out IntPtr value);

		// Token: 0x0600006C RID: 108 RVA: 0x00003E54 File Offset: 0x00002054
		[ThreadAndSerializationSafe]
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_GetFieldID(clazz, name, sig, out result);
			return result;
		}

		// Token: 0x0600006D RID: 109
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetFieldID(IntPtr clazz, string name, string sig, out IntPtr value);

		// Token: 0x0600006E RID: 110 RVA: 0x00003E74 File Offset: 0x00002074
		[ThreadAndSerializationSafe]
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_GetStaticMethodID(clazz, name, sig, out result);
			return result;
		}

		// Token: 0x0600006F RID: 111
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetStaticMethodID(IntPtr clazz, string name, string sig, out IntPtr value);

		// Token: 0x06000070 RID: 112 RVA: 0x00003E94 File Offset: 0x00002094
		[ThreadAndSerializationSafe]
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_GetStaticFieldID(clazz, name, sig, out result);
			return result;
		}

		// Token: 0x06000071 RID: 113
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetStaticFieldID(IntPtr clazz, string name, string sig, out IntPtr value);

		// Token: 0x06000072 RID: 114 RVA: 0x00003EB4 File Offset: 0x000020B4
		[ThreadAndSerializationSafe]
		public static IntPtr NewStringUTF(string bytes)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewStringUTF(bytes, out result);
			return result;
		}

		// Token: 0x06000073 RID: 115
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewStringUTF(string bytes, out IntPtr value);

		// Token: 0x06000074 RID: 116
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetStringUTFLength(IntPtr str);

		// Token: 0x06000075 RID: 117
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetStringUTFChars(IntPtr str);

		// Token: 0x06000076 RID: 118
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000077 RID: 119 RVA: 0x00003ED4 File Offset: 0x000020D4
		[ThreadAndSerializationSafe]
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_CallObjectMethod(obj, methodID, args, out result);
			return result;
		}

		// Token: 0x06000078 RID: 120
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args, out IntPtr value);

		// Token: 0x06000079 RID: 121
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600007A RID: 122
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600007B RID: 123
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600007C RID: 124
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte CallByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600007D RID: 125
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600007E RID: 126
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600007F RID: 127
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000080 RID: 128
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000081 RID: 129
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000082 RID: 130
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetStringField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000083 RID: 131 RVA: 0x00003EF4 File Offset: 0x000020F4
		[ThreadAndSerializationSafe]
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_GetObjectField(obj, fieldID, out result);
			return result;
		}

		// Token: 0x06000084 RID: 132
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetObjectField(IntPtr obj, IntPtr fieldID, out IntPtr value);

		// Token: 0x06000085 RID: 133
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetBooleanField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000086 RID: 134
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte GetByteField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000087 RID: 135
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern char GetCharField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000088 RID: 136
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern short GetShortField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000089 RID: 137
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetIntField(IntPtr obj, IntPtr fieldID);

		// Token: 0x0600008A RID: 138
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetLongField(IntPtr obj, IntPtr fieldID);

		// Token: 0x0600008B RID: 139
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetFloatField(IntPtr obj, IntPtr fieldID);

		// Token: 0x0600008C RID: 140
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetDoubleField(IntPtr obj, IntPtr fieldID);

		// Token: 0x0600008D RID: 141
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStringField(IntPtr obj, IntPtr fieldID, string val);

		// Token: 0x0600008E RID: 142
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val);

		// Token: 0x0600008F RID: 143
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val);

		// Token: 0x06000090 RID: 144
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetByteField(IntPtr obj, IntPtr fieldID, byte val);

		// Token: 0x06000091 RID: 145
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCharField(IntPtr obj, IntPtr fieldID, char val);

		// Token: 0x06000092 RID: 146
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShortField(IntPtr obj, IntPtr fieldID, short val);

		// Token: 0x06000093 RID: 147
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetIntField(IntPtr obj, IntPtr fieldID, int val);

		// Token: 0x06000094 RID: 148
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetLongField(IntPtr obj, IntPtr fieldID, long val);

		// Token: 0x06000095 RID: 149
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFloatField(IntPtr obj, IntPtr fieldID, float val);

		// Token: 0x06000096 RID: 150
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDoubleField(IntPtr obj, IntPtr fieldID, double val);

		// Token: 0x06000097 RID: 151
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000098 RID: 152 RVA: 0x00003F14 File Offset: 0x00002114
		[ThreadAndSerializationSafe]
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_CallStaticObjectMethod(clazz, methodID, args, out result);
			return result;
		}

		// Token: 0x06000099 RID: 153
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args, out IntPtr value);

		// Token: 0x0600009A RID: 154
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600009B RID: 155
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600009C RID: 156
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600009D RID: 157
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600009E RID: 158
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600009F RID: 159
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x060000A0 RID: 160
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x060000A1 RID: 161
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x060000A2 RID: 162
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x060000A3 RID: 163
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetStaticStringField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x060000A4 RID: 164 RVA: 0x00003F34 File Offset: 0x00002134
		[ThreadAndSerializationSafe]
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_GetStaticObjectField(clazz, fieldID, out result);
			return result;
		}

		// Token: 0x060000A5 RID: 165
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetStaticObjectField(IntPtr clazz, IntPtr fieldID, out IntPtr value);

		// Token: 0x060000A6 RID: 166
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x060000A7 RID: 167
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte GetStaticByteField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x060000A8 RID: 168
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern char GetStaticCharField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x060000A9 RID: 169
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern short GetStaticShortField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x060000AA RID: 170
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetStaticIntField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x060000AB RID: 171
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetStaticLongField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x060000AC RID: 172
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetStaticFloatField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x060000AD RID: 173
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x060000AE RID: 174
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val);

		// Token: 0x060000AF RID: 175
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val);

		// Token: 0x060000B0 RID: 176
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val);

		// Token: 0x060000B1 RID: 177
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val);

		// Token: 0x060000B2 RID: 178
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val);

		// Token: 0x060000B3 RID: 179
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val);

		// Token: 0x060000B4 RID: 180
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val);

		// Token: 0x060000B5 RID: 181
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val);

		// Token: 0x060000B6 RID: 182
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val);

		// Token: 0x060000B7 RID: 183
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val);

		// Token: 0x060000B8 RID: 184 RVA: 0x00003F54 File Offset: 0x00002154
		[ThreadAndSerializationSafe]
		public static IntPtr ToBooleanArray(bool[] array)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ToBooleanArray(array, out result);
			return result;
		}

		// Token: 0x060000B9 RID: 185
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ToBooleanArray(bool[] array, out IntPtr value);

		// Token: 0x060000BA RID: 186 RVA: 0x00003F74 File Offset: 0x00002174
		[ThreadAndSerializationSafe]
		public static IntPtr ToByteArray(byte[] array)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ToByteArray(array, out result);
			return result;
		}

		// Token: 0x060000BB RID: 187
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ToByteArray(byte[] array, out IntPtr value);

		// Token: 0x060000BC RID: 188 RVA: 0x00003F94 File Offset: 0x00002194
		[ThreadAndSerializationSafe]
		public static IntPtr ToCharArray(char[] array)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ToCharArray(array, out result);
			return result;
		}

		// Token: 0x060000BD RID: 189
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ToCharArray(char[] array, out IntPtr value);

		// Token: 0x060000BE RID: 190 RVA: 0x00003FB4 File Offset: 0x000021B4
		[ThreadAndSerializationSafe]
		public static IntPtr ToShortArray(short[] array)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ToShortArray(array, out result);
			return result;
		}

		// Token: 0x060000BF RID: 191
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ToShortArray(short[] array, out IntPtr value);

		// Token: 0x060000C0 RID: 192 RVA: 0x00003FD4 File Offset: 0x000021D4
		[ThreadAndSerializationSafe]
		public static IntPtr ToIntArray(int[] array)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ToIntArray(array, out result);
			return result;
		}

		// Token: 0x060000C1 RID: 193
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ToIntArray(int[] array, out IntPtr value);

		// Token: 0x060000C2 RID: 194 RVA: 0x00003FF4 File Offset: 0x000021F4
		[ThreadAndSerializationSafe]
		public static IntPtr ToLongArray(long[] array)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ToLongArray(array, out result);
			return result;
		}

		// Token: 0x060000C3 RID: 195
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ToLongArray(long[] array, out IntPtr value);

		// Token: 0x060000C4 RID: 196 RVA: 0x00004014 File Offset: 0x00002214
		[ThreadAndSerializationSafe]
		public static IntPtr ToFloatArray(float[] array)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ToFloatArray(array, out result);
			return result;
		}

		// Token: 0x060000C5 RID: 197
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ToFloatArray(float[] array, out IntPtr value);

		// Token: 0x060000C6 RID: 198 RVA: 0x00004034 File Offset: 0x00002234
		[ThreadAndSerializationSafe]
		public static IntPtr ToDoubleArray(double[] array)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ToDoubleArray(array, out result);
			return result;
		}

		// Token: 0x060000C7 RID: 199
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ToDoubleArray(double[] array, out IntPtr value);

		// Token: 0x060000C8 RID: 200 RVA: 0x00004054 File Offset: 0x00002254
		[ThreadAndSerializationSafe]
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_ToObjectArray(array, arrayClass, out result);
			return result;
		}

		// Token: 0x060000C9 RID: 201
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ToObjectArray(IntPtr[] array, IntPtr arrayClass, out IntPtr value);

		// Token: 0x060000CA RID: 202 RVA: 0x00004074 File Offset: 0x00002274
		public static IntPtr ToObjectArray(IntPtr[] array)
		{
			return AndroidJNI.ToObjectArray(array, IntPtr.Zero);
		}

		// Token: 0x060000CB RID: 203
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool[] FromBooleanArray(IntPtr array);

		// Token: 0x060000CC RID: 204
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte[] FromByteArray(IntPtr array);

		// Token: 0x060000CD RID: 205
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern char[] FromCharArray(IntPtr array);

		// Token: 0x060000CE RID: 206
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern short[] FromShortArray(IntPtr array);

		// Token: 0x060000CF RID: 207
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int[] FromIntArray(IntPtr array);

		// Token: 0x060000D0 RID: 208
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long[] FromLongArray(IntPtr array);

		// Token: 0x060000D1 RID: 209
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float[] FromFloatArray(IntPtr array);

		// Token: 0x060000D2 RID: 210
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double[] FromDoubleArray(IntPtr array);

		// Token: 0x060000D3 RID: 211
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr[] FromObjectArray(IntPtr array);

		// Token: 0x060000D4 RID: 212
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetArrayLength(IntPtr array);

		// Token: 0x060000D5 RID: 213 RVA: 0x00004094 File Offset: 0x00002294
		[ThreadAndSerializationSafe]
		public static IntPtr NewBooleanArray(int size)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewBooleanArray(size, out result);
			return result;
		}

		// Token: 0x060000D6 RID: 214
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewBooleanArray(int size, out IntPtr value);

		// Token: 0x060000D7 RID: 215 RVA: 0x000040B4 File Offset: 0x000022B4
		[ThreadAndSerializationSafe]
		public static IntPtr NewByteArray(int size)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewByteArray(size, out result);
			return result;
		}

		// Token: 0x060000D8 RID: 216
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewByteArray(int size, out IntPtr value);

		// Token: 0x060000D9 RID: 217 RVA: 0x000040D4 File Offset: 0x000022D4
		[ThreadAndSerializationSafe]
		public static IntPtr NewCharArray(int size)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewCharArray(size, out result);
			return result;
		}

		// Token: 0x060000DA RID: 218
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewCharArray(int size, out IntPtr value);

		// Token: 0x060000DB RID: 219 RVA: 0x000040F4 File Offset: 0x000022F4
		[ThreadAndSerializationSafe]
		public static IntPtr NewShortArray(int size)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewShortArray(size, out result);
			return result;
		}

		// Token: 0x060000DC RID: 220
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewShortArray(int size, out IntPtr value);

		// Token: 0x060000DD RID: 221 RVA: 0x00004114 File Offset: 0x00002314
		[ThreadAndSerializationSafe]
		public static IntPtr NewIntArray(int size)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewIntArray(size, out result);
			return result;
		}

		// Token: 0x060000DE RID: 222
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewIntArray(int size, out IntPtr value);

		// Token: 0x060000DF RID: 223 RVA: 0x00004134 File Offset: 0x00002334
		[ThreadAndSerializationSafe]
		public static IntPtr NewLongArray(int size)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewLongArray(size, out result);
			return result;
		}

		// Token: 0x060000E0 RID: 224
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewLongArray(int size, out IntPtr value);

		// Token: 0x060000E1 RID: 225 RVA: 0x00004154 File Offset: 0x00002354
		[ThreadAndSerializationSafe]
		public static IntPtr NewFloatArray(int size)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewFloatArray(size, out result);
			return result;
		}

		// Token: 0x060000E2 RID: 226
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewFloatArray(int size, out IntPtr value);

		// Token: 0x060000E3 RID: 227 RVA: 0x00004174 File Offset: 0x00002374
		[ThreadAndSerializationSafe]
		public static IntPtr NewDoubleArray(int size)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewDoubleArray(size, out result);
			return result;
		}

		// Token: 0x060000E4 RID: 228
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewDoubleArray(int size, out IntPtr value);

		// Token: 0x060000E5 RID: 229 RVA: 0x00004194 File Offset: 0x00002394
		[ThreadAndSerializationSafe]
		public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_NewObjectArray(size, clazz, obj, out result);
			return result;
		}

		// Token: 0x060000E6 RID: 230
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_NewObjectArray(int size, IntPtr clazz, IntPtr obj, out IntPtr value);

		// Token: 0x060000E7 RID: 231
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetBooleanArrayElement(IntPtr array, int index);

		// Token: 0x060000E8 RID: 232
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte GetByteArrayElement(IntPtr array, int index);

		// Token: 0x060000E9 RID: 233
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern char GetCharArrayElement(IntPtr array, int index);

		// Token: 0x060000EA RID: 234
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern short GetShortArrayElement(IntPtr array, int index);

		// Token: 0x060000EB RID: 235
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetIntArrayElement(IntPtr array, int index);

		// Token: 0x060000EC RID: 236
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetLongArrayElement(IntPtr array, int index);

		// Token: 0x060000ED RID: 237
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetFloatArrayElement(IntPtr array, int index);

		// Token: 0x060000EE RID: 238
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetDoubleArrayElement(IntPtr array, int index);

		// Token: 0x060000EF RID: 239 RVA: 0x000041B4 File Offset: 0x000023B4
		[ThreadAndSerializationSafe]
		public static IntPtr GetObjectArrayElement(IntPtr array, int index)
		{
			IntPtr result;
			AndroidJNI.INTERNAL_CALL_GetObjectArrayElement(array, index, out result);
			return result;
		}

		// Token: 0x060000F0 RID: 240
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetObjectArrayElement(IntPtr array, int index, out IntPtr value);

		// Token: 0x060000F1 RID: 241
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetBooleanArrayElement(IntPtr array, int index, byte val);

		// Token: 0x060000F2 RID: 242
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetByteArrayElement(IntPtr array, int index, sbyte val);

		// Token: 0x060000F3 RID: 243
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCharArrayElement(IntPtr array, int index, char val);

		// Token: 0x060000F4 RID: 244
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShortArrayElement(IntPtr array, int index, short val);

		// Token: 0x060000F5 RID: 245
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetIntArrayElement(IntPtr array, int index, int val);

		// Token: 0x060000F6 RID: 246
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetLongArrayElement(IntPtr array, int index, long val);

		// Token: 0x060000F7 RID: 247
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFloatArrayElement(IntPtr array, int index, float val);

		// Token: 0x060000F8 RID: 248
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDoubleArrayElement(IntPtr array, int index, double val);

		// Token: 0x060000F9 RID: 249
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetObjectArrayElement(IntPtr array, int index, IntPtr obj);
	}
}
