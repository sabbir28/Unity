using System;
using System.Text.RegularExpressions;
using UnityEngine.Scripting;

namespace UnityEngineInternal
{
	// Token: 0x0200027F RID: 639
	internal static class WebRequestUtils
	{
		// Token: 0x06002B0D RID: 11021 RVA: 0x0003CABC File Offset: 0x0003ACBC
		[RequiredByNativeCode]
		internal static string RedirectTo(string baseUri, string redirectUri)
		{
			Uri uri;
			if (redirectUri[0] == '/')
			{
				uri = new Uri(redirectUri, UriKind.Relative);
			}
			else
			{
				uri = new Uri(redirectUri, UriKind.RelativeOrAbsolute);
			}
			string result;
			if (uri.IsAbsoluteUri)
			{
				result = redirectUri;
			}
			else
			{
				Uri baseUri2 = new Uri(baseUri, UriKind.Absolute);
				Uri uri2 = new Uri(baseUri2, uri);
				result = uri2.AbsoluteUri;
			}
			return result;
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0003CB1C File Offset: 0x0003AD1C
		internal static string MakeInitialUrl(string targetUrl, string localUrl)
		{
			Uri uri = new Uri(localUrl);
			if (targetUrl.StartsWith("//"))
			{
				targetUrl = uri.Scheme + ":" + targetUrl;
			}
			if (targetUrl.StartsWith("/"))
			{
				targetUrl = uri.Scheme + "://" + uri.Host + targetUrl;
			}
			if (WebRequestUtils.domainRegex.IsMatch(targetUrl))
			{
				targetUrl = uri.Scheme + "://" + targetUrl;
			}
			Uri uri2 = null;
			try
			{
				uri2 = new Uri(targetUrl);
			}
			catch (FormatException ex)
			{
				try
				{
					uri2 = new Uri(uri, targetUrl);
				}
				catch (FormatException)
				{
					throw ex;
				}
			}
			return (!targetUrl.Contains("%")) ? uri2.AbsoluteUri : uri2.OriginalString;
		}

		// Token: 0x0400085B RID: 2139
		private static Regex domainRegex = new Regex("^\\s*\\w+(?:\\.\\w+)+\\s*$");
	}
}
