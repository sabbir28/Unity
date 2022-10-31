using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000267 RID: 615
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class GUIStyleState
	{
		// Token: 0x06002939 RID: 10553 RVA: 0x00036C20 File Offset: 0x00034E20
		public GUIStyleState()
		{
			this.Init();
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x00036C30 File Offset: 0x00034E30
		private GUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			this.m_SourceStyle = sourceStyle;
			this.m_Ptr = source;
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00036C48 File Offset: 0x00034E48
		internal static GUIStyleState ProduceGUIStyleStateFromDeserialization(GUIStyle sourceStyle, IntPtr source)
		{
			GUIStyleState guistyleState = new GUIStyleState(sourceStyle, source);
			guistyleState.m_Background = guistyleState.GetBackgroundInternalFromDeserialization();
			return guistyleState;
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00036C74 File Offset: 0x00034E74
		internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			GUIStyleState guistyleState = new GUIStyleState(sourceStyle, source);
			guistyleState.m_Background = guistyleState.GetBackgroundInternal();
			return guistyleState;
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x00036CA0 File Offset: 0x00034EA0
		~GUIStyleState()
		{
			if (this.m_SourceStyle == null)
			{
				this.Cleanup();
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x00036CDC File Offset: 0x00034EDC
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x00036CF8 File Offset: 0x00034EF8
		public Texture2D background
		{
			get
			{
				return this.GetBackgroundInternal();
			}
			set
			{
				this.SetBackgroundInternal(value);
				this.m_Background = value;
			}
		}

		// Token: 0x06002940 RID: 10560
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x06002941 RID: 10561
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		// Token: 0x06002942 RID: 10562
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetBackgroundInternal(Texture2D value);

		// Token: 0x06002943 RID: 10563
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Texture2D GetBackgroundInternalFromDeserialization();

		// Token: 0x06002944 RID: 10564
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Texture2D GetBackgroundInternal();

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x00036D0C File Offset: 0x00034F0C
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x00036D2C File Offset: 0x00034F2C
		public Color textColor
		{
			get
			{
				Color result;
				this.INTERNAL_get_textColor(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_textColor(ref value);
			}
		}

		// Token: 0x06002947 RID: 10567
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_textColor(out Color value);

		// Token: 0x06002948 RID: 10568
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_textColor(ref Color value);

		// Token: 0x04000792 RID: 1938
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x04000793 RID: 1939
		private readonly GUIStyle m_SourceStyle;

		// Token: 0x04000794 RID: 1940
		[NonSerialized]
		private Texture2D m_Background;
	}
}
