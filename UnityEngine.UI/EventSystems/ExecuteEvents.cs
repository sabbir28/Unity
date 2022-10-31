using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200001A RID: 26
	public static class ExecuteEvents
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00002AB4 File Offset: 0x00000EB4
		public static T ValidateEventData<T>(BaseEventData data) where T : class
		{
			if (!(data is T))
			{
				throw new ArgumentException(string.Format("Invalid type: {0} passed to event expecting {1}", data.GetType(), typeof(T)));
			}
			return data as T;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002B13 File Offset: 0x00000F13
		private static void Execute(IPointerEnterHandler handler, BaseEventData eventData)
		{
			handler.OnPointerEnter(ExecuteEvents.ValidateEventData<PointerEventData>(eventData));
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002B22 File Offset: 0x00000F22
		private static void Execute(IPointerExitHandler handler, BaseEventData eventData)
		{
			handler.OnPointerExit(ExecuteEvents.ValidateEventData<PointerEventData>(eventData));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002B31 File Offset: 0x00000F31
		private static void Execute(IPointerDownHandler handler, BaseEventData eventData)
		{
			handler.OnPointerDown(ExecuteEvents.ValidateEventData<PointerEventData>(eventData));
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002B40 File Offset: 0x00000F40
		private static void Execute(IPointerUpHandler handler, BaseEventData eventData)
		{
			handler.OnPointerUp(ExecuteEvents.ValidateEventData<PointerEventData>(eventData));
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002B4F File Offset: 0x00000F4F
		private static void Execute(IPointerClickHandler handler, BaseEventData eventData)
		{
			handler.OnPointerClick(ExecuteEvents.ValidateEventData<PointerEventData>(eventData));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002B5E File Offset: 0x00000F5E
		private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData)
		{
			handler.OnInitializePotentialDrag(ExecuteEvents.ValidateEventData<PointerEventData>(eventData));
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002B6D File Offset: 0x00000F6D
		private static void Execute(IBeginDragHandler handler, BaseEventData eventData)
		{
			handler.OnBeginDrag(ExecuteEvents.ValidateEventData<PointerEventData>(eventData));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002B7C File Offset: 0x00000F7C
		private static void Execute(IDragHandler handler, BaseEventData eventData)
		{
			handler.OnDrag(ExecuteEvents.ValidateEventData<PointerEventData>(eventData));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002B8B File Offset: 0x00000F8B
		private static void Execute(IEndDragHandler handler, BaseEventData eventData)
		{
			handler.OnEndDrag(ExecuteEvents.ValidateEventData<PointerEventData>(eventData));
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002B9A File Offset: 0x00000F9A
		private static void Execute(IDropHandler handler, BaseEventData eventData)
		{
			handler.OnDrop(ExecuteEvents.ValidateEventData<PointerEventData>(eventData));
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002BA9 File Offset: 0x00000FA9
		private static void Execute(IScrollHandler handler, BaseEventData eventData)
		{
			handler.OnScroll(ExecuteEvents.ValidateEventData<PointerEventData>(eventData));
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002BB8 File Offset: 0x00000FB8
		private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData)
		{
			handler.OnUpdateSelected(eventData);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002BC2 File Offset: 0x00000FC2
		private static void Execute(ISelectHandler handler, BaseEventData eventData)
		{
			handler.OnSelect(eventData);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002BCC File Offset: 0x00000FCC
		private static void Execute(IDeselectHandler handler, BaseEventData eventData)
		{
			handler.OnDeselect(eventData);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002BD6 File Offset: 0x00000FD6
		private static void Execute(IMoveHandler handler, BaseEventData eventData)
		{
			handler.OnMove(ExecuteEvents.ValidateEventData<AxisEventData>(eventData));
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002BE5 File Offset: 0x00000FE5
		private static void Execute(ISubmitHandler handler, BaseEventData eventData)
		{
			handler.OnSubmit(eventData);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002BEF File Offset: 0x00000FEF
		private static void Execute(ICancelHandler handler, BaseEventData eventData)
		{
			handler.OnCancel(eventData);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002BFC File Offset: 0x00000FFC
		public static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler
		{
			get
			{
				return ExecuteEvents.s_PointerEnterHandler;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002C18 File Offset: 0x00001018
		public static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler
		{
			get
			{
				return ExecuteEvents.s_PointerExitHandler;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002C34 File Offset: 0x00001034
		public static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler
		{
			get
			{
				return ExecuteEvents.s_PointerDownHandler;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002C50 File Offset: 0x00001050
		public static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler
		{
			get
			{
				return ExecuteEvents.s_PointerUpHandler;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002C6C File Offset: 0x0000106C
		public static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler
		{
			get
			{
				return ExecuteEvents.s_PointerClickHandler;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002C88 File Offset: 0x00001088
		public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
		{
			get
			{
				return ExecuteEvents.s_InitializePotentialDragHandler;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002CA4 File Offset: 0x000010A4
		public static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler
		{
			get
			{
				return ExecuteEvents.s_BeginDragHandler;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002CC0 File Offset: 0x000010C0
		public static ExecuteEvents.EventFunction<IDragHandler> dragHandler
		{
			get
			{
				return ExecuteEvents.s_DragHandler;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002CDC File Offset: 0x000010DC
		public static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler
		{
			get
			{
				return ExecuteEvents.s_EndDragHandler;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002CF8 File Offset: 0x000010F8
		public static ExecuteEvents.EventFunction<IDropHandler> dropHandler
		{
			get
			{
				return ExecuteEvents.s_DropHandler;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002D14 File Offset: 0x00001114
		public static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler
		{
			get
			{
				return ExecuteEvents.s_ScrollHandler;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002D30 File Offset: 0x00001130
		public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler
		{
			get
			{
				return ExecuteEvents.s_UpdateSelectedHandler;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002D4C File Offset: 0x0000114C
		public static ExecuteEvents.EventFunction<ISelectHandler> selectHandler
		{
			get
			{
				return ExecuteEvents.s_SelectHandler;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002D68 File Offset: 0x00001168
		public static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler
		{
			get
			{
				return ExecuteEvents.s_DeselectHandler;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002D84 File Offset: 0x00001184
		public static ExecuteEvents.EventFunction<IMoveHandler> moveHandler
		{
			get
			{
				return ExecuteEvents.s_MoveHandler;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002DA0 File Offset: 0x000011A0
		public static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler
		{
			get
			{
				return ExecuteEvents.s_SubmitHandler;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002DBC File Offset: 0x000011BC
		public static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler
		{
			get
			{
				return ExecuteEvents.s_CancelHandler;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002DD8 File Offset: 0x000011D8
		private static void GetEventChain(GameObject root, IList<Transform> eventChain)
		{
			eventChain.Clear();
			if (!(root == null))
			{
				Transform transform = root.transform;
				while (transform != null)
				{
					eventChain.Add(transform);
					transform = transform.parent;
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002E28 File Offset: 0x00001228
		public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) where T : IEventSystemHandler
		{
			List<IEventSystemHandler> list = ExecuteEvents.s_HandlerListPool.Get();
			ExecuteEvents.GetEventList<T>(target, list);
			int i = 0;
			while (i < list.Count)
			{
				T handler;
				try
				{
					handler = (T)((object)list[i]);
				}
				catch (Exception innerException)
				{
					IEventSystemHandler eventSystemHandler = list[i];
					Debug.LogException(new Exception(string.Format("Type {0} expected {1} received.", typeof(T).Name, eventSystemHandler.GetType().Name), innerException));
					goto IL_8F;
				}
				goto Block_2;
				IL_8F:
				i++;
				continue;
				Block_2:
				try
				{
					functor(handler, eventData);
				}
				catch (Exception exception)
				{
					Debug.LogException(exception);
				}
				goto IL_8F;
			}
			int count = list.Count;
			ExecuteEvents.s_HandlerListPool.Release(list);
			return count > 0;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002F14 File Offset: 0x00001314
		public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) where T : IEventSystemHandler
		{
			ExecuteEvents.GetEventChain(root, ExecuteEvents.s_InternalTransformList);
			for (int i = 0; i < ExecuteEvents.s_InternalTransformList.Count; i++)
			{
				Transform transform = ExecuteEvents.s_InternalTransformList[i];
				if (ExecuteEvents.Execute<T>(transform.gameObject, eventData, callbackFunction))
				{
					return transform.gameObject;
				}
			}
			return null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002F7C File Offset: 0x0000137C
		private static bool ShouldSendToComponent<T>(Component component) where T : IEventSystemHandler
		{
			bool result;
			if (!(component is T))
			{
				result = false;
			}
			else
			{
				Behaviour behaviour = component as Behaviour;
				result = (!(behaviour != null) || behaviour.isActiveAndEnabled);
			}
			return result;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002FC8 File Offset: 0x000013C8
		private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) where T : IEventSystemHandler
		{
			if (results == null)
			{
				throw new ArgumentException("Results array is null", "results");
			}
			if (!(go == null) && go.activeInHierarchy)
			{
				List<Component> list = ListPool<Component>.Get();
				go.GetComponents<Component>(list);
				for (int i = 0; i < list.Count; i++)
				{
					if (ExecuteEvents.ShouldSendToComponent<T>(list[i]))
					{
						results.Add(list[i] as IEventSystemHandler);
					}
				}
				ListPool<Component>.Release(list);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000305C File Offset: 0x0000145C
		public static bool CanHandleEvent<T>(GameObject go) where T : IEventSystemHandler
		{
			List<IEventSystemHandler> list = ExecuteEvents.s_HandlerListPool.Get();
			ExecuteEvents.GetEventList<T>(go, list);
			int count = list.Count;
			ExecuteEvents.s_HandlerListPool.Release(list);
			return count != 0;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000309C File Offset: 0x0000149C
		public static GameObject GetEventHandler<T>(GameObject root) where T : IEventSystemHandler
		{
			GameObject result;
			if (root == null)
			{
				result = null;
			}
			else
			{
				Transform transform = root.transform;
				while (transform != null)
				{
					if (ExecuteEvents.CanHandleEvent<T>(transform.gameObject))
					{
						return transform.gameObject;
					}
					transform = transform.parent;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003104 File Offset: 0x00001504
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteEvents()
		{
			if (ExecuteEvents.<>f__mg$cache0 == null)
			{
				ExecuteEvents.<>f__mg$cache0 = new ExecuteEvents.EventFunction<IPointerEnterHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_PointerEnterHandler = ExecuteEvents.<>f__mg$cache0;
			if (ExecuteEvents.<>f__mg$cache1 == null)
			{
				ExecuteEvents.<>f__mg$cache1 = new ExecuteEvents.EventFunction<IPointerExitHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_PointerExitHandler = ExecuteEvents.<>f__mg$cache1;
			if (ExecuteEvents.<>f__mg$cache2 == null)
			{
				ExecuteEvents.<>f__mg$cache2 = new ExecuteEvents.EventFunction<IPointerDownHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_PointerDownHandler = ExecuteEvents.<>f__mg$cache2;
			if (ExecuteEvents.<>f__mg$cache3 == null)
			{
				ExecuteEvents.<>f__mg$cache3 = new ExecuteEvents.EventFunction<IPointerUpHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_PointerUpHandler = ExecuteEvents.<>f__mg$cache3;
			if (ExecuteEvents.<>f__mg$cache4 == null)
			{
				ExecuteEvents.<>f__mg$cache4 = new ExecuteEvents.EventFunction<IPointerClickHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_PointerClickHandler = ExecuteEvents.<>f__mg$cache4;
			if (ExecuteEvents.<>f__mg$cache5 == null)
			{
				ExecuteEvents.<>f__mg$cache5 = new ExecuteEvents.EventFunction<IInitializePotentialDragHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_InitializePotentialDragHandler = ExecuteEvents.<>f__mg$cache5;
			if (ExecuteEvents.<>f__mg$cache6 == null)
			{
				ExecuteEvents.<>f__mg$cache6 = new ExecuteEvents.EventFunction<IBeginDragHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_BeginDragHandler = ExecuteEvents.<>f__mg$cache6;
			if (ExecuteEvents.<>f__mg$cache7 == null)
			{
				ExecuteEvents.<>f__mg$cache7 = new ExecuteEvents.EventFunction<IDragHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_DragHandler = ExecuteEvents.<>f__mg$cache7;
			if (ExecuteEvents.<>f__mg$cache8 == null)
			{
				ExecuteEvents.<>f__mg$cache8 = new ExecuteEvents.EventFunction<IEndDragHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_EndDragHandler = ExecuteEvents.<>f__mg$cache8;
			if (ExecuteEvents.<>f__mg$cache9 == null)
			{
				ExecuteEvents.<>f__mg$cache9 = new ExecuteEvents.EventFunction<IDropHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_DropHandler = ExecuteEvents.<>f__mg$cache9;
			if (ExecuteEvents.<>f__mg$cacheA == null)
			{
				ExecuteEvents.<>f__mg$cacheA = new ExecuteEvents.EventFunction<IScrollHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_ScrollHandler = ExecuteEvents.<>f__mg$cacheA;
			if (ExecuteEvents.<>f__mg$cacheB == null)
			{
				ExecuteEvents.<>f__mg$cacheB = new ExecuteEvents.EventFunction<IUpdateSelectedHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_UpdateSelectedHandler = ExecuteEvents.<>f__mg$cacheB;
			if (ExecuteEvents.<>f__mg$cacheC == null)
			{
				ExecuteEvents.<>f__mg$cacheC = new ExecuteEvents.EventFunction<ISelectHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_SelectHandler = ExecuteEvents.<>f__mg$cacheC;
			if (ExecuteEvents.<>f__mg$cacheD == null)
			{
				ExecuteEvents.<>f__mg$cacheD = new ExecuteEvents.EventFunction<IDeselectHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_DeselectHandler = ExecuteEvents.<>f__mg$cacheD;
			if (ExecuteEvents.<>f__mg$cacheE == null)
			{
				ExecuteEvents.<>f__mg$cacheE = new ExecuteEvents.EventFunction<IMoveHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_MoveHandler = ExecuteEvents.<>f__mg$cacheE;
			if (ExecuteEvents.<>f__mg$cacheF == null)
			{
				ExecuteEvents.<>f__mg$cacheF = new ExecuteEvents.EventFunction<ISubmitHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_SubmitHandler = ExecuteEvents.<>f__mg$cacheF;
			if (ExecuteEvents.<>f__mg$cache10 == null)
			{
				ExecuteEvents.<>f__mg$cache10 = new ExecuteEvents.EventFunction<ICancelHandler>(ExecuteEvents.Execute);
			}
			ExecuteEvents.s_CancelHandler = ExecuteEvents.<>f__mg$cache10;
			ExecuteEvents.s_HandlerListPool = new ObjectPool<List<IEventSystemHandler>>(null, delegate(List<IEventSystemHandler> l)
			{
				l.Clear();
			});
			ExecuteEvents.s_InternalTransformList = new List<Transform>(30);
		}

		// Token: 0x04000026 RID: 38
		private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler;

		// Token: 0x04000027 RID: 39
		private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler;

		// Token: 0x04000028 RID: 40
		private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler;

		// Token: 0x04000029 RID: 41
		private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler;

		// Token: 0x0400002A RID: 42
		private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler;

		// Token: 0x0400002B RID: 43
		private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler;

		// Token: 0x0400002C RID: 44
		private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler;

		// Token: 0x0400002D RID: 45
		private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler;

		// Token: 0x0400002E RID: 46
		private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler;

		// Token: 0x0400002F RID: 47
		private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler;

		// Token: 0x04000030 RID: 48
		private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler;

		// Token: 0x04000031 RID: 49
		private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler;

		// Token: 0x04000032 RID: 50
		private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler;

		// Token: 0x04000033 RID: 51
		private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler;

		// Token: 0x04000034 RID: 52
		private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler;

		// Token: 0x04000035 RID: 53
		private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler;

		// Token: 0x04000036 RID: 54
		private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler;

		// Token: 0x04000037 RID: 55
		private static readonly ObjectPool<List<IEventSystemHandler>> s_HandlerListPool;

		// Token: 0x04000038 RID: 56
		private static readonly List<Transform> s_InternalTransformList;

		// Token: 0x04000039 RID: 57
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IPointerEnterHandler> <>f__mg$cache0;

		// Token: 0x0400003A RID: 58
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IPointerExitHandler> <>f__mg$cache1;

		// Token: 0x0400003B RID: 59
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IPointerDownHandler> <>f__mg$cache2;

		// Token: 0x0400003C RID: 60
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IPointerUpHandler> <>f__mg$cache3;

		// Token: 0x0400003D RID: 61
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IPointerClickHandler> <>f__mg$cache4;

		// Token: 0x0400003E RID: 62
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> <>f__mg$cache5;

		// Token: 0x0400003F RID: 63
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IBeginDragHandler> <>f__mg$cache6;

		// Token: 0x04000040 RID: 64
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IDragHandler> <>f__mg$cache7;

		// Token: 0x04000041 RID: 65
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IEndDragHandler> <>f__mg$cache8;

		// Token: 0x04000042 RID: 66
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IDropHandler> <>f__mg$cache9;

		// Token: 0x04000043 RID: 67
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IScrollHandler> <>f__mg$cacheA;

		// Token: 0x04000044 RID: 68
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IUpdateSelectedHandler> <>f__mg$cacheB;

		// Token: 0x04000045 RID: 69
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<ISelectHandler> <>f__mg$cacheC;

		// Token: 0x04000046 RID: 70
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IDeselectHandler> <>f__mg$cacheD;

		// Token: 0x04000047 RID: 71
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<IMoveHandler> <>f__mg$cacheE;

		// Token: 0x04000048 RID: 72
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<ISubmitHandler> <>f__mg$cacheF;

		// Token: 0x04000049 RID: 73
		[CompilerGenerated]
		private static ExecuteEvents.EventFunction<ICancelHandler> <>f__mg$cache10;

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000073 RID: 115
		public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData);
	}
}
