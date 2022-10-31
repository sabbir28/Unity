using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine.Assertions.Comparers;

namespace UnityEngine.Assertions
{
	// Token: 0x020003F9 RID: 1017
	[DebuggerStepThrough]
	public static class Assert
	{
		// Token: 0x060033F0 RID: 13296 RVA: 0x00052174 File Offset: 0x00050374
		private static void Fail(string message, string userMessage)
		{
			if (Debugger.IsAttached)
			{
				throw new AssertionException(message, userMessage);
			}
			if (Assert.raiseExceptions)
			{
				throw new AssertionException(message, userMessage);
			}
			if (message == null)
			{
				message = "Assertion has failed\n";
			}
			if (userMessage != null)
			{
				message = userMessage + '\n' + message;
			}
			Debug.LogAssertion(message);
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x000521D0 File Offset: 0x000503D0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Assert.Equals should not be used for Assertions", true)]
		public new static bool Equals(object obj1, object obj2)
		{
			throw new InvalidOperationException("Assert.Equals should not be used for Assertions");
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000521E0 File Offset: 0x000503E0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Assert.ReferenceEquals should not be used for Assertions", true)]
		public new static bool ReferenceEquals(object obj1, object obj2)
		{
			throw new InvalidOperationException("Assert.ReferenceEquals should not be used for Assertions");
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x000521F0 File Offset: 0x000503F0
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsTrue(bool condition)
		{
			Assert.IsTrue(condition, null);
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x000521FC File Offset: 0x000503FC
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsTrue(bool condition, string message)
		{
			if (!condition)
			{
				Assert.Fail(AssertionMessageUtil.BooleanFailureMessage(true), message);
			}
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00052214 File Offset: 0x00050414
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsFalse(bool condition)
		{
			Assert.IsFalse(condition, null);
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00052220 File Offset: 0x00050420
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsFalse(bool condition, string message)
		{
			if (condition)
			{
				Assert.Fail(AssertionMessageUtil.BooleanFailureMessage(false), message);
			}
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00052238 File Offset: 0x00050438
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreApproximatelyEqual(float expected, float actual)
		{
			Assert.AreEqual<float>(expected, actual, null, FloatComparer.s_ComparerWithDefaultTolerance);
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x00052248 File Offset: 0x00050448
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreApproximatelyEqual(float expected, float actual, string message)
		{
			Assert.AreEqual<float>(expected, actual, message, FloatComparer.s_ComparerWithDefaultTolerance);
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00052258 File Offset: 0x00050458
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, null);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00052264 File Offset: 0x00050464
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreEqual<float>(expected, actual, message, new FloatComparer(tolerance));
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x00052278 File Offset: 0x00050478
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotApproximatelyEqual(float expected, float actual)
		{
			Assert.AreNotEqual<float>(expected, actual, null, FloatComparer.s_ComparerWithDefaultTolerance);
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00052288 File Offset: 0x00050488
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotApproximatelyEqual(float expected, float actual, string message)
		{
			Assert.AreNotEqual<float>(expected, actual, message, FloatComparer.s_ComparerWithDefaultTolerance);
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00052298 File Offset: 0x00050498
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, null);
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x000522A4 File Offset: 0x000504A4
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreNotEqual<float>(expected, actual, message, new FloatComparer(tolerance));
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x000522B8 File Offset: 0x000504B8
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual<T>(T expected, T actual)
		{
			Assert.AreEqual<T>(expected, actual, null);
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x000522C4 File Offset: 0x000504C4
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual<T>(T expected, T actual, string message)
		{
			Assert.AreEqual<T>(expected, actual, message, EqualityComparer<T>.Default);
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x000522D4 File Offset: 0x000504D4
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			if (typeof(Object).IsAssignableFrom(typeof(T)))
			{
				Assert.AreEqual(expected as Object, actual as Object, message);
			}
			else if (!comparer.Equals(actual, expected))
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, true), message);
			}
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00052348 File Offset: 0x00050548
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual(Object expected, Object actual, string message)
		{
			if (actual != expected)
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, true), message);
			}
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x00052368 File Offset: 0x00050568
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotEqual<T>(T expected, T actual)
		{
			Assert.AreNotEqual<T>(expected, actual, null);
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x00052374 File Offset: 0x00050574
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotEqual<T>(T expected, T actual, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message, EqualityComparer<T>.Default);
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x00052384 File Offset: 0x00050584
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			if (typeof(Object).IsAssignableFrom(typeof(T)))
			{
				Assert.AreNotEqual(expected as Object, actual as Object, message);
			}
			else if (comparer.Equals(actual, expected))
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, false), message);
			}
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x000523F8 File Offset: 0x000505F8
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotEqual(Object expected, Object actual, string message)
		{
			if (actual == expected)
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, false), message);
			}
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x00052418 File Offset: 0x00050618
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNull<T>(T value) where T : class
		{
			Assert.IsNull<T>(value, null);
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00052424 File Offset: 0x00050624
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNull<T>(T value, string message) where T : class
		{
			if (typeof(Object).IsAssignableFrom(typeof(T)))
			{
				Assert.IsNull(value as Object, message);
			}
			else if (value != null)
			{
				Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, true), message);
			}
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00052488 File Offset: 0x00050688
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNull(Object value, string message)
		{
			if (value != null)
			{
				Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, true), message);
			}
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x000524A4 File Offset: 0x000506A4
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNotNull<T>(T value) where T : class
		{
			Assert.IsNotNull<T>(value, null);
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x000524B0 File Offset: 0x000506B0
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNotNull<T>(T value, string message) where T : class
		{
			if (typeof(Object).IsAssignableFrom(typeof(T)))
			{
				Assert.IsNotNull(value as Object, message);
			}
			else if (value == null)
			{
				Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, false), message);
			}
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00052514 File Offset: 0x00050714
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNotNull(Object value, string message)
		{
			if (value == null)
			{
				Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, false), message);
			}
		}

		// Token: 0x04000EEC RID: 3820
		internal const string UNITY_ASSERTIONS = "UNITY_ASSERTIONS";

		// Token: 0x04000EED RID: 3821
		public static bool raiseExceptions;
	}
}
