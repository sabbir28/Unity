using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D3 RID: 211
	[UsedByNativeCode]
	public sealed class WWW : IDisposable
	{
		// Token: 0x06000F6A RID: 3946 RVA: 0x0001432C File Offset: 0x0001252C
		public WWW(string url)
		{
			this.InitWWW(url, null, null);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00014340 File Offset: 0x00012540
		public WWW(string url, WWWForm form)
		{
			string[] iHeaders = WWW.FlattenedHeadersFrom(form.headers);
			this.InitWWW(url, form.data, iHeaders);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00014370 File Offset: 0x00012570
		public WWW(string url, byte[] postData)
		{
			this.InitWWW(url, postData, null);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00014384 File Offset: 0x00012584
		[Obsolete("This overload is deprecated. Use UnityEngine.WWW.WWW(string, byte[], System.Collections.Generic.Dictionary<string, string>) instead.", true)]
		public WWW(string url, byte[] postData, Hashtable headers)
		{
			Debug.LogError("This overload is deprecated. Use UnityEngine.WWW.WWW(string, byte[], System.Collections.Generic.Dictionary<string, string>) instead");
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00014398 File Offset: 0x00012598
		public WWW(string url, byte[] postData, Dictionary<string, string> headers)
		{
			string[] iHeaders = WWW.FlattenedHeadersFrom(headers);
			this.InitWWW(url, postData, iHeaders);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000143BC File Offset: 0x000125BC
		internal WWW(string url, Hash128 hash, uint crc)
		{
			WWW.INTERNAL_CALL_WWW(this, url, ref hash, crc);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x000143D0 File Offset: 0x000125D0
		public void Dispose()
		{
			this.DestroyWWW(true);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x000143DC File Offset: 0x000125DC
		~WWW()
		{
			this.DestroyWWW(false);
		}

		// Token: 0x06000F72 RID: 3954
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void DestroyWWW(bool cancel);

		// Token: 0x06000F73 RID: 3955
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InitWWW(string url, byte[] postData, string[] iHeaders);

		// Token: 0x06000F74 RID: 3956
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool enforceWebSecurityRestrictions();

		// Token: 0x06000F75 RID: 3957 RVA: 0x00014410 File Offset: 0x00012610
		[ExcludeFromDocs]
		public static string EscapeURL(string s)
		{
			Encoding utf = Encoding.UTF8;
			return WWW.EscapeURL(s, utf);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00014434 File Offset: 0x00012634
		public static string EscapeURL(string s, [DefaultValue("System.Text.Encoding.UTF8")] Encoding e)
		{
			string result;
			if (s == null)
			{
				result = null;
			}
			else if (s == "")
			{
				result = "";
			}
			else if (e == null)
			{
				result = null;
			}
			else
			{
				result = WWWTranscoder.URLEncode(s, e);
			}
			return result;
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00014488 File Offset: 0x00012688
		[ExcludeFromDocs]
		public static string UnEscapeURL(string s)
		{
			Encoding utf = Encoding.UTF8;
			return WWW.UnEscapeURL(s, utf);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000144AC File Offset: 0x000126AC
		public static string UnEscapeURL(string s, [DefaultValue("System.Text.Encoding.UTF8")] Encoding e)
		{
			string result;
			if (s == null)
			{
				result = null;
			}
			else if (s.IndexOf('%') == -1 && s.IndexOf('+') == -1)
			{
				result = s;
			}
			else
			{
				result = WWWTranscoder.URLDecode(s, e);
			}
			return result;
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x000144F8 File Offset: 0x000126F8
		public Dictionary<string, string> responseHeaders
		{
			get
			{
				if (!this.isDone)
				{
					throw new UnityException("WWW is not finished downloading yet");
				}
				return WWW.ParseHTTPHeaderString(this.responseHeadersString);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000F7A RID: 3962
		private extern string responseHeadersString { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00014530 File Offset: 0x00012730
		public string text
		{
			get
			{
				if (!this.isDone)
				{
					throw new UnityException("WWW is not ready downloading yet");
				}
				byte[] bytes = this.bytes;
				return this.GetTextEncoder().GetString(bytes, 0, bytes.Length);
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00014574 File Offset: 0x00012774
		internal static Encoding DefaultEncoding
		{
			get
			{
				return Encoding.ASCII;
			}
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00014590 File Offset: 0x00012790
		private Encoding GetTextEncoder()
		{
			string text = null;
			if (this.responseHeaders.TryGetValue("CONTENT-TYPE", out text))
			{
				int num = text.IndexOf("charset", StringComparison.OrdinalIgnoreCase);
				if (num > -1)
				{
					int num2 = text.IndexOf('=', num);
					if (num2 > -1)
					{
						string text2 = text.Substring(num2 + 1).Trim().Trim(new char[]
						{
							'\'',
							'"'
						}).Trim();
						int num3 = text2.IndexOf(';');
						if (num3 > -1)
						{
							text2 = text2.Substring(0, num3);
						}
						try
						{
							return Encoding.GetEncoding(text2);
						}
						catch (Exception)
						{
							Debug.Log("Unsupported encoding: '" + text2 + "'");
						}
					}
				}
			}
			return Encoding.UTF8;
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x00014670 File Offset: 0x00012870
		[Obsolete("Please use WWW.text instead")]
		public string data
		{
			get
			{
				return this.text;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000F7F RID: 3967
		public extern byte[] bytes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000F80 RID: 3968
		public extern int size { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000F81 RID: 3969
		public extern string error { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F82 RID: 3970
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Texture2D GetTexture(bool markNonReadable);

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x0001468C File Offset: 0x0001288C
		public Texture2D texture
		{
			get
			{
				return this.GetTexture(false);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x000146A8 File Offset: 0x000128A8
		public Texture2D textureNonReadable
		{
			get
			{
				return this.GetTexture(true);
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x000146C4 File Offset: 0x000128C4
		[Obsolete("Obsolete msg (UnityUpgradable) -> * UnityEngine.WWWAudioExtensions.GetAudioClip(UnityEngine.WWW)", true)]
		public Object audioClip
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000F86 RID: 3974
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Object GetAudioClipInternal(bool threeD, bool stream, bool compressed, AudioType audioType);

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x000146DC File Offset: 0x000128DC
		[Obsolete("Obsolete msg (UnityUpgradable) -> * UnityEngine.WWWAudioExtensions.GetMovieTexture(UnityEngine.WWW)", true)]
		public Object movie
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000F88 RID: 3976
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Object GetMovieTextureInternal();

		// Token: 0x06000F89 RID: 3977
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void LoadImageIntoTexture(Texture2D tex);

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000F8A RID: 3978
		public extern bool isDone { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000F8B RID: 3979
		[Obsolete("All blocking WWW functions have been deprecated, please use one of the asynchronous functions instead.", true)]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetURL(string url);

		// Token: 0x06000F8C RID: 3980 RVA: 0x000146F4 File Offset: 0x000128F4
		[Obsolete("All blocking WWW functions have been deprecated, please use one of the asynchronous functions instead.", true)]
		public static Texture2D GetTextureFromURL(string url)
		{
			return new WWW(url).texture;
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000F8D RID: 3981
		public extern float progress { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000F8E RID: 3982
		public extern float uploadProgress { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000F8F RID: 3983
		public extern int bytesDownloaded { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00014714 File Offset: 0x00012914
		public Object oggVorbis
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0001472C File Offset: 0x0001292C
		[Obsolete("LoadUnityWeb is no longer supported. Please use javascript to reload the web player on a different url instead", true)]
		public void LoadUnityWeb()
		{
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000F92 RID: 3986
		public extern string url { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000F93 RID: 3987
		public extern AssetBundle assetBundle { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000F94 RID: 3988
		// (set) Token: 0x06000F95 RID: 3989
		public extern ThreadPriority threadPriority { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000F96 RID: 3990
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_WWW(WWW self, string url, ref Hash128 hash, uint crc);

		// Token: 0x06000F97 RID: 3991 RVA: 0x00014730 File Offset: 0x00012930
		[ExcludeFromDocs]
		public static WWW LoadFromCacheOrDownload(string url, int version)
		{
			uint crc = 0U;
			return WWW.LoadFromCacheOrDownload(url, version, crc);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00014750 File Offset: 0x00012950
		public static WWW LoadFromCacheOrDownload(string url, int version, [DefaultValue("0")] uint crc)
		{
			Hash128 hash = new Hash128(0U, 0U, 0U, (uint)version);
			return WWW.LoadFromCacheOrDownload(url, hash, crc);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00014778 File Offset: 0x00012978
		[ExcludeFromDocs]
		public static WWW LoadFromCacheOrDownload(string url, Hash128 hash)
		{
			uint crc = 0U;
			return WWW.LoadFromCacheOrDownload(url, hash, crc);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00014798 File Offset: 0x00012998
		public static WWW LoadFromCacheOrDownload(string url, Hash128 hash, [DefaultValue("0")] uint crc)
		{
			return new WWW(url, hash, crc);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x000147B8 File Offset: 0x000129B8
		private static string[] FlattenedHeadersFrom(Dictionary<string, string> headers)
		{
			string[] result;
			if (headers == null)
			{
				result = null;
			}
			else
			{
				string[] array = new string[headers.Count * 2];
				int num = 0;
				foreach (KeyValuePair<string, string> keyValuePair in headers)
				{
					array[num++] = keyValuePair.Key.ToString();
					array[num++] = keyValuePair.Value.ToString();
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00014858 File Offset: 0x00012A58
		internal static Dictionary<string, string> ParseHTTPHeaderString(string input)
		{
			if (input == null)
			{
				throw new ArgumentException("input was null to ParseHTTPHeaderString");
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			StringReader stringReader = new StringReader(input);
			int num = 0;
			for (;;)
			{
				string text = stringReader.ReadLine();
				if (text == null)
				{
					break;
				}
				if (num++ == 0 && text.StartsWith("HTTP"))
				{
					dictionary["STATUS"] = text;
				}
				else
				{
					int num2 = text.IndexOf(": ");
					if (num2 != -1)
					{
						string key = text.Substring(0, num2).ToUpper();
						string text2 = text.Substring(num2 + 2);
						string str;
						if (dictionary.TryGetValue(key, out str))
						{
							text2 = str + "," + text2;
						}
						dictionary[key] = text2;
					}
				}
			}
			return dictionary;
		}

		// Token: 0x040001EF RID: 495
		[RequiredByNativeCode]
		internal IntPtr m_Ptr;
	}
}
