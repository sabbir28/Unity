using System;
using System.Collections.Generic;
using UnityEngine.UI;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000031 RID: 49
	[AddComponentMenu("Event/Physics Raycaster")]
	[RequireComponent(typeof(Camera))]
	public class PhysicsRaycaster : BaseRaycaster
	{
		// Token: 0x06000146 RID: 326 RVA: 0x0000610C File Offset: 0x0000450C
		protected PhysicsRaycaster()
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00006124 File Offset: 0x00004524
		public override Camera eventCamera
		{
			get
			{
				if (this.m_EventCamera == null)
				{
					this.m_EventCamera = base.GetComponent<Camera>();
				}
				return this.m_EventCamera ?? Camera.main;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00006168 File Offset: 0x00004568
		public virtual int depth
		{
			get
			{
				return (!(this.eventCamera != null)) ? 16777215 : ((int)this.eventCamera.depth);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000061A4 File Offset: 0x000045A4
		public int finalEventMask
		{
			get
			{
				return (!(this.eventCamera != null)) ? -1 : (this.eventCamera.cullingMask & this.m_EventMask);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000061E8 File Offset: 0x000045E8
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00006203 File Offset: 0x00004603
		public LayerMask eventMask
		{
			get
			{
				return this.m_EventMask;
			}
			set
			{
				this.m_EventMask = value;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006210 File Offset: 0x00004610
		protected void ComputeRayAndDistance(PointerEventData eventData, out Ray ray, out float distanceToClipPlane)
		{
			ray = this.eventCamera.ScreenPointToRay(eventData.position);
			float z = ray.direction.z;
			distanceToClipPlane = ((!Mathf.Approximately(0f, z)) ? Mathf.Abs((this.eventCamera.farClipPlane - this.eventCamera.nearClipPlane) / z) : float.PositiveInfinity);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00006284 File Offset: 0x00004684
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			if (!(this.eventCamera == null))
			{
				Ray r;
				float f;
				this.ComputeRayAndDistance(eventData, out r, out f);
				if (ReflectionMethodsCache.Singleton.raycast3DAll != null)
				{
					RaycastHit[] array = ReflectionMethodsCache.Singleton.raycast3DAll(r, f, this.finalEventMask);
					if (array.Length > 1)
					{
						Array.Sort<RaycastHit>(array, (RaycastHit r1, RaycastHit r2) => r1.distance.CompareTo(r2.distance));
					}
					if (array.Length != 0)
					{
						int i = 0;
						int num = array.Length;
						while (i < num)
						{
							RaycastResult item = new RaycastResult
							{
								gameObject = array[i].collider.gameObject,
								module = this,
								distance = array[i].distance,
								worldPosition = array[i].point,
								worldNormal = array[i].normal,
								screenPosition = eventData.position,
								index = (float)resultAppendList.Count,
								sortingLayer = 0,
								sortingOrder = 0
							};
							resultAppendList.Add(item);
							i++;
						}
					}
				}
			}
		}

		// Token: 0x040000A1 RID: 161
		protected const int kNoEventMaskSet = -1;

		// Token: 0x040000A2 RID: 162
		protected Camera m_EventCamera;

		// Token: 0x040000A3 RID: 163
		[SerializeField]
		protected LayerMask m_EventMask = -1;
	}
}
