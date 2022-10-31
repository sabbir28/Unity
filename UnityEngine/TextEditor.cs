using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000272 RID: 626
	public class TextEditor
	{
		// Token: 0x06002A48 RID: 10824 RVA: 0x0003901C File Offset: 0x0003721C
		[RequiredByNativeCode]
		public TextEditor()
		{
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x000390AC File Offset: 0x000372AC
		// (set) Token: 0x06002A4A RID: 10826 RVA: 0x000390C8 File Offset: 0x000372C8
		[Obsolete("Please use 'text' instead of 'content'", false)]
		public GUIContent content
		{
			get
			{
				return this.m_Content;
			}
			set
			{
				this.m_Content = value;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x000390D4 File Offset: 0x000372D4
		// (set) Token: 0x06002A4C RID: 10828 RVA: 0x000390F4 File Offset: 0x000372F4
		public string text
		{
			get
			{
				return this.m_Content.text;
			}
			set
			{
				this.m_Content.text = value;
				this.ClampTextIndex(ref this.m_CursorIndex);
				this.ClampTextIndex(ref this.m_SelectIndex);
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x0003911C File Offset: 0x0003731C
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x00039138 File Offset: 0x00037338
		public Rect position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				if (!(this.m_Position == value))
				{
					this.m_Position = value;
					this.UpdateScrollOffset();
				}
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x00039160 File Offset: 0x00037360
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x0003917C File Offset: 0x0003737C
		public int cursorIndex
		{
			get
			{
				return this.m_CursorIndex;
			}
			set
			{
				int cursorIndex = this.m_CursorIndex;
				this.m_CursorIndex = value;
				this.ClampTextIndex(ref this.m_CursorIndex);
				if (this.m_CursorIndex != cursorIndex)
				{
					this.m_RevealCursor = true;
				}
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000391B8 File Offset: 0x000373B8
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x000391D4 File Offset: 0x000373D4
		public int selectIndex
		{
			get
			{
				return this.m_SelectIndex;
			}
			set
			{
				this.m_SelectIndex = value;
				this.ClampTextIndex(ref this.m_SelectIndex);
			}
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x000391EC File Offset: 0x000373EC
		private void ClearCursorPos()
		{
			this.hasHorizontalCursorPos = false;
			this.m_iAltCursorPos = -1;
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x00039200 File Offset: 0x00037400
		public void OnFocus()
		{
			if (this.multiline)
			{
				int num = 0;
				this.selectIndex = num;
				this.cursorIndex = num;
			}
			else
			{
				this.SelectAll();
			}
			this.m_HasFocus = true;
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x0003923C File Offset: 0x0003743C
		public void OnLostFocus()
		{
			this.m_HasFocus = false;
			this.scrollOffset = Vector2.zero;
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00039254 File Offset: 0x00037454
		private void GrabGraphicalCursorPos()
		{
			if (!this.hasHorizontalCursorPos)
			{
				this.graphicalCursorPos = this.style.GetCursorPixelPosition(this.position, this.m_Content, this.cursorIndex);
				this.graphicalSelectCursorPos = this.style.GetCursorPixelPosition(this.position, this.m_Content, this.selectIndex);
				this.hasHorizontalCursorPos = false;
			}
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x000392BC File Offset: 0x000374BC
		public bool HandleKeyEvent(Event e)
		{
			this.InitKeyActions();
			EventModifiers modifiers = e.modifiers;
			e.modifiers &= ~EventModifiers.CapsLock;
			bool result;
			if (TextEditor.s_Keyactions.ContainsKey(e))
			{
				TextEditor.TextEditOp operation = TextEditor.s_Keyactions[e];
				this.PerformOperation(operation);
				e.modifiers = modifiers;
				result = true;
			}
			else
			{
				e.modifiers = modifiers;
				result = false;
			}
			return result;
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x00039328 File Offset: 0x00037528
		public bool DeleteLineBack()
		{
			bool result;
			if (this.hasSelection)
			{
				this.DeleteSelection();
				result = true;
			}
			else
			{
				int num = this.cursorIndex;
				int num2 = num;
				while (num2-- != 0)
				{
					if (this.text[num2] == '\n')
					{
						num = num2 + 1;
						break;
					}
				}
				if (num2 == -1)
				{
					num = 0;
				}
				if (this.cursorIndex != num)
				{
					this.m_Content.text = this.text.Remove(num, this.cursorIndex - num);
					int num3 = num;
					this.cursorIndex = num3;
					this.selectIndex = num3;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x000393DC File Offset: 0x000375DC
		public bool DeleteWordBack()
		{
			bool result;
			if (this.hasSelection)
			{
				this.DeleteSelection();
				result = true;
			}
			else
			{
				int num = this.FindEndOfPreviousWord(this.cursorIndex);
				if (this.cursorIndex != num)
				{
					this.m_Content.text = this.text.Remove(num, this.cursorIndex - num);
					int num2 = num;
					this.cursorIndex = num2;
					this.selectIndex = num2;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x0003945C File Offset: 0x0003765C
		public bool DeleteWordForward()
		{
			bool result;
			if (this.hasSelection)
			{
				this.DeleteSelection();
				result = true;
			}
			else
			{
				int num = this.FindStartOfNextWord(this.cursorIndex);
				if (this.cursorIndex < this.text.Length)
				{
					this.m_Content.text = this.text.Remove(this.cursorIndex, num - this.cursorIndex);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x000394DC File Offset: 0x000376DC
		public bool Delete()
		{
			bool result;
			if (this.hasSelection)
			{
				this.DeleteSelection();
				result = true;
			}
			else if (this.cursorIndex < this.text.Length)
			{
				this.m_Content.text = this.text.Remove(this.cursorIndex, 1);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x00039548 File Offset: 0x00037748
		public bool CanPaste()
		{
			return GUIUtility.systemCopyBuffer.Length != 0;
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x00039570 File Offset: 0x00037770
		public bool Backspace()
		{
			bool result;
			if (this.hasSelection)
			{
				this.DeleteSelection();
				result = true;
			}
			else if (this.cursorIndex > 0)
			{
				this.m_Content.text = this.text.Remove(this.cursorIndex - 1, 1);
				int num = this.cursorIndex - 1;
				this.cursorIndex = num;
				this.selectIndex = num;
				this.ClearCursorPos();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x000395F0 File Offset: 0x000377F0
		public void SelectAll()
		{
			this.cursorIndex = 0;
			this.selectIndex = this.text.Length;
			this.ClearCursorPos();
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x00039614 File Offset: 0x00037814
		public void SelectNone()
		{
			this.selectIndex = this.cursorIndex;
			this.ClearCursorPos();
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x0003962C File Offset: 0x0003782C
		public bool hasSelection
		{
			get
			{
				return this.cursorIndex != this.selectIndex;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x00039654 File Offset: 0x00037854
		public string SelectedText
		{
			get
			{
				string result;
				if (this.cursorIndex == this.selectIndex)
				{
					result = "";
				}
				else if (this.cursorIndex < this.selectIndex)
				{
					result = this.text.Substring(this.cursorIndex, this.selectIndex - this.cursorIndex);
				}
				else
				{
					result = this.text.Substring(this.selectIndex, this.cursorIndex - this.selectIndex);
				}
				return result;
			}
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000396D8 File Offset: 0x000378D8
		public bool DeleteSelection()
		{
			bool result;
			if (this.cursorIndex == this.selectIndex)
			{
				result = false;
			}
			else
			{
				if (this.cursorIndex < this.selectIndex)
				{
					this.m_Content.text = this.text.Substring(0, this.cursorIndex) + this.text.Substring(this.selectIndex, this.text.Length - this.selectIndex);
					this.selectIndex = this.cursorIndex;
				}
				else
				{
					this.m_Content.text = this.text.Substring(0, this.selectIndex) + this.text.Substring(this.cursorIndex, this.text.Length - this.cursorIndex);
					this.cursorIndex = this.selectIndex;
				}
				this.ClearCursorPos();
				result = true;
			}
			return result;
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x000397C8 File Offset: 0x000379C8
		public void ReplaceSelection(string replace)
		{
			this.DeleteSelection();
			this.m_Content.text = this.text.Insert(this.cursorIndex, replace);
			this.selectIndex = (this.cursorIndex += replace.Length);
			this.ClearCursorPos();
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x0003981C File Offset: 0x00037A1C
		public void Insert(char c)
		{
			this.ReplaceSelection(c.ToString());
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00039834 File Offset: 0x00037A34
		public void MoveSelectionToAltCursor()
		{
			if (this.m_iAltCursorPos != -1)
			{
				int iAltCursorPos = this.m_iAltCursorPos;
				string selectedText = this.SelectedText;
				this.m_Content.text = this.text.Insert(iAltCursorPos, selectedText);
				if (iAltCursorPos < this.cursorIndex)
				{
					this.cursorIndex += selectedText.Length;
					this.selectIndex += selectedText.Length;
				}
				this.DeleteSelection();
				int num = iAltCursorPos;
				this.cursorIndex = num;
				this.selectIndex = num;
				this.ClearCursorPos();
			}
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x000398CC File Offset: 0x00037ACC
		public void MoveRight()
		{
			this.ClearCursorPos();
			if (this.selectIndex == this.cursorIndex)
			{
				this.cursorIndex++;
				this.DetectFocusChange();
				this.selectIndex = this.cursorIndex;
			}
			else if (this.selectIndex > this.cursorIndex)
			{
				this.cursorIndex = this.selectIndex;
			}
			else
			{
				this.selectIndex = this.cursorIndex;
			}
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00039948 File Offset: 0x00037B48
		public void MoveLeft()
		{
			if (this.selectIndex == this.cursorIndex)
			{
				this.cursorIndex--;
				this.selectIndex = this.cursorIndex;
			}
			else if (this.selectIndex > this.cursorIndex)
			{
				this.selectIndex = this.cursorIndex;
			}
			else
			{
				this.cursorIndex = this.selectIndex;
			}
			this.ClearCursorPos();
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x000399C0 File Offset: 0x00037BC0
		public void MoveUp()
		{
			if (this.selectIndex < this.cursorIndex)
			{
				this.selectIndex = this.cursorIndex;
			}
			else
			{
				this.cursorIndex = this.selectIndex;
			}
			this.GrabGraphicalCursorPos();
			this.graphicalCursorPos.y = this.graphicalCursorPos.y - 1f;
			int cursorStringIndex = this.style.GetCursorStringIndex(this.position, this.m_Content, this.graphicalCursorPos);
			this.selectIndex = cursorStringIndex;
			this.cursorIndex = cursorStringIndex;
			if (this.cursorIndex <= 0)
			{
				this.ClearCursorPos();
			}
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00039A58 File Offset: 0x00037C58
		public void MoveDown()
		{
			if (this.selectIndex > this.cursorIndex)
			{
				this.selectIndex = this.cursorIndex;
			}
			else
			{
				this.cursorIndex = this.selectIndex;
			}
			this.GrabGraphicalCursorPos();
			this.graphicalCursorPos.y = this.graphicalCursorPos.y + (this.style.lineHeight + 5f);
			int cursorStringIndex = this.style.GetCursorStringIndex(this.position, this.m_Content, this.graphicalCursorPos);
			this.selectIndex = cursorStringIndex;
			this.cursorIndex = cursorStringIndex;
			if (this.cursorIndex == this.text.Length)
			{
				this.ClearCursorPos();
			}
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x00039B08 File Offset: 0x00037D08
		public void MoveLineStart()
		{
			int num = (this.selectIndex >= this.cursorIndex) ? this.cursorIndex : this.selectIndex;
			int num2 = num;
			int num3;
			while (num2-- != 0)
			{
				if (this.text[num2] == '\n')
				{
					num3 = num2 + 1;
					this.cursorIndex = num3;
					this.selectIndex = num3;
					return;
				}
			}
			num3 = 0;
			this.cursorIndex = num3;
			this.selectIndex = num3;
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x00039B88 File Offset: 0x00037D88
		public void MoveLineEnd()
		{
			int num = (this.selectIndex <= this.cursorIndex) ? this.cursorIndex : this.selectIndex;
			int i = num;
			int length = this.text.Length;
			int num2;
			while (i < length)
			{
				if (this.text[i] == '\n')
				{
					num2 = i;
					this.cursorIndex = num2;
					this.selectIndex = num2;
					return;
				}
				i++;
			}
			num2 = length;
			this.cursorIndex = num2;
			this.selectIndex = num2;
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x00039C14 File Offset: 0x00037E14
		public void MoveGraphicalLineStart()
		{
			int graphicalLineStart = this.GetGraphicalLineStart((this.cursorIndex >= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			this.selectIndex = graphicalLineStart;
			this.cursorIndex = graphicalLineStart;
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x00039C5C File Offset: 0x00037E5C
		public void MoveGraphicalLineEnd()
		{
			int graphicalLineEnd = this.GetGraphicalLineEnd((this.cursorIndex <= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			this.selectIndex = graphicalLineEnd;
			this.cursorIndex = graphicalLineEnd;
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x00039CA4 File Offset: 0x00037EA4
		public void MoveTextStart()
		{
			int num = 0;
			this.cursorIndex = num;
			this.selectIndex = num;
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x00039CC4 File Offset: 0x00037EC4
		public void MoveTextEnd()
		{
			int length = this.text.Length;
			this.cursorIndex = length;
			this.selectIndex = length;
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x00039CEC File Offset: 0x00037EEC
		private int IndexOfEndOfLine(int startIndex)
		{
			int num = this.text.IndexOf('\n', startIndex);
			return (num == -1) ? this.text.Length : num;
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x00039D28 File Offset: 0x00037F28
		public void MoveParagraphForward()
		{
			this.cursorIndex = ((this.cursorIndex <= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			if (this.cursorIndex < this.text.Length)
			{
				int num = this.IndexOfEndOfLine(this.cursorIndex + 1);
				this.cursorIndex = num;
				this.selectIndex = num;
			}
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x00039D94 File Offset: 0x00037F94
		public void MoveParagraphBackward()
		{
			this.cursorIndex = ((this.cursorIndex >= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			if (this.cursorIndex > 1)
			{
				int num = this.text.LastIndexOf('\n', this.cursorIndex - 2) + 1;
				this.cursorIndex = num;
				this.selectIndex = num;
			}
			else
			{
				int num = 0;
				this.cursorIndex = num;
				this.selectIndex = num;
			}
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x00039E14 File Offset: 0x00038014
		public void MoveCursorToPosition(Vector2 cursorPosition)
		{
			this.selectIndex = this.style.GetCursorStringIndex(this.position, this.m_Content, cursorPosition + this.scrollOffset);
			if (!Event.current.shift)
			{
				this.cursorIndex = this.selectIndex;
			}
			this.DetectFocusChange();
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00039E70 File Offset: 0x00038070
		public void MoveAltCursorToPosition(Vector2 cursorPosition)
		{
			int cursorStringIndex = this.style.GetCursorStringIndex(this.position, this.m_Content, cursorPosition + this.scrollOffset);
			this.m_iAltCursorPos = Mathf.Min(this.text.Length, cursorStringIndex);
			this.DetectFocusChange();
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x00039EC0 File Offset: 0x000380C0
		public bool IsOverSelection(Vector2 cursorPosition)
		{
			int cursorStringIndex = this.style.GetCursorStringIndex(this.position, this.m_Content, cursorPosition + this.scrollOffset);
			return cursorStringIndex < Mathf.Max(this.cursorIndex, this.selectIndex) && cursorStringIndex > Mathf.Min(this.cursorIndex, this.selectIndex);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x00039F28 File Offset: 0x00038128
		public void SelectToPosition(Vector2 cursorPosition)
		{
			if (!this.m_MouseDragSelectsWholeWords)
			{
				this.cursorIndex = this.style.GetCursorStringIndex(this.position, this.m_Content, cursorPosition + this.scrollOffset);
			}
			else
			{
				int num = this.style.GetCursorStringIndex(this.position, this.m_Content, cursorPosition + this.scrollOffset);
				if (this.m_DblClickSnap == TextEditor.DblClickSnapping.WORDS)
				{
					if (num < this.m_DblClickInitPos)
					{
						this.cursorIndex = this.FindEndOfClassification(num, -1);
						this.selectIndex = this.FindEndOfClassification(this.m_DblClickInitPos, 1);
					}
					else
					{
						if (num >= this.text.Length)
						{
							num = this.text.Length - 1;
						}
						this.cursorIndex = this.FindEndOfClassification(num, 1);
						this.selectIndex = this.FindEndOfClassification(this.m_DblClickInitPos - 1, -1);
					}
				}
				else if (num < this.m_DblClickInitPos)
				{
					if (num > 0)
					{
						this.cursorIndex = this.text.LastIndexOf('\n', Mathf.Max(0, num - 2)) + 1;
					}
					else
					{
						this.cursorIndex = 0;
					}
					this.selectIndex = this.text.LastIndexOf('\n', this.m_DblClickInitPos);
				}
				else
				{
					if (num < this.text.Length)
					{
						this.cursorIndex = this.IndexOfEndOfLine(num);
					}
					else
					{
						this.cursorIndex = this.text.Length;
					}
					this.selectIndex = this.text.LastIndexOf('\n', Mathf.Max(0, this.m_DblClickInitPos - 2)) + 1;
				}
			}
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x0003A0DC File Offset: 0x000382DC
		public void SelectLeft()
		{
			if (this.m_bJustSelected && this.cursorIndex > this.selectIndex)
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.selectIndex;
				this.selectIndex = cursorIndex;
			}
			this.m_bJustSelected = false;
			this.cursorIndex--;
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x0003A138 File Offset: 0x00038338
		public void SelectRight()
		{
			if (this.m_bJustSelected && this.cursorIndex < this.selectIndex)
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.selectIndex;
				this.selectIndex = cursorIndex;
			}
			this.m_bJustSelected = false;
			this.cursorIndex++;
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x0003A194 File Offset: 0x00038394
		public void SelectUp()
		{
			this.GrabGraphicalCursorPos();
			this.graphicalCursorPos.y = this.graphicalCursorPos.y - 1f;
			this.cursorIndex = this.style.GetCursorStringIndex(this.position, this.m_Content, this.graphicalCursorPos);
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x0003A1E4 File Offset: 0x000383E4
		public void SelectDown()
		{
			this.GrabGraphicalCursorPos();
			this.graphicalCursorPos.y = this.graphicalCursorPos.y + (this.style.lineHeight + 5f);
			this.cursorIndex = this.style.GetCursorStringIndex(this.position, this.m_Content, this.graphicalCursorPos);
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x0003A240 File Offset: 0x00038440
		public void SelectTextEnd()
		{
			this.cursorIndex = this.text.Length;
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x0003A254 File Offset: 0x00038454
		public void SelectTextStart()
		{
			this.cursorIndex = 0;
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x0003A260 File Offset: 0x00038460
		public void MouseDragSelectsWholeWords(bool on)
		{
			this.m_MouseDragSelectsWholeWords = on;
			this.m_DblClickInitPos = this.cursorIndex;
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x0003A278 File Offset: 0x00038478
		public void DblClickSnap(TextEditor.DblClickSnapping snapping)
		{
			this.m_DblClickSnap = snapping;
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x0003A284 File Offset: 0x00038484
		private int GetGraphicalLineStart(int p)
		{
			Vector2 cursorPixelPosition = this.style.GetCursorPixelPosition(this.position, this.m_Content, p);
			cursorPixelPosition.x = 0f;
			return this.style.GetCursorStringIndex(this.position, this.m_Content, cursorPixelPosition);
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x0003A2D8 File Offset: 0x000384D8
		private int GetGraphicalLineEnd(int p)
		{
			Vector2 cursorPixelPosition = this.style.GetCursorPixelPosition(this.position, this.m_Content, p);
			cursorPixelPosition.x += 5000f;
			return this.style.GetCursorStringIndex(this.position, this.m_Content, cursorPixelPosition);
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x0003A334 File Offset: 0x00038534
		private int FindNextSeperator(int startPos)
		{
			int length = this.text.Length;
			while (startPos < length && !TextEditor.isLetterLikeChar(this.text[startPos]))
			{
				startPos++;
			}
			while (startPos < length && TextEditor.isLetterLikeChar(this.text[startPos]))
			{
				startPos++;
			}
			return startPos;
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x0003A3A4 File Offset: 0x000385A4
		private static bool isLetterLikeChar(char c)
		{
			return char.IsLetterOrDigit(c) || c == '\'';
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x0003A3CC File Offset: 0x000385CC
		private int FindPrevSeperator(int startPos)
		{
			startPos--;
			while (startPos > 0 && !TextEditor.isLetterLikeChar(this.text[startPos]))
			{
				startPos--;
			}
			while (startPos >= 0 && TextEditor.isLetterLikeChar(this.text[startPos]))
			{
				startPos--;
			}
			return startPos + 1;
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x0003A438 File Offset: 0x00038638
		public void MoveWordRight()
		{
			this.cursorIndex = ((this.cursorIndex <= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			int num = this.FindNextSeperator(this.cursorIndex);
			this.selectIndex = num;
			this.cursorIndex = num;
			this.ClearCursorPos();
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x0003A490 File Offset: 0x00038690
		public void MoveToStartOfNextWord()
		{
			this.ClearCursorPos();
			if (this.cursorIndex != this.selectIndex)
			{
				this.MoveRight();
			}
			else
			{
				int num = this.FindStartOfNextWord(this.cursorIndex);
				this.selectIndex = num;
				this.cursorIndex = num;
			}
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x0003A4DC File Offset: 0x000386DC
		public void MoveToEndOfPreviousWord()
		{
			this.ClearCursorPos();
			if (this.cursorIndex != this.selectIndex)
			{
				this.MoveLeft();
			}
			else
			{
				int num = this.FindEndOfPreviousWord(this.cursorIndex);
				this.selectIndex = num;
				this.cursorIndex = num;
			}
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x0003A528 File Offset: 0x00038728
		public void SelectToStartOfNextWord()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.FindStartOfNextWord(this.cursorIndex);
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x0003A544 File Offset: 0x00038744
		public void SelectToEndOfPreviousWord()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.FindEndOfPreviousWord(this.cursorIndex);
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x0003A560 File Offset: 0x00038760
		private TextEditor.CharacterType ClassifyChar(char c)
		{
			TextEditor.CharacterType result;
			if (char.IsWhiteSpace(c))
			{
				result = TextEditor.CharacterType.WhiteSpace;
			}
			else if (char.IsLetterOrDigit(c) || c == '\'')
			{
				result = TextEditor.CharacterType.LetterLike;
			}
			else
			{
				result = TextEditor.CharacterType.Symbol;
			}
			return result;
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x0003A5A4 File Offset: 0x000387A4
		public int FindStartOfNextWord(int p)
		{
			int length = this.text.Length;
			int result;
			if (p == length)
			{
				result = p;
			}
			else
			{
				char c = this.text[p];
				TextEditor.CharacterType characterType = this.ClassifyChar(c);
				if (characterType != TextEditor.CharacterType.WhiteSpace)
				{
					p++;
					while (p < length && this.ClassifyChar(this.text[p]) == characterType)
					{
						p++;
					}
				}
				else if (c == '\t' || c == '\n')
				{
					return p + 1;
				}
				if (p == length)
				{
					result = p;
				}
				else
				{
					c = this.text[p];
					if (c == ' ')
					{
						while (p < length && char.IsWhiteSpace(this.text[p]))
						{
							p++;
						}
					}
					else if (c == '\t' || c == '\n')
					{
						return p;
					}
					result = p;
				}
			}
			return result;
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x0003A6AC File Offset: 0x000388AC
		private int FindEndOfPreviousWord(int p)
		{
			int result;
			if (p == 0)
			{
				result = p;
			}
			else
			{
				p--;
				while (p > 0 && this.text[p] == ' ')
				{
					p--;
				}
				TextEditor.CharacterType characterType = this.ClassifyChar(this.text[p]);
				if (characterType != TextEditor.CharacterType.WhiteSpace)
				{
					while (p > 0 && this.ClassifyChar(this.text[p - 1]) == characterType)
					{
						p--;
					}
				}
				result = p;
			}
			return result;
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x0003A740 File Offset: 0x00038940
		public void MoveWordLeft()
		{
			this.cursorIndex = ((this.cursorIndex >= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			this.cursorIndex = this.FindPrevSeperator(this.cursorIndex);
			this.selectIndex = this.cursorIndex;
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x0003A794 File Offset: 0x00038994
		public void SelectWordRight()
		{
			this.ClearCursorPos();
			int selectIndex = this.selectIndex;
			if (this.cursorIndex < this.selectIndex)
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordRight();
				this.selectIndex = selectIndex;
				this.cursorIndex = ((this.cursorIndex >= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			}
			else
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordRight();
				this.selectIndex = selectIndex;
			}
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x0003A820 File Offset: 0x00038A20
		public void SelectWordLeft()
		{
			this.ClearCursorPos();
			int selectIndex = this.selectIndex;
			if (this.cursorIndex > this.selectIndex)
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordLeft();
				this.selectIndex = selectIndex;
				this.cursorIndex = ((this.cursorIndex <= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			}
			else
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordLeft();
				this.selectIndex = selectIndex;
			}
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x0003A8AC File Offset: 0x00038AAC
		public void ExpandSelectGraphicalLineStart()
		{
			this.ClearCursorPos();
			if (this.cursorIndex < this.selectIndex)
			{
				this.cursorIndex = this.GetGraphicalLineStart(this.cursorIndex);
			}
			else
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.GetGraphicalLineStart(this.selectIndex);
				this.selectIndex = cursorIndex;
			}
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x0003A90C File Offset: 0x00038B0C
		public void ExpandSelectGraphicalLineEnd()
		{
			this.ClearCursorPos();
			if (this.cursorIndex > this.selectIndex)
			{
				this.cursorIndex = this.GetGraphicalLineEnd(this.cursorIndex);
			}
			else
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.GetGraphicalLineEnd(this.selectIndex);
				this.selectIndex = cursorIndex;
			}
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x0003A96C File Offset: 0x00038B6C
		public void SelectGraphicalLineStart()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.GetGraphicalLineStart(this.cursorIndex);
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x0003A988 File Offset: 0x00038B88
		public void SelectGraphicalLineEnd()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.GetGraphicalLineEnd(this.cursorIndex);
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x0003A9A4 File Offset: 0x00038BA4
		public void SelectParagraphForward()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex < this.selectIndex;
			if (this.cursorIndex < this.text.Length)
			{
				this.cursorIndex = this.IndexOfEndOfLine(this.cursorIndex + 1);
				if (flag && this.cursorIndex > this.selectIndex)
				{
					this.cursorIndex = this.selectIndex;
				}
			}
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x0003AA18 File Offset: 0x00038C18
		public void SelectParagraphBackward()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex > this.selectIndex;
			if (this.cursorIndex > 1)
			{
				this.cursorIndex = this.text.LastIndexOf('\n', this.cursorIndex - 2) + 1;
				if (flag && this.cursorIndex < this.selectIndex)
				{
					this.cursorIndex = this.selectIndex;
				}
			}
			else
			{
				int num = 0;
				this.cursorIndex = num;
				this.selectIndex = num;
			}
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x0003AAA0 File Offset: 0x00038CA0
		public void SelectCurrentWord()
		{
			this.ClearCursorPos();
			int length = this.text.Length;
			this.selectIndex = this.cursorIndex;
			if (length != 0)
			{
				if (this.cursorIndex >= length)
				{
					this.cursorIndex = length - 1;
				}
				if (this.selectIndex >= length)
				{
					this.selectIndex--;
				}
				if (this.cursorIndex < this.selectIndex)
				{
					this.cursorIndex = this.FindEndOfClassification(this.cursorIndex, -1);
					this.selectIndex = this.FindEndOfClassification(this.selectIndex, 1);
				}
				else
				{
					this.cursorIndex = this.FindEndOfClassification(this.cursorIndex, 1);
					this.selectIndex = this.FindEndOfClassification(this.selectIndex, -1);
				}
				this.m_bJustSelected = true;
			}
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x0003AB74 File Offset: 0x00038D74
		private int FindEndOfClassification(int p, int dir)
		{
			int length = this.text.Length;
			int result;
			if (p >= length || p < 0)
			{
				result = p;
			}
			else
			{
				TextEditor.CharacterType characterType = this.ClassifyChar(this.text[p]);
				for (;;)
				{
					p += dir;
					if (p < 0)
					{
						break;
					}
					if (p >= length)
					{
						goto Block_3;
					}
					if (this.ClassifyChar(this.text[p]) != characterType)
					{
						goto Block_4;
					}
				}
				return 0;
				Block_3:
				return length;
				Block_4:
				if (dir == 1)
				{
					result = p;
				}
				else
				{
					result = p + 1;
				}
			}
			return result;
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x0003AC0C File Offset: 0x00038E0C
		public void SelectCurrentParagraph()
		{
			this.ClearCursorPos();
			int length = this.text.Length;
			if (this.cursorIndex < length)
			{
				this.cursorIndex = this.IndexOfEndOfLine(this.cursorIndex) + 1;
			}
			if (this.selectIndex != 0)
			{
				this.selectIndex = this.text.LastIndexOf('\n', this.selectIndex - 1) + 1;
			}
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x0003AC78 File Offset: 0x00038E78
		public void UpdateScrollOffsetIfNeeded(Event evt)
		{
			if (evt.type != EventType.Repaint && evt.type != EventType.Layout)
			{
				this.UpdateScrollOffset();
			}
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x0003AC9C File Offset: 0x00038E9C
		private void UpdateScrollOffset()
		{
			int cursorIndex = this.cursorIndex;
			this.graphicalCursorPos = this.style.GetCursorPixelPosition(new Rect(0f, 0f, this.position.width, this.position.height), this.m_Content, cursorIndex);
			Rect rect = this.style.padding.Remove(this.position);
			Vector2 vector = new Vector2(this.style.CalcSize(this.m_Content).x, this.style.CalcHeight(this.m_Content, this.position.width));
			if (vector.x < this.position.width)
			{
				this.scrollOffset.x = 0f;
			}
			else if (this.m_RevealCursor)
			{
				if (this.graphicalCursorPos.x + 1f > this.scrollOffset.x + rect.width)
				{
					this.scrollOffset.x = this.graphicalCursorPos.x - rect.width;
				}
				if (this.graphicalCursorPos.x < this.scrollOffset.x + (float)this.style.padding.left)
				{
					this.scrollOffset.x = this.graphicalCursorPos.x - (float)this.style.padding.left;
				}
			}
			if (vector.y < rect.height)
			{
				this.scrollOffset.y = 0f;
			}
			else if (this.m_RevealCursor)
			{
				if (this.graphicalCursorPos.y + this.style.lineHeight > this.scrollOffset.y + rect.height + (float)this.style.padding.top)
				{
					this.scrollOffset.y = this.graphicalCursorPos.y - rect.height - (float)this.style.padding.top + this.style.lineHeight;
				}
				if (this.graphicalCursorPos.y < this.scrollOffset.y + (float)this.style.padding.top)
				{
					this.scrollOffset.y = this.graphicalCursorPos.y - (float)this.style.padding.top;
				}
			}
			if (this.scrollOffset.y > 0f && vector.y - this.scrollOffset.y < rect.height)
			{
				this.scrollOffset.y = vector.y - rect.height - (float)this.style.padding.top - (float)this.style.padding.bottom;
			}
			this.scrollOffset.y = ((this.scrollOffset.y >= 0f) ? this.scrollOffset.y : 0f);
			this.m_RevealCursor = false;
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x0003AFE0 File Offset: 0x000391E0
		public void DrawCursor(string newText)
		{
			string text = this.text;
			int num = this.cursorIndex;
			if (Input.compositionString.Length > 0)
			{
				this.m_Content.text = newText.Substring(0, this.cursorIndex) + Input.compositionString + newText.Substring(this.selectIndex);
				num += Input.compositionString.Length;
			}
			else
			{
				this.m_Content.text = newText;
			}
			this.graphicalCursorPos = this.style.GetCursorPixelPosition(new Rect(0f, 0f, this.position.width, this.position.height), this.m_Content, num);
			Vector2 contentOffset = this.style.contentOffset;
			this.style.contentOffset -= this.scrollOffset;
			this.style.Internal_clipOffset = this.scrollOffset;
			Input.compositionCursorPos = this.graphicalCursorPos + new Vector2(this.position.x, this.position.y + this.style.lineHeight) - this.scrollOffset;
			if (Input.compositionString.Length > 0)
			{
				this.style.DrawWithTextSelection(this.position, this.m_Content, this.controlID, this.cursorIndex, this.cursorIndex + Input.compositionString.Length, true);
			}
			else
			{
				this.style.DrawWithTextSelection(this.position, this.m_Content, this.controlID, this.cursorIndex, this.selectIndex);
			}
			if (this.m_iAltCursorPos != -1)
			{
				this.style.DrawCursor(this.position, this.m_Content, this.controlID, this.m_iAltCursorPos);
			}
			this.style.contentOffset = contentOffset;
			this.style.Internal_clipOffset = Vector2.zero;
			this.m_Content.text = text;
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x0003B1EC File Offset: 0x000393EC
		private bool PerformOperation(TextEditor.TextEditOp operation)
		{
			this.m_RevealCursor = true;
			switch (operation)
			{
			case TextEditor.TextEditOp.MoveLeft:
				this.MoveLeft();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveRight:
				this.MoveRight();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveUp:
				this.MoveUp();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveDown:
				this.MoveDown();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveLineStart:
				this.MoveLineStart();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveLineEnd:
				this.MoveLineEnd();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveTextStart:
				this.MoveTextStart();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveTextEnd:
				this.MoveTextEnd();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveGraphicalLineStart:
				this.MoveGraphicalLineStart();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveGraphicalLineEnd:
				this.MoveGraphicalLineEnd();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveWordLeft:
				this.MoveWordLeft();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveWordRight:
				this.MoveWordRight();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveParagraphForward:
				this.MoveParagraphForward();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveParagraphBackward:
				this.MoveParagraphBackward();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveToStartOfNextWord:
				this.MoveToStartOfNextWord();
				goto IL_2BA;
			case TextEditor.TextEditOp.MoveToEndOfPreviousWord:
				this.MoveToEndOfPreviousWord();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectLeft:
				this.SelectLeft();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectRight:
				this.SelectRight();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectUp:
				this.SelectUp();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectDown:
				this.SelectDown();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectTextStart:
				this.SelectTextStart();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectTextEnd:
				this.SelectTextEnd();
				goto IL_2BA;
			case TextEditor.TextEditOp.ExpandSelectGraphicalLineStart:
				this.ExpandSelectGraphicalLineStart();
				goto IL_2BA;
			case TextEditor.TextEditOp.ExpandSelectGraphicalLineEnd:
				this.ExpandSelectGraphicalLineEnd();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectGraphicalLineStart:
				this.SelectGraphicalLineStart();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectGraphicalLineEnd:
				this.SelectGraphicalLineEnd();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectWordLeft:
				this.SelectWordLeft();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectWordRight:
				this.SelectWordRight();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectToEndOfPreviousWord:
				this.SelectToEndOfPreviousWord();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectToStartOfNextWord:
				this.SelectToStartOfNextWord();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectParagraphBackward:
				this.SelectParagraphBackward();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectParagraphForward:
				this.SelectParagraphForward();
				goto IL_2BA;
			case TextEditor.TextEditOp.Delete:
				return this.Delete();
			case TextEditor.TextEditOp.Backspace:
				return this.Backspace();
			case TextEditor.TextEditOp.DeleteWordBack:
				return this.DeleteWordBack();
			case TextEditor.TextEditOp.DeleteWordForward:
				return this.DeleteWordForward();
			case TextEditor.TextEditOp.DeleteLineBack:
				return this.DeleteLineBack();
			case TextEditor.TextEditOp.Cut:
				return this.Cut();
			case TextEditor.TextEditOp.Copy:
				this.Copy();
				goto IL_2BA;
			case TextEditor.TextEditOp.Paste:
				return this.Paste();
			case TextEditor.TextEditOp.SelectAll:
				this.SelectAll();
				goto IL_2BA;
			case TextEditor.TextEditOp.SelectNone:
				this.SelectNone();
				goto IL_2BA;
			}
			Debug.Log("Unimplemented: " + operation);
			IL_2BA:
			return false;
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x0003B4BC File Offset: 0x000396BC
		public void SaveBackup()
		{
			this.oldText = this.text;
			this.oldPos = this.cursorIndex;
			this.oldSelectPos = this.selectIndex;
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x0003B4E4 File Offset: 0x000396E4
		public void Undo()
		{
			this.m_Content.text = this.oldText;
			this.cursorIndex = this.oldPos;
			this.selectIndex = this.oldSelectPos;
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0003B510 File Offset: 0x00039710
		public bool Cut()
		{
			bool result;
			if (this.isPasswordField)
			{
				result = false;
			}
			else
			{
				this.Copy();
				result = this.DeleteSelection();
			}
			return result;
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x0003B544 File Offset: 0x00039744
		public void Copy()
		{
			if (this.selectIndex != this.cursorIndex)
			{
				if (!this.isPasswordField)
				{
					string systemCopyBuffer;
					if (this.cursorIndex < this.selectIndex)
					{
						systemCopyBuffer = this.text.Substring(this.cursorIndex, this.selectIndex - this.cursorIndex);
					}
					else
					{
						systemCopyBuffer = this.text.Substring(this.selectIndex, this.cursorIndex - this.selectIndex);
					}
					GUIUtility.systemCopyBuffer = systemCopyBuffer;
				}
			}
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x0003B5D4 File Offset: 0x000397D4
		private static string ReplaceNewlinesWithSpaces(string value)
		{
			value = value.Replace("\r\n", " ");
			value = value.Replace('\n', ' ');
			value = value.Replace('\r', ' ');
			return value;
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x0003B614 File Offset: 0x00039814
		public bool Paste()
		{
			string text = GUIUtility.systemCopyBuffer;
			bool result;
			if (text != "")
			{
				if (!this.multiline)
				{
					text = TextEditor.ReplaceNewlinesWithSpaces(text);
				}
				this.ReplaceSelection(text);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0003B664 File Offset: 0x00039864
		private static void MapKey(string key, TextEditor.TextEditOp action)
		{
			TextEditor.s_Keyactions[Event.KeyboardEvent(key)] = action;
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0003B678 File Offset: 0x00039878
		private void InitKeyActions()
		{
			if (TextEditor.s_Keyactions == null)
			{
				TextEditor.s_Keyactions = new Dictionary<Event, TextEditor.TextEditOp>();
				TextEditor.MapKey("left", TextEditor.TextEditOp.MoveLeft);
				TextEditor.MapKey("right", TextEditor.TextEditOp.MoveRight);
				TextEditor.MapKey("up", TextEditor.TextEditOp.MoveUp);
				TextEditor.MapKey("down", TextEditor.TextEditOp.MoveDown);
				TextEditor.MapKey("#left", TextEditor.TextEditOp.SelectLeft);
				TextEditor.MapKey("#right", TextEditor.TextEditOp.SelectRight);
				TextEditor.MapKey("#up", TextEditor.TextEditOp.SelectUp);
				TextEditor.MapKey("#down", TextEditor.TextEditOp.SelectDown);
				TextEditor.MapKey("delete", TextEditor.TextEditOp.Delete);
				TextEditor.MapKey("backspace", TextEditor.TextEditOp.Backspace);
				TextEditor.MapKey("#backspace", TextEditor.TextEditOp.Backspace);
				if (SystemInfo.operatingSystemFamily == OperatingSystemFamily.MacOSX)
				{
					TextEditor.MapKey("^left", TextEditor.TextEditOp.MoveGraphicalLineStart);
					TextEditor.MapKey("^right", TextEditor.TextEditOp.MoveGraphicalLineEnd);
					TextEditor.MapKey("&left", TextEditor.TextEditOp.MoveWordLeft);
					TextEditor.MapKey("&right", TextEditor.TextEditOp.MoveWordRight);
					TextEditor.MapKey("&up", TextEditor.TextEditOp.MoveParagraphBackward);
					TextEditor.MapKey("&down", TextEditor.TextEditOp.MoveParagraphForward);
					TextEditor.MapKey("%left", TextEditor.TextEditOp.MoveGraphicalLineStart);
					TextEditor.MapKey("%right", TextEditor.TextEditOp.MoveGraphicalLineEnd);
					TextEditor.MapKey("%up", TextEditor.TextEditOp.MoveTextStart);
					TextEditor.MapKey("%down", TextEditor.TextEditOp.MoveTextEnd);
					TextEditor.MapKey("#home", TextEditor.TextEditOp.SelectTextStart);
					TextEditor.MapKey("#end", TextEditor.TextEditOp.SelectTextEnd);
					TextEditor.MapKey("#^left", TextEditor.TextEditOp.ExpandSelectGraphicalLineStart);
					TextEditor.MapKey("#^right", TextEditor.TextEditOp.ExpandSelectGraphicalLineEnd);
					TextEditor.MapKey("#^up", TextEditor.TextEditOp.SelectParagraphBackward);
					TextEditor.MapKey("#^down", TextEditor.TextEditOp.SelectParagraphForward);
					TextEditor.MapKey("#&left", TextEditor.TextEditOp.SelectWordLeft);
					TextEditor.MapKey("#&right", TextEditor.TextEditOp.SelectWordRight);
					TextEditor.MapKey("#&up", TextEditor.TextEditOp.SelectParagraphBackward);
					TextEditor.MapKey("#&down", TextEditor.TextEditOp.SelectParagraphForward);
					TextEditor.MapKey("#%left", TextEditor.TextEditOp.ExpandSelectGraphicalLineStart);
					TextEditor.MapKey("#%right", TextEditor.TextEditOp.ExpandSelectGraphicalLineEnd);
					TextEditor.MapKey("#%up", TextEditor.TextEditOp.SelectTextStart);
					TextEditor.MapKey("#%down", TextEditor.TextEditOp.SelectTextEnd);
					TextEditor.MapKey("%a", TextEditor.TextEditOp.SelectAll);
					TextEditor.MapKey("%x", TextEditor.TextEditOp.Cut);
					TextEditor.MapKey("%c", TextEditor.TextEditOp.Copy);
					TextEditor.MapKey("%v", TextEditor.TextEditOp.Paste);
					TextEditor.MapKey("^d", TextEditor.TextEditOp.Delete);
					TextEditor.MapKey("^h", TextEditor.TextEditOp.Backspace);
					TextEditor.MapKey("^b", TextEditor.TextEditOp.MoveLeft);
					TextEditor.MapKey("^f", TextEditor.TextEditOp.MoveRight);
					TextEditor.MapKey("^a", TextEditor.TextEditOp.MoveLineStart);
					TextEditor.MapKey("^e", TextEditor.TextEditOp.MoveLineEnd);
					TextEditor.MapKey("&delete", TextEditor.TextEditOp.DeleteWordForward);
					TextEditor.MapKey("&backspace", TextEditor.TextEditOp.DeleteWordBack);
					TextEditor.MapKey("%backspace", TextEditor.TextEditOp.DeleteLineBack);
				}
				else
				{
					TextEditor.MapKey("home", TextEditor.TextEditOp.MoveGraphicalLineStart);
					TextEditor.MapKey("end", TextEditor.TextEditOp.MoveGraphicalLineEnd);
					TextEditor.MapKey("%left", TextEditor.TextEditOp.MoveWordLeft);
					TextEditor.MapKey("%right", TextEditor.TextEditOp.MoveWordRight);
					TextEditor.MapKey("%up", TextEditor.TextEditOp.MoveParagraphBackward);
					TextEditor.MapKey("%down", TextEditor.TextEditOp.MoveParagraphForward);
					TextEditor.MapKey("^left", TextEditor.TextEditOp.MoveToEndOfPreviousWord);
					TextEditor.MapKey("^right", TextEditor.TextEditOp.MoveToStartOfNextWord);
					TextEditor.MapKey("^up", TextEditor.TextEditOp.MoveParagraphBackward);
					TextEditor.MapKey("^down", TextEditor.TextEditOp.MoveParagraphForward);
					TextEditor.MapKey("#^left", TextEditor.TextEditOp.SelectToEndOfPreviousWord);
					TextEditor.MapKey("#^right", TextEditor.TextEditOp.SelectToStartOfNextWord);
					TextEditor.MapKey("#^up", TextEditor.TextEditOp.SelectParagraphBackward);
					TextEditor.MapKey("#^down", TextEditor.TextEditOp.SelectParagraphForward);
					TextEditor.MapKey("#home", TextEditor.TextEditOp.SelectGraphicalLineStart);
					TextEditor.MapKey("#end", TextEditor.TextEditOp.SelectGraphicalLineEnd);
					TextEditor.MapKey("^delete", TextEditor.TextEditOp.DeleteWordForward);
					TextEditor.MapKey("^backspace", TextEditor.TextEditOp.DeleteWordBack);
					TextEditor.MapKey("%backspace", TextEditor.TextEditOp.DeleteLineBack);
					TextEditor.MapKey("^a", TextEditor.TextEditOp.SelectAll);
					TextEditor.MapKey("^x", TextEditor.TextEditOp.Cut);
					TextEditor.MapKey("^c", TextEditor.TextEditOp.Copy);
					TextEditor.MapKey("^v", TextEditor.TextEditOp.Paste);
					TextEditor.MapKey("#delete", TextEditor.TextEditOp.Cut);
					TextEditor.MapKey("^insert", TextEditor.TextEditOp.Copy);
					TextEditor.MapKey("#insert", TextEditor.TextEditOp.Paste);
				}
			}
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x0003BA24 File Offset: 0x00039C24
		public void DetectFocusChange()
		{
			if (this.m_HasFocus && this.controlID != GUIUtility.keyboardControl)
			{
				this.OnLostFocus();
			}
			if (!this.m_HasFocus && this.controlID == GUIUtility.keyboardControl)
			{
				this.OnFocus();
			}
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x0003BA74 File Offset: 0x00039C74
		private void ClampTextIndex(ref int index)
		{
			index = Mathf.Clamp(index, 0, this.text.Length);
		}

		// Token: 0x040007C3 RID: 1987
		public TouchScreenKeyboard keyboardOnScreen = null;

		// Token: 0x040007C4 RID: 1988
		public int controlID = 0;

		// Token: 0x040007C5 RID: 1989
		public GUIStyle style = GUIStyle.none;

		// Token: 0x040007C6 RID: 1990
		public bool multiline = false;

		// Token: 0x040007C7 RID: 1991
		public bool hasHorizontalCursorPos = false;

		// Token: 0x040007C8 RID: 1992
		public bool isPasswordField = false;

		// Token: 0x040007C9 RID: 1993
		internal bool m_HasFocus;

		// Token: 0x040007CA RID: 1994
		public Vector2 scrollOffset = Vector2.zero;

		// Token: 0x040007CB RID: 1995
		private GUIContent m_Content = new GUIContent();

		// Token: 0x040007CC RID: 1996
		private Rect m_Position;

		// Token: 0x040007CD RID: 1997
		private int m_CursorIndex = 0;

		// Token: 0x040007CE RID: 1998
		private int m_SelectIndex = 0;

		// Token: 0x040007CF RID: 1999
		private bool m_RevealCursor = false;

		// Token: 0x040007D0 RID: 2000
		public Vector2 graphicalCursorPos;

		// Token: 0x040007D1 RID: 2001
		public Vector2 graphicalSelectCursorPos;

		// Token: 0x040007D2 RID: 2002
		private bool m_MouseDragSelectsWholeWords = false;

		// Token: 0x040007D3 RID: 2003
		private int m_DblClickInitPos = 0;

		// Token: 0x040007D4 RID: 2004
		private TextEditor.DblClickSnapping m_DblClickSnap = TextEditor.DblClickSnapping.WORDS;

		// Token: 0x040007D5 RID: 2005
		private bool m_bJustSelected = false;

		// Token: 0x040007D6 RID: 2006
		private int m_iAltCursorPos = -1;

		// Token: 0x040007D7 RID: 2007
		private string oldText;

		// Token: 0x040007D8 RID: 2008
		private int oldPos;

		// Token: 0x040007D9 RID: 2009
		private int oldSelectPos;

		// Token: 0x040007DA RID: 2010
		private static Dictionary<Event, TextEditor.TextEditOp> s_Keyactions;

		// Token: 0x02000273 RID: 627
		public enum DblClickSnapping : byte
		{
			// Token: 0x040007DC RID: 2012
			WORDS,
			// Token: 0x040007DD RID: 2013
			PARAGRAPHS
		}

		// Token: 0x02000274 RID: 628
		private enum CharacterType
		{
			// Token: 0x040007DF RID: 2015
			LetterLike,
			// Token: 0x040007E0 RID: 2016
			Symbol,
			// Token: 0x040007E1 RID: 2017
			Symbol2,
			// Token: 0x040007E2 RID: 2018
			WhiteSpace
		}

		// Token: 0x02000275 RID: 629
		private enum TextEditOp
		{
			// Token: 0x040007E4 RID: 2020
			MoveLeft,
			// Token: 0x040007E5 RID: 2021
			MoveRight,
			// Token: 0x040007E6 RID: 2022
			MoveUp,
			// Token: 0x040007E7 RID: 2023
			MoveDown,
			// Token: 0x040007E8 RID: 2024
			MoveLineStart,
			// Token: 0x040007E9 RID: 2025
			MoveLineEnd,
			// Token: 0x040007EA RID: 2026
			MoveTextStart,
			// Token: 0x040007EB RID: 2027
			MoveTextEnd,
			// Token: 0x040007EC RID: 2028
			MovePageUp,
			// Token: 0x040007ED RID: 2029
			MovePageDown,
			// Token: 0x040007EE RID: 2030
			MoveGraphicalLineStart,
			// Token: 0x040007EF RID: 2031
			MoveGraphicalLineEnd,
			// Token: 0x040007F0 RID: 2032
			MoveWordLeft,
			// Token: 0x040007F1 RID: 2033
			MoveWordRight,
			// Token: 0x040007F2 RID: 2034
			MoveParagraphForward,
			// Token: 0x040007F3 RID: 2035
			MoveParagraphBackward,
			// Token: 0x040007F4 RID: 2036
			MoveToStartOfNextWord,
			// Token: 0x040007F5 RID: 2037
			MoveToEndOfPreviousWord,
			// Token: 0x040007F6 RID: 2038
			SelectLeft,
			// Token: 0x040007F7 RID: 2039
			SelectRight,
			// Token: 0x040007F8 RID: 2040
			SelectUp,
			// Token: 0x040007F9 RID: 2041
			SelectDown,
			// Token: 0x040007FA RID: 2042
			SelectTextStart,
			// Token: 0x040007FB RID: 2043
			SelectTextEnd,
			// Token: 0x040007FC RID: 2044
			SelectPageUp,
			// Token: 0x040007FD RID: 2045
			SelectPageDown,
			// Token: 0x040007FE RID: 2046
			ExpandSelectGraphicalLineStart,
			// Token: 0x040007FF RID: 2047
			ExpandSelectGraphicalLineEnd,
			// Token: 0x04000800 RID: 2048
			SelectGraphicalLineStart,
			// Token: 0x04000801 RID: 2049
			SelectGraphicalLineEnd,
			// Token: 0x04000802 RID: 2050
			SelectWordLeft,
			// Token: 0x04000803 RID: 2051
			SelectWordRight,
			// Token: 0x04000804 RID: 2052
			SelectToEndOfPreviousWord,
			// Token: 0x04000805 RID: 2053
			SelectToStartOfNextWord,
			// Token: 0x04000806 RID: 2054
			SelectParagraphBackward,
			// Token: 0x04000807 RID: 2055
			SelectParagraphForward,
			// Token: 0x04000808 RID: 2056
			Delete,
			// Token: 0x04000809 RID: 2057
			Backspace,
			// Token: 0x0400080A RID: 2058
			DeleteWordBack,
			// Token: 0x0400080B RID: 2059
			DeleteWordForward,
			// Token: 0x0400080C RID: 2060
			DeleteLineBack,
			// Token: 0x0400080D RID: 2061
			Cut,
			// Token: 0x0400080E RID: 2062
			Copy,
			// Token: 0x0400080F RID: 2063
			Paste,
			// Token: 0x04000810 RID: 2064
			SelectAll,
			// Token: 0x04000811 RID: 2065
			SelectNone,
			// Token: 0x04000812 RID: 2066
			ScrollStart,
			// Token: 0x04000813 RID: 2067
			ScrollEnd,
			// Token: 0x04000814 RID: 2068
			ScrollPageUp,
			// Token: 0x04000815 RID: 2069
			ScrollPageDown
		}
	}
}
