using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Director
{
	// Token: 0x0200021F RID: 543
	[RequiredByNativeCode]
	internal sealed class AnimationOffsetPlayable : AnimationPlayable
	{
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x0002A10C File Offset: 0x0002830C
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x0002A12C File Offset: 0x0002832C
		public Vector3 position
		{
			get
			{
				return AnimationOffsetPlayable.GetPosition(ref this.handle);
			}
			set
			{
				AnimationOffsetPlayable.SetPosition(ref this.handle, value);
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x0002A13C File Offset: 0x0002833C
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x0002A15C File Offset: 0x0002835C
		public Quaternion rotation
		{
			get
			{
				return AnimationOffsetPlayable.GetRotation(ref this.handle);
			}
			set
			{
				AnimationOffsetPlayable.SetRotation(ref this.handle, value);
			}
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0002A16C File Offset: 0x0002836C
		private static Vector3 GetPosition(ref PlayableHandle handle)
		{
			Vector3 result;
			AnimationOffsetPlayable.INTERNAL_CALL_GetPosition(ref handle, out result);
			return result;
		}

		// Token: 0x060024A8 RID: 9384
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetPosition(ref PlayableHandle handle, out Vector3 value);

		// Token: 0x060024A9 RID: 9385 RVA: 0x0002A18C File Offset: 0x0002838C
		private static void SetPosition(ref PlayableHandle handle, Vector3 value)
		{
			AnimationOffsetPlayable.INTERNAL_CALL_SetPosition(ref handle, ref value);
		}

		// Token: 0x060024AA RID: 9386
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetPosition(ref PlayableHandle handle, ref Vector3 value);

		// Token: 0x060024AB RID: 9387 RVA: 0x0002A198 File Offset: 0x00028398
		private static Quaternion GetRotation(ref PlayableHandle handle)
		{
			Quaternion result;
			AnimationOffsetPlayable.INTERNAL_CALL_GetRotation(ref handle, out result);
			return result;
		}

		// Token: 0x060024AC RID: 9388
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetRotation(ref PlayableHandle handle, out Quaternion value);

		// Token: 0x060024AD RID: 9389 RVA: 0x0002A1B8 File Offset: 0x000283B8
		private static void SetRotation(ref PlayableHandle handle, Quaternion value)
		{
			AnimationOffsetPlayable.INTERNAL_CALL_SetRotation(ref handle, ref value);
		}

		// Token: 0x060024AE RID: 9390
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetRotation(ref PlayableHandle handle, ref Quaternion value);
	}
}
