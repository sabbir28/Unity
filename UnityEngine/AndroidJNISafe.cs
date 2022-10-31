using System;

namespace UnityEngine
{
	// Token: 0x02000306 RID: 774
	internal class AndroidJNISafe
	{
		// Token: 0x06003014 RID: 12308 RVA: 0x00047908 File Offset: 0x00045B08
		public static void CheckException()
		{
			IntPtr intPtr = AndroidJNI.ExceptionOccurred();
			if (intPtr != IntPtr.Zero)
			{
				AndroidJNI.ExceptionClear();
				IntPtr intPtr2 = AndroidJNI.FindClass("java/lang/Throwable");
				IntPtr intPtr3 = AndroidJNI.FindClass("android/util/Log");
				try
				{
					IntPtr methodID = AndroidJNI.GetMethodID(intPtr2, "toString", "()Ljava/lang/String;");
					IntPtr staticMethodID = AndroidJNI.GetStaticMethodID(intPtr3, "getStackTraceString", "(Ljava/lang/Throwable;)Ljava/lang/String;");
					string message = AndroidJNI.CallStringMethod(intPtr, methodID, new jvalue[0]);
					jvalue[] array = new jvalue[1];
					array[0].l = intPtr;
					string javaStackTrace = AndroidJNI.CallStaticStringMethod(intPtr3, staticMethodID, array);
					throw new AndroidJavaException(message, javaStackTrace);
				}
				finally
				{
					AndroidJNISafe.DeleteLocalRef(intPtr);
					AndroidJNISafe.DeleteLocalRef(intPtr2);
					AndroidJNISafe.DeleteLocalRef(intPtr3);
				}
			}
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x000479CC File Offset: 0x00045BCC
		public static void DeleteGlobalRef(IntPtr globalref)
		{
			if (globalref != IntPtr.Zero)
			{
				AndroidJNI.DeleteGlobalRef(globalref);
			}
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x000479E8 File Offset: 0x00045BE8
		public static void DeleteLocalRef(IntPtr localref)
		{
			if (localref != IntPtr.Zero)
			{
				AndroidJNI.DeleteLocalRef(localref);
			}
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00047A04 File Offset: 0x00045C04
		public static IntPtr NewStringUTF(string bytes)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.NewStringUTF(bytes);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00047A38 File Offset: 0x00045C38
		public static string GetStringUTFChars(IntPtr str)
		{
			string stringUTFChars;
			try
			{
				stringUTFChars = AndroidJNI.GetStringUTFChars(str);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return stringUTFChars;
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x00047A6C File Offset: 0x00045C6C
		public static IntPtr GetObjectClass(IntPtr ptr)
		{
			IntPtr objectClass;
			try
			{
				objectClass = AndroidJNI.GetObjectClass(ptr);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return objectClass;
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x00047AA0 File Offset: 0x00045CA0
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
		{
			IntPtr staticMethodID;
			try
			{
				staticMethodID = AndroidJNI.GetStaticMethodID(clazz, name, sig);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticMethodID;
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x00047AD8 File Offset: 0x00045CD8
		public static IntPtr GetMethodID(IntPtr obj, string name, string sig)
		{
			IntPtr methodID;
			try
			{
				methodID = AndroidJNI.GetMethodID(obj, name, sig);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return methodID;
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00047B10 File Offset: 0x00045D10
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
		{
			IntPtr fieldID;
			try
			{
				fieldID = AndroidJNI.GetFieldID(clazz, name, sig);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return fieldID;
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x00047B48 File Offset: 0x00045D48
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
		{
			IntPtr staticFieldID;
			try
			{
				staticFieldID = AndroidJNI.GetStaticFieldID(clazz, name, sig);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticFieldID;
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x00047B80 File Offset: 0x00045D80
		public static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.FromReflectedMethod(refMethod);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00047BB4 File Offset: 0x00045DB4
		public static IntPtr FromReflectedField(IntPtr refField)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.FromReflectedField(refField);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x00047BE8 File Offset: 0x00045DE8
		public static IntPtr FindClass(string name)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.FindClass(name);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x00047C1C File Offset: 0x00045E1C
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.NewObject(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x00047C54 File Offset: 0x00045E54
		public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
		{
			try
			{
				AndroidJNI.SetStaticObjectField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x00047C8C File Offset: 0x00045E8C
		public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
		{
			try
			{
				AndroidJNI.SetStaticStringField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x00047CC4 File Offset: 0x00045EC4
		public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
		{
			try
			{
				AndroidJNI.SetStaticCharField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x00047CFC File Offset: 0x00045EFC
		public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
		{
			try
			{
				AndroidJNI.SetStaticDoubleField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x00047D34 File Offset: 0x00045F34
		public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
		{
			try
			{
				AndroidJNI.SetStaticFloatField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x00047D6C File Offset: 0x00045F6C
		public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
		{
			try
			{
				AndroidJNI.SetStaticLongField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x00047DA4 File Offset: 0x00045FA4
		public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
		{
			try
			{
				AndroidJNI.SetStaticShortField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x00047DDC File Offset: 0x00045FDC
		public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val)
		{
			try
			{
				AndroidJNI.SetStaticByteField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x00047E14 File Offset: 0x00046014
		public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
		{
			try
			{
				AndroidJNI.SetStaticBooleanField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x00047E4C File Offset: 0x0004604C
		public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
		{
			try
			{
				AndroidJNI.SetStaticIntField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x00047E84 File Offset: 0x00046084
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr staticObjectField;
			try
			{
				staticObjectField = AndroidJNI.GetStaticObjectField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticObjectField;
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x00047EBC File Offset: 0x000460BC
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
		{
			string staticStringField;
			try
			{
				staticStringField = AndroidJNI.GetStaticStringField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticStringField;
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x00047EF4 File Offset: 0x000460F4
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
		{
			char staticCharField;
			try
			{
				staticCharField = AndroidJNI.GetStaticCharField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticCharField;
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x00047F2C File Offset: 0x0004612C
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
		{
			double staticDoubleField;
			try
			{
				staticDoubleField = AndroidJNI.GetStaticDoubleField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticDoubleField;
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x00047F64 File Offset: 0x00046164
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
		{
			float staticFloatField;
			try
			{
				staticFloatField = AndroidJNI.GetStaticFloatField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticFloatField;
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x00047F9C File Offset: 0x0004619C
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
		{
			long staticLongField;
			try
			{
				staticLongField = AndroidJNI.GetStaticLongField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticLongField;
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x00047FD4 File Offset: 0x000461D4
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
		{
			short staticShortField;
			try
			{
				staticShortField = AndroidJNI.GetStaticShortField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticShortField;
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x0004800C File Offset: 0x0004620C
		public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID)
		{
			byte staticByteField;
			try
			{
				staticByteField = AndroidJNI.GetStaticByteField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticByteField;
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x00048044 File Offset: 0x00046244
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
		{
			bool staticBooleanField;
			try
			{
				staticBooleanField = AndroidJNI.GetStaticBooleanField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticBooleanField;
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x0004807C File Offset: 0x0004627C
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
		{
			int staticIntField;
			try
			{
				staticIntField = AndroidJNI.GetStaticIntField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticIntField;
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x000480B4 File Offset: 0x000462B4
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			try
			{
				AndroidJNI.CallStaticVoidMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x000480EC File Offset: 0x000462EC
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.CallStaticObjectMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x00048124 File Offset: 0x00046324
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			string result;
			try
			{
				result = AndroidJNI.CallStaticStringMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x0004815C File Offset: 0x0004635C
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			char result;
			try
			{
				result = AndroidJNI.CallStaticCharMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x00048194 File Offset: 0x00046394
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			double result;
			try
			{
				result = AndroidJNI.CallStaticDoubleMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x000481CC File Offset: 0x000463CC
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			float result;
			try
			{
				result = AndroidJNI.CallStaticFloatMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x00048204 File Offset: 0x00046404
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			long result;
			try
			{
				result = AndroidJNI.CallStaticLongMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x0004823C File Offset: 0x0004643C
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			short result;
			try
			{
				result = AndroidJNI.CallStaticShortMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x00048274 File Offset: 0x00046474
		public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			byte result;
			try
			{
				result = AndroidJNI.CallStaticByteMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x000482AC File Offset: 0x000464AC
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			bool result;
			try
			{
				result = AndroidJNI.CallStaticBooleanMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x000482E4 File Offset: 0x000464E4
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			int result;
			try
			{
				result = AndroidJNI.CallStaticIntMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x0004831C File Offset: 0x0004651C
		public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
		{
			try
			{
				AndroidJNI.SetObjectField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x00048354 File Offset: 0x00046554
		public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
		{
			try
			{
				AndroidJNI.SetStringField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x0004838C File Offset: 0x0004658C
		public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
		{
			try
			{
				AndroidJNI.SetCharField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x000483C4 File Offset: 0x000465C4
		public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
		{
			try
			{
				AndroidJNI.SetDoubleField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x000483FC File Offset: 0x000465FC
		public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
		{
			try
			{
				AndroidJNI.SetFloatField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x00048434 File Offset: 0x00046634
		public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
		{
			try
			{
				AndroidJNI.SetLongField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x0004846C File Offset: 0x0004666C
		public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
		{
			try
			{
				AndroidJNI.SetShortField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x000484A4 File Offset: 0x000466A4
		public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val)
		{
			try
			{
				AndroidJNI.SetByteField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x000484DC File Offset: 0x000466DC
		public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
		{
			try
			{
				AndroidJNI.SetBooleanField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x00048514 File Offset: 0x00046714
		public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
		{
			try
			{
				AndroidJNI.SetIntField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x0004854C File Offset: 0x0004674C
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr objectField;
			try
			{
				objectField = AndroidJNI.GetObjectField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return objectField;
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x00048584 File Offset: 0x00046784
		public static string GetStringField(IntPtr obj, IntPtr fieldID)
		{
			string stringField;
			try
			{
				stringField = AndroidJNI.GetStringField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return stringField;
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x000485BC File Offset: 0x000467BC
		public static char GetCharField(IntPtr obj, IntPtr fieldID)
		{
			char charField;
			try
			{
				charField = AndroidJNI.GetCharField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return charField;
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x000485F4 File Offset: 0x000467F4
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
		{
			double doubleField;
			try
			{
				doubleField = AndroidJNI.GetDoubleField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return doubleField;
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x0004862C File Offset: 0x0004682C
		public static float GetFloatField(IntPtr obj, IntPtr fieldID)
		{
			float floatField;
			try
			{
				floatField = AndroidJNI.GetFloatField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return floatField;
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x00048664 File Offset: 0x00046864
		public static long GetLongField(IntPtr obj, IntPtr fieldID)
		{
			long longField;
			try
			{
				longField = AndroidJNI.GetLongField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return longField;
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x0004869C File Offset: 0x0004689C
		public static short GetShortField(IntPtr obj, IntPtr fieldID)
		{
			short shortField;
			try
			{
				shortField = AndroidJNI.GetShortField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return shortField;
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x000486D4 File Offset: 0x000468D4
		public static byte GetByteField(IntPtr obj, IntPtr fieldID)
		{
			byte byteField;
			try
			{
				byteField = AndroidJNI.GetByteField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return byteField;
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x0004870C File Offset: 0x0004690C
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
		{
			bool booleanField;
			try
			{
				booleanField = AndroidJNI.GetBooleanField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return booleanField;
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x00048744 File Offset: 0x00046944
		public static int GetIntField(IntPtr obj, IntPtr fieldID)
		{
			int intField;
			try
			{
				intField = AndroidJNI.GetIntField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return intField;
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x0004877C File Offset: 0x0004697C
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			try
			{
				AndroidJNI.CallVoidMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x000487B4 File Offset: 0x000469B4
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.CallObjectMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x000487EC File Offset: 0x000469EC
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			string result;
			try
			{
				result = AndroidJNI.CallStringMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x00048824 File Offset: 0x00046A24
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			char result;
			try
			{
				result = AndroidJNI.CallCharMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x0004885C File Offset: 0x00046A5C
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			double result;
			try
			{
				result = AndroidJNI.CallDoubleMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x00048894 File Offset: 0x00046A94
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			float result;
			try
			{
				result = AndroidJNI.CallFloatMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x000488CC File Offset: 0x00046ACC
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			long result;
			try
			{
				result = AndroidJNI.CallLongMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x00048904 File Offset: 0x00046B04
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			short result;
			try
			{
				result = AndroidJNI.CallShortMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x0004893C File Offset: 0x00046B3C
		public static byte CallByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			byte result;
			try
			{
				result = AndroidJNI.CallByteMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x00048974 File Offset: 0x00046B74
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			bool result;
			try
			{
				result = AndroidJNI.CallBooleanMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x000489AC File Offset: 0x00046BAC
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			int result;
			try
			{
				result = AndroidJNI.CallIntMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x000489E4 File Offset: 0x00046BE4
		public static IntPtr[] FromObjectArray(IntPtr array)
		{
			IntPtr[] result;
			try
			{
				result = AndroidJNI.FromObjectArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x00048A18 File Offset: 0x00046C18
		public static char[] FromCharArray(IntPtr array)
		{
			char[] result;
			try
			{
				result = AndroidJNI.FromCharArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x00048A4C File Offset: 0x00046C4C
		public static double[] FromDoubleArray(IntPtr array)
		{
			double[] result;
			try
			{
				result = AndroidJNI.FromDoubleArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x00048A80 File Offset: 0x00046C80
		public static float[] FromFloatArray(IntPtr array)
		{
			float[] result;
			try
			{
				result = AndroidJNI.FromFloatArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x00048AB4 File Offset: 0x00046CB4
		public static long[] FromLongArray(IntPtr array)
		{
			long[] result;
			try
			{
				result = AndroidJNI.FromLongArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x00048AE8 File Offset: 0x00046CE8
		public static short[] FromShortArray(IntPtr array)
		{
			short[] result;
			try
			{
				result = AndroidJNI.FromShortArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x00048B1C File Offset: 0x00046D1C
		public static byte[] FromByteArray(IntPtr array)
		{
			byte[] result;
			try
			{
				result = AndroidJNI.FromByteArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x00048B50 File Offset: 0x00046D50
		public static bool[] FromBooleanArray(IntPtr array)
		{
			bool[] result;
			try
			{
				result = AndroidJNI.FromBooleanArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x00048B84 File Offset: 0x00046D84
		public static int[] FromIntArray(IntPtr array)
		{
			int[] result;
			try
			{
				result = AndroidJNI.FromIntArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x00048BB8 File Offset: 0x00046DB8
		public static IntPtr ToObjectArray(IntPtr[] array)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.ToObjectArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x00048BEC File Offset: 0x00046DEC
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.ToObjectArray(array, type);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x00048C24 File Offset: 0x00046E24
		public static IntPtr ToCharArray(char[] array)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.ToCharArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x00048C58 File Offset: 0x00046E58
		public static IntPtr ToDoubleArray(double[] array)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.ToDoubleArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x00048C8C File Offset: 0x00046E8C
		public static IntPtr ToFloatArray(float[] array)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.ToFloatArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x00048CC0 File Offset: 0x00046EC0
		public static IntPtr ToLongArray(long[] array)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.ToLongArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x00048CF4 File Offset: 0x00046EF4
		public static IntPtr ToShortArray(short[] array)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.ToShortArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x00048D28 File Offset: 0x00046F28
		public static IntPtr ToByteArray(byte[] array)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.ToByteArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x00048D5C File Offset: 0x00046F5C
		public static IntPtr ToBooleanArray(bool[] array)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.ToBooleanArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x00048D90 File Offset: 0x00046F90
		public static IntPtr ToIntArray(int[] array)
		{
			IntPtr result;
			try
			{
				result = AndroidJNI.ToIntArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return result;
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x00048DC4 File Offset: 0x00046FC4
		public static IntPtr GetObjectArrayElement(IntPtr array, int index)
		{
			IntPtr objectArrayElement;
			try
			{
				objectArrayElement = AndroidJNI.GetObjectArrayElement(array, index);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return objectArrayElement;
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x00048DFC File Offset: 0x00046FFC
		public static int GetArrayLength(IntPtr array)
		{
			int arrayLength;
			try
			{
				arrayLength = AndroidJNI.GetArrayLength(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return arrayLength;
		}
	}
}
