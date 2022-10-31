using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine.Networking
{
	// Token: 0x02000279 RID: 633
	[StructLayout(LayoutKind.Sequential)]
	public sealed class UnityWebRequest : IDisposable
	{
		// Token: 0x06002AA7 RID: 10919 RVA: 0x0003BA94 File Offset: 0x00039C94
		public UnityWebRequest()
		{
			this.InternalCreate();
			this.InternalSetDefaults();
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x0003BAAC File Offset: 0x00039CAC
		public UnityWebRequest(string url)
		{
			this.InternalCreate();
			this.InternalSetDefaults();
			this.url = url;
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x0003BAC8 File Offset: 0x00039CC8
		public UnityWebRequest(string url, string method)
		{
			this.InternalCreate();
			this.InternalSetDefaults();
			this.url = url;
			this.method = method;
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x0003BAEC File Offset: 0x00039CEC
		public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
		{
			this.InternalCreate();
			this.InternalSetDefaults();
			this.url = url;
			this.method = method;
			this.downloadHandler = downloadHandler;
			this.uploadHandler = uploadHandler;
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x0003BB20 File Offset: 0x00039D20
		public static UnityWebRequest Get(string uri)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerBuffer(), null);
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x0003BB48 File Offset: 0x00039D48
		public static UnityWebRequest Delete(string uri)
		{
			return new UnityWebRequest(uri, "DELETE");
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x0003BB6C File Offset: 0x00039D6C
		public static UnityWebRequest Head(string uri)
		{
			return new UnityWebRequest(uri, "HEAD");
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x0003BB90 File Offset: 0x00039D90
		public static UnityWebRequest GetTexture(string uri)
		{
			return UnityWebRequest.GetTexture(uri, false);
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x0003BBAC File Offset: 0x00039DAC
		public static UnityWebRequest GetTexture(string uri, bool nonReadable)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerTexture(!nonReadable), null);
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x0003BBD8 File Offset: 0x00039DD8
		public static UnityWebRequest GetAudioClip(string uri, AudioType audioType)
		{
			Type type = Type.GetType("UnityEngine.Networking.DownloadHandlerAudioClip");
			UnityWebRequest result;
			if (type == null)
			{
				result = UnityWebRequest.Get(uri);
			}
			else
			{
				ConstructorInfo constructor = type.GetConstructor(new Type[]
				{
					typeof(string),
					typeof(AudioType)
				});
				UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "GET", constructor.Invoke(new object[]
				{
					uri,
					audioType
				}) as DownloadHandler, null);
				result = unityWebRequest;
			}
			return result;
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x0003BC60 File Offset: 0x00039E60
		public static UnityWebRequest GetAssetBundle(string uri)
		{
			return UnityWebRequest.GetAssetBundle(uri, 0U);
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x0003BC7C File Offset: 0x00039E7C
		public static UnityWebRequest GetAssetBundle(string uri, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, crc), null);
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x0003BCA8 File Offset: 0x00039EA8
		public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, version, crc), null);
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x0003BCD4 File Offset: 0x00039ED4
		public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc)
		{
			return new UnityWebRequest(uri, "GET", new DownloadHandlerAssetBundle(uri, hash, crc), null);
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x0003BD00 File Offset: 0x00039F00
		public static UnityWebRequest Put(string uri, byte[] bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(bodyData));
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x0003BD30 File Offset: 0x00039F30
		public static UnityWebRequest Put(string uri, string bodyData)
		{
			return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(Encoding.UTF8.GetBytes(bodyData)));
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x0003BD68 File Offset: 0x00039F68
		public static UnityWebRequest Post(string uri, string postData)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			byte[] data = null;
			if (!string.IsNullOrEmpty(postData))
			{
				string s = WWWTranscoder.URLEncode(postData, Encoding.UTF8);
				data = Encoding.UTF8.GetBytes(s);
			}
			unityWebRequest.uploadHandler = new UploadHandlerRaw(data);
			unityWebRequest.uploadHandler.contentType = "application/x-www-form-urlencoded";
			unityWebRequest.downloadHandler = new DownloadHandlerBuffer();
			return unityWebRequest;
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x0003BDD8 File Offset: 0x00039FD8
		public static UnityWebRequest Post(string uri, WWWForm formData)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			byte[] array = null;
			if (formData != null)
			{
				array = formData.data;
				if (array.Length == 0)
				{
					array = null;
				}
			}
			unityWebRequest.uploadHandler = new UploadHandlerRaw(array);
			unityWebRequest.downloadHandler = new DownloadHandlerBuffer();
			if (formData != null)
			{
				Dictionary<string, string> headers = formData.headers;
				foreach (KeyValuePair<string, string> keyValuePair in headers)
				{
					unityWebRequest.SetRequestHeader(keyValuePair.Key, keyValuePair.Value);
				}
			}
			return unityWebRequest;
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0003BE98 File Offset: 0x0003A098
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections)
		{
			byte[] boundary = UnityWebRequest.GenerateBoundary();
			return UnityWebRequest.Post(uri, multipartFormSections, boundary);
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x0003BEBC File Offset: 0x0003A0BC
		public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections, byte[] boundary)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			byte[] data = null;
			if (multipartFormSections != null && multipartFormSections.Count != 0)
			{
				data = UnityWebRequest.SerializeFormSections(multipartFormSections, boundary);
			}
			unityWebRequest.uploadHandler = new UploadHandlerRaw(data)
			{
				contentType = "multipart/form-data; boundary=" + Encoding.UTF8.GetString(boundary, 0, boundary.Length)
			};
			unityWebRequest.downloadHandler = new DownloadHandlerBuffer();
			return unityWebRequest;
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0003BF34 File Offset: 0x0003A134
		public static UnityWebRequest Post(string uri, Dictionary<string, string> formFields)
		{
			UnityWebRequest unityWebRequest = new UnityWebRequest(uri, "POST");
			byte[] data = null;
			if (formFields != null && formFields.Count != 0)
			{
				data = UnityWebRequest.SerializeSimpleForm(formFields);
			}
			unityWebRequest.uploadHandler = new UploadHandlerRaw(data)
			{
				contentType = "application/x-www-form-urlencoded"
			};
			unityWebRequest.downloadHandler = new DownloadHandlerBuffer();
			return unityWebRequest;
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x0003BF94 File Offset: 0x0003A194
		public static byte[] SerializeFormSections(List<IMultipartFormSection> multipartFormSections, byte[] boundary)
		{
			byte[] bytes = Encoding.UTF8.GetBytes("\r\n");
			byte[] bytes2 = WWW.DefaultEncoding.GetBytes("--");
			int num = 0;
			foreach (IMultipartFormSection multipartFormSection in multipartFormSections)
			{
				num += 64 + multipartFormSection.sectionData.Length;
			}
			List<byte> list = new List<byte>(num);
			foreach (IMultipartFormSection multipartFormSection2 in multipartFormSections)
			{
				string str = "form-data";
				string sectionName = multipartFormSection2.sectionName;
				string fileName = multipartFormSection2.fileName;
				if (!string.IsNullOrEmpty(fileName))
				{
					str = "file";
				}
				string text = "Content-Disposition: " + str;
				if (!string.IsNullOrEmpty(sectionName))
				{
					text = text + "; name=\"" + sectionName + "\"";
				}
				if (!string.IsNullOrEmpty(fileName))
				{
					text = text + "; filename=\"" + fileName + "\"";
				}
				text += "\r\n";
				string contentType = multipartFormSection2.contentType;
				if (!string.IsNullOrEmpty(contentType))
				{
					text = text + "Content-Type: " + contentType + "\r\n";
				}
				list.AddRange(bytes);
				list.AddRange(bytes2);
				list.AddRange(boundary);
				list.AddRange(bytes);
				list.AddRange(Encoding.UTF8.GetBytes(text));
				list.AddRange(bytes);
				list.AddRange(multipartFormSection2.sectionData);
			}
			list.TrimExcess();
			return list.ToArray();
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x0003C19C File Offset: 0x0003A39C
		public static byte[] GenerateBoundary()
		{
			byte[] array = new byte[40];
			for (int i = 0; i < 40; i++)
			{
				int num = Random.Range(48, 110);
				if (num > 57)
				{
					num += 7;
				}
				if (num > 90)
				{
					num += 6;
				}
				array[i] = (byte)num;
			}
			return array;
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x0003C1F8 File Offset: 0x0003A3F8
		public static byte[] SerializeSimpleForm(Dictionary<string, string> formFields)
		{
			string text = "";
			foreach (KeyValuePair<string, string> keyValuePair in formFields)
			{
				if (text.Length > 0)
				{
					text += "&";
				}
				text = text + Uri.EscapeDataString(keyValuePair.Key) + "=" + Uri.EscapeDataString(keyValuePair.Value);
			}
			return Encoding.UTF8.GetBytes(text);
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x0003C2A4 File Offset: 0x0003A4A4
		// (set) Token: 0x06002AC0 RID: 10944 RVA: 0x0003C2C0 File Offset: 0x0003A4C0
		public bool disposeDownloadHandlerOnDispose { get; set; }

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x0003C2CC File Offset: 0x0003A4CC
		// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x0003C2E8 File Offset: 0x0003A4E8
		public bool disposeUploadHandlerOnDispose { get; set; }

		// Token: 0x06002AC3 RID: 10947
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalCreate();

		// Token: 0x06002AC4 RID: 10948
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalDestroy();

		// Token: 0x06002AC5 RID: 10949 RVA: 0x0003C2F4 File Offset: 0x0003A4F4
		private void InternalSetDefaults()
		{
			this.disposeDownloadHandlerOnDispose = true;
			this.disposeUploadHandlerOnDispose = true;
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x0003C308 File Offset: 0x0003A508
		~UnityWebRequest()
		{
			this.InternalDestroy();
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x0003C338 File Offset: 0x0003A538
		public void Dispose()
		{
			if (this.disposeDownloadHandlerOnDispose)
			{
				DownloadHandler downloadHandler = this.downloadHandler;
				if (downloadHandler != null)
				{
					downloadHandler.Dispose();
				}
			}
			if (this.disposeUploadHandlerOnDispose)
			{
				UploadHandler uploadHandler = this.uploadHandler;
				if (uploadHandler != null)
				{
					uploadHandler.Dispose();
				}
			}
			this.InternalDestroy();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002AC8 RID: 10952
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern AsyncOperation InternalBegin();

		// Token: 0x06002AC9 RID: 10953
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalAbort();

		// Token: 0x06002ACA RID: 10954 RVA: 0x0003C398 File Offset: 0x0003A598
		public AsyncOperation Send()
		{
			return this.InternalBegin();
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x0003C3B4 File Offset: 0x0003A5B4
		public void Abort()
		{
			this.InternalAbort();
		}

		// Token: 0x06002ACC RID: 10956
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType);

		// Token: 0x06002ACD RID: 10957
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalSetCustomMethod(string customMethodName);

		// Token: 0x06002ACE RID: 10958
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern int InternalGetMethod();

		// Token: 0x06002ACF RID: 10959
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern string InternalGetCustomMethod();

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x0003C3C0 File Offset: 0x0003A5C0
		// (set) Token: 0x06002AD1 RID: 10961 RVA: 0x0003C42C File Offset: 0x0003A62C
		public string method
		{
			get
			{
				string result;
				switch (this.InternalGetMethod())
				{
				case 0:
					result = "GET";
					break;
				case 1:
					result = "POST";
					break;
				case 2:
					result = "PUT";
					break;
				case 3:
					result = "HEAD";
					break;
				default:
					result = this.InternalGetCustomMethod();
					break;
				}
				return result;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Cannot set a UnityWebRequest's method to an empty or null string");
				}
				string text = value.ToUpper();
				if (text != null)
				{
					if (text == "GET")
					{
						this.InternalSetMethod(UnityWebRequest.UnityWebRequestMethod.Get);
						return;
					}
					if (text == "POST")
					{
						this.InternalSetMethod(UnityWebRequest.UnityWebRequestMethod.Post);
						return;
					}
					if (text == "PUT")
					{
						this.InternalSetMethod(UnityWebRequest.UnityWebRequestMethod.Put);
						return;
					}
					if (text == "HEAD")
					{
						this.InternalSetMethod(UnityWebRequest.UnityWebRequestMethod.Head);
						return;
					}
				}
				this.InternalSetCustomMethod(value.ToUpper());
			}
		}

		// Token: 0x06002AD2 RID: 10962
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern int InternalGetError();

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002AD3 RID: 10963
		public extern string error { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06002AD4 RID: 10964
		// (set) Token: 0x06002AD5 RID: 10965
		public extern bool useHttpContinue { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002AD6 RID: 10966 RVA: 0x0003C4E4 File Offset: 0x0003A6E4
		// (set) Token: 0x06002AD7 RID: 10967 RVA: 0x0003C500 File Offset: 0x0003A700
		public string url
		{
			get
			{
				return this.InternalGetUrl();
			}
			set
			{
				string localUrl = "http://localhost/";
				this.InternalSetUrl(WebRequestUtils.MakeInitialUrl(value, localUrl));
			}
		}

		// Token: 0x06002AD8 RID: 10968
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern string InternalGetUrl();

		// Token: 0x06002AD9 RID: 10969
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InternalSetUrl(string url);

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002ADA RID: 10970
		public extern long responseCode { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002ADB RID: 10971
		public extern float uploadProgress { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002ADC RID: 10972
		public extern bool isModifiable { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06002ADD RID: 10973
		public extern bool isDone { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06002ADE RID: 10974
		public extern bool isError { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06002ADF RID: 10975
		public extern float downloadProgress { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002AE0 RID: 10976
		public extern ulong uploadedBytes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002AE1 RID: 10977
		public extern ulong downloadedBytes { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002AE2 RID: 10978
		// (set) Token: 0x06002AE3 RID: 10979
		public extern int redirectLimit { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002AE4 RID: 10980
		// (set) Token: 0x06002AE5 RID: 10981
		public extern bool chunkedTransfer { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002AE6 RID: 10982
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetRequestHeader(string name);

		// Token: 0x06002AE7 RID: 10983
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalSetRequestHeader(string name, string value);

		// Token: 0x06002AE8 RID: 10984 RVA: 0x0003C524 File Offset: 0x0003A724
		public void SetRequestHeader(string name, string value)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException("Cannot set a Request Header with a null or empty name");
			}
			if (value == null)
			{
				throw new ArgumentException("Cannot set a Request header with a null");
			}
			this.InternalSetRequestHeader(name, value);
		}

		// Token: 0x06002AE9 RID: 10985
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetResponseHeader(string name);

		// Token: 0x06002AEA RID: 10986
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern string[] InternalGetResponseHeaderKeys();

		// Token: 0x06002AEB RID: 10987 RVA: 0x0003C558 File Offset: 0x0003A758
		public Dictionary<string, string> GetResponseHeaders()
		{
			string[] array = this.InternalGetResponseHeaderKeys();
			Dictionary<string, string> result;
			if (array == null)
			{
				result = null;
			}
			else
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>(array.Length, StringComparer.OrdinalIgnoreCase);
				for (int i = 0; i < array.Length; i++)
				{
					string responseHeader = this.GetResponseHeader(array[i]);
					dictionary.Add(array[i], responseHeader);
				}
				result = dictionary;
			}
			return result;
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002AEC RID: 10988
		// (set) Token: 0x06002AED RID: 10989
		public extern UploadHandler uploadHandler { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002AEE RID: 10990
		// (set) Token: 0x06002AEF RID: 10991
		public extern DownloadHandler downloadHandler { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002AF0 RID: 10992
		// (set) Token: 0x06002AF1 RID: 10993
		public extern int timeout { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06002AF2 RID: 10994 RVA: 0x0003C5C0 File Offset: 0x0003A7C0
		private static string GetErrorDescription(UnityWebRequest.UnityWebRequestError errorCode)
		{
			switch (errorCode)
			{
			case UnityWebRequest.UnityWebRequestError.OK:
				return "No Error";
			case UnityWebRequest.UnityWebRequestError.SDKError:
				return "Internal Error With Transport Layer";
			case UnityWebRequest.UnityWebRequestError.UnsupportedProtocol:
				return "Specified Transport Protocol is Unsupported";
			case UnityWebRequest.UnityWebRequestError.MalformattedUrl:
				return "URL is Malformatted";
			case UnityWebRequest.UnityWebRequestError.CannotResolveProxy:
				return "Unable to resolve specified proxy server";
			case UnityWebRequest.UnityWebRequestError.CannotResolveHost:
				return "Unable to resolve host specified in URL";
			case UnityWebRequest.UnityWebRequestError.CannotConnectToHost:
				return "Unable to connect to host specified in URL";
			case UnityWebRequest.UnityWebRequestError.AccessDenied:
				return "Remote server denied access to the specified URL";
			case UnityWebRequest.UnityWebRequestError.GenericHTTPError:
				return "Unknown/Generic HTTP Error - Check HTTP Error code";
			case UnityWebRequest.UnityWebRequestError.WriteError:
				return "Error when transmitting request to remote server - transmission terminated prematurely";
			case UnityWebRequest.UnityWebRequestError.ReadError:
				return "Error when reading response from remote server - transmission terminated prematurely";
			case UnityWebRequest.UnityWebRequestError.OutOfMemory:
				return "Out of Memory";
			case UnityWebRequest.UnityWebRequestError.Timeout:
				return "Timeout occurred while waiting for response from remote server";
			case UnityWebRequest.UnityWebRequestError.HTTPPostError:
				return "Error while transmitting HTTP POST body data";
			case UnityWebRequest.UnityWebRequestError.SSLCannotConnect:
				return "Unable to connect to SSL server at remote host";
			case UnityWebRequest.UnityWebRequestError.Aborted:
				return "Request was manually aborted by local code";
			case UnityWebRequest.UnityWebRequestError.TooManyRedirects:
				return "Redirect limit exceeded";
			case UnityWebRequest.UnityWebRequestError.ReceivedNoData:
				return "Received an empty response from remote host";
			case UnityWebRequest.UnityWebRequestError.SSLNotSupported:
				return "SSL connections are not supported on the local machine";
			case UnityWebRequest.UnityWebRequestError.FailedToSendData:
				return "Failed to transmit body data";
			case UnityWebRequest.UnityWebRequestError.FailedToReceiveData:
				return "Failed to receive response body data";
			case UnityWebRequest.UnityWebRequestError.SSLCertificateError:
				return "Failure to authenticate SSL certificate of remote host";
			case UnityWebRequest.UnityWebRequestError.SSLCipherNotAvailable:
				return "SSL cipher received from remote host is not supported on the local machine";
			case UnityWebRequest.UnityWebRequestError.SSLCACertError:
				return "Failure to authenticate Certificate Authority of the SSL certificate received from the remote host";
			case UnityWebRequest.UnityWebRequestError.UnrecognizedContentEncoding:
				return "Remote host returned data with an unrecognized/unparseable content encoding";
			case UnityWebRequest.UnityWebRequestError.LoginFailed:
				return "HTTP authentication failed";
			case UnityWebRequest.UnityWebRequestError.SSLShutdownFailed:
				return "Failure while shutting down SSL connection";
			}
			return "Unknown error";
		}

		// Token: 0x04000827 RID: 2087
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x04000828 RID: 2088
		public const string kHttpVerbGET = "GET";

		// Token: 0x04000829 RID: 2089
		public const string kHttpVerbHEAD = "HEAD";

		// Token: 0x0400082A RID: 2090
		public const string kHttpVerbPOST = "POST";

		// Token: 0x0400082B RID: 2091
		public const string kHttpVerbPUT = "PUT";

		// Token: 0x0400082C RID: 2092
		public const string kHttpVerbCREATE = "CREATE";

		// Token: 0x0400082D RID: 2093
		public const string kHttpVerbDELETE = "DELETE";

		// Token: 0x0200027A RID: 634
		internal enum UnityWebRequestMethod
		{
			// Token: 0x04000831 RID: 2097
			Get,
			// Token: 0x04000832 RID: 2098
			Post,
			// Token: 0x04000833 RID: 2099
			Put,
			// Token: 0x04000834 RID: 2100
			Head,
			// Token: 0x04000835 RID: 2101
			Custom
		}

		// Token: 0x0200027B RID: 635
		internal enum UnityWebRequestError
		{
			// Token: 0x04000837 RID: 2103
			OK,
			// Token: 0x04000838 RID: 2104
			Unknown,
			// Token: 0x04000839 RID: 2105
			SDKError,
			// Token: 0x0400083A RID: 2106
			UnsupportedProtocol,
			// Token: 0x0400083B RID: 2107
			MalformattedUrl,
			// Token: 0x0400083C RID: 2108
			CannotResolveProxy,
			// Token: 0x0400083D RID: 2109
			CannotResolveHost,
			// Token: 0x0400083E RID: 2110
			CannotConnectToHost,
			// Token: 0x0400083F RID: 2111
			AccessDenied,
			// Token: 0x04000840 RID: 2112
			GenericHTTPError,
			// Token: 0x04000841 RID: 2113
			WriteError,
			// Token: 0x04000842 RID: 2114
			ReadError,
			// Token: 0x04000843 RID: 2115
			OutOfMemory,
			// Token: 0x04000844 RID: 2116
			Timeout,
			// Token: 0x04000845 RID: 2117
			HTTPPostError,
			// Token: 0x04000846 RID: 2118
			SSLCannotConnect,
			// Token: 0x04000847 RID: 2119
			Aborted,
			// Token: 0x04000848 RID: 2120
			TooManyRedirects,
			// Token: 0x04000849 RID: 2121
			ReceivedNoData,
			// Token: 0x0400084A RID: 2122
			SSLNotSupported,
			// Token: 0x0400084B RID: 2123
			FailedToSendData,
			// Token: 0x0400084C RID: 2124
			FailedToReceiveData,
			// Token: 0x0400084D RID: 2125
			SSLCertificateError,
			// Token: 0x0400084E RID: 2126
			SSLCipherNotAvailable,
			// Token: 0x0400084F RID: 2127
			SSLCACertError,
			// Token: 0x04000850 RID: 2128
			UnrecognizedContentEncoding,
			// Token: 0x04000851 RID: 2129
			LoginFailed,
			// Token: 0x04000852 RID: 2130
			SSLShutdownFailed,
			// Token: 0x04000853 RID: 2131
			NoInternetConnection
		}
	}
}
