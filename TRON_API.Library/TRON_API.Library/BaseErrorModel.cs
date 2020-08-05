using System.Text.Json.Serialization;

namespace TRON_API.Library
{
    public class BaseErrorModel
    {
        [JsonPropertyName("Error")]
        public string Error { get; set; }
        
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("txid")]
        public string TxId { get; set; }
    }
}