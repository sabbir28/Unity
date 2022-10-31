﻿using System;
using System.Collections.Generic;
using UnityEngine.UI;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000030 RID: 48
	[AddComponentMenu("Event/Physics 2D Raycaster")]
	[RequireComponent(typeof(Camera))]
	public class Physics2DRaycaster : PhysicsRaycaster
	{
		// Token: 0x06000144 RID: 324 RVA: 0x000063F2 File Offset: 0x000047F2
		protected Physics2DRaycaster()
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000063FC File Offset: 0x000047FC
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			if (!(this.eventCamera == null))
			{
				Ray r;
				float f;
				base.ComputeRayAndDistance(eventData, out r, out f);
				if (ReflectionMethodsCache.Singleton.getRayIntersectionAll != null)
				{
					RaycastHit2D[] array = ReflectionMethodsCache.Singleton.getRayIntersectionAll(r, f, base.finalEventMask);
					if (array.Length != 0)
					{
						int i = 0;
						int num = array.Length;
						while (i < num)
						{
							SpriteRenderer component = array[i].collider.gameObject.GetComponent<SpriteRenderer>();
							RaycastResult item = new RaycastResult
							{
								gameObject = array[i].collider.gameObject,
								module = this,
								distance = Vector3.Distance(this.eventCamera.transform.position, array[i].point),
								worldPosition = array[i].point,
								worldNormal = array[i].normal,
								screenPosition = eventData.position,
								index = (float)resultAppendList.Count,
								sortingLayer = ((!(component != null)) ? 0 : component.sortingLayerID),
								sortingOrder = ((!(component != null)) ? 0 : component.sortingOrder)
							};
							resultAppendList.Add(item);
							i++;
						}
					}
				}
			}
		}
	}
}
