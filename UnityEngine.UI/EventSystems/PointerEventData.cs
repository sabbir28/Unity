using System;
using System.Collections.Generic;
using System.Text;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000023 RID: 35
	public class PointerEventData : BaseEventData
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00003704 File Offset: 0x00001B04
		public PointerEventData(EventSystem eventSystem) : base(eventSystem)
		{
			this.eligibleForClick = false;
			this.pointerId = -1;
			this.position = Vector2.zero;
			this.delta = Vector2.zero;
			this.pressPosition = Vector2.zero;
			this.clickTime = 0f;
			this.clickCount = 0;
			this.scrollDelta = Vector2.zero;
			this.useDragThreshold = true;
			this.dragging = false;
			this.button = PointerEventData.InputButton.Left;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00003788 File Offset: 0x00001B88
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000037A2 File Offset: 0x00001BA2
		public GameObject pointerEnter { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000037AC File Offset: 0x00001BAC
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000037C6 File Offset: 0x00001BC6
		public GameObject lastPress { get; private set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000037D0 File Offset: 0x00001BD0
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000037EA File Offset: 0x00001BEA
		public GameObject rawPointerPress { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000037F4 File Offset: 0x00001BF4
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000380E File Offset: 0x00001C0E
		public GameObject pointerDrag { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003818 File Offset: 0x00001C18
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00003832 File Offset: 0x00001C32
		public RaycastResult pointerCurrentRaycast { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000383C File Offset: 0x00001C3C
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00003856 File Offset: 0x00001C56
		public RaycastResult pointerPressRaycast { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003860 File Offset: 0x00001C60
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000387A File Offset: 0x00001C7A
		public bool eligibleForClick { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00003884 File Offset: 0x00001C84
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000389E File Offset: 0x00001C9E
		public int pointerId { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000038A8 File Offset: 0x00001CA8
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000038C2 File Offset: 0x00001CC2
		public Vector2 position { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000038CC File Offset: 0x00001CCC
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000038E6 File Offset: 0x00001CE6
		public Vector2 delta { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000038F0 File Offset: 0x00001CF0
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000390A File Offset: 0x00001D0A
		public Vector2 pressPosition { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00003914 File Offset: 0x00001D14
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000392E File Offset: 0x00001D2E
		[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
		public Vector3 worldPosition { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00003938 File Offset: 0x00001D38
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00003952 File Offset: 0x00001D52
		[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
		public Vector3 worldNormal { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000395C File Offset: 0x00001D5C
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00003976 File Offset: 0x00001D76
		public float clickTime { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00003980 File Offset: 0x00001D80
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000399A File Offset: 0x00001D9A
		public int clickCount { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000039A4 File Offset: 0x00001DA4
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000039BE File Offset: 0x00001DBE
		public Vector2 scrollDelta { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000039C8 File Offset: 0x00001DC8
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000039E2 File Offset: 0x00001DE2
		public bool useDragThreshold { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000039EC File Offset: 0x00001DEC
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00003A06 File Offset: 0x00001E06
		public bool dragging { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00003A10 File Offset: 0x00001E10
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00003A2A File Offset: 0x00001E2A
		public PointerEventData.InputButton button { get; set; }

		// Token: 0x060000C1 RID: 193 RVA: 0x00003A34 File Offset: 0x00001E34
		public bool IsPointerMoving()
		{
			return this.delta.sqrMagnitude > 0f;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003A60 File Offset: 0x00001E60
		public bool IsScrolling()
		{
			return this.scrollDelta.sqrMagnitude > 0f;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003A8C File Offset: 0x00001E8C
		public Camera enterEventCamera
		{
			get
			{
				return (!(this.pointerCurrentRaycast.module == null)) ? this.pointerCurrentRaycast.module.eventCamera : null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00003AD4 File Offset: 0x00001ED4
		public Camera pressEventCamera
		{
			get
			{
				return (!(this.pointerPressRaycast.module == null)) ? this.pointerPressRaycast.module.eventCamera : null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00003B1C File Offset: 0x00001F1C
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00003B37 File Offset: 0x00001F37
		public GameObject pointerPress
		{
			get
			{
				return this.m_PointerPress;
			}
			set
			{
				if (!(this.m_PointerPress == value))
				{
					this.lastPress = this.m_PointerPress;
					this.m_PointerPress = value;
				}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003B64 File Offset: 0x00001F64
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<b>Position</b>: " + this.position);
			stringBuilder.AppendLine("<b>delta</b>: " + this.delta);
			stringBuilder.AppendLine("<b>eligibleForClick</b>: " + this.eligibleForClick);
			stringBuilder.AppendLine("<b>pointerEnter</b>: " + this.pointerEnter);
			stringBuilder.AppendLine("<b>pointerPress</b>: " + this.pointerPress);
			stringBuilder.AppendLine("<b>lastPointerPress</b>: " + this.lastPress);
			stringBuilder.AppendLine("<b>pointerDrag</b>: " + this.pointerDrag);
			stringBuilder.AppendLine("<b>Use Drag Threshold</b>: " + this.useDragThreshold);
			stringBuilder.AppendLine("<b>Current Rayast:</b>");
			stringBuilder.AppendLine(this.pointerCurrentRaycast.ToString());
			stringBuilder.AppendLine("<b>Press Rayast:</b>");
			stringBuilder.AppendLine(this.pointerPressRaycast.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x04000060 RID: 96
		private GameObject m_PointerPress;

		// Token: 0x04000066 RID: 102
		public List<GameObject> hovered = new List<GameObject>();

		// Token: 0x02000024 RID: 36
		public enum InputButton
		{
			// Token: 0x04000075 RID: 117
			Left,
			// Token: 0x04000076 RID: 118
			Right,
			// Token: 0x04000077 RID: 119
			Middle
		}

		// Token: 0x02000025 RID: 37
		public enum FramePressState
		{
			// Token: 0x04000079 RID: 121
			Pressed,
			// Token: 0x0400007A RID: 122
			Released,
			// Token: 0x0400007B RID: 123
			PressedAndReleased,
			// Token: 0x0400007C RID: 124
			NotChanged
		}
	}
}
