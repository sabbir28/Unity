using System;
using System.Collections;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000038 RID: 56
	internal class TweenRunner<T> where T : struct, ITweenValue
	{
		// Token: 0x06000172 RID: 370 RVA: 0x000068EC File Offset: 0x00004CEC
		private static IEnumerator Start(T tweenInfo)
		{
			if (!tweenInfo.ValidTarget())
			{
				yield break;
			}
			float elapsedTime = 0f;
			while (elapsedTime < tweenInfo.duration)
			{
				elapsedTime += ((!tweenInfo.ignoreTimeScale) ? Time.deltaTime : Time.unscaledDeltaTime);
				float percentage = Mathf.Clamp01(elapsedTime / tweenInfo.duration);
				tweenInfo.TweenValue(percentage);
				yield return null;
			}
			tweenInfo.TweenValue(1f);
			yield break;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000690E File Offset: 0x00004D0E
		public void Init(MonoBehaviour coroutineContainer)
		{
			this.m_CoroutineContainer = coroutineContainer;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006918 File Offset: 0x00004D18
		public void StartTween(T info)
		{
			if (this.m_CoroutineContainer == null)
			{
				Debug.LogWarning("Coroutine container not configured... did you forget to call Init?");
			}
			else
			{
				this.StopTween();
				if (!this.m_CoroutineContainer.gameObject.activeInHierarchy)
				{
					info.TweenValue(1f);
				}
				else
				{
					this.m_Tween = TweenRunner<T>.Start(info);
					this.m_CoroutineContainer.StartCoroutine(this.m_Tween);
				}
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00006998 File Offset: 0x00004D98
		public void StopTween()
		{
			if (this.m_Tween != null)
			{
				this.m_CoroutineContainer.StopCoroutine(this.m_Tween);
				this.m_Tween = null;
			}
		}

		// Token: 0x040000B4 RID: 180
		protected MonoBehaviour m_CoroutineContainer;

		// Token: 0x040000B5 RID: 181
		protected IEnumerator m_Tween;
	}
}
