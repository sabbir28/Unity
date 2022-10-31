using System;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000033 RID: 51
	internal struct ColorTween : ITweenValue
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00006584 File Offset: 0x00004984
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0000659F File Offset: 0x0000499F
		public Color startColor
		{
			get
			{
				return this.m_StartColor;
			}
			set
			{
				this.m_StartColor = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000065AC File Offset: 0x000049AC
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000065C7 File Offset: 0x000049C7
		public Color targetColor
		{
			get
			{
				return this.m_TargetColor;
			}
			set
			{
				this.m_TargetColor = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000065D4 File Offset: 0x000049D4
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000065EF File Offset: 0x000049EF
		public ColorTween.ColorTweenMode tweenMode
		{
			get
			{
				return this.m_TweenMode;
			}
			set
			{
				this.m_TweenMode = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000065FC File Offset: 0x000049FC
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00006617 File Offset: 0x00004A17
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00006624 File Offset: 0x00004A24
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0000663F File Offset: 0x00004A3F
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

		// Token: 0x0600015D RID: 349 RVA: 0x0000664C File Offset: 0x00004A4C
		public void TweenValue(float floatPercentage)
		{
			if (this.ValidTarget())
			{
				Color arg = Color.Lerp(this.m_StartColor, this.m_TargetColor, floatPercentage);
				if (this.m_TweenMode == ColorTween.ColorTweenMode.Alpha)
				{
					arg.r = this.m_StartColor.r;
					arg.g = this.m_StartColor.g;
					arg.b = this.m_StartColor.b;
				}
				else if (this.m_TweenMode == ColorTween.ColorTweenMode.RGB)
				{
					arg.a = this.m_StartColor.a;
				}
				this.m_Target.Invoke(arg);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000066F2 File Offset: 0x00004AF2
		public void AddOnChangedCallback(UnityAction<Color> callback)
		{
			if (this.m_Target == null)
			{
				this.m_Target = new ColorTween.ColorTweenCallback();
			}
			this.m_Target.AddListener(callback);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00006718 File Offset: 0x00004B18
		public bool GetIgnoreTimescale()
		{
			return this.m_IgnoreTimeScale;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00006734 File Offset: 0x00004B34
		public float GetDuration()
		{
			return this.m_Duration;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00006750 File Offset: 0x00004B50
		public bool ValidTarget()
		{
			return this.m_Target != null;
		}

		// Token: 0x040000A5 RID: 165
		private ColorTween.ColorTweenCallback m_Target;

		// Token: 0x040000A6 RID: 166
		private Color m_StartColor;

		// Token: 0x040000A7 RID: 167
		private Color m_TargetColor;

		// Token: 0x040000A8 RID: 168
		private ColorTween.ColorTweenMode m_TweenMode;

		// Token: 0x040000A9 RID: 169
		private float m_Duration;

		// Token: 0x040000AA RID: 170
		private bool m_IgnoreTimeScale;

		// Token: 0x02000034 RID: 52
		public enum ColorTweenMode
		{
			// Token: 0x040000AC RID: 172
			All,
			// Token: 0x040000AD RID: 173
			RGB,
			// Token: 0x040000AE RID: 174
			Alpha
		}

		// Token: 0x02000035 RID: 53
		public class ColorTweenCallback : UnityEvent<Color>
		{
		}
	}
}
