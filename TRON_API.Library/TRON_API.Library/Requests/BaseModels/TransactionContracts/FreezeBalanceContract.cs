using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.BaseModels.TransactionContracts
{
    public class FreezeBalanceContract : BaseTransactionContract
    {
        [JsonPropertyName("frozen_duration")]
        public int FrozenDuration { get; set; } 

        [JsonPropertyName("frozen_balance")]
        public int FrozenBalance { get; set; } 

        [JsonPropertyName("owner_address")]
        public string OwnerAddress { get; set; } 
    }
}