using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.BaseModels.TransactionContracts
{
    public class GetTransactionSignContract : BaseTransactionContract
    {
        [JsonPropertyName("amount")]
        public long Amount { get; set; }
        
        [JsonPropertyName("owner_address")]
        public long OwnerAddress { get; set; }
        
        [JsonPropertyName("to_address")]
        public long ToAddress { get; set; }
    }
}