using System;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000036 RID: 54
	internal struct FloatTween : ITweenValue
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000677C File Offset: 0x00004B7C
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00006797 File Offset: 0x00004B97
		public float startValue
		{
			get
			{
				return this.m_StartValue;
			}
			set
			{
				this.m_StartValue = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000067A4 File Offset: 0x00004BA4
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000067BF File Offset: 0x00004BBF
		public float targetValue
		{
			get
			{
				return this.m_TargetValue;
			}
			set
			{
				this.m_TargetValue = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000067CC File Offset: 0x00004BCC
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000067E7 File Offset: 0x00004BE7
		public float duration
		{
			get
			{
				return this.m_Duration;
			}
			set
			{
				this.m_Duration = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000067F4 File Offset: 0x00004BF4
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0000680F File Offset: 0x00004C0F
		public bool ignoreTimeScale
		{
			get
			{
				return this.m_IgnoreTimeScale;
			}
			set
			{
				this.m_IgnoreTimeScale = value;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000681C File Offset: 0x00004C1C
		public void TweenValue(float floatPercentage)
		{
			if (this.ValidTarget())
			{
				float arg = Mathf.Lerp(this.m_StartValue, this.m_TargetValue, floatPercentage);
				this.m_Target.Invoke(arg);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00006859 File Offset: 0x00004C59
		public void AddOnChangedCallback(UnityAction<float> callback)
		{
			if (this.m_Target == null)
			{
				this.m_Target = new FloatTween.FloatTweenCallback();
			}
			this.m_Target.AddListener(callback);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00006880 File Offset: 0x00004C80
		public bool GetIgnoreTimescale()
		{
			return this.m_IgnoreTimeScale;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000689C File Offset: 0x00004C9C
		public float GetDuration()
		{
			return this.m_Duration;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000068B8 File Offset: 0x00004CB8
		public bool ValidTarget()
		{
			return this.m_Target != null;
		}

		// Token: 0x040000AF RID: 175
		private FloatTween.FloatTweenCallback m_Target;

		// Token: 0x040000B0 RID: 176
		private float m_StartValue;

		// Token: 0x040000B1 RID: 177
		private float m_TargetValue;

		// Token: 0x040000B2 RID: 178
		private float m_Duration;

		// Token: 0x040000B3 RID: 179
		private bool m_IgnoreTimeScale;

		// Token: 0x02000037 RID: 55
		public class FloatTweenCallback : UnityEvent<float>
		{
		}
	}
}
