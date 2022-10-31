using System;

namespace UnityEngine.Assertions
{
	// Token: 0x020003FB RID: 1019
	internal class AssertionMessageUtil
	{
		// Token: 0x06003410 RID: 13328 RVA: 0x00052588 File Offset: 0x00050788
		public static string GetMessage(string failureMessage)
		{
			return UnityString.Format("{0} {1}", new object[]
			{
				"Assertion failed.",
				failureMessage
			});
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x000525BC File Offset: 0x000507BC
		public static string GetMessage(string failureMessage, string expected)
		{
			return AssertionMessageUtil.GetMessage(UnityString.Format("{0}{1}{2} {3}", new object[]
			{
				failureMessage,
				Environment.NewLine,
				"Expected:",
				expected
			}));
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x00052600 File Offset: 0x00050800
		public static string GetEqualityMessage(object actual, object expected, bool expectEqual)
		{
			return AssertionMessageUtil.GetMessage(UnityString.Format("Values are {0}equal.", new object[]
			{
				(!expectEqual) ? "" : "not "
			}), UnityString.Format("{0} {2} {1}", new object[]
			{
				actual,
				expected,
				(!expectEqual) ? "!=" : "=="
			}));
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x00052674 File Offset: 0x00050874
		public static string NullFailureMessage(object value, bool expectNull)
		{
			return AssertionMessageUtil.GetMessage(UnityString.Format("Value was {0}Null", new object[]
			{
				(!expectNull) ? "" : "not "
			}), UnityString.Format("Value was {0}Null", new object[]
			{
				(!expectNull) ? "not " : ""
			}));
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x000526E0 File Offset: 0x000508E0
		public static string BooleanFailureMessage(bool expected)
		{
			return AssertionMessageUtil.GetMessage("Value was " + !expected, expected.ToString());
		}

		// Token: 0x04000EEF RID: 3823
		private const string k_Expected = "Expected:";

		// Token: 0x04000EF0 RID: 3824
		private const string k_AssertionFailed = "Assertion failed.";
	}
}
