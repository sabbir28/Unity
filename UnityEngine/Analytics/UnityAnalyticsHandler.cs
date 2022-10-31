using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	// Token: 0x020002C1 RID: 705
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class UnityAnalyticsHandler : IDisposable
	{
		// Token: 0x06002DD9 RID: 11737 RVA: 0x00042650 File Offset: 0x00040850
		public UnityAnalyticsHandler()
		{
			this.InternalCreate();
		}

		// Token: 0x06002DDA RID: 11738
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreate();

		// Token: 0x06002DDB RID: 11739
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalDestroy();

		// Token: 0x06002DDC RID: 11740 RVA: 0x00042660 File Offset: 0x00040860
		~UnityAnalyticsHandler()
		{
			this.InternalDestroy();
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x00042690 File Offset: 0x00040890
		public void Dispose()
		{
			this.InternalDestroy();
			GC.SuppressFinalize(this);
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002DDE RID: 11742
		// (set) Token: 0x06002DDF RID: 11743
		public static extern bool limitUserTracking { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002DE0 RID: 11744
		// (set) Token: 0x06002DE1 RID: 11745
		public static extern bool deviceStatsEnabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002DE2 RID: 11746
		// (set) Token: 0x06002DE3 RID: 11747
		public extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002DE4 RID: 11748
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnalyticsResult FlushEvents();

		// Token: 0x06002DE5 RID: 11749
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnalyticsResult SetUserId(string userId);

		// Token: 0x06002DE6 RID: 11750
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnalyticsResult SetUserGender(Gender gender);

		// Token: 0x06002DE7 RID: 11751
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnalyticsResult SetUserBirthYear(int birthYear);

		// Token: 0x06002DE8 RID: 11752
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnalyticsResult Transaction(string productId, double amount, string currency);

		// Token: 0x06002DE9 RID: 11753 RVA: 0x000426A0 File Offset: 0x000408A0
		public AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature)
		{
			return this.Transaction(productId, amount, currency, receiptPurchaseData, signature, false);
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x000426C4 File Offset: 0x000408C4
		internal AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
		{
			if (receiptPurchaseData == null)
			{
				receiptPurchaseData = string.Empty;
			}
			if (signature == null)
			{
				signature = string.Empty;
			}
			return this.InternalTransaction(productId, amount, currency, receiptPurchaseData, signature, usingIAPService);
		}

		// Token: 0x06002DEB RID: 11755
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnalyticsResult InternalTransaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);

		// Token: 0x06002DEC RID: 11756 RVA: 0x00042704 File Offset: 0x00040904
		public AnalyticsResult CustomEvent(string customEventName)
		{
			return this.SendCustomEventName(customEventName);
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x00042720 File Offset: 0x00040920
		public AnalyticsResult CustomEvent(CustomEventData eventData)
		{
			return this.SendCustomEvent(eventData);
		}

		// Token: 0x06002DEE RID: 11758
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnalyticsResult SendCustomEventName(string customEventName);

		// Token: 0x06002DEF RID: 11759
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern AnalyticsResult SendCustomEvent(CustomEventData eventData);

		// Token: 0x04000940 RID: 2368
		[NonSerialized]
		internal IntPtr m_Ptr;
	}
}
