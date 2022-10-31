using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	// Token: 0x020001B5 RID: 437
	[MovedFrom("UnityEngine")]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class NavMeshPath
	{
		// Token: 0x06001F82 RID: 8066
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern NavMeshPath();

		// Token: 0x06001F83 RID: 8067
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void DestroyNavMeshPath();

		// Token: 0x06001F84 RID: 8068 RVA: 0x00025A18 File Offset: 0x00023C18
		~NavMeshPath()
		{
			this.DestroyNavMeshPath();
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x06001F85 RID: 8069
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetCornersNonAlloc(Vector3[] results);

		// Token: 0x06001F86 RID: 8070
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Vector3[] CalculateCornersInternal();

		// Token: 0x06001F87 RID: 8071
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ClearCornersInternal();

		// Token: 0x06001F88 RID: 8072 RVA: 0x00025A54 File Offset: 0x00023C54
		public void ClearCorners()
		{
			this.ClearCornersInternal();
			this.m_corners = null;
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00025A64 File Offset: 0x00023C64
		private void CalculateCorners()
		{
			if (this.m_corners == null)
			{
				this.m_corners = this.CalculateCornersInternal();
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001F8A RID: 8074 RVA: 0x00025A80 File Offset: 0x00023C80
		public Vector3[] corners
		{
			get
			{
				this.CalculateCorners();
				return this.m_corners;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001F8B RID: 8075
		public extern NavMeshPathStatus status { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0400048C RID: 1164
		internal IntPtr m_Ptr;

		// Token: 0x0400048D RID: 1165
		internal Vector3[] m_corners;
	}
}
