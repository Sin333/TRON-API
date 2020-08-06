using System;
using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.BaseModels
{
    public class TransactionModel<T> where T: BaseTransactionContract
    {
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }

        [JsonPropertyName("txID")] 
        public string? TxId { get; set; }

        [JsonPropertyName("raw_data")] 
        public TransactionRawData<T> RawData { get; set; }

        [JsonPropertyName("raw_data_hex")] 
        public string? RawDataHex { get; set; }
    }
    
    public class TransactionRawData<T> where T: BaseTransactionContract
    {
        [JsonPropertyName("contract")]
        public TransactionContract<T>[] Contracts { get; set; } 
        
        [JsonPropertyName("ref_block_bytes")] 
        public string RefBlockBytes { get; set; }

        [JsonPropertyName("ref_block_hash")] 
        public string RefBlockHash { get; set; }

        [JsonPropertyName("expiration")] 
        public long ExpirationTicks { get; set; }
        
        public TimeSpan GetExpiration() => new TimeSpan(ExpirationTicks);

        [JsonPropertyName("timestamp")] 
        public long TimestampTicks { get; set; }
        
        public TimeSpan GetTimestamp() => new TimeSpan(TimestampTicks);
    }

    public class TransactionContract<T> where T: BaseTransactionContract
    {
        [JsonPropertyName("parameter")]
        public TransactionParameter<T> Parameter { get; set; } 

        [JsonPropertyName("type")]
        public string Type { get; set; } 
    }
    
    public class TransactionParameter<T> where T: BaseTransactionContract
    {
        [JsonPropertyName("value")]
        public T Value { get; set; }
        
        [JsonPropertyName("type_url")]
        public string TypeUrl { get; set; } 
    }
}