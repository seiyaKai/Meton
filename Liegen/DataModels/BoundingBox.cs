﻿using Newtonsoft.Json;

namespace Meton.Liegen.DataModels
{
    public class BoundingBox
    {
        [JsonProperty("coordinates")]
        public double[][][] Coordinates { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
