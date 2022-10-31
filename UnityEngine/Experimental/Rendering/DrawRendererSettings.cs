using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020000F8 RID: 248
	public struct DrawRendererSettings
	{
		// Token: 0x06001173 RID: 4467 RVA: 0x0001767C File Offset: 0x0001587C
		public DrawRendererSettings(CullResults cullResults, Camera camera, ShaderPassName shaderPassName)
		{
			this._cullResults = cullResults.cullResults;
			this.shaderPassName = shaderPassName;
			this.rendererConfiguration = RendererConfiguration.None;
			this.flags = DrawRendererFlags.EnableInstancing;
			this.inputFilter = InputFilter.Default();
			DrawRendererSettings.InitializeSortSettings(camera, out this.sorting);
		}

		// Token: 0x17000391 RID: 913
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x000176B8 File Offset: 0x000158B8
		public CullResults cullResults
		{
			set
			{
				this._cullResults = value.cullResults;
			}
		}

		// Token: 0x06001175 RID: 4469
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitializeSortSettings(Camera camera, out DrawRendererSortSettings sortSettings);

		// Token: 0x04000235 RID: 565
		public DrawRendererSortSettings sorting;

		// Token: 0x04000236 RID: 566
		public ShaderPassName shaderPassName;

		// Token: 0x04000237 RID: 567
		public InputFilter inputFilter;

		// Token: 0x04000238 RID: 568
		public RendererConfiguration rendererConfiguration;

		// Token: 0x04000239 RID: 569
		public DrawRendererFlags flags;

		// Token: 0x0400023A RID: 570
		private IntPtr _cullResults;
	}
}
