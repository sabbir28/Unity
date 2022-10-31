using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000144 RID: 324
	[RequireComponent(typeof(Transform))]
	public sealed class ParticleSystemRenderer : Renderer
	{
		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600176F RID: 5999
		// (set) Token: 0x06001770 RID: 6000
		public extern ParticleSystemRenderMode renderMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001771 RID: 6001
		// (set) Token: 0x06001772 RID: 6002
		public extern float lengthScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001773 RID: 6003
		// (set) Token: 0x06001774 RID: 6004
		public extern float velocityScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001775 RID: 6005
		// (set) Token: 0x06001776 RID: 6006
		public extern float cameraVelocityScale { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001777 RID: 6007
		// (set) Token: 0x06001778 RID: 6008
		public extern float normalDirection { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001779 RID: 6009
		// (set) Token: 0x0600177A RID: 6010
		public extern ParticleSystemRenderSpace alignment { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x0001D4CC File Offset: 0x0001B6CC
		// (set) Token: 0x0600177C RID: 6012 RVA: 0x0001D4EC File Offset: 0x0001B6EC
		public Vector3 pivot
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_pivot(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_pivot(ref value);
			}
		}

		// Token: 0x0600177D RID: 6013
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pivot(out Vector3 value);

		// Token: 0x0600177E RID: 6014
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_pivot(ref Vector3 value);

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600177F RID: 6015
		// (set) Token: 0x06001780 RID: 6016
		public extern ParticleSystemSortMode sortMode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001781 RID: 6017
		// (set) Token: 0x06001782 RID: 6018
		public extern float sortingFudge { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001783 RID: 6019
		// (set) Token: 0x06001784 RID: 6020
		public extern float minParticleSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001785 RID: 6021
		// (set) Token: 0x06001786 RID: 6022
		public extern float maxParticleSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001787 RID: 6023
		// (set) Token: 0x06001788 RID: 6024
		public extern Mesh mesh { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x0001D4F8 File Offset: 0x0001B6F8
		public int meshCount
		{
			get
			{
				return this.Internal_GetMeshCount();
			}
		}

		// Token: 0x0600178A RID: 6026
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int Internal_GetMeshCount();

		// Token: 0x0600178B RID: 6027
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetMeshes(Mesh[] meshes);

		// Token: 0x0600178C RID: 6028 RVA: 0x0001D514 File Offset: 0x0001B714
		public void SetMeshes(Mesh[] meshes)
		{
			this.SetMeshes(meshes, meshes.Length);
		}

		// Token: 0x0600178D RID: 6029
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetMeshes(Mesh[] meshes, int size);

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600178E RID: 6030
		// (set) Token: 0x0600178F RID: 6031
		public extern Material trailMaterial { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001790 RID: 6032
		public extern int activeVertexStreamsCount { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001791 RID: 6033 RVA: 0x0001D524 File Offset: 0x0001B724
		public void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams)
		{
			if (streams == null)
			{
				throw new ArgumentNullException("streams");
			}
			this.SetActiveVertexStreamsInternal(streams);
		}

		// Token: 0x06001792 RID: 6034
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetActiveVertexStreamsInternal(object streams);

		// Token: 0x06001793 RID: 6035 RVA: 0x0001D540 File Offset: 0x0001B740
		public void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams)
		{
			if (streams == null)
			{
				throw new ArgumentNullException("streams");
			}
			this.GetActiveVertexStreamsInternal(streams);
		}

		// Token: 0x06001794 RID: 6036
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetActiveVertexStreamsInternal(object streams);

		// Token: 0x06001795 RID: 6037 RVA: 0x0001D55C File Offset: 0x0001B75C
		[Obsolete("EnableVertexStreams is deprecated. Use SetActiveVertexStreams instead.")]
		public void EnableVertexStreams(ParticleSystemVertexStreams streams)
		{
			this.Internal_SetVertexStreams(streams, true);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0001D568 File Offset: 0x0001B768
		[Obsolete("DisableVertexStreams is deprecated. Use SetActiveVertexStreams instead.")]
		public void DisableVertexStreams(ParticleSystemVertexStreams streams)
		{
			this.Internal_SetVertexStreams(streams, false);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0001D574 File Offset: 0x0001B774
		[Obsolete("AreVertexStreamsEnabled is deprecated. Use GetActiveVertexStreams instead.")]
		public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams)
		{
			return this.Internal_GetEnabledVertexStreams(streams) == streams;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x0001D594 File Offset: 0x0001B794
		[Obsolete("GetEnabledVertexStreams is deprecated. Use GetActiveVertexStreams instead.")]
		public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams)
		{
			return this.Internal_GetEnabledVertexStreams(streams);
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x0001D5B0 File Offset: 0x0001B7B0
		[Obsolete("Internal_SetVertexStreams is deprecated. Use SetActiveVertexStreams instead.")]
		internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled)
		{
			List<ParticleSystemVertexStream> list = new List<ParticleSystemVertexStream>(this.activeVertexStreamsCount);
			this.GetActiveVertexStreams(list);
			if (enabled)
			{
				if ((streams & ParticleSystemVertexStreams.Position) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.Position))
					{
						list.Add(ParticleSystemVertexStream.Position);
					}
				}
				if ((streams & ParticleSystemVertexStreams.Normal) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.Normal))
					{
						list.Add(ParticleSystemVertexStream.Normal);
					}
				}
				if ((streams & ParticleSystemVertexStreams.Tangent) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.Tangent))
					{
						list.Add(ParticleSystemVertexStream.Tangent);
					}
				}
				if ((streams & ParticleSystemVertexStreams.Color) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.Color))
					{
						list.Add(ParticleSystemVertexStream.Color);
					}
				}
				if ((streams & ParticleSystemVertexStreams.UV) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.UV))
					{
						list.Add(ParticleSystemVertexStream.UV);
					}
				}
				if ((streams & ParticleSystemVertexStreams.UV2BlendAndFrame) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.UV2))
					{
						list.Add(ParticleSystemVertexStream.UV2);
						list.Add(ParticleSystemVertexStream.AnimBlend);
						list.Add(ParticleSystemVertexStream.AnimFrame);
					}
				}
				if ((streams & ParticleSystemVertexStreams.CenterAndVertexID) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.Center))
					{
						list.Add(ParticleSystemVertexStream.Center);
						list.Add(ParticleSystemVertexStream.VertexID);
					}
				}
				if ((streams & ParticleSystemVertexStreams.Size) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.SizeXYZ))
					{
						list.Add(ParticleSystemVertexStream.SizeXYZ);
					}
				}
				if ((streams & ParticleSystemVertexStreams.Rotation) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.Rotation3D))
					{
						list.Add(ParticleSystemVertexStream.Rotation3D);
					}
				}
				if ((streams & ParticleSystemVertexStreams.Velocity) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.Velocity))
					{
						list.Add(ParticleSystemVertexStream.Velocity);
					}
				}
				if ((streams & ParticleSystemVertexStreams.Lifetime) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.AgePercent))
					{
						list.Add(ParticleSystemVertexStream.AgePercent);
						list.Add(ParticleSystemVertexStream.InvStartLifetime);
					}
				}
				if ((streams & ParticleSystemVertexStreams.Custom1) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.Custom1XYZW))
					{
						list.Add(ParticleSystemVertexStream.Custom1XYZW);
					}
				}
				if ((streams & ParticleSystemVertexStreams.Custom2) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.Custom2XYZW))
					{
						list.Add(ParticleSystemVertexStream.Custom2XYZW);
					}
				}
				if ((streams & ParticleSystemVertexStreams.Random) != ParticleSystemVertexStreams.None)
				{
					if (!list.Contains(ParticleSystemVertexStream.StableRandomXYZ))
					{
						list.Add(ParticleSystemVertexStream.StableRandomXYZ);
						list.Add(ParticleSystemVertexStream.VaryingRandomX);
					}
				}
			}
			else
			{
				if ((streams & ParticleSystemVertexStreams.Position) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.Position);
				}
				if ((streams & ParticleSystemVertexStreams.Normal) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.Normal);
				}
				if ((streams & ParticleSystemVertexStreams.Tangent) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.Tangent);
				}
				if ((streams & ParticleSystemVertexStreams.Color) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.Color);
				}
				if ((streams & ParticleSystemVertexStreams.UV) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.UV);
				}
				if ((streams & ParticleSystemVertexStreams.UV2BlendAndFrame) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.UV2);
					list.Remove(ParticleSystemVertexStream.AnimBlend);
					list.Remove(ParticleSystemVertexStream.AnimFrame);
				}
				if ((streams & ParticleSystemVertexStreams.CenterAndVertexID) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.Center);
					list.Remove(ParticleSystemVertexStream.VertexID);
				}
				if ((streams & ParticleSystemVertexStreams.Size) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.SizeXYZ);
				}
				if ((streams & ParticleSystemVertexStreams.Rotation) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.Rotation3D);
				}
				if ((streams & ParticleSystemVertexStreams.Velocity) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.Velocity);
				}
				if ((streams & ParticleSystemVertexStreams.Lifetime) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.AgePercent);
					list.Remove(ParticleSystemVertexStream.InvStartLifetime);
				}
				if ((streams & ParticleSystemVertexStreams.Custom1) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.Custom1XYZW);
				}
				if ((streams & ParticleSystemVertexStreams.Custom2) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.Custom2XYZW);
				}
				if ((streams & ParticleSystemVertexStreams.Random) != ParticleSystemVertexStreams.None)
				{
					list.Remove(ParticleSystemVertexStream.StableRandomXYZW);
					list.Remove(ParticleSystemVertexStream.VaryingRandomX);
				}
			}
			this.SetActiveVertexStreams(list);
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x0001D940 File Offset: 0x0001BB40
		[Obsolete("Internal_GetVertexStreams is deprecated. Use GetActiveVertexStreams instead.")]
		internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams)
		{
			List<ParticleSystemVertexStream> list = new List<ParticleSystemVertexStream>(this.activeVertexStreamsCount);
			this.GetActiveVertexStreams(list);
			ParticleSystemVertexStreams particleSystemVertexStreams = ParticleSystemVertexStreams.None;
			if (list.Contains(ParticleSystemVertexStream.Position))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Position;
			}
			if (list.Contains(ParticleSystemVertexStream.Normal))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Normal;
			}
			if (list.Contains(ParticleSystemVertexStream.Tangent))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Tangent;
			}
			if (list.Contains(ParticleSystemVertexStream.Color))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Color;
			}
			if (list.Contains(ParticleSystemVertexStream.UV))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.UV;
			}
			if (list.Contains(ParticleSystemVertexStream.UV2))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.UV2BlendAndFrame;
			}
			if (list.Contains(ParticleSystemVertexStream.Center))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.CenterAndVertexID;
			}
			if (list.Contains(ParticleSystemVertexStream.SizeXYZ))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Size;
			}
			if (list.Contains(ParticleSystemVertexStream.Rotation3D))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Rotation;
			}
			if (list.Contains(ParticleSystemVertexStream.Velocity))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Velocity;
			}
			if (list.Contains(ParticleSystemVertexStream.AgePercent))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Lifetime;
			}
			if (list.Contains(ParticleSystemVertexStream.Custom1XYZW))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Custom1;
			}
			if (list.Contains(ParticleSystemVertexStream.Custom2XYZW))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Custom2;
			}
			if (list.Contains(ParticleSystemVertexStream.StableRandomXYZ))
			{
				particleSystemVertexStreams |= ParticleSystemVertexStreams.Random;
			}
			return particleSystemVertexStreams & streams;
		}
	}
}
