using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000064 RID: 100
	[RequireComponent(typeof(Camera))]
	public sealed class GUILayer : Behaviour
	{
		// Token: 0x06000770 RID: 1904 RVA: 0x00009660 File Offset: 0x00007860
		public GUIElement HitTest(Vector3 screenPosition)
		{
			return GUILayer.INTERNAL_CALL_HitTest(this, ref screenPosition);
		}

		// Token: 0x06000771 RID: 1905
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern GUIElement INTERNAL_CALL_HitTest(GUILayer self, ref Vector3 screenPosition);
	}
}
