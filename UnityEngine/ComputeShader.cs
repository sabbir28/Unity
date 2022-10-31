using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000029 RID: 41
	public sealed class ComputeShader : Object
	{
		// Token: 0x0600033E RID: 830
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int FindKernel(string name);

		// Token: 0x0600033F RID: 831
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool HasKernel(string name);

		// Token: 0x06000340 RID: 832
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z);

		// Token: 0x06000341 RID: 833 RVA: 0x00005D10 File Offset: 0x00003F10
		public void SetFloat(string name, float val)
		{
			this.SetFloat(Shader.PropertyToID(name), val);
		}

		// Token: 0x06000342 RID: 834
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetFloat(int nameID, float val);

		// Token: 0x06000343 RID: 835 RVA: 0x00005D20 File Offset: 0x00003F20
		public void SetInt(string name, int val)
		{
			this.SetInt(Shader.PropertyToID(name), val);
		}

		// Token: 0x06000344 RID: 836
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetInt(int nameID, int val);

		// Token: 0x06000345 RID: 837 RVA: 0x00005D30 File Offset: 0x00003F30
		public void SetBool(string name, bool val)
		{
			this.SetInt(name, (!val) ? 0 : 1);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00005D48 File Offset: 0x00003F48
		public void SetBool(int nameID, bool val)
		{
			this.SetInt(nameID, (!val) ? 0 : 1);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00005D60 File Offset: 0x00003F60
		public void SetVector(string name, Vector4 val)
		{
			this.SetVector(Shader.PropertyToID(name), val);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00005D70 File Offset: 0x00003F70
		public void SetVector(int nameID, Vector4 val)
		{
			ComputeShader.INTERNAL_CALL_SetVector(this, nameID, ref val);
		}

		// Token: 0x06000349 RID: 841
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetVector(ComputeShader self, int nameID, ref Vector4 val);

		// Token: 0x0600034A RID: 842 RVA: 0x00005D7C File Offset: 0x00003F7C
		public void SetFloats(string name, params float[] values)
		{
			this.Internal_SetFloats(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00005D8C File Offset: 0x00003F8C
		public void SetFloats(int nameID, params float[] values)
		{
			this.Internal_SetFloats(nameID, values);
		}

		// Token: 0x0600034C RID: 844
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetFloats(int nameID, float[] values);

		// Token: 0x0600034D RID: 845 RVA: 0x00005D98 File Offset: 0x00003F98
		public void SetInts(string name, params int[] values)
		{
			this.Internal_SetInts(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00005DA8 File Offset: 0x00003FA8
		public void SetInts(int nameID, params int[] values)
		{
			this.Internal_SetInts(nameID, values);
		}

		// Token: 0x0600034F RID: 847
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetInts(int nameID, int[] values);

		// Token: 0x06000350 RID: 848 RVA: 0x00005DB4 File Offset: 0x00003FB4
		public void SetTexture(int kernelIndex, string name, Texture texture)
		{
			this.SetTexture(kernelIndex, Shader.PropertyToID(name), texture);
		}

		// Token: 0x06000351 RID: 849
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTexture(int kernelIndex, int nameID, Texture texture);

		// Token: 0x06000352 RID: 850 RVA: 0x00005DC8 File Offset: 0x00003FC8
		public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName)
		{
			this.SetTextureFromGlobal(kernelIndex, Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
		}

		// Token: 0x06000353 RID: 851
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID);

		// Token: 0x06000354 RID: 852 RVA: 0x00005DE0 File Offset: 0x00003FE0
		public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer)
		{
			this.SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06000355 RID: 853
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer);

		// Token: 0x06000356 RID: 854
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);

		// Token: 0x06000357 RID: 855 RVA: 0x00005DF4 File Offset: 0x00003FF4
		[ExcludeFromDocs]
		public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer)
		{
			uint argsOffset = 0U;
			this.DispatchIndirect(kernelIndex, argsBuffer, argsOffset);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00005E10 File Offset: 0x00004010
		public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, [DefaultValue("0")] uint argsOffset)
		{
			if (argsBuffer == null)
			{
				throw new ArgumentNullException("argsBuffer");
			}
			if (argsBuffer.m_Ptr == IntPtr.Zero)
			{
				throw new ObjectDisposedException("argsBuffer");
			}
			this.Internal_DispatchIndirect(kernelIndex, argsBuffer, argsOffset);
		}

		// Token: 0x06000359 RID: 857
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset);
	}
}
