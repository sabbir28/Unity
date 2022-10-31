using System;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000026 RID: 38
	public class BaseInput : UIBehaviour
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00003CA8 File Offset: 0x000020A8
		public virtual string compositionString
		{
			get
			{
				return Input.compositionString;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00003CC4 File Offset: 0x000020C4
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00003CDE File Offset: 0x000020DE
		public virtual IMECompositionMode imeCompositionMode
		{
			get
			{
				return Input.imeCompositionMode;
			}
			set
			{
				Input.imeCompositionMode = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00003CE8 File Offset: 0x000020E8
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00003D02 File Offset: 0x00002102
		public virtual Vector2 compositionCursorPos
		{
			get
			{
				return Input.compositionCursorPos;
			}
			set
			{
				Input.compositionCursorPos = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00003D0C File Offset: 0x0000210C
		public virtual bool mousePresent
		{
			get
			{
				return Input.mousePresent;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003D28 File Offset: 0x00002128
		public virtual bool GetMouseButtonDown(int button)
		{
			return Input.GetMouseButtonDown(button);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003D44 File Offset: 0x00002144
		public virtual bool GetMouseButtonUp(int button)
		{
			return Input.GetMouseButtonUp(button);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003D60 File Offset: 0x00002160
		public virtual bool GetMouseButton(int button)
		{
			return Input.GetMouseButton(button);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003D7C File Offset: 0x0000217C
		public virtual Vector2 mousePosition
		{
			get
			{
				return Input.mousePosition;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00003D9C File Offset: 0x0000219C
		public virtual Vector2 mouseScrollDelta
		{
			get
			{
				return Input.mouseScrollDelta;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003DB8 File Offset: 0x000021B8
		public virtual bool touchSupported
		{
			get
			{
				return Input.touchSupported;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00003DD4 File Offset: 0x000021D4
		public virtual int touchCount
		{
			get
			{
				return Input.touchCount;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003DF0 File Offset: 0x000021F0
		public virtual Touch GetTouch(int index)
		{
			return Input.GetTouch(index);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003E0C File Offset: 0x0000220C
		public virtual float GetAxisRaw(string axisName)
		{
			return Input.GetAxisRaw(axisName);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00003E28 File Offset: 0x00002228
		public virtual bool GetButtonDown(string buttonName)
		{
			return Input.GetButtonDown(buttonName);
		}
	}
}
