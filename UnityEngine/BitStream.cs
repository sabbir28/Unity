using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000097 RID: 151
	[RequiredByNativeCode(Optional = true)]
	public sealed class BitStream
	{
		// Token: 0x06000B08 RID: 2824
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serializeb(ref int value);

		// Token: 0x06000B09 RID: 2825
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serializec(ref char value);

		// Token: 0x06000B0A RID: 2826
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serializes(ref short value);

		// Token: 0x06000B0B RID: 2827
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serializei(ref int value);

		// Token: 0x06000B0C RID: 2828
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serializef(ref float value, float maximumDelta);

		// Token: 0x06000B0D RID: 2829 RVA: 0x0000F938 File Offset: 0x0000DB38
		private void Serializeq(ref Quaternion value, float maximumDelta)
		{
			BitStream.INTERNAL_CALL_Serializeq(this, ref value, maximumDelta);
		}

		// Token: 0x06000B0E RID: 2830
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Serializeq(BitStream self, ref Quaternion value, float maximumDelta);

		// Token: 0x06000B0F RID: 2831 RVA: 0x0000F944 File Offset: 0x0000DB44
		private void Serializev(ref Vector3 value, float maximumDelta)
		{
			BitStream.INTERNAL_CALL_Serializev(this, ref value, maximumDelta);
		}

		// Token: 0x06000B10 RID: 2832
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Serializev(BitStream self, ref Vector3 value, float maximumDelta);

		// Token: 0x06000B11 RID: 2833 RVA: 0x0000F950 File Offset: 0x0000DB50
		private void Serializen(ref NetworkViewID viewID)
		{
			BitStream.INTERNAL_CALL_Serializen(this, ref viewID);
		}

		// Token: 0x06000B12 RID: 2834
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Serializen(BitStream self, ref NetworkViewID viewID);

		// Token: 0x06000B13 RID: 2835 RVA: 0x0000F95C File Offset: 0x0000DB5C
		public void Serialize(ref bool value)
		{
			int num = (!value) ? 0 : 1;
			this.Serializeb(ref num);
			value = (num != 0);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0000F990 File Offset: 0x0000DB90
		public void Serialize(ref char value)
		{
			this.Serializec(ref value);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0000F99C File Offset: 0x0000DB9C
		public void Serialize(ref short value)
		{
			this.Serializes(ref value);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		public void Serialize(ref int value)
		{
			this.Serializei(ref value);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0000F9B4 File Offset: 0x0000DBB4
		[ExcludeFromDocs]
		public void Serialize(ref float value)
		{
			float maxDelta = 1E-05f;
			this.Serialize(ref value, maxDelta);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
		public void Serialize(ref float value, [DefaultValue("0.00001F")] float maxDelta)
		{
			this.Serializef(ref value, maxDelta);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0000F9DC File Offset: 0x0000DBDC
		[ExcludeFromDocs]
		public void Serialize(ref Quaternion value)
		{
			float maxDelta = 1E-05f;
			this.Serialize(ref value, maxDelta);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
		public void Serialize(ref Quaternion value, [DefaultValue("0.00001F")] float maxDelta)
		{
			this.Serializeq(ref value, maxDelta);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0000FA04 File Offset: 0x0000DC04
		[ExcludeFromDocs]
		public void Serialize(ref Vector3 value)
		{
			float maxDelta = 1E-05f;
			this.Serialize(ref value, maxDelta);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0000FA20 File Offset: 0x0000DC20
		public void Serialize(ref Vector3 value, [DefaultValue("0.00001F")] float maxDelta)
		{
			this.Serializev(ref value, maxDelta);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0000FA2C File Offset: 0x0000DC2C
		public void Serialize(ref NetworkPlayer value)
		{
			int index = value.index;
			this.Serializei(ref index);
			value.index = index;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0000FA50 File Offset: 0x0000DC50
		public void Serialize(ref NetworkViewID viewID)
		{
			this.Serializen(ref viewID);
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000B1F RID: 2847
		public extern bool isReading { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000B20 RID: 2848
		public extern bool isWriting { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000B21 RID: 2849
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Serialize(ref string value);

		// Token: 0x04000144 RID: 324
		internal IntPtr m_Ptr;
	}
}
