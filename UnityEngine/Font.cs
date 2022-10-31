using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000239 RID: 569
	public sealed class Font : Object
	{
		// Token: 0x06002627 RID: 9767 RVA: 0x0002BE00 File Offset: 0x0002A000
		public Font()
		{
			Font.Internal_CreateFont(this, null);
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x0002BE10 File Offset: 0x0002A010
		public Font(string name)
		{
			Font.Internal_CreateFont(this, name);
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x0002BE20 File Offset: 0x0002A020
		private Font(string[] names, int size)
		{
			Font.Internal_CreateDynamicFont(this, names, size);
		}

		// Token: 0x0600262A RID: 9770
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string[] GetOSInstalledFontNames();

		// Token: 0x0600262B RID: 9771
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateFont([Writable] Font _font, string name);

		// Token: 0x0600262C RID: 9772
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateDynamicFont([Writable] Font _font, string[] _names, int size);

		// Token: 0x0600262D RID: 9773 RVA: 0x0002BE34 File Offset: 0x0002A034
		public static Font CreateDynamicFontFromOSFont(string fontname, int size)
		{
			return new Font(new string[]
			{
				fontname
			}, size);
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x0002BE5C File Offset: 0x0002A05C
		public static Font CreateDynamicFontFromOSFont(string[] fontnames, int size)
		{
			return new Font(fontnames, size);
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x0600262F RID: 9775
		// (set) Token: 0x06002630 RID: 9776
		public extern Material material { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002631 RID: 9777
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool HasCharacter(char c);

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002632 RID: 9778
		// (set) Token: 0x06002633 RID: 9779
		public extern string[] fontNames { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002634 RID: 9780
		// (set) Token: 0x06002635 RID: 9781
		public extern CharacterInfo[] characterInfo { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002636 RID: 9782
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RequestCharactersInTexture(string characters, [UnityEngine.Internal.DefaultValue("0")] int size, [UnityEngine.Internal.DefaultValue("FontStyle.Normal")] FontStyle style);

		// Token: 0x06002637 RID: 9783 RVA: 0x0002BE7C File Offset: 0x0002A07C
		[ExcludeFromDocs]
		public void RequestCharactersInTexture(string characters, int size)
		{
			FontStyle style = FontStyle.Normal;
			this.RequestCharactersInTexture(characters, size, style);
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x0002BE98 File Offset: 0x0002A098
		[ExcludeFromDocs]
		public void RequestCharactersInTexture(string characters)
		{
			FontStyle style = FontStyle.Normal;
			int size = 0;
			this.RequestCharactersInTexture(characters, size, style);
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06002639 RID: 9785 RVA: 0x0002BEB4 File Offset: 0x0002A0B4
		// (remove) Token: 0x0600263A RID: 9786 RVA: 0x0002BEE8 File Offset: 0x0002A0E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<Font> textureRebuilt;

		// Token: 0x0600263B RID: 9787 RVA: 0x0002BF1C File Offset: 0x0002A11C
		[RequiredByNativeCode]
		private static void InvokeTextureRebuilt_Internal(Font font)
		{
			Action<Font> action = Font.textureRebuilt;
			if (action != null)
			{
				action(font);
			}
			if (font.m_FontTextureRebuildCallback != null)
			{
				font.m_FontTextureRebuildCallback();
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600263C RID: 9788 RVA: 0x0002BF54 File Offset: 0x0002A154
		// (remove) Token: 0x0600263D RID: 9789 RVA: 0x0002BF8C File Offset: 0x0002A18C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private event Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x0002BFC4 File Offset: 0x0002A1C4
		// (set) Token: 0x0600263F RID: 9791 RVA: 0x0002BFE0 File Offset: 0x0002A1E0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Font.textureRebuildCallback has been deprecated. Use Font.textureRebuilt instead.")]
		public Font.FontTextureRebuildCallback textureRebuildCallback
		{
			get
			{
				return this.m_FontTextureRebuildCallback;
			}
			set
			{
				this.m_FontTextureRebuildCallback = value;
			}
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x0002BFEC File Offset: 0x0002A1EC
		public static int GetMaxVertsForString(string str)
		{
			return str.Length * 4 + 4;
		}

		// Token: 0x06002641 RID: 9793
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetCharacterInfo(char ch, out CharacterInfo info, [UnityEngine.Internal.DefaultValue("0")] int size, [UnityEngine.Internal.DefaultValue("FontStyle.Normal")] FontStyle style);

		// Token: 0x06002642 RID: 9794 RVA: 0x0002C00C File Offset: 0x0002A20C
		[ExcludeFromDocs]
		public bool GetCharacterInfo(char ch, out CharacterInfo info, int size)
		{
			FontStyle style = FontStyle.Normal;
			return this.GetCharacterInfo(ch, out info, size, style);
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x0002C030 File Offset: 0x0002A230
		[ExcludeFromDocs]
		public bool GetCharacterInfo(char ch, out CharacterInfo info)
		{
			FontStyle style = FontStyle.Normal;
			int size = 0;
			return this.GetCharacterInfo(ch, out info, size, style);
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002644 RID: 9796
		public extern bool dynamic { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002645 RID: 9797
		public extern int ascent { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002646 RID: 9798
		public extern int lineHeight { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002647 RID: 9799
		public extern int fontSize { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0200023A RID: 570
		// (Invoke) Token: 0x06002649 RID: 9801
		[EditorBrowsable(EditorBrowsableState.Never)]
		public delegate void FontTextureRebuildCallback();
	}
}
