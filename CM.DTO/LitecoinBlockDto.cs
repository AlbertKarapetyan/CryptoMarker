﻿using System.Text.Json.Serialization;

namespace CM.DTO
{
    public class LitecoinBlockDto : BaseCoinBlockDto
    {
        [JsonPropertyName("high_fee_per_kb")]
        public int HighFeePerKb { get; set; }

        [JsonPropertyName("medium_fee_per_kb")]
        public int MediumFeePerKb { get; set; }

        [JsonPropertyName("low_fee_per_kb")]
        public int LowFeePerKb { get; set; }
    }
}
