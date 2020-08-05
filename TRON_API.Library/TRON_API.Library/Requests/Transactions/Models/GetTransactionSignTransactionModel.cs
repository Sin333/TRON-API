using System.Text.Json.Serialization;
using TRON_API.Library.Requests.BaseModels;

namespace TRON_API.Library.Requests.Transactions.Models
{
    public class GetTransactionSignTransactionModel<T> : TransactionModel<T> where T: BaseTransactionContract
    {
        [JsonPropertyName("signature")] 
        public string[]? Signature { get; set; }
    }
}