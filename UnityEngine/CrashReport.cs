using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200002B RID: 43
	public sealed class CrashReport
	{
		// Token: 0x0600036D RID: 877 RVA: 0x00005FC0 File Offset: 0x000041C0
		private CrashReport(string id, DateTime time, string text)
		{
			this.id = id;
			this.time = time;
			this.text = text;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00005FE0 File Offset: 0x000041E0
		private static int Compare(CrashReport c1, CrashReport c2)
		{
			long ticks = c1.time.Ticks;
			long ticks2 = c2.time.Ticks;
			int result;
			if (ticks > ticks2)
			{
				result = 1;
			}
			else if (ticks < ticks2)
			{
				result = -1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00006034 File Offset: 0x00004234
		private static void PopulateReports()
		{
			object obj = CrashReport.reportsLock;
			lock (obj)
			{
				if (CrashReport.internalReports == null)
				{
					string[] reports = CrashReport.GetReports();
					CrashReport.internalReports = new List<CrashReport>(reports.Length);
					foreach (string text in reports)
					{
						double value;
						string reportData = CrashReport.GetReportData(text, out value);
						DateTime dateTime = new DateTime(1970, 1, 1);
						DateTime dateTime2 = dateTime.AddSeconds(value);
						CrashReport.internalReports.Add(new CrashReport(text, dateTime2, reportData));
					}
					List<CrashReport> list = CrashReport.internalReports;
					if (CrashReport.<>f__mg$cache0 == null)
					{
						CrashReport.<>f__mg$cache0 = new Comparison<CrashReport>(CrashReport.Compare);
					}
					list.Sort(CrashReport.<>f__mg$cache0);
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00006110 File Offset: 0x00004310
		public static CrashReport[] reports
		{
			get
			{
				CrashReport.PopulateReports();
				object obj = CrashReport.reportsLock;
				CrashReport[] result;
				lock (obj)
				{
					result = CrashReport.internalReports.ToArray();
				}
				return result;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00006158 File Offset: 0x00004358
		public static CrashReport lastReport
		{
			get
			{
				CrashReport.PopulateReports();
				object obj = CrashReport.reportsLock;
				lock (obj)
				{
					if (CrashReport.internalReports.Count > 0)
					{
						return CrashReport.internalReports[CrashReport.internalReports.Count - 1];
					}
				}
				return null;
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000061CC File Offset: 0x000043CC
		public static void RemoveAll()
		{
			foreach (CrashReport crashReport in CrashReport.reports)
			{
				crashReport.Remove();
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00006200 File Offset: 0x00004400
		public void Remove()
		{
			if (CrashReport.RemoveReport(this.id))
			{
				object obj = CrashReport.reportsLock;
				lock (obj)
				{
					CrashReport.internalReports.Remove(this);
				}
			}
		}

		// Token: 0x06000374 RID: 884
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string[] GetReports();

		// Token: 0x06000375 RID: 885
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetReportData(string id, out double secondsSinceUnixEpoch);

		// Token: 0x06000376 RID: 886
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool RemoveReport(string id);

		// Token: 0x0400003B RID: 59
		private static List<CrashReport> internalReports;

		// Token: 0x0400003C RID: 60
		private static object reportsLock = new object();

		// Token: 0x0400003D RID: 61
		private readonly string id;

		// Token: 0x0400003E RID: 62
		public readonly DateTime time;

		// Token: 0x0400003F RID: 63
		public readonly string text;

		// Token: 0x04000040 RID: 64
		[CompilerGenerated]
		private static Comparison<CrashReport> <>f__mg$cache0;
	}
}
