using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200008A RID: 138
	[RequiredByNativeCode]
	public class MonoBehaviour : Behaviour
	{
		// Token: 0x06000A57 RID: 2647
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern MonoBehaviour();

		// Token: 0x06000A58 RID: 2648
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_CancelInvokeAll();

		// Token: 0x06000A59 RID: 2649
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_IsInvokingAll();

		// Token: 0x06000A5A RID: 2650
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Invoke(string methodName, float time);

		// Token: 0x06000A5B RID: 2651
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InvokeRepeating(string methodName, float time, float repeatRate);

		// Token: 0x06000A5C RID: 2652 RVA: 0x0000F044 File Offset: 0x0000D244
		public void CancelInvoke()
		{
			this.Internal_CancelInvokeAll();
		}

		// Token: 0x06000A5D RID: 2653
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CancelInvoke(string methodName);

		// Token: 0x06000A5E RID: 2654
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsInvoking(string methodName);

		// Token: 0x06000A5F RID: 2655 RVA: 0x0000F050 File Offset: 0x0000D250
		public bool IsInvoking()
		{
			return this.Internal_IsInvokingAll();
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0000F06C File Offset: 0x0000D26C
		public Coroutine StartCoroutine(IEnumerator routine)
		{
			return this.StartCoroutine_Auto_Internal(routine);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0000F088 File Offset: 0x0000D288
		[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", false)]
		public Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return this.StartCoroutine(routine);
		}

		// Token: 0x06000A62 RID: 2658
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Coroutine StartCoroutine_Auto_Internal(IEnumerator routine);

		// Token: 0x06000A63 RID: 2659
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value);

		// Token: 0x06000A64 RID: 2660 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		[ExcludeFromDocs]
		public Coroutine StartCoroutine(string methodName)
		{
			object value = null;
			return this.StartCoroutine(methodName, value);
		}

		// Token: 0x06000A65 RID: 2661
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StopCoroutine(string methodName);

		// Token: 0x06000A66 RID: 2662 RVA: 0x0000F0C4 File Offset: 0x0000D2C4
		public void StopCoroutine(IEnumerator routine)
		{
			this.StopCoroutineViaEnumerator_Auto(routine);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0000F0D0 File Offset: 0x0000D2D0
		public void StopCoroutine(Coroutine routine)
		{
			this.StopCoroutine_Auto(routine);
		}

		// Token: 0x06000A68 RID: 2664
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void StopCoroutineViaEnumerator_Auto(IEnumerator routine);

		// Token: 0x06000A69 RID: 2665
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void StopCoroutine_Auto(Coroutine routine);

		// Token: 0x06000A6A RID: 2666
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StopAllCoroutines();

		// Token: 0x06000A6B RID: 2667 RVA: 0x0000F0DC File Offset: 0x0000D2DC
		public static void print(object message)
		{
			Debug.Log(message);
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A6C RID: 2668
		// (set) Token: 0x06000A6D RID: 2669
		public extern bool useGUILayout { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
