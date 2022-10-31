using System;
using System.Collections.Generic;
using System.Text;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000028 RID: 40
	public abstract class PointerInputModule : BaseInputModule
	{
		// Token: 0x060000ED RID: 237 RVA: 0x000043C4 File Offset: 0x000027C4
		protected bool GetPointerData(int id, out PointerEventData data, bool create)
		{
			bool result;
			if (!this.m_PointerData.TryGetValue(id, out data) && create)
			{
				data = new PointerEventData(base.eventSystem)
				{
					pointerId = id
				};
				this.m_PointerData.Add(id, data);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000441E File Offset: 0x0000281E
		protected void RemovePointerData(PointerEventData data)
		{
			this.m_PointerData.Remove(data.pointerId);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004434 File Offset: 0x00002834
		protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released)
		{
			PointerEventData pointerEventData;
			bool pointerData = this.GetPointerData(input.fingerId, out pointerEventData, true);
			pointerEventData.Reset();
			pressed = (pointerData || input.phase == TouchPhase.Began);
			released = (input.phase == TouchPhase.Canceled || input.phase == TouchPhase.Ended);
			if (pointerData)
			{
				pointerEventData.position = input.position;
			}
			if (pressed)
			{
				pointerEventData.delta = Vector2.zero;
			}
			else
			{
				pointerEventData.delta = input.position - pointerEventData.position;
			}
			pointerEventData.position = input.position;
			pointerEventData.button = PointerEventData.InputButton.Left;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return pointerEventData;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004518 File Offset: 0x00002918
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
			to.position = from.position;
			to.delta = from.delta;
			to.scrollDelta = from.scrollDelta;
			to.pointerCurrentRaycast = from.pointerCurrentRaycast;
			to.pointerEnter = from.pointerEnter;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004558 File Offset: 0x00002958
		protected PointerEventData.FramePressState StateForMouseButton(int buttonId)
		{
			bool mouseButtonDown = base.input.GetMouseButtonDown(buttonId);
			bool mouseButtonUp = base.input.GetMouseButtonUp(buttonId);
			PointerEventData.FramePressState result;
			if (mouseButtonDown && mouseButtonUp)
			{
				result = PointerEventData.FramePressState.PressedAndReleased;
			}
			else if (mouseButtonDown)
			{
				result = PointerEventData.FramePressState.Pressed;
			}
			else if (mouseButtonUp)
			{
				result = PointerEventData.FramePressState.Released;
			}
			else
			{
				result = PointerEventData.FramePressState.NotChanged;
			}
			return result;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000045B8 File Offset: 0x000029B8
		protected virtual PointerInputModule.MouseState GetMousePointerEventData()
		{
			return this.GetMousePointerEventData(0);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000045D4 File Offset: 0x000029D4
		protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id)
		{
			PointerEventData pointerEventData;
			bool pointerData = this.GetPointerData(-1, out pointerEventData, true);
			pointerEventData.Reset();
			if (pointerData)
			{
				pointerEventData.position = base.input.mousePosition;
			}
			Vector2 mousePosition = base.input.mousePosition;
			if (Cursor.lockState == CursorLockMode.Locked)
			{
				pointerEventData.position = new Vector2(-1f, -1f);
				pointerEventData.delta = Vector2.zero;
			}
			else
			{
				pointerEventData.delta = mousePosition - pointerEventData.position;
				pointerEventData.position = mousePosition;
			}
			pointerEventData.scrollDelta = base.input.mouseScrollDelta;
			pointerEventData.button = PointerEventData.InputButton.Left;
			base.eventSystem.RaycastAll(pointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			PointerEventData pointerEventData2;
			this.GetPointerData(-2, out pointerEventData2, true);
			this.CopyFromTo(pointerEventData, pointerEventData2);
			pointerEventData2.button = PointerEventData.InputButton.Right;
			PointerEventData pointerEventData3;
			this.GetPointerData(-3, out pointerEventData3, true);
			this.CopyFromTo(pointerEventData, pointerEventData3);
			pointerEventData3.button = PointerEventData.InputButton.Middle;
			this.m_MouseState.SetButtonState(PointerEventData.InputButton.Left, this.StateForMouseButton(0), pointerEventData);
			this.m_MouseState.SetButtonState(PointerEventData.InputButton.Right, this.StateForMouseButton(1), pointerEventData2);
			this.m_MouseState.SetButtonState(PointerEventData.InputButton.Middle, this.StateForMouseButton(2), pointerEventData3);
			return this.m_MouseState;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00004734 File Offset: 0x00002B34
		protected PointerEventData GetLastPointerEventData(int id)
		{
			PointerEventData result;
			this.GetPointerData(id, out result, false);
			return result;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004758 File Offset: 0x00002B58
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return !useDragThreshold || (pressPos - currentPos).sqrMagnitude >= threshold * threshold;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004794 File Offset: 0x00002B94
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
			GameObject newEnterTarget = (Cursor.lockState != CursorLockMode.Locked) ? pointerEvent.pointerCurrentRaycast.gameObject : null;
			base.HandlePointerExitAndEnter(pointerEvent, newEnterTarget);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000047CC File Offset: 0x00002BCC
		protected virtual void ProcessDrag(PointerEventData pointerEvent)
		{
			if (pointerEvent.IsPointerMoving() && Cursor.lockState != CursorLockMode.Locked && !(pointerEvent.pointerDrag == null))
			{
				if (!pointerEvent.dragging && PointerInputModule.ShouldStartDrag(pointerEvent.pressPosition, pointerEvent.position, (float)base.eventSystem.pixelDragThreshold, pointerEvent.useDragThreshold))
				{
					ExecuteEvents.Execute<IBeginDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.beginDragHandler);
					pointerEvent.dragging = true;
				}
				if (pointerEvent.dragging)
				{
					if (pointerEvent.pointerPress != pointerEvent.pointerDrag)
					{
						ExecuteEvents.Execute<IPointerUpHandler>(pointerEvent.pointerPress, pointerEvent, ExecuteEvents.pointerUpHandler);
						pointerEvent.eligibleForClick = false;
						pointerEvent.pointerPress = null;
						pointerEvent.rawPointerPress = null;
					}
					ExecuteEvents.Execute<IDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.dragHandler);
				}
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000048B4 File Offset: 0x00002CB4
		public override bool IsPointerOverGameObject(int pointerId)
		{
			PointerEventData lastPointerEventData = this.GetLastPointerEventData(pointerId);
			return lastPointerEventData != null && lastPointerEventData.pointerEnter != null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000048EC File Offset: 0x00002CEC
		protected void ClearSelection()
		{
			BaseEventData baseEventData = this.GetBaseEventData();
			foreach (PointerEventData currentPointerData in this.m_PointerData.Values)
			{
				base.HandlePointerExitAndEnter(currentPointerData, null);
			}
			this.m_PointerData.Clear();
			base.eventSystem.SetSelectedGameObject(null, baseEventData);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00004974 File Offset: 0x00002D74
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder("<b>Pointer Input Module of type: </b>" + base.GetType());
			stringBuilder.AppendLine();
			foreach (KeyValuePair<int, PointerEventData> keyValuePair in this.m_PointerData)
			{
				if (keyValuePair.Value != null)
				{
					stringBuilder.AppendLine("<B>Pointer:</b> " + keyValuePair.Key);
					stringBuilder.AppendLine(keyValuePair.Value.ToString());
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004A38 File Offset: 0x00002E38
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			GameObject eventHandler = ExecuteEvents.GetEventHandler<ISelectHandler>(currentOverGo);
			if (eventHandler != base.eventSystem.currentSelectedGameObject)
			{
				base.eventSystem.SetSelectedGameObject(null, pointerEvent);
			}
		}

		// Token: 0x04000083 RID: 131
		public const int kMouseLeftId = -1;

		// Token: 0x04000084 RID: 132
		public const int kMouseRightId = -2;

		// Token: 0x04000085 RID: 133
		public const int kMouseMiddleId = -3;

		// Token: 0x04000086 RID: 134
		public const int kFakeTouchesId = -4;

		// Token: 0x04000087 RID: 135
		protected Dictionary<int, PointerEventData> m_PointerData = new Dictionary<int, PointerEventData>();

		// Token: 0x04000088 RID: 136
		private readonly PointerInputModule.MouseState m_MouseState = new PointerInputModule.MouseState();

		// Token: 0x02000029 RID: 41
		protected class ButtonState
		{
			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000FD RID: 253 RVA: 0x00004A80 File Offset: 0x00002E80
			// (set) Token: 0x060000FE RID: 254 RVA: 0x00004A9B File Offset: 0x00002E9B
			public PointerInputModule.MouseButtonEventData eventData
			{
				get
				{
					return this.m_EventData;
				}
				set
				{
					this.m_EventData = value;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000FF RID: 255 RVA: 0x00004AA8 File Offset: 0x00002EA8
			// (set) Token: 0x06000100 RID: 256 RVA: 0x00004AC3 File Offset: 0x00002EC3
			public PointerEventData.InputButton button
			{
				get
				{
					return this.m_Button;
				}
				set
				{
					this.m_Button = value;
				}
			}

			// Token: 0x04000089 RID: 137
			private PointerEventData.InputButton m_Button = PointerEventData.InputButton.Left;

			// Token: 0x0400008A RID: 138
			private PointerInputModule.MouseButtonEventData m_EventData;
		}

		// Token: 0x0200002A RID: 42
		protected class MouseState
		{
			// Token: 0x06000102 RID: 258 RVA: 0x00004AE0 File Offset: 0x00002EE0
			public bool AnyPressesThisFrame()
			{
				for (int i = 0; i < this.m_TrackedButtons.Count; i++)
				{
					if (this.m_TrackedButtons[i].eventData.PressedThisFrame())
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06000103 RID: 259 RVA: 0x00004B38 File Offset: 0x00002F38
			public bool AnyReleasesThisFrame()
			{
				for (int i = 0; i < this.m_TrackedButtons.Count; i++)
				{
					if (this.m_TrackedButtons[i].eventData.ReleasedThisFrame())
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06000104 RID: 260 RVA: 0x00004B90 File Offset: 0x00002F90
			public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button)
			{
				PointerInputModule.ButtonState buttonState = null;
				for (int i = 0; i < this.m_TrackedButtons.Count; i++)
				{
					if (this.m_TrackedButtons[i].button == button)
					{
						buttonState = this.m_TrackedButtons[i];
						break;
					}
				}
				if (buttonState == null)
				{
					buttonState = new PointerInputModule.ButtonState
					{
						button = button,
						eventData = new PointerInputModule.MouseButtonEventData()
					};
					this.m_TrackedButtons.Add(buttonState);
				}
				return buttonState;
			}

			// Token: 0x06000105 RID: 261 RVA: 0x00004C20 File Offset: 0x00003020
			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data)
			{
				PointerInputModule.ButtonState buttonState = this.GetButtonState(button);
				buttonState.eventData.buttonState = stateForMouseButton;
				buttonState.eventData.buttonData = data;
			}

			// Token: 0x0400008B RID: 139
			private List<PointerInputModule.ButtonState> m_TrackedButtons = new List<PointerInputModule.ButtonState>();
		}

		// Token: 0x0200002B RID: 43
		public class MouseButtonEventData
		{
			// Token: 0x06000107 RID: 263 RVA: 0x00004C58 File Offset: 0x00003058
			public bool PressedThisFrame()
			{
				return this.buttonState == PointerEventData.FramePressState.Pressed || this.buttonState == PointerEventData.FramePressState.PressedAndReleased;
			}

			// Token: 0x06000108 RID: 264 RVA: 0x00004C84 File Offset: 0x00003084
			public bool ReleasedThisFrame()
			{
				return this.buttonState == PointerEventData.FramePressState.Released || this.buttonState == PointerEventData.FramePressState.PressedAndReleased;
			}

			// Token: 0x0400008C RID: 140
			public PointerEventData.FramePressState buttonState;

			// Token: 0x0400008D RID: 141
			public PointerEventData buttonData;
		}
	}
}
