using System;
using System.Reflection;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200026B RID: 619
	[AttributeUsage(AttributeTargets.Method)]
	public class GUITargetAttribute : Attribute
	{
		// Token: 0x060029C5 RID: 10693 RVA: 0x00037908 File Offset: 0x00035B08
		public GUITargetAttribute()
		{
			this.displayMask = -1;
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x00037918 File Offset: 0x00035B18
		public GUITargetAttribute(int displayIndex)
		{
			this.displayMask = 1 << displayIndex;
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x00037930 File Offset: 0x00035B30
		public GUITargetAttribute(int displayIndex, int displayIndex1)
		{
			this.displayMask = (1 << displayIndex | 1 << displayIndex1);
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x0003794C File Offset: 0x00035B4C
		public GUITargetAttribute(int displayIndex, int displayIndex1, params int[] displayIndexList)
		{
			this.displayMask = (1 << displayIndex | 1 << displayIndex1);
			for (int i = 0; i < displayIndexList.Length; i++)
			{
				this.displayMask |= 1 << displayIndexList[i];
			}
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x0003799C File Offset: 0x00035B9C
		[RequiredByNativeCode]
		private static int GetGUITargetAttrValue(Type klass, string methodName)
		{
			MethodInfo method = klass.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (method != null)
			{
				object[] customAttributes = method.GetCustomAttributes(true);
				if (customAttributes != null)
				{
					for (int i = 0; i < customAttributes.Length; i++)
					{
						if (customAttributes[i].GetType() == typeof(GUITargetAttribute))
						{
							GUITargetAttribute guitargetAttribute = customAttributes[i] as GUITargetAttribute;
							return guitargetAttribute.displayMask;
						}
					}
				}
			}
			return -1;
		}

		// Token: 0x040007AD RID: 1965
		internal int displayMask;
	}
}
