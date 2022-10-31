using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000247 RID: 583
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Event
	{
		// Token: 0x060026C7 RID: 9927 RVA: 0x0002C948 File Offset: 0x0002AB48
		public Event()
		{
			this.Init(0);
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x0002C958 File Offset: 0x0002AB58
		public Event(int displayIndex)
		{
			this.Init(displayIndex);
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0002C968 File Offset: 0x0002AB68
		public Event(Event other)
		{
			if (other == null)
			{
				throw new ArgumentException("Event to copy from is null.");
			}
			this.InitCopy(other);
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x0002C98C File Offset: 0x0002AB8C
		private Event(IntPtr ptr)
		{
			this.InitPtr(ptr);
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0002C99C File Offset: 0x0002AB9C
		~Event()
		{
			this.Cleanup();
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x0002C9CC File Offset: 0x0002ABCC
		internal static void CleanupRoots()
		{
			Event.s_Current = null;
			Event.s_MasterEvent = null;
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x0002C9DC File Offset: 0x0002ABDC
		// (set) Token: 0x060026CE RID: 9934 RVA: 0x0002C9FC File Offset: 0x0002ABFC
		public Vector2 mousePosition
		{
			get
			{
				Vector2 result;
				this.Internal_GetMousePosition(out result);
				return result;
			}
			set
			{
				this.Internal_SetMousePosition(value);
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x0002CA08 File Offset: 0x0002AC08
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x0002CA28 File Offset: 0x0002AC28
		public Vector2 delta
		{
			get
			{
				Vector2 result;
				this.Internal_GetMouseDelta(out result);
				return result;
			}
			set
			{
				this.Internal_SetMouseDelta(value);
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x0002CA34 File Offset: 0x0002AC34
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x0002CA58 File Offset: 0x0002AC58
		[Obsolete("Use HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);", true)]
		public Ray mouseRay
		{
			get
			{
				return new Ray(Vector3.up, Vector3.up);
			}
			set
			{
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x0002CA5C File Offset: 0x0002AC5C
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x0002CA80 File Offset: 0x0002AC80
		public bool shift
		{
			get
			{
				return (this.modifiers & EventModifiers.Shift) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.Shift;
				}
				else
				{
					this.modifiers |= EventModifiers.Shift;
				}
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x0002CAAC File Offset: 0x0002ACAC
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x0002CAD0 File Offset: 0x0002ACD0
		public bool control
		{
			get
			{
				return (this.modifiers & EventModifiers.Control) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.Control;
				}
				else
				{
					this.modifiers |= EventModifiers.Control;
				}
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x0002CAFC File Offset: 0x0002ACFC
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x0002CB20 File Offset: 0x0002AD20
		public bool alt
		{
			get
			{
				return (this.modifiers & EventModifiers.Alt) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.Alt;
				}
				else
				{
					this.modifiers |= EventModifiers.Alt;
				}
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x0002CB4C File Offset: 0x0002AD4C
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x0002CB70 File Offset: 0x0002AD70
		public bool command
		{
			get
			{
				return (this.modifiers & EventModifiers.Command) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.Command;
				}
				else
				{
					this.modifiers |= EventModifiers.Command;
				}
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x0002CB9C File Offset: 0x0002AD9C
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x0002CBC0 File Offset: 0x0002ADC0
		public bool capsLock
		{
			get
			{
				return (this.modifiers & EventModifiers.CapsLock) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.CapsLock;
				}
				else
				{
					this.modifiers |= EventModifiers.CapsLock;
				}
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x0002CBEC File Offset: 0x0002ADEC
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x0002CC10 File Offset: 0x0002AE10
		public bool numeric
		{
			get
			{
				return (this.modifiers & EventModifiers.Numeric) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.Shift;
				}
				else
				{
					this.modifiers |= EventModifiers.Shift;
				}
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x0002CC3C File Offset: 0x0002AE3C
		public bool functionKey
		{
			get
			{
				return (this.modifiers & EventModifiers.FunctionKey) != EventModifiers.None;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x0002CC60 File Offset: 0x0002AE60
		// (set) Token: 0x060026E1 RID: 9953 RVA: 0x0002CC7C File Offset: 0x0002AE7C
		public static Event current
		{
			get
			{
				return Event.s_Current;
			}
			set
			{
				if (value != null)
				{
					Event.s_Current = value;
				}
				else
				{
					Event.s_Current = Event.s_MasterEvent;
				}
				Event.Internal_SetNativeEvent(Event.s_Current.m_Ptr);
			}
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x0002CCAC File Offset: 0x0002AEAC
		[RequiredByNativeCode]
		private static void Internal_MakeMasterEventCurrent(int displayIndex)
		{
			if (Event.s_MasterEvent == null)
			{
				Event.s_MasterEvent = new Event(displayIndex);
			}
			Event.s_MasterEvent.displayIndex = displayIndex;
			Event.s_Current = Event.s_MasterEvent;
			Event.Internal_SetNativeEvent(Event.s_MasterEvent.m_Ptr);
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x0002CCE8 File Offset: 0x0002AEE8
		public bool isKey
		{
			get
			{
				EventType type = this.type;
				return type == EventType.KeyDown || type == EventType.KeyUp;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060026E4 RID: 9956 RVA: 0x0002CD14 File Offset: 0x0002AF14
		public bool isMouse
		{
			get
			{
				EventType type = this.type;
				return type == EventType.MouseMove || type == EventType.MouseDown || type == EventType.MouseUp || type == EventType.MouseDrag || type == EventType.ContextClick || type == EventType.MouseEnterWindow || type == EventType.MouseLeaveWindow;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x0002CD64 File Offset: 0x0002AF64
		public bool isScrollWheel
		{
			get
			{
				EventType type = this.type;
				return type == EventType.ScrollWheel || type == EventType.ScrollWheel;
			}
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x0002CD90 File Offset: 0x0002AF90
		public static Event KeyboardEvent(string key)
		{
			Event @event = new Event(0);
			@event.type = EventType.KeyDown;
			Event result;
			if (string.IsNullOrEmpty(key))
			{
				result = @event;
			}
			else
			{
				int num = 0;
				bool flag;
				do
				{
					flag = true;
					if (num >= key.Length)
					{
						break;
					}
					char c = key[num];
					switch (c)
					{
					case '#':
						@event.modifiers |= EventModifiers.Shift;
						num++;
						break;
					default:
						if (c != '^')
						{
							flag = false;
						}
						else
						{
							@event.modifiers |= EventModifiers.Control;
							num++;
						}
						break;
					case '%':
						@event.modifiers |= EventModifiers.Command;
						num++;
						break;
					case '&':
						@event.modifiers |= EventModifiers.Alt;
						num++;
						break;
					}
				}
				while (flag);
				string text = key.Substring(num, key.Length - num).ToLower();
				switch (text)
				{
				case "[0]":
					@event.character = '0';
					@event.keyCode = KeyCode.Keypad0;
					goto IL_A83;
				case "[1]":
					@event.character = '1';
					@event.keyCode = KeyCode.Keypad1;
					goto IL_A83;
				case "[2]":
					@event.character = '2';
					@event.keyCode = KeyCode.Keypad2;
					goto IL_A83;
				case "[3]":
					@event.character = '3';
					@event.keyCode = KeyCode.Keypad3;
					goto IL_A83;
				case "[4]":
					@event.character = '4';
					@event.keyCode = KeyCode.Keypad4;
					goto IL_A83;
				case "[5]":
					@event.character = '5';
					@event.keyCode = KeyCode.Keypad5;
					goto IL_A83;
				case "[6]":
					@event.character = '6';
					@event.keyCode = KeyCode.Keypad6;
					goto IL_A83;
				case "[7]":
					@event.character = '7';
					@event.keyCode = KeyCode.Keypad7;
					goto IL_A83;
				case "[8]":
					@event.character = '8';
					@event.keyCode = KeyCode.Keypad8;
					goto IL_A83;
				case "[9]":
					@event.character = '9';
					@event.keyCode = KeyCode.Keypad9;
					goto IL_A83;
				case "[.]":
					@event.character = '.';
					@event.keyCode = KeyCode.KeypadPeriod;
					goto IL_A83;
				case "[/]":
					@event.character = '/';
					@event.keyCode = KeyCode.KeypadDivide;
					goto IL_A83;
				case "[-]":
					@event.character = '-';
					@event.keyCode = KeyCode.KeypadMinus;
					goto IL_A83;
				case "[+]":
					@event.character = '+';
					@event.keyCode = KeyCode.KeypadPlus;
					goto IL_A83;
				case "[=]":
					@event.character = '=';
					@event.keyCode = KeyCode.KeypadEquals;
					goto IL_A83;
				case "[equals]":
					@event.character = '=';
					@event.keyCode = KeyCode.KeypadEquals;
					goto IL_A83;
				case "[enter]":
					@event.character = '\n';
					@event.keyCode = KeyCode.KeypadEnter;
					goto IL_A83;
				case "up":
					@event.keyCode = KeyCode.UpArrow;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "down":
					@event.keyCode = KeyCode.DownArrow;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "left":
					@event.keyCode = KeyCode.LeftArrow;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "right":
					@event.keyCode = KeyCode.RightArrow;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "insert":
					@event.keyCode = KeyCode.Insert;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "home":
					@event.keyCode = KeyCode.Home;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "end":
					@event.keyCode = KeyCode.End;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "pgup":
					@event.keyCode = KeyCode.PageDown;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "page up":
					@event.keyCode = KeyCode.PageUp;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "pgdown":
					@event.keyCode = KeyCode.PageUp;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "page down":
					@event.keyCode = KeyCode.PageDown;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "backspace":
					@event.keyCode = KeyCode.Backspace;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "delete":
					@event.keyCode = KeyCode.Delete;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "tab":
					@event.keyCode = KeyCode.Tab;
					goto IL_A83;
				case "f1":
					@event.keyCode = KeyCode.F1;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f2":
					@event.keyCode = KeyCode.F2;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f3":
					@event.keyCode = KeyCode.F3;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f4":
					@event.keyCode = KeyCode.F4;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f5":
					@event.keyCode = KeyCode.F5;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f6":
					@event.keyCode = KeyCode.F6;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f7":
					@event.keyCode = KeyCode.F7;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f8":
					@event.keyCode = KeyCode.F8;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f9":
					@event.keyCode = KeyCode.F9;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f10":
					@event.keyCode = KeyCode.F10;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f11":
					@event.keyCode = KeyCode.F11;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f12":
					@event.keyCode = KeyCode.F12;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f13":
					@event.keyCode = KeyCode.F13;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f14":
					@event.keyCode = KeyCode.F14;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "f15":
					@event.keyCode = KeyCode.F15;
					@event.modifiers |= EventModifiers.FunctionKey;
					goto IL_A83;
				case "[esc]":
					@event.keyCode = KeyCode.Escape;
					goto IL_A83;
				case "return":
					@event.character = '\n';
					@event.keyCode = KeyCode.Return;
					@event.modifiers &= ~EventModifiers.FunctionKey;
					goto IL_A83;
				case "space":
					@event.keyCode = KeyCode.Space;
					@event.character = ' ';
					@event.modifiers &= ~EventModifiers.FunctionKey;
					goto IL_A83;
				}
				if (text.Length != 1)
				{
					try
					{
						@event.keyCode = (KeyCode)Enum.Parse(typeof(KeyCode), text, true);
					}
					catch (ArgumentException)
					{
						Debug.LogError(UnityString.Format("Unable to find key name that matches '{0}'", new object[]
						{
							text
						}));
					}
				}
				else
				{
					@event.character = text.ToLower()[0];
					@event.keyCode = (KeyCode)@event.character;
					if (@event.modifiers != EventModifiers.None)
					{
						@event.character = '\0';
					}
				}
				IL_A83:
				result = @event;
			}
			return result;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x0002D838 File Offset: 0x0002BA38
		public override int GetHashCode()
		{
			int num = 1;
			if (this.isKey)
			{
				num = (int)((ushort)this.keyCode);
			}
			if (this.isMouse)
			{
				num = this.mousePosition.GetHashCode();
			}
			return num * 37 | (int)this.modifiers;
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x0002D890 File Offset: 0x0002BA90
		public override bool Equals(object obj)
		{
			bool result;
			if (obj == null)
			{
				result = false;
			}
			else if (object.ReferenceEquals(this, obj))
			{
				result = true;
			}
			else if (obj.GetType() != base.GetType())
			{
				result = false;
			}
			else
			{
				Event @event = (Event)obj;
				if (this.type != @event.type || (this.modifiers & ~EventModifiers.CapsLock) != (@event.modifiers & ~EventModifiers.CapsLock))
				{
					result = false;
				}
				else if (this.isKey)
				{
					result = (this.keyCode == @event.keyCode);
				}
				else
				{
					result = (this.isMouse && this.mousePosition == @event.mousePosition);
				}
			}
			return result;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0002D958 File Offset: 0x0002BB58
		public override string ToString()
		{
			string result;
			if (this.isKey)
			{
				if (this.character == '\0')
				{
					result = UnityString.Format("Event:{0}   Character:\\0   Modifiers:{1}   KeyCode:{2}", new object[]
					{
						this.type,
						this.modifiers,
						this.keyCode
					});
				}
				else
				{
					result = string.Concat(new object[]
					{
						"Event:",
						this.type,
						"   Character:",
						(int)this.character,
						"   Modifiers:",
						this.modifiers,
						"   KeyCode:",
						this.keyCode
					});
				}
			}
			else if (this.isMouse)
			{
				result = UnityString.Format("Event: {0}   Position: {1} Modifiers: {2}", new object[]
				{
					this.type,
					this.mousePosition,
					this.modifiers
				});
			}
			else if (this.type == EventType.ExecuteCommand || this.type == EventType.ValidateCommand)
			{
				result = UnityString.Format("Event: {0}  \"{1}\"", new object[]
				{
					this.type,
					this.commandName
				});
			}
			else
			{
				result = "" + this.type;
			}
			return result;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0002DAD4 File Offset: 0x0002BCD4
		public void Use()
		{
			if (this.type == EventType.Repaint || this.type == EventType.Layout)
			{
				Debug.LogWarning(UnityString.Format("Event.Use() should not be called for events of type {0}", new object[]
				{
					this.type
				}));
			}
			this.Internal_Use();
		}

		// Token: 0x060026EB RID: 9963
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init(int displayIndex);

		// Token: 0x060026EC RID: 9964
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		// Token: 0x060026ED RID: 9965
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InitCopy(Event other);

		// Token: 0x060026EE RID: 9966
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InitPtr(IntPtr ptr);

		// Token: 0x060026EF RID: 9967
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void CopyFromPtr(IntPtr ptr);

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060026F0 RID: 9968
		public extern EventType rawType { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060026F1 RID: 9969
		// (set) Token: 0x060026F2 RID: 9970
		public extern EventType type { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060026F3 RID: 9971
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern EventType GetTypeForControl(int controlID);

		// Token: 0x060026F4 RID: 9972 RVA: 0x0002DB28 File Offset: 0x0002BD28
		private void Internal_SetMousePosition(Vector2 value)
		{
			Event.INTERNAL_CALL_Internal_SetMousePosition(this, ref value);
		}

		// Token: 0x060026F5 RID: 9973
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_SetMousePosition(Event self, ref Vector2 value);

		// Token: 0x060026F6 RID: 9974
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_GetMousePosition(out Vector2 value);

		// Token: 0x060026F7 RID: 9975 RVA: 0x0002DB34 File Offset: 0x0002BD34
		private void Internal_SetMouseDelta(Vector2 value)
		{
			Event.INTERNAL_CALL_Internal_SetMouseDelta(this, ref value);
		}

		// Token: 0x060026F8 RID: 9976
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_SetMouseDelta(Event self, ref Vector2 value);

		// Token: 0x060026F9 RID: 9977
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_GetMouseDelta(out Vector2 value);

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060026FA RID: 9978
		// (set) Token: 0x060026FB RID: 9979
		public extern int button { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060026FC RID: 9980
		// (set) Token: 0x060026FD RID: 9981
		public extern EventModifiers modifiers { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060026FE RID: 9982
		// (set) Token: 0x060026FF RID: 9983
		public extern float pressure { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06002700 RID: 9984
		// (set) Token: 0x06002701 RID: 9985
		public extern int clickCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002702 RID: 9986
		// (set) Token: 0x06002703 RID: 9987
		public extern char character { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002704 RID: 9988
		// (set) Token: 0x06002705 RID: 9989
		public extern string commandName { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06002706 RID: 9990
		// (set) Token: 0x06002707 RID: 9991
		public extern KeyCode keyCode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002708 RID: 9992
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetNativeEvent(IntPtr ptr);

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06002709 RID: 9993
		// (set) Token: 0x0600270A RID: 9994
		public extern int displayIndex { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x0600270B RID: 9995
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_Use();

		// Token: 0x0600270C RID: 9996
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool PopEvent(Event outEvent);

		// Token: 0x0600270D RID: 9997
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetEventCount();

		// Token: 0x040006CF RID: 1743
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x040006D0 RID: 1744
		private static Event s_Current;

		// Token: 0x040006D1 RID: 1745
		private static Event s_MasterEvent;
	}
}
