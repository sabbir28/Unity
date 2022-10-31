using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000094 RID: 148
	[RequiredByNativeCode(Optional = true)]
	public struct NetworkViewID
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		public static NetworkViewID unassigned
		{
			get
			{
				NetworkViewID result;
				NetworkViewID.INTERNAL_get_unassigned(out result);
				return result;
			}
		}

		// Token: 0x06000A84 RID: 2692
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_unassigned(out NetworkViewID value);

		// Token: 0x06000A85 RID: 2693 RVA: 0x0000F308 File Offset: 0x0000D508
		internal static bool Internal_IsMine(NetworkViewID value)
		{
			return NetworkViewID.INTERNAL_CALL_Internal_IsMine(ref value);
		}

		// Token: 0x06000A86 RID: 2694
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_IsMine(ref NetworkViewID value);

		// Token: 0x06000A87 RID: 2695 RVA: 0x0000F324 File Offset: 0x0000D524
		internal static void Internal_GetOwner(NetworkViewID value, out NetworkPlayer player)
		{
			NetworkViewID.INTERNAL_CALL_Internal_GetOwner(ref value, out player);
		}

		// Token: 0x06000A88 RID: 2696
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetOwner(ref NetworkViewID value, out NetworkPlayer player);

		// Token: 0x06000A89 RID: 2697 RVA: 0x0000F330 File Offset: 0x0000D530
		internal static string Internal_GetString(NetworkViewID value)
		{
			return NetworkViewID.INTERNAL_CALL_Internal_GetString(ref value);
		}

		// Token: 0x06000A8A RID: 2698
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string INTERNAL_CALL_Internal_GetString(ref NetworkViewID value);

		// Token: 0x06000A8B RID: 2699 RVA: 0x0000F34C File Offset: 0x0000D54C
		internal static bool Internal_Compare(NetworkViewID lhs, NetworkViewID rhs)
		{
			return NetworkViewID.INTERNAL_CALL_Internal_Compare(ref lhs, ref rhs);
		}

		// Token: 0x06000A8C RID: 2700
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_Compare(ref NetworkViewID lhs, ref NetworkViewID rhs);

		// Token: 0x06000A8D RID: 2701 RVA: 0x0000F36C File Offset: 0x0000D56C
		public static bool operator ==(NetworkViewID lhs, NetworkViewID rhs)
		{
			return NetworkViewID.Internal_Compare(lhs, rhs);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0000F388 File Offset: 0x0000D588
		public static bool operator !=(NetworkViewID lhs, NetworkViewID rhs)
		{
			return !NetworkViewID.Internal_Compare(lhs, rhs);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		public override int GetHashCode()
		{
			return this.a ^ this.b ^ this.c;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0000F3D4 File Offset: 0x0000D5D4
		public override bool Equals(object other)
		{
			bool result;
			if (!(other is NetworkViewID))
			{
				result = false;
			}
			else
			{
				NetworkViewID rhs = (NetworkViewID)other;
				result = NetworkViewID.Internal_Compare(this, rhs);
			}
			return result;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0000F410 File Offset: 0x0000D610
		public bool isMine
		{
			get
			{
				return NetworkViewID.Internal_IsMine(this);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0000F430 File Offset: 0x0000D630
		public NetworkPlayer owner
		{
			get
			{
				NetworkPlayer result;
				NetworkViewID.Internal_GetOwner(this, out result);
				return result;
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0000F454 File Offset: 0x0000D654
		public override string ToString()
		{
			return NetworkViewID.Internal_GetString(this);
		}

		// Token: 0x04000141 RID: 321
		private int a;

		// Token: 0x04000142 RID: 322
		private int b;

		// Token: 0x04000143 RID: 323
		private int c;
	}
}
