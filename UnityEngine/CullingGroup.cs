using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200002F RID: 47
	[StructLayout(LayoutKind.Sequential)]
	public sealed class CullingGroup : IDisposable
	{
		// Token: 0x06000381 RID: 897 RVA: 0x000063AC File Offset: 0x000045AC
		public CullingGroup()
		{
			this.Init();
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000063C4 File Offset: 0x000045C4
		~CullingGroup()
		{
			if (this.m_Ptr != IntPtr.Zero)
			{
				this.FinalizerFailure();
			}
		}

		// Token: 0x06000383 RID: 899
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Dispose();

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000640C File Offset: 0x0000460C
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00006428 File Offset: 0x00004628
		public CullingGroup.StateChanged onStateChanged
		{
			get
			{
				return this.m_OnStateChanged;
			}
			set
			{
				this.m_OnStateChanged = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000386 RID: 902
		// (set) Token: 0x06000387 RID: 903
		public extern bool enabled { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000388 RID: 904
		// (set) Token: 0x06000389 RID: 905
		public extern Camera targetCamera { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600038A RID: 906
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetBoundingSpheres(BoundingSphere[] array);

		// Token: 0x0600038B RID: 907
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetBoundingSphereCount(int count);

		// Token: 0x0600038C RID: 908
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void EraseSwapBack(int index);

		// Token: 0x0600038D RID: 909 RVA: 0x00006434 File Offset: 0x00004634
		public static void EraseSwapBack<T>(int index, T[] myArray, ref int size)
		{
			size--;
			myArray[index] = myArray[size];
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000644C File Offset: 0x0000464C
		public int QueryIndices(bool visible, int[] result, int firstIndex)
		{
			return this.QueryIndices(visible, -1, CullingQueryOptions.IgnoreDistance, result, firstIndex);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000646C File Offset: 0x0000466C
		public int QueryIndices(int distanceIndex, int[] result, int firstIndex)
		{
			return this.QueryIndices(false, distanceIndex, CullingQueryOptions.IgnoreVisibility, result, firstIndex);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000648C File Offset: 0x0000468C
		public int QueryIndices(bool visible, int distanceIndex, int[] result, int firstIndex)
		{
			return this.QueryIndices(visible, distanceIndex, CullingQueryOptions.Normal, result, firstIndex);
		}

		// Token: 0x06000391 RID: 913
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, int[] result, int firstIndex);

		// Token: 0x06000392 RID: 914
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsVisible(int index);

		// Token: 0x06000393 RID: 915
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetDistance(int index);

		// Token: 0x06000394 RID: 916
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetBoundingDistances(float[] distances);

		// Token: 0x06000395 RID: 917 RVA: 0x000064B0 File Offset: 0x000046B0
		public void SetDistanceReferencePoint(Vector3 point)
		{
			CullingGroup.INTERNAL_CALL_SetDistanceReferencePoint(this, ref point);
		}

		// Token: 0x06000396 RID: 918
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetDistanceReferencePoint(CullingGroup self, ref Vector3 point);

		// Token: 0x06000397 RID: 919
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetDistanceReferencePoint(Transform transform);

		// Token: 0x06000398 RID: 920 RVA: 0x000064BC File Offset: 0x000046BC
		[SecuritySafeCritical]
		[RequiredByNativeCode]
		private unsafe static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
		{
			CullingGroupEvent* ptr = (CullingGroupEvent*)eventsPtr.ToPointer();
			if (cullingGroup.m_OnStateChanged != null)
			{
				for (int i = 0; i < count; i++)
				{
					cullingGroup.m_OnStateChanged(ptr[i]);
				}
			}
		}

		// Token: 0x06000399 RID: 921
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x0600039A RID: 922
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void FinalizerFailure();

		// Token: 0x0400004C RID: 76
		internal IntPtr m_Ptr;

		// Token: 0x0400004D RID: 77
		private CullingGroup.StateChanged m_OnStateChanged = null;

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600039C RID: 924
		public delegate void StateChanged(CullingGroupEvent sphere);
	}
}
