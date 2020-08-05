using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.BaseModels.TransactionContracts
{
    public class UpdateAccountContract : BaseTransactionContract
    {
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; } 

        [JsonPropertyName("owner_address")]
        public string OwnerAddress { get; set; } 
    }
}