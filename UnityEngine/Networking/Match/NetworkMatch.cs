using System;
using System.Collections;
using System.Collections.Generic;
using SimpleJson;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
	// Token: 0x020002A9 RID: 681
	public class NetworkMatch : MonoBehaviour
	{
		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x0003F560 File Offset: 0x0003D760
		// (set) Token: 0x06002C72 RID: 11378 RVA: 0x0003F57C File Offset: 0x0003D77C
		public Uri baseUri
		{
			get
			{
				return this.m_BaseUri;
			}
			set
			{
				this.m_BaseUri = value;
			}
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x0003F588 File Offset: 0x0003D788
		[Obsolete("This function is not used any longer to interface with the matchmaker. Please set up your project by logging in through the editor connect dialog.", true)]
		public void SetProgramAppID(AppID programAppID)
		{
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x0003F58C File Offset: 0x0003D78C
		public Coroutine CreateMatch(string matchName, uint matchSize, bool matchAdvertise, string matchPassword, string publicClientAddress, string privateClientAddress, int eloScoreForMatch, int requestDomain, NetworkMatch.DataResponseDelegate<MatchInfo> callback)
		{
			Coroutine result;
			if (Application.platform == RuntimePlatform.WebGLPlayer)
			{
				Debug.LogError("Matchmaking is not supported on WebGL player.");
				result = null;
			}
			else
			{
				result = this.CreateMatch(new CreateMatchRequest
				{
					name = matchName,
					size = matchSize,
					advertise = matchAdvertise,
					password = matchPassword,
					publicAddress = publicClientAddress,
					privateAddress = privateClientAddress,
					eloScore = eloScoreForMatch,
					domain = requestDomain
				}, callback);
			}
			return result;
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x0003F60C File Offset: 0x0003D80C
		internal Coroutine CreateMatch(CreateMatchRequest req, NetworkMatch.DataResponseDelegate<MatchInfo> callback)
		{
			Coroutine result;
			if (callback == null)
			{
				Debug.Log("callback supplied is null, aborting CreateMatch Request.");
				result = null;
			}
			else
			{
				Uri uri = new Uri(this.baseUri, "/json/reply/CreateMatchRequest");
				Debug.Log("MatchMakingClient Create :" + uri);
				WWWForm wwwform = new WWWForm();
				wwwform.AddField("version", Request.currentVersion);
				wwwform.AddField("projectId", Application.cloudProjectId);
				wwwform.AddField("sourceId", Utility.GetSourceID().ToString());
				wwwform.AddField("accessTokenString", 0);
				wwwform.AddField("domain", req.domain);
				wwwform.AddField("name", req.name);
				wwwform.AddField("size", req.size.ToString());
				wwwform.AddField("advertise", req.advertise.ToString());
				wwwform.AddField("password", req.password);
				wwwform.AddField("publicAddress", req.publicAddress);
				wwwform.AddField("privateAddress", req.privateAddress);
				wwwform.AddField("eloScore", req.eloScore.ToString());
				wwwform.headers["Accept"] = "application/json";
				WWW client = new WWW(uri.ToString(), wwwform);
				result = base.StartCoroutine(this.ProcessMatchResponse<CreateMatchResponse, NetworkMatch.DataResponseDelegate<MatchInfo>>(client, new NetworkMatch.InternalResponseDelegate<CreateMatchResponse, NetworkMatch.DataResponseDelegate<MatchInfo>>(this.OnMatchCreate), callback));
			}
			return result;
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x0003F7A0 File Offset: 0x0003D9A0
		internal virtual void OnMatchCreate(CreateMatchResponse response, NetworkMatch.DataResponseDelegate<MatchInfo> userCallback)
		{
			if (response.success)
			{
				Utility.SetAccessTokenForNetwork(response.networkId, new NetworkAccessToken(response.accessTokenString));
			}
			userCallback(response.success, response.extendedInfo, new MatchInfo(response));
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x0003F7DC File Offset: 0x0003D9DC
		public Coroutine JoinMatch(NetworkID netId, string matchPassword, string publicClientAddress, string privateClientAddress, int eloScoreForClient, int requestDomain, NetworkMatch.DataResponseDelegate<MatchInfo> callback)
		{
			return this.JoinMatch(new JoinMatchRequest
			{
				networkId = netId,
				password = matchPassword,
				publicAddress = publicClientAddress,
				privateAddress = privateClientAddress,
				eloScore = eloScoreForClient,
				domain = requestDomain
			}, callback);
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x0003F830 File Offset: 0x0003DA30
		internal Coroutine JoinMatch(JoinMatchRequest req, NetworkMatch.DataResponseDelegate<MatchInfo> callback)
		{
			Coroutine result;
			if (callback == null)
			{
				Debug.Log("callback supplied is null, aborting JoinMatch Request.");
				result = null;
			}
			else
			{
				Uri uri = new Uri(this.baseUri, "/json/reply/JoinMatchRequest");
				Debug.Log("MatchMakingClient Join :" + uri);
				WWWForm wwwform = new WWWForm();
				wwwform.AddField("version", Request.currentVersion);
				wwwform.AddField("projectId", Application.cloudProjectId);
				wwwform.AddField("sourceId", Utility.GetSourceID().ToString());
				wwwform.AddField("accessTokenString", 0);
				wwwform.AddField("domain", req.domain);
				wwwform.AddField("networkId", req.networkId.ToString());
				wwwform.AddField("password", req.password);
				wwwform.AddField("publicAddress", req.publicAddress);
				wwwform.AddField("privateAddress", req.privateAddress);
				wwwform.AddField("eloScore", req.eloScore.ToString());
				wwwform.headers["Accept"] = "application/json";
				WWW client = new WWW(uri.ToString(), wwwform);
				result = base.StartCoroutine(this.ProcessMatchResponse<JoinMatchResponse, NetworkMatch.DataResponseDelegate<MatchInfo>>(client, new NetworkMatch.InternalResponseDelegate<JoinMatchResponse, NetworkMatch.DataResponseDelegate<MatchInfo>>(this.OnMatchJoined), callback));
			}
			return result;
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x0003F990 File Offset: 0x0003DB90
		internal void OnMatchJoined(JoinMatchResponse response, NetworkMatch.DataResponseDelegate<MatchInfo> userCallback)
		{
			if (response.success)
			{
				Utility.SetAccessTokenForNetwork(response.networkId, new NetworkAccessToken(response.accessTokenString));
			}
			userCallback(response.success, response.extendedInfo, new MatchInfo(response));
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x0003F9CC File Offset: 0x0003DBCC
		public Coroutine DestroyMatch(NetworkID netId, int requestDomain, NetworkMatch.BasicResponseDelegate callback)
		{
			return this.DestroyMatch(new DestroyMatchRequest
			{
				networkId = netId,
				domain = requestDomain
			}, callback);
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x0003FA00 File Offset: 0x0003DC00
		internal Coroutine DestroyMatch(DestroyMatchRequest req, NetworkMatch.BasicResponseDelegate callback)
		{
			Coroutine result;
			if (callback == null)
			{
				Debug.Log("callback supplied is null, aborting DestroyMatch Request.");
				result = null;
			}
			else
			{
				Uri uri = new Uri(this.baseUri, "/json/reply/DestroyMatchRequest");
				Debug.Log("MatchMakingClient Destroy :" + uri.ToString());
				WWWForm wwwform = new WWWForm();
				wwwform.AddField("version", Request.currentVersion);
				wwwform.AddField("projectId", Application.cloudProjectId);
				wwwform.AddField("sourceId", Utility.GetSourceID().ToString());
				wwwform.AddField("accessTokenString", Utility.GetAccessTokenForNetwork(req.networkId).GetByteString());
				wwwform.AddField("domain", req.domain);
				wwwform.AddField("networkId", req.networkId.ToString());
				wwwform.headers["Accept"] = "application/json";
				WWW client = new WWW(uri.ToString(), wwwform);
				result = base.StartCoroutine(this.ProcessMatchResponse<BasicResponse, NetworkMatch.BasicResponseDelegate>(client, new NetworkMatch.InternalResponseDelegate<BasicResponse, NetworkMatch.BasicResponseDelegate>(this.OnMatchDestroyed), callback));
			}
			return result;
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x0003FB24 File Offset: 0x0003DD24
		internal void OnMatchDestroyed(BasicResponse response, NetworkMatch.BasicResponseDelegate userCallback)
		{
			userCallback(response.success, response.extendedInfo);
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x0003FB3C File Offset: 0x0003DD3C
		public Coroutine DropConnection(NetworkID netId, NodeID dropNodeId, int requestDomain, NetworkMatch.BasicResponseDelegate callback)
		{
			return this.DropConnection(new DropConnectionRequest
			{
				networkId = netId,
				nodeId = dropNodeId,
				domain = requestDomain
			}, callback);
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x0003FB78 File Offset: 0x0003DD78
		internal Coroutine DropConnection(DropConnectionRequest req, NetworkMatch.BasicResponseDelegate callback)
		{
			Coroutine result;
			if (callback == null)
			{
				Debug.Log("callback supplied is null, aborting DropConnection Request.");
				result = null;
			}
			else
			{
				Uri uri = new Uri(this.baseUri, "/json/reply/DropConnectionRequest");
				Debug.Log("MatchMakingClient DropConnection :" + uri);
				WWWForm wwwform = new WWWForm();
				wwwform.AddField("version", Request.currentVersion);
				wwwform.AddField("projectId", Application.cloudProjectId);
				wwwform.AddField("sourceId", Utility.GetSourceID().ToString());
				wwwform.AddField("accessTokenString", Utility.GetAccessTokenForNetwork(req.networkId).GetByteString());
				wwwform.AddField("domain", req.domain);
				wwwform.AddField("networkId", req.networkId.ToString());
				wwwform.AddField("nodeId", req.nodeId.ToString());
				wwwform.headers["Accept"] = "application/json";
				WWW client = new WWW(uri.ToString(), wwwform);
				result = base.StartCoroutine(this.ProcessMatchResponse<DropConnectionResponse, NetworkMatch.BasicResponseDelegate>(client, new NetworkMatch.InternalResponseDelegate<DropConnectionResponse, NetworkMatch.BasicResponseDelegate>(this.OnDropConnection), callback));
			}
			return result;
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x0003FCB4 File Offset: 0x0003DEB4
		internal void OnDropConnection(DropConnectionResponse response, NetworkMatch.BasicResponseDelegate userCallback)
		{
			userCallback(response.success, response.extendedInfo);
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x0003FCCC File Offset: 0x0003DECC
		public Coroutine ListMatches(int startPageNumber, int resultPageSize, string matchNameFilter, bool filterOutPrivateMatchesFromResults, int eloScoreTarget, int requestDomain, NetworkMatch.DataResponseDelegate<List<MatchInfoSnapshot>> callback)
		{
			Coroutine result;
			if (Application.platform == RuntimePlatform.WebGLPlayer)
			{
				Debug.LogError("Matchmaking is not supported on WebGL player.");
				result = null;
			}
			else
			{
				result = this.ListMatches(new ListMatchRequest
				{
					pageNum = startPageNumber,
					pageSize = resultPageSize,
					nameFilter = matchNameFilter,
					filterOutPrivateMatches = filterOutPrivateMatchesFromResults,
					eloScore = eloScoreTarget,
					domain = requestDomain
				}, callback);
			}
			return result;
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x0003FD3C File Offset: 0x0003DF3C
		internal Coroutine ListMatches(ListMatchRequest req, NetworkMatch.DataResponseDelegate<List<MatchInfoSnapshot>> callback)
		{
			Coroutine result;
			if (callback == null)
			{
				Debug.Log("callback supplied is null, aborting ListMatch Request.");
				result = null;
			}
			else
			{
				Uri uri = new Uri(this.baseUri, "/json/reply/ListMatchRequest");
				Debug.Log("MatchMakingClient ListMatches :" + uri);
				WWWForm wwwform = new WWWForm();
				wwwform.AddField("version", Request.currentVersion);
				wwwform.AddField("projectId", Application.cloudProjectId);
				wwwform.AddField("sourceId", Utility.GetSourceID().ToString());
				wwwform.AddField("accessTokenString", 0);
				wwwform.AddField("domain", req.domain);
				wwwform.AddField("pageSize", req.pageSize);
				wwwform.AddField("pageNum", req.pageNum);
				wwwform.AddField("nameFilter", req.nameFilter);
				wwwform.AddField("filterOutPrivateMatches", req.filterOutPrivateMatches.ToString());
				wwwform.AddField("eloScore", req.eloScore.ToString());
				wwwform.headers["Accept"] = "application/json";
				WWW client = new WWW(uri.ToString(), wwwform);
				result = base.StartCoroutine(this.ProcessMatchResponse<ListMatchResponse, NetworkMatch.DataResponseDelegate<List<MatchInfoSnapshot>>>(client, new NetworkMatch.InternalResponseDelegate<ListMatchResponse, NetworkMatch.DataResponseDelegate<List<MatchInfoSnapshot>>>(this.OnMatchList), callback));
			}
			return result;
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x0003FE9C File Offset: 0x0003E09C
		internal void OnMatchList(ListMatchResponse response, NetworkMatch.DataResponseDelegate<List<MatchInfoSnapshot>> userCallback)
		{
			List<MatchInfoSnapshot> list = new List<MatchInfoSnapshot>();
			foreach (MatchDesc matchDesc in response.matches)
			{
				list.Add(new MatchInfoSnapshot(matchDesc));
			}
			userCallback(response.success, response.extendedInfo, list);
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0003FF1C File Offset: 0x0003E11C
		public Coroutine SetMatchAttributes(NetworkID networkId, bool isListed, int requestDomain, NetworkMatch.BasicResponseDelegate callback)
		{
			return this.SetMatchAttributes(new SetMatchAttributesRequest
			{
				networkId = networkId,
				isListed = isListed,
				domain = requestDomain
			}, callback);
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x0003FF58 File Offset: 0x0003E158
		internal Coroutine SetMatchAttributes(SetMatchAttributesRequest req, NetworkMatch.BasicResponseDelegate callback)
		{
			Coroutine result;
			if (callback == null)
			{
				Debug.Log("callback supplied is null, aborting SetMatchAttributes Request.");
				result = null;
			}
			else
			{
				Uri uri = new Uri(this.baseUri, "/json/reply/SetMatchAttributesRequest");
				Debug.Log("MatchMakingClient SetMatchAttributes :" + uri);
				WWWForm wwwform = new WWWForm();
				wwwform.AddField("version", Request.currentVersion);
				wwwform.AddField("projectId", Application.cloudProjectId);
				wwwform.AddField("sourceId", Utility.GetSourceID().ToString());
				wwwform.AddField("accessTokenString", Utility.GetAccessTokenForNetwork(req.networkId).GetByteString());
				wwwform.AddField("domain", req.domain);
				wwwform.AddField("networkId", req.networkId.ToString());
				wwwform.AddField("isListed", req.isListed.ToString());
				wwwform.headers["Accept"] = "application/json";
				WWW client = new WWW(uri.ToString(), wwwform);
				result = base.StartCoroutine(this.ProcessMatchResponse<BasicResponse, NetworkMatch.BasicResponseDelegate>(client, new NetworkMatch.InternalResponseDelegate<BasicResponse, NetworkMatch.BasicResponseDelegate>(this.OnSetMatchAttributes), callback));
			}
			return result;
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x00040094 File Offset: 0x0003E294
		internal void OnSetMatchAttributes(BasicResponse response, NetworkMatch.BasicResponseDelegate userCallback)
		{
			userCallback(response.success, response.extendedInfo);
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000400AC File Offset: 0x0003E2AC
		private IEnumerator ProcessMatchResponse<JSONRESPONSE, USERRESPONSEDELEGATETYPE>(WWW client, NetworkMatch.InternalResponseDelegate<JSONRESPONSE, USERRESPONSEDELEGATETYPE> internalCallback, USERRESPONSEDELEGATETYPE userCallback) where JSONRESPONSE : Response, new()
		{
			yield return client;
			JSONRESPONSE jsonInterface = Activator.CreateInstance<JSONRESPONSE>();
			if (string.IsNullOrEmpty(client.error))
			{
				object obj;
				if (SimpleJson.TryDeserializeObject(client.text, out obj))
				{
					IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
					if (dictionary != null)
					{
						try
						{
							jsonInterface.Parse(obj);
						}
						catch (FormatException ex)
						{
							jsonInterface.SetFailure(UnityString.Format("FormatException:[{0}] ", new object[]
							{
								ex.ToString()
							}));
						}
					}
				}
			}
			else
			{
				jsonInterface.SetFailure(UnityString.Format("Request error:[{0}] Raw response:[{1}]", new object[]
				{
					client.error,
					client.text
				}));
			}
			client.Dispose();
			internalCallback(jsonInterface, userCallback);
			yield break;
		}

		// Token: 0x040008CE RID: 2254
		private Uri m_BaseUri = new Uri("https://mm.unet.unity3d.com");

		// Token: 0x020002AA RID: 682
		// (Invoke) Token: 0x06002C88 RID: 11400
		public delegate void BasicResponseDelegate(bool success, string extendedInfo);

		// Token: 0x020002AB RID: 683
		// (Invoke) Token: 0x06002C8C RID: 11404
		public delegate void DataResponseDelegate<T>(bool success, string extendedInfo, T responseData);

		// Token: 0x020002AC RID: 684
		// (Invoke) Token: 0x06002C90 RID: 11408
		private delegate void InternalResponseDelegate<T, U>(T response, U userCallback);
	}
}
