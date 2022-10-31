using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020000A6 RID: 166
	[UsedByNativeCode]
	public sealed class CommandBuffer : IDisposable
	{
		// Token: 0x06000BE3 RID: 3043 RVA: 0x00010228 File Offset: 0x0000E428
		public CommandBuffer()
		{
			this.m_Ptr = IntPtr.Zero;
			CommandBuffer.InitBuffer(this);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00010244 File Offset: 0x0000E444
		~CommandBuffer()
		{
			this.Dispose(false);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00010278 File Offset: 0x0000E478
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00010288 File Offset: 0x0000E488
		private void Dispose(bool disposing)
		{
			this.ReleaseBuffer();
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x06000BE7 RID: 3047
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitBuffer(CommandBuffer buf);

		// Token: 0x06000BE8 RID: 3048
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ReleaseBuffer();

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0001029C File Offset: 0x0000E49C
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x06000BEA RID: 3050
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetComputeFloatParam(ComputeShader computeShader, string name, float val);

		// Token: 0x06000BEB RID: 3051
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetComputeIntParam(ComputeShader computeShader, string name, int val);

		// Token: 0x06000BEC RID: 3052 RVA: 0x000102A8 File Offset: 0x0000E4A8
		public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val)
		{
			CommandBuffer.INTERNAL_CALL_SetComputeVectorParam(this, computeShader, name, ref val);
		}

		// Token: 0x06000BED RID: 3053
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetComputeVectorParam(CommandBuffer self, ComputeShader computeShader, string name, ref Vector4 val);

		// Token: 0x06000BEE RID: 3054 RVA: 0x000102B8 File Offset: 0x0000E4B8
		public void SetComputeFloatParams(ComputeShader computeShader, string name, params float[] values)
		{
			this.Internal_SetComputeFloats(computeShader, name, values);
		}

		// Token: 0x06000BEF RID: 3055
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetComputeFloats(ComputeShader computeShader, string name, float[] values);

		// Token: 0x06000BF0 RID: 3056 RVA: 0x000102C4 File Offset: 0x0000E4C4
		public void SetComputeIntParams(ComputeShader computeShader, string name, params int[] values)
		{
			this.Internal_SetComputeInts(computeShader, name, values);
		}

		// Token: 0x06000BF1 RID: 3057
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetComputeInts(ComputeShader computeShader, string name, int[] values);

		// Token: 0x06000BF2 RID: 3058 RVA: 0x000102D0 File Offset: 0x0000E4D0
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt)
		{
			this.Internal_SetComputeTextureParam(computeShader, kernelIndex, name, ref rt);
		}

		// Token: 0x06000BF3 RID: 3059
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, ref RenderTargetIdentifier rt);

		// Token: 0x06000BF4 RID: 3060
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer);

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000102E0 File Offset: 0x0000E4E0
		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
			this.Internal_DispatchCompute(computeShader, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
		}

		// Token: 0x06000BF6 RID: 3062
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);

		// Token: 0x06000BF7 RID: 3063 RVA: 0x000102F0 File Offset: 0x0000E4F0
		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset)
		{
			this.Internal_DispatchComputeIndirect(computeShader, kernelIndex, indirectBuffer, argsOffset);
		}

		// Token: 0x06000BF8 RID: 3064
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_DispatchComputeIndirect(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset);

		// Token: 0x06000BF9 RID: 3065
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CopyCounterValue(ComputeBuffer src, ComputeBuffer dst, uint dstOffset);

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000BFA RID: 3066
		// (set) Token: 0x06000BFB RID: 3067
		public extern string name { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000BFC RID: 3068
		public extern int sizeInBytes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000BFD RID: 3069
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear();

		// Token: 0x06000BFE RID: 3070 RVA: 0x00010300 File Offset: 0x0000E500
		[ExcludeFromDocs]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass)
		{
			MaterialPropertyBlock properties = null;
			this.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00010320 File Offset: 0x0000E520
		[ExcludeFromDocs]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex)
		{
			MaterialPropertyBlock properties = null;
			int shaderPass = -1;
			this.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00010340 File Offset: 0x0000E540
		[ExcludeFromDocs]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material)
		{
			MaterialPropertyBlock properties = null;
			int shaderPass = -1;
			int submeshIndex = 0;
			this.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00010360 File Offset: 0x0000E560
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, [DefaultValue("0")] int submeshIndex, [DefaultValue("-1")] int shaderPass, [DefaultValue("null")] MaterialPropertyBlock properties)
		{
			if (mesh == null)
			{
				throw new ArgumentNullException("mesh");
			}
			if (submeshIndex < 0 || submeshIndex >= mesh.subMeshCount)
			{
				submeshIndex = Mathf.Clamp(submeshIndex, 0, mesh.subMeshCount - 1);
				Debug.LogWarning(string.Format("submeshIndex out of range. Clampped to {0}.", submeshIndex));
			}
			if (material == null)
			{
				throw new ArgumentNullException("material");
			}
			this.Internal_DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000103EC File Offset: 0x0000E5EC
		private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
			CommandBuffer.INTERNAL_CALL_Internal_DrawMesh(this, mesh, ref matrix, material, submeshIndex, shaderPass, properties);
		}

		// Token: 0x06000C03 RID: 3075
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawMesh(CommandBuffer self, Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties);

		// Token: 0x06000C04 RID: 3076 RVA: 0x00010400 File Offset: 0x0000E600
		[ExcludeFromDocs]
		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex)
		{
			int shaderPass = -1;
			this.DrawRenderer(renderer, material, submeshIndex, shaderPass);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0001041C File Offset: 0x0000E61C
		[ExcludeFromDocs]
		public void DrawRenderer(Renderer renderer, Material material)
		{
			int shaderPass = -1;
			int submeshIndex = 0;
			this.DrawRenderer(renderer, material, submeshIndex, shaderPass);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00010438 File Offset: 0x0000E638
		public void DrawRenderer(Renderer renderer, Material material, [DefaultValue("0")] int submeshIndex, [DefaultValue("-1")] int shaderPass)
		{
			if (renderer == null)
			{
				throw new ArgumentNullException("renderer");
			}
			if (submeshIndex < 0)
			{
				submeshIndex = Mathf.Max(submeshIndex, 0);
				Debug.LogWarning(string.Format("submeshIndex out of range. Clampped to {0}.", submeshIndex));
			}
			if (material == null)
			{
				throw new ArgumentNullException("material");
			}
			this.Internal_DrawRenderer(renderer, material, submeshIndex, shaderPass);
		}

		// Token: 0x06000C07 RID: 3079
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_DrawRenderer(Renderer renderer, Material material, [DefaultValue("0")] int submeshIndex, [DefaultValue("-1")] int shaderPass);

		// Token: 0x06000C08 RID: 3080 RVA: 0x000104A8 File Offset: 0x0000E6A8
		[ExcludeFromDocs]
		private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex)
		{
			int shaderPass = -1;
			this.Internal_DrawRenderer(renderer, material, submeshIndex, shaderPass);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000104C4 File Offset: 0x0000E6C4
		[ExcludeFromDocs]
		private void Internal_DrawRenderer(Renderer renderer, Material material)
		{
			int shaderPass = -1;
			int submeshIndex = 0;
			this.Internal_DrawRenderer(renderer, material, submeshIndex, shaderPass);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000104E0 File Offset: 0x0000E6E0
		[ExcludeFromDocs]
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount)
		{
			MaterialPropertyBlock properties = null;
			this.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00010500 File Offset: 0x0000E700
		[ExcludeFromDocs]
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount)
		{
			MaterialPropertyBlock properties = null;
			int instanceCount = 1;
			this.DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00010524 File Offset: 0x0000E724
		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, [DefaultValue("1")] int instanceCount, [DefaultValue("null")] MaterialPropertyBlock properties)
		{
			if (material == null)
			{
				throw new ArgumentNullException("material");
			}
			this.Internal_DrawProcedural(matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00010550 File Offset: 0x0000E750
		private void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
			CommandBuffer.INTERNAL_CALL_Internal_DrawProcedural(this, ref matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
		}

		// Token: 0x06000C0E RID: 3086
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawProcedural(CommandBuffer self, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties);

		// Token: 0x06000C0F RID: 3087 RVA: 0x00010568 File Offset: 0x0000E768
		[ExcludeFromDocs]
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			MaterialPropertyBlock properties = null;
			this.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00010588 File Offset: 0x0000E788
		[ExcludeFromDocs]
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs)
		{
			MaterialPropertyBlock properties = null;
			int argsOffset = 0;
			this.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x000105AC File Offset: 0x0000E7AC
		public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, [DefaultValue("0")] int argsOffset, [DefaultValue("null")] MaterialPropertyBlock properties)
		{
			if (material == null)
			{
				throw new ArgumentNullException("material");
			}
			if (bufferWithArgs == null)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.Internal_DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000105EC File Offset: 0x0000E7EC
		private void Internal_DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
		{
			CommandBuffer.INTERNAL_CALL_Internal_DrawProceduralIndirect(this, ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06000C13 RID: 3091
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_DrawProceduralIndirect(CommandBuffer self, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties);

		// Token: 0x06000C14 RID: 3092 RVA: 0x00010604 File Offset: 0x0000E804
		[ExcludeFromDocs]
		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count)
		{
			MaterialPropertyBlock properties = null;
			this.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count, properties);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00010624 File Offset: 0x0000E824
		[ExcludeFromDocs]
		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices)
		{
			MaterialPropertyBlock properties = null;
			int count = matrices.Length;
			this.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count, properties);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00010648 File Offset: 0x0000E848
		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, [DefaultValue("matrices.Length")] int count, [DefaultValue("null")] MaterialPropertyBlock properties)
		{
			if (!SystemInfo.supportsInstancing)
			{
				throw new InvalidOperationException("DrawMeshInstanced is not supported.");
			}
			if (mesh == null)
			{
				throw new ArgumentNullException("mesh");
			}
			if (submeshIndex < 0 || submeshIndex >= mesh.subMeshCount)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			if (material == null)
			{
				throw new ArgumentNullException("material");
			}
			if (matrices == null)
			{
				throw new ArgumentNullException("matrices");
			}
			if (count < 0 || count > Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length))
			{
				throw new ArgumentOutOfRangeException("count", string.Format("Count must be in the range of 0 to {0}.", Mathf.Min(Graphics.kMaxDrawMeshInstanceCount, matrices.Length)));
			}
			if (count > 0)
			{
				this.Internal_DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices, count, properties);
			}
		}

		// Token: 0x06000C17 RID: 3095
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties);

		// Token: 0x06000C18 RID: 3096 RVA: 0x0001072C File Offset: 0x0000E92C
		[ExcludeFromDocs]
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset)
		{
			MaterialPropertyBlock properties = null;
			this.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0001074C File Offset: 0x0000E94C
		[ExcludeFromDocs]
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs)
		{
			MaterialPropertyBlock properties = null;
			int argsOffset = 0;
			this.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00010770 File Offset: 0x0000E970
		public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, [DefaultValue("0")] int argsOffset, [DefaultValue("null")] MaterialPropertyBlock properties)
		{
			if (!SystemInfo.supportsInstancing)
			{
				throw new InvalidOperationException("Instancing is not supported.");
			}
			if (mesh == null)
			{
				throw new ArgumentNullException("mesh");
			}
			if (submeshIndex < 0 || submeshIndex >= mesh.subMeshCount)
			{
				throw new ArgumentOutOfRangeException("submeshIndex", "submeshIndex out of range.");
			}
			if (material == null)
			{
				throw new ArgumentNullException("material");
			}
			if (bufferWithArgs == null)
			{
				throw new ArgumentNullException("bufferWithArgs");
			}
			this.Internal_DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs, argsOffset, properties);
		}

		// Token: 0x06000C1B RID: 3099
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties);

		// Token: 0x06000C1C RID: 3100 RVA: 0x00010808 File Offset: 0x0000EA08
		public void SetRenderTarget(RenderTargetIdentifier rt)
		{
			this.SetRenderTarget_Single(ref rt, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00010818 File Offset: 0x0000EA18
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel)
		{
			this.SetRenderTarget_Single(ref rt, mipLevel, CubemapFace.Unknown, 0);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00010828 File Offset: 0x0000EA28
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace)
		{
			this.SetRenderTarget_Single(ref rt, mipLevel, cubemapFace, 0);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00010838 File Offset: 0x0000EA38
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			this.SetRenderTarget_Single(ref rt, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00010848 File Offset: 0x0000EA48
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth)
		{
			this.SetRenderTarget_ColDepth(ref color, ref depth, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00010858 File Offset: 0x0000EA58
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel)
		{
			this.SetRenderTarget_ColDepth(ref color, ref depth, mipLevel, CubemapFace.Unknown, 0);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00010868 File Offset: 0x0000EA68
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace)
		{
			this.SetRenderTarget_ColDepth(ref color, ref depth, mipLevel, cubemapFace, 0);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0001087C File Offset: 0x0000EA7C
		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			this.SetRenderTarget_ColDepth(ref color, ref depth, mipLevel, cubemapFace, depthSlice);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00010890 File Offset: 0x0000EA90
		public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth)
		{
			this.SetRenderTarget_Multiple(colors, ref depth);
		}

		// Token: 0x06000C25 RID: 3109
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetRenderTarget_Single(ref RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice);

		// Token: 0x06000C26 RID: 3110
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetRenderTarget_ColDepth(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice);

		// Token: 0x06000C27 RID: 3111
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetRenderTarget_Multiple(RenderTargetIdentifier[] color, ref RenderTargetIdentifier depth);

		// Token: 0x06000C28 RID: 3112 RVA: 0x0001089C File Offset: 0x0000EA9C
		public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst)
		{
			this.CopyTexture_Internal(ref src, -1, -1, -1, -1, -1, -1, ref dst, -1, -1, -1, -1, 1);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x000108C0 File Offset: 0x0000EAC0
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement)
		{
			this.CopyTexture_Internal(ref src, srcElement, -1, -1, -1, -1, -1, ref dst, dstElement, -1, -1, -1, 2);
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x000108E4 File Offset: 0x0000EAE4
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip)
		{
			this.CopyTexture_Internal(ref src, srcElement, srcMip, -1, -1, -1, -1, ref dst, dstElement, dstMip, -1, -1, 3);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0001090C File Offset: 0x0000EB0C
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY)
		{
			this.CopyTexture_Internal(ref src, srcElement, srcMip, srcX, srcY, srcWidth, srcHeight, ref dst, dstElement, dstMip, dstX, dstY, 4);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00010938 File Offset: 0x0000EB38
		public void SetViewport(Rect pixelRect)
		{
			CommandBuffer.INTERNAL_CALL_SetViewport(this, ref pixelRect);
		}

		// Token: 0x06000C2D RID: 3117
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetViewport(CommandBuffer self, ref Rect pixelRect);

		// Token: 0x06000C2E RID: 3118
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode);

		// Token: 0x06000C2F RID: 3119 RVA: 0x00010944 File Offset: 0x0000EB44
		public void Blit(Texture source, RenderTargetIdentifier dest)
		{
			this.Blit_Texture(source, ref dest, null, -1);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00010954 File Offset: 0x0000EB54
		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat)
		{
			this.Blit_Texture(source, ref dest, mat, -1);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00010964 File Offset: 0x0000EB64
		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass)
		{
			this.Blit_Texture(source, ref dest, mat, pass);
		}

		// Token: 0x06000C32 RID: 3122
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass);

		// Token: 0x06000C33 RID: 3123 RVA: 0x00010974 File Offset: 0x0000EB74
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest)
		{
			this.Blit_Identifier(ref source, ref dest, null, -1);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00010984 File Offset: 0x0000EB84
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat)
		{
			this.Blit_Identifier(ref source, ref dest, mat, -1);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00010994 File Offset: 0x0000EB94
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass)
		{
			this.Blit_Identifier(ref source, ref dest, mat, pass);
		}

		// Token: 0x06000C36 RID: 3126
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, [DefaultValue("null")] Material mat, [DefaultValue("-1")] int pass);

		// Token: 0x06000C37 RID: 3127 RVA: 0x000109A4 File Offset: 0x0000EBA4
		[ExcludeFromDocs]
		private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat)
		{
			int pass = -1;
			this.Blit_Identifier(ref source, ref dest, mat, pass);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000109C0 File Offset: 0x0000EBC0
		[ExcludeFromDocs]
		private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest)
		{
			int pass = -1;
			Material mat = null;
			this.Blit_Identifier(ref source, ref dest, mat, pass);
		}

		// Token: 0x06000C39 RID: 3129
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void GetTemporaryRT(int nameID, int width, int height, [DefaultValue("0")] int depthBuffer, [DefaultValue("FilterMode.Point")] FilterMode filter, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite, [DefaultValue("1")] int antiAliasing, [DefaultValue("false")] bool enableRandomWrite);

		// Token: 0x06000C3A RID: 3130 RVA: 0x000109DC File Offset: 0x0000EBDC
		[ExcludeFromDocs]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
			bool enableRandomWrite = false;
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00010A00 File Offset: 0x0000EC00
		[ExcludeFromDocs]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			bool enableRandomWrite = false;
			int antiAliasing = 1;
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00010A28 File Offset: 0x0000EC28
		[ExcludeFromDocs]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format)
		{
			bool enableRandomWrite = false;
			int antiAliasing = 1;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00010A50 File Offset: 0x0000EC50
		[ExcludeFromDocs]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter)
		{
			bool enableRandomWrite = false;
			int antiAliasing = 1;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			RenderTextureFormat format = RenderTextureFormat.Default;
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00010A78 File Offset: 0x0000EC78
		[ExcludeFromDocs]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer)
		{
			bool enableRandomWrite = false;
			int antiAliasing = 1;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			RenderTextureFormat format = RenderTextureFormat.Default;
			FilterMode filter = FilterMode.Point;
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00010AA4 File Offset: 0x0000ECA4
		[ExcludeFromDocs]
		public void GetTemporaryRT(int nameID, int width, int height)
		{
			bool enableRandomWrite = false;
			int antiAliasing = 1;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			RenderTextureFormat format = RenderTextureFormat.Default;
			FilterMode filter = FilterMode.Point;
			int depthBuffer = 0;
			this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing, enableRandomWrite);
		}

		// Token: 0x06000C40 RID: 3136
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ReleaseTemporaryRT(int nameID);

		// Token: 0x06000C41 RID: 3137 RVA: 0x00010AD4 File Offset: 0x0000ECD4
		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, [DefaultValue("1.0f")] float depth)
		{
			CommandBuffer.INTERNAL_CALL_ClearRenderTarget(this, clearDepth, clearColor, ref backgroundColor, depth);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00010AE4 File Offset: 0x0000ECE4
		[ExcludeFromDocs]
		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor)
		{
			float depth = 1f;
			CommandBuffer.INTERNAL_CALL_ClearRenderTarget(this, clearDepth, clearColor, ref backgroundColor, depth);
		}

		// Token: 0x06000C43 RID: 3139
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClearRenderTarget(CommandBuffer self, bool clearDepth, bool clearColor, ref Color backgroundColor, float depth);

		// Token: 0x06000C44 RID: 3140 RVA: 0x00010B04 File Offset: 0x0000ED04
		public void SetGlobalFloat(string name, float value)
		{
			this.SetGlobalFloat(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000C45 RID: 3141
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetGlobalFloat(int nameID, float value);

		// Token: 0x06000C46 RID: 3142 RVA: 0x00010B14 File Offset: 0x0000ED14
		public void SetGlobalVector(string name, Vector4 value)
		{
			this.SetGlobalVector(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00010B24 File Offset: 0x0000ED24
		public void SetGlobalVector(int nameID, Vector4 value)
		{
			CommandBuffer.INTERNAL_CALL_SetGlobalVector(this, nameID, ref value);
		}

		// Token: 0x06000C48 RID: 3144
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetGlobalVector(CommandBuffer self, int nameID, ref Vector4 value);

		// Token: 0x06000C49 RID: 3145 RVA: 0x00010B30 File Offset: 0x0000ED30
		public void SetGlobalColor(string name, Color value)
		{
			this.SetGlobalColor(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00010B40 File Offset: 0x0000ED40
		public void SetGlobalColor(int nameID, Color value)
		{
			CommandBuffer.INTERNAL_CALL_SetGlobalColor(this, nameID, ref value);
		}

		// Token: 0x06000C4B RID: 3147
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetGlobalColor(CommandBuffer self, int nameID, ref Color value);

		// Token: 0x06000C4C RID: 3148 RVA: 0x00010B4C File Offset: 0x0000ED4C
		public void SetGlobalMatrix(string name, Matrix4x4 value)
		{
			this.SetGlobalMatrix(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00010B5C File Offset: 0x0000ED5C
		public void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
			CommandBuffer.INTERNAL_CALL_SetGlobalMatrix(this, nameID, ref value);
		}

		// Token: 0x06000C4E RID: 3150
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetGlobalMatrix(CommandBuffer self, int nameID, ref Matrix4x4 value);

		// Token: 0x06000C4F RID: 3151
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void EnableShaderKeyword(string keyword);

		// Token: 0x06000C50 RID: 3152
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DisableShaderKeyword(string keyword);

		// Token: 0x06000C51 RID: 3153 RVA: 0x00010B68 File Offset: 0x0000ED68
		public void SetViewMatrix(Matrix4x4 view)
		{
			CommandBuffer.INTERNAL_CALL_SetViewMatrix(this, ref view);
		}

		// Token: 0x06000C52 RID: 3154
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetViewMatrix(CommandBuffer self, ref Matrix4x4 view);

		// Token: 0x06000C53 RID: 3155 RVA: 0x00010B74 File Offset: 0x0000ED74
		public void SetProjectionMatrix(Matrix4x4 proj)
		{
			CommandBuffer.INTERNAL_CALL_SetProjectionMatrix(this, ref proj);
		}

		// Token: 0x06000C54 RID: 3156
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetProjectionMatrix(CommandBuffer self, ref Matrix4x4 proj);

		// Token: 0x06000C55 RID: 3157 RVA: 0x00010B80 File Offset: 0x0000ED80
		public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj)
		{
			CommandBuffer.INTERNAL_CALL_SetViewProjectionMatrices(this, ref view, ref proj);
		}

		// Token: 0x06000C56 RID: 3158
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetViewProjectionMatrices(CommandBuffer self, ref Matrix4x4 view, ref Matrix4x4 proj);

		// Token: 0x06000C57 RID: 3159
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetGlobalDepthBias(float bias, float slopeBias);

		// Token: 0x06000C58 RID: 3160 RVA: 0x00010B90 File Offset: 0x0000ED90
		public void SetGlobalFloatArray(string propertyName, List<float> values)
		{
			this.SetGlobalFloatArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00010BA0 File Offset: 0x0000EDA0
		public void SetGlobalFloatArray(int nameID, List<float> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Count == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetGlobalFloatArrayListImpl(nameID, values);
		}

		// Token: 0x06000C5A RID: 3162
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetGlobalFloatArrayListImpl(int nameID, object values);

		// Token: 0x06000C5B RID: 3163 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		public void SetGlobalFloatArray(string propertyName, float[] values)
		{
			this.SetGlobalFloatArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06000C5C RID: 3164
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetGlobalFloatArray(int nameID, float[] values);

		// Token: 0x06000C5D RID: 3165 RVA: 0x00010BE4 File Offset: 0x0000EDE4
		public void SetGlobalVectorArray(string propertyName, List<Vector4> values)
		{
			this.SetGlobalVectorArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00010BF4 File Offset: 0x0000EDF4
		public void SetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Count == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetGlobalVectorArrayListImpl(nameID, values);
		}

		// Token: 0x06000C5F RID: 3167
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetGlobalVectorArrayListImpl(int nameID, object values);

		// Token: 0x06000C60 RID: 3168 RVA: 0x00010C28 File Offset: 0x0000EE28
		public void SetGlobalVectorArray(string propertyName, Vector4[] values)
		{
			this.SetGlobalVectorArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06000C61 RID: 3169
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetGlobalVectorArray(int nameID, Vector4[] values);

		// Token: 0x06000C62 RID: 3170 RVA: 0x00010C38 File Offset: 0x0000EE38
		public void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values)
		{
			this.SetGlobalMatrixArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00010C48 File Offset: 0x0000EE48
		public void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Count == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetGlobalMatrixArrayListImpl(nameID, values);
		}

		// Token: 0x06000C64 RID: 3172
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetGlobalMatrixArrayListImpl(int nameID, object values);

		// Token: 0x06000C65 RID: 3173 RVA: 0x00010C7C File Offset: 0x0000EE7C
		public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values)
		{
			this.SetGlobalMatrixArray(Shader.PropertyToID(propertyName), values);
		}

		// Token: 0x06000C66 RID: 3174
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetGlobalMatrixArray(int nameID, Matrix4x4[] values);

		// Token: 0x06000C67 RID: 3175 RVA: 0x00010C8C File Offset: 0x0000EE8C
		public void SetGlobalTexture(string name, RenderTargetIdentifier value)
		{
			this.SetGlobalTexture(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00010C9C File Offset: 0x0000EE9C
		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value)
		{
			this.SetGlobalTexture_Impl(nameID, ref value);
		}

		// Token: 0x06000C69 RID: 3177
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt);

		// Token: 0x06000C6A RID: 3178 RVA: 0x00010CA8 File Offset: 0x0000EEA8
		public void SetGlobalBuffer(string name, ComputeBuffer value)
		{
			this.SetGlobalBuffer(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000C6B RID: 3179
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetGlobalBuffer(int nameID, ComputeBuffer value);

		// Token: 0x06000C6C RID: 3180 RVA: 0x00010CB8 File Offset: 0x0000EEB8
		public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode)
		{
			this.SetShadowSamplingMode_Impl(ref shadowmap, mode);
		}

		// Token: 0x06000C6D RID: 3181
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode);

		// Token: 0x06000C6E RID: 3182 RVA: 0x00010CC4 File Offset: 0x0000EEC4
		public void IssuePluginEvent(IntPtr callback, int eventID)
		{
			if (callback == IntPtr.Zero)
			{
				throw new ArgumentException("Null callback specified.");
			}
			this.IssuePluginEventInternal(callback, eventID);
		}

		// Token: 0x06000C6F RID: 3183
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void IssuePluginEventInternal(IntPtr callback, int eventID);

		// Token: 0x06000C70 RID: 3184
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void BeginSample(string name);

		// Token: 0x06000C71 RID: 3185
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void EndSample(string name);

		// Token: 0x04000157 RID: 343
		internal IntPtr m_Ptr;
	}
}
