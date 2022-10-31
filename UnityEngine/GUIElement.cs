using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000062 RID: 98
	[RequireComponent(typeof(Transform))]
	public class GUIElement : Behaviour
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x00009574 File Offset: 0x00007774
		public bool HitTest(Vector3 screenPosition, [DefaultValue("null")] Camera camera)
		{
			return GUIElement.INTERNAL_CALL_HitTest(this, ref screenPosition, camera);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00009594 File Offset: 0x00007794
		[ExcludeFromDocs]
		public bool HitTest(Vector3 screenPosition)
		{
			Camera camera = null;
			return GUIElement.INTERNAL_CALL_HitTest(this, ref screenPosition, camera);
		}

		// Token: 0x0600075E RID: 1886
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_HitTest(GUIElement self, ref Vector3 screenPosition, Camera camera);

		// Token: 0x0600075F RID: 1887 RVA: 0x000095B4 File Offset: 0x000077B4
		public Rect GetScreenRect([DefaultValue("null")] Camera camera)
		{
			Rect result;
			GUIElement.INTERNAL_CALL_GetScreenRect(this, camera, out result);
			return result;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000095D4 File Offset: 0x000077D4
		[ExcludeFromDocs]
		public Rect GetScreenRect()
		{
			Camera camera = null;
			Rect result;
			GUIElement.INTERNAL_CALL_GetScreenRect(this, camera, out result);
			return result;
		}

		// Token: 0x06000761 RID: 1889
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetScreenRect(GUIElement self, Camera camera, out Rect value);
	}
}
