using System;
using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.QueryTheNetwork.Models.BaseModels
{
    public class BaseBlockHeader<T> where T: BaseBlockHeaderRawData
    {
        [JsonPropertyName("raw_data")] 
        public T RawData { get; set; }

        [JsonPropertyName("witness_signature")]
        public string WitnessSignature { get; set; }
    }

    public class BaseBlockHeaderRawData
    {
        [JsonPropertyName("number")]
        public int Number { get; set; } 

        [JsonPropertyName("txTrieRoot")]
        public string TxTrieRoot { get; set; } 

        [JsonPropertyName("witness_address")]
        public string WitnessAddress { get; set; } 

        [JsonPropertyName("parentHash")]
        public string ParentHash { get; set; }

        [JsonPropertyName("timestamp")]
        public long TimestampTicks { get; set; } 
        
        public TimeSpan GetTimestamp() => new TimeSpan(TimestampTicks);
    }
}