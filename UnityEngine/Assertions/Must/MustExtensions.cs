using System;
using System.Diagnostics;

namespace UnityEngine.Assertions.Must
{
	// Token: 0x020003FD RID: 1021
	[DebuggerStepThrough]
	[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
	public static class MustExtensions
	{
		// Token: 0x0600341E RID: 13342 RVA: 0x00052844 File Offset: 0x00050A44
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustBeTrue(this bool value)
		{
			Assert.IsTrue(value);
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x00052850 File Offset: 0x00050A50
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustBeTrue(this bool value, string message)
		{
			Assert.IsTrue(value, message);
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x0005285C File Offset: 0x00050A5C
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustBeFalse(this bool value)
		{
			Assert.IsFalse(value);
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00052868 File Offset: 0x00050A68
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustBeFalse(this bool value, string message)
		{
			Assert.IsFalse(value, message);
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x00052874 File Offset: 0x00050A74
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustBeApproximatelyEqual(this float actual, float expected)
		{
			Assert.AreApproximatelyEqual(actual, expected);
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00052880 File Offset: 0x00050A80
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustBeApproximatelyEqual(this float actual, float expected, string message)
		{
			Assert.AreApproximatelyEqual(actual, expected, message);
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x0005288C File Offset: 0x00050A8C
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeApproximatelyEqual(this float actual, float expected, float tolerance)
		{
			Assert.AreApproximatelyEqual(actual, expected, tolerance);
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00052898 File Offset: 0x00050A98
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustBeApproximatelyEqual(this float actual, float expected, float tolerance, string message)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, message);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x000528A4 File Offset: 0x00050AA4
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustNotBeApproximatelyEqual(this float actual, float expected)
		{
			Assert.AreNotApproximatelyEqual(expected, actual);
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x000528B0 File Offset: 0x00050AB0
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustNotBeApproximatelyEqual(this float actual, float expected, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, message);
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x000528BC File Offset: 0x00050ABC
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustNotBeApproximatelyEqual(this float actual, float expected, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance);
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x000528C8 File Offset: 0x00050AC8
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustNotBeApproximatelyEqual(this float actual, float expected, float tolerance, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, message);
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x000528D4 File Offset: 0x00050AD4
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustBeEqual<T>(this T actual, T expected)
		{
			Assert.AreEqual<T>(actual, expected);
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x000528E0 File Offset: 0x00050AE0
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustBeEqual<T>(this T actual, T expected, string message)
		{
			Assert.AreEqual<T>(expected, actual, message);
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x000528EC File Offset: 0x00050AEC
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustNotBeEqual<T>(this T actual, T expected)
		{
			Assert.AreNotEqual<T>(actual, expected);
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x000528F8 File Offset: 0x00050AF8
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustNotBeEqual<T>(this T actual, T expected, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message);
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x00052904 File Offset: 0x00050B04
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustBeNull<T>(this T expected) where T : class
		{
			Assert.IsNull<T>(expected);
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x00052910 File Offset: 0x00050B10
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustBeNull<T>(this T expected, string message) where T : class
		{
			Assert.IsNull<T>(expected, message);
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x0005291C File Offset: 0x00050B1C
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustNotBeNull<T>(this T expected) where T : class
		{
			Assert.IsNotNull<T>(expected);
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x00052928 File Offset: 0x00050B28
		[Conditional("UNITY_ASSERTIONS")]
		[Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
		public static void MustNotBeNull<T>(this T expected, string message) where T : class
		{
			Assert.IsNotNull<T>(expected, message);
		}
	}
}
