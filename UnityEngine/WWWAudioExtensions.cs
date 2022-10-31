using System;

namespace UnityEngine
{
	// Token: 0x020001C0 RID: 448
	public static class WWWAudioExtensions
	{
		// Token: 0x06001FF5 RID: 8181 RVA: 0x00026488 File Offset: 0x00024688
		public static AudioClip GetAudioClip(this WWW www)
		{
			return www.GetAudioClip(true, false, AudioType.UNKNOWN);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x000264A8 File Offset: 0x000246A8
		public static AudioClip GetAudioClip(this WWW www, bool threeD)
		{
			return www.GetAudioClip(threeD, false, AudioType.UNKNOWN);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000264C8 File Offset: 0x000246C8
		public static AudioClip GetAudioClip(this WWW www, bool threeD, bool stream)
		{
			return www.GetAudioClip(threeD, stream, AudioType.UNKNOWN);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000264E8 File Offset: 0x000246E8
		public static AudioClip GetAudioClip(this WWW www, bool threeD, bool stream, AudioType audioType)
		{
			return (AudioClip)www.GetAudioClipInternal(threeD, stream, false, audioType);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0002650C File Offset: 0x0002470C
		public static AudioClip GetAudioClipCompressed(this WWW www)
		{
			return www.GetAudioClipCompressed(false, AudioType.UNKNOWN);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0002652C File Offset: 0x0002472C
		public static AudioClip GetAudioClipCompressed(this WWW www, bool threeD)
		{
			return www.GetAudioClipCompressed(threeD, AudioType.UNKNOWN);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x0002654C File Offset: 0x0002474C
		public static AudioClip GetAudioClipCompressed(this WWW www, bool threeD, AudioType audioType)
		{
			return (AudioClip)www.GetAudioClipInternal(threeD, false, true, audioType);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00026570 File Offset: 0x00024770
		public static MovieTexture GetMovieTexture(this WWW www)
		{
			return (MovieTexture)www.GetMovieTextureInternal();
		}
	}
}
