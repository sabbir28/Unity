using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200016D RID: 365
	public sealed class PhysicMaterial : Object
	{
		// Token: 0x06001A6E RID: 6766 RVA: 0x00020BB0 File Offset: 0x0001EDB0
		public PhysicMaterial()
		{
			PhysicMaterial.Internal_CreateDynamicsMaterial(this, null);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00020BC0 File Offset: 0x0001EDC0
		public PhysicMaterial(string name)
		{
			PhysicMaterial.Internal_CreateDynamicsMaterial(this, name);
		}

		// Token: 0x06001A70 RID: 6768
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateDynamicsMaterial([Writable] PhysicMaterial mat, string name);

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001A71 RID: 6769
		// (set) Token: 0x06001A72 RID: 6770
		public extern float dynamicFriction { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001A73 RID: 6771
		// (set) Token: 0x06001A74 RID: 6772
		public extern float staticFriction { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001A75 RID: 6773
		// (set) Token: 0x06001A76 RID: 6774
		public extern float bounciness { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x00020BD0 File Offset: 0x0001EDD0
		// (set) Token: 0x06001A78 RID: 6776 RVA: 0x00020BEC File Offset: 0x0001EDEC
		[Obsolete("Use PhysicMaterial.bounciness instead", true)]
		public float bouncyness
		{
			get
			{
				return this.bounciness;
			}
			set
			{
				this.bounciness = value;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		// (set) Token: 0x06001A7A RID: 6778 RVA: 0x00020C14 File Offset: 0x0001EE14
		[Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
		public Vector3 frictionDirection2
		{
			get
			{
				return Vector3.zero;
			}
			set
			{
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001A7B RID: 6779
		// (set) Token: 0x06001A7C RID: 6780
		[Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
		public extern float dynamicFriction2 { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001A7D RID: 6781
		// (set) Token: 0x06001A7E RID: 6782
		[Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
		public extern float staticFriction2 { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001A7F RID: 6783
		// (set) Token: 0x06001A80 RID: 6784
		public extern PhysicMaterialCombine frictionCombine { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001A81 RID: 6785
		// (set) Token: 0x06001A82 RID: 6786
		public extern PhysicMaterialCombine bounceCombine { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x00020C18 File Offset: 0x0001EE18
		// (set) Token: 0x06001A84 RID: 6788 RVA: 0x00020C34 File Offset: 0x0001EE34
		[Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
		public Vector3 frictionDirection
		{
			get
			{
				return Vector3.zero;
			}
			set
			{
			}
		}
	}
}
