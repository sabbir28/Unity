using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
	// Token: 0x020002C0 RID: 704
	public static class Analytics
	{
		// Token: 0x06002DC8 RID: 11720 RVA: 0x0004229C File Offset: 0x0004049C
		internal static UnityAnalyticsHandler GetUnityAnalyticsHandler()
		{
			if (Analytics.s_UnityAnalyticsHandler == null)
			{
				Analytics.s_UnityAnalyticsHandler = new UnityAnalyticsHandler();
			}
			return Analytics.s_UnityAnalyticsHandler;
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x000422CC File Offset: 0x000404CC
		// (set) Token: 0x06002DCA RID: 11722 RVA: 0x000422E8 File Offset: 0x000404E8
		public static bool limitUserTracking
		{
			get
			{
				return UnityAnalyticsHandler.limitUserTracking;
			}
			set
			{
				UnityAnalyticsHandler.limitUserTracking = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x000422F4 File Offset: 0x000404F4
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x00042310 File Offset: 0x00040510
		public static bool deviceStatsEnabled
		{
			get
			{
				return UnityAnalyticsHandler.deviceStatsEnabled;
			}
			set
			{
				UnityAnalyticsHandler.deviceStatsEnabled = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x0004231C File Offset: 0x0004051C
		// (set) Token: 0x06002DCE RID: 11726 RVA: 0x0004234C File Offset: 0x0004054C
		public static bool enabled
		{
			get
			{
				UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
				return unityAnalyticsHandler != null && unityAnalyticsHandler.enabled;
			}
			set
			{
				UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
				if (unityAnalyticsHandler != null)
				{
					unityAnalyticsHandler.enabled = value;
				}
			}
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00042370 File Offset: 0x00040570
		public static AnalyticsResult FlushEvents()
		{
			UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
			AnalyticsResult result;
			if (unityAnalyticsHandler == null)
			{
				result = AnalyticsResult.NotInitialized;
			}
			else
			{
				result = unityAnalyticsHandler.FlushEvents();
			}
			return result;
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x000423A0 File Offset: 0x000405A0
		public static AnalyticsResult SetUserId(string userId)
		{
			if (string.IsNullOrEmpty(userId))
			{
				throw new ArgumentException("Cannot set userId to an empty or null string");
			}
			UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
			AnalyticsResult result;
			if (unityAnalyticsHandler == null)
			{
				result = AnalyticsResult.NotInitialized;
			}
			else
			{
				result = unityAnalyticsHandler.SetUserId(userId);
			}
			return result;
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x000423E8 File Offset: 0x000405E8
		public static AnalyticsResult SetUserGender(Gender gender)
		{
			UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
			AnalyticsResult result;
			if (unityAnalyticsHandler == null)
			{
				result = AnalyticsResult.NotInitialized;
			}
			else
			{
				result = unityAnalyticsHandler.SetUserGender(gender);
			}
			return result;
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00042418 File Offset: 0x00040618
		public static AnalyticsResult SetUserBirthYear(int birthYear)
		{
			UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
			AnalyticsResult result;
			if (Analytics.s_UnityAnalyticsHandler == null)
			{
				result = AnalyticsResult.NotInitialized;
			}
			else
			{
				result = unityAnalyticsHandler.SetUserBirthYear(birthYear);
			}
			return result;
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x0004244C File Offset: 0x0004064C
		public static AnalyticsResult Transaction(string productId, decimal amount, string currency)
		{
			UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
			AnalyticsResult result;
			if (unityAnalyticsHandler == null)
			{
				result = AnalyticsResult.NotInitialized;
			}
			else
			{
				result = unityAnalyticsHandler.Transaction(productId, Convert.ToDouble(amount), currency, null, null);
			}
			return result;
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x00042484 File Offset: 0x00040684
		public static AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature)
		{
			UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
			AnalyticsResult result;
			if (unityAnalyticsHandler == null)
			{
				result = AnalyticsResult.NotInitialized;
			}
			else
			{
				result = unityAnalyticsHandler.Transaction(productId, Convert.ToDouble(amount), currency, receiptPurchaseData, signature);
			}
			return result;
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x000424C0 File Offset: 0x000406C0
		public static AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
		{
			UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
			AnalyticsResult result;
			if (unityAnalyticsHandler == null)
			{
				result = AnalyticsResult.NotInitialized;
			}
			else
			{
				result = unityAnalyticsHandler.Transaction(productId, Convert.ToDouble(amount), currency, receiptPurchaseData, signature, usingIAPService);
			}
			return result;
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x000424FC File Offset: 0x000406FC
		public static AnalyticsResult CustomEvent(string customEventName)
		{
			if (string.IsNullOrEmpty(customEventName))
			{
				throw new ArgumentException("Cannot set custom event name to an empty or null string");
			}
			UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
			AnalyticsResult result;
			if (unityAnalyticsHandler == null)
			{
				result = AnalyticsResult.NotInitialized;
			}
			else
			{
				result = unityAnalyticsHandler.CustomEvent(customEventName);
			}
			return result;
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00042544 File Offset: 0x00040744
		public static AnalyticsResult CustomEvent(string customEventName, Vector3 position)
		{
			if (string.IsNullOrEmpty(customEventName))
			{
				throw new ArgumentException("Cannot set custom event name to an empty or null string");
			}
			UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
			AnalyticsResult result;
			if (unityAnalyticsHandler == null)
			{
				result = AnalyticsResult.NotInitialized;
			}
			else
			{
				CustomEventData customEventData = new CustomEventData(customEventName);
				customEventData.Add("x", (double)Convert.ToDecimal(position.x));
				customEventData.Add("y", (double)Convert.ToDecimal(position.y));
				customEventData.Add("z", (double)Convert.ToDecimal(position.z));
				result = unityAnalyticsHandler.CustomEvent(customEventData);
			}
			return result;
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x000425E8 File Offset: 0x000407E8
		public static AnalyticsResult CustomEvent(string customEventName, IDictionary<string, object> eventData)
		{
			if (string.IsNullOrEmpty(customEventName))
			{
				throw new ArgumentException("Cannot set custom event name to an empty or null string");
			}
			UnityAnalyticsHandler unityAnalyticsHandler = Analytics.GetUnityAnalyticsHandler();
			AnalyticsResult result;
			if (unityAnalyticsHandler == null)
			{
				result = AnalyticsResult.NotInitialized;
			}
			else if (eventData == null)
			{
				result = unityAnalyticsHandler.CustomEvent(customEventName);
			}
			else
			{
				CustomEventData customEventData = new CustomEventData(customEventName);
				customEventData.Add(eventData);
				result = unityAnalyticsHandler.CustomEvent(customEventData);
			}
			return result;
		}

		// Token: 0x0400093F RID: 2367
		private static UnityAnalyticsHandler s_UnityAnalyticsHandler;
	}
}
