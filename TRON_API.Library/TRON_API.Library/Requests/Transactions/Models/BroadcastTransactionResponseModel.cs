using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.Transactions.Models
{
    public class BroadcastTransactionResponseModel
    {
        [JsonPropertyName("result")]
        public bool Result { get; set; }
        
        [JsonPropertyName("txid")]
        public string TxId { get; set; }
    }
}