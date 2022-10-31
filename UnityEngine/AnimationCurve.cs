using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000084 RID: 132
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class AnimationCurve
	{
		// Token: 0x060009B5 RID: 2485 RVA: 0x0000E420 File Offset: 0x0000C620
		public AnimationCurve(params Keyframe[] keys)
		{
			this.Init(keys);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0000E430 File Offset: 0x0000C630
		[RequiredByNativeCode]
		public AnimationCurve()
		{
			this.Init(null);
		}

		// Token: 0x060009B7 RID: 2487
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		// Token: 0x060009B8 RID: 2488 RVA: 0x0000E440 File Offset: 0x0000C640
		~AnimationCurve()
		{
			this.Cleanup();
		}

		// Token: 0x060009B9 RID: 2489
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float Evaluate(float time);

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0000E470 File Offset: 0x0000C670
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x0000E48C File Offset: 0x0000C68C
		public Keyframe[] keys
		{
			get
			{
				return this.GetKeys();
			}
			set
			{
				this.SetKeys(value);
			}
		}

		// Token: 0x060009BC RID: 2492
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int AddKey(float time, float value);

		// Token: 0x060009BD RID: 2493 RVA: 0x0000E498 File Offset: 0x0000C698
		public int AddKey(Keyframe key)
		{
			return this.AddKey_Internal(key);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0000E4B4 File Offset: 0x0000C6B4
		private int AddKey_Internal(Keyframe key)
		{
			return AnimationCurve.INTERNAL_CALL_AddKey_Internal(this, ref key);
		}

		// Token: 0x060009BF RID: 2495
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_AddKey_Internal(AnimationCurve self, ref Keyframe key);

		// Token: 0x060009C0 RID: 2496 RVA: 0x0000E4D4 File Offset: 0x0000C6D4
		public int MoveKey(int index, Keyframe key)
		{
			return AnimationCurve.INTERNAL_CALL_MoveKey(this, index, ref key);
		}

		// Token: 0x060009C1 RID: 2497
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_MoveKey(AnimationCurve self, int index, ref Keyframe key);

		// Token: 0x060009C2 RID: 2498
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveKey(int index);

		// Token: 0x17000241 RID: 577
		public Keyframe this[int index]
		{
			get
			{
				return this.GetKey_Internal(index);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060009C4 RID: 2500
		public extern int length { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060009C5 RID: 2501
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetKeys(Keyframe[] keys);

		// Token: 0x060009C6 RID: 2502 RVA: 0x0000E510 File Offset: 0x0000C710
		private Keyframe GetKey_Internal(int index)
		{
			Keyframe result;
			AnimationCurve.INTERNAL_CALL_GetKey_Internal(this, index, out result);
			return result;
		}

		// Token: 0x060009C7 RID: 2503
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetKey_Internal(AnimationCurve self, int index, out Keyframe value);

		// Token: 0x060009C8 RID: 2504
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Keyframe[] GetKeys();

		// Token: 0x060009C9 RID: 2505
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SmoothTangents(int index, float weight);

		// Token: 0x060009CA RID: 2506 RVA: 0x0000E530 File Offset: 0x0000C730
		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			float num = (valueEnd - valueStart) / (timeEnd - timeStart);
			Keyframe[] keys = new Keyframe[]
			{
				new Keyframe(timeStart, valueStart, 0f, num),
				new Keyframe(timeEnd, valueEnd, num, 0f)
			};
			return new AnimationCurve(keys);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0000E58C File Offset: 0x0000C78C
		public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			Keyframe[] keys = new Keyframe[]
			{
				new Keyframe(timeStart, valueStart, 0f, 0f),
				new Keyframe(timeEnd, valueEnd, 0f, 0f)
			};
			return new AnimationCurve(keys);
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060009CC RID: 2508
		// (set) Token: 0x060009CD RID: 2509
		public extern WrapMode preWrapMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060009CE RID: 2510
		// (set) Token: 0x060009CF RID: 2511
		public extern WrapMode postWrapMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060009D0 RID: 2512
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init(Keyframe[] keys);

		// Token: 0x040000FB RID: 251
		internal IntPtr m_Ptr;
	}
}
