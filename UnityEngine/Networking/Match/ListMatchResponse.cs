using System;
using System.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200029B RID: 667
	internal class ListMatchResponse : BasicResponse
	{
		// Token: 0x06002C24 RID: 11300 RVA: 0x0003EBF8 File Offset: 0x0003CDF8
		public ListMatchResponse()
		{
			this.matches = new List<MatchDesc>();
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x0003EC0C File Offset: 0x0003CE0C
		public ListMatchResponse(List<MatchDesc> otherMatches)
		{
			this.matches = otherMatches;
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x0003EC1C File Offset: 0x0003CE1C
		// (set) Token: 0x06002C27 RID: 11303 RVA: 0x0003EC38 File Offset: 0x0003CE38
		public List<MatchDesc> matches { get; set; }

		// Token: 0x06002C28 RID: 11304 RVA: 0x0003EC44 File Offset: 0x0003CE44
		public override string ToString()
		{
			return UnityString.Format("[{0}]-matches.Count:{1}", new object[]
			{
				base.ToString(),
				(this.matches != null) ? this.matches.Count : 0
			});
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x0003EC98 File Offset: 0x0003CE98
		public override void Parse(object obj)
		{
			base.Parse(obj);
			IDictionary<string, object> dictionary = obj as IDictionary<string, object>;
			if (dictionary != null)
			{
				this.matches = base.ParseJSONList<MatchDesc>("matches", obj, dictionary);
				return;
			}
			throw new FormatException("While parsing JSON response, found obj is not of type IDictionary<string,object>:" + obj.ToString());
		}
	}
}
