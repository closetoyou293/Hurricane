﻿using Newtonsoft.Json;

namespace Hurricane.Music.Track.WebApi.YouTubeApi.DataClasses
{
    public class YtPlaylistId
    {
        [JsonProperty("$t")]
        public string Text { get; set; }
    }
}