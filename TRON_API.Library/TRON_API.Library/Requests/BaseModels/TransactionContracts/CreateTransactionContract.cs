using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.BaseModels.TransactionContracts
{
    public class CreateTransactionContract : BaseTransactionContract
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        
        [JsonPropertyName("owner_address")]
        public string OwnerAddress { get; set; }
        
        [JsonPropertyName("to_address")]
        public string ToAddress { get; set; }
    }
}