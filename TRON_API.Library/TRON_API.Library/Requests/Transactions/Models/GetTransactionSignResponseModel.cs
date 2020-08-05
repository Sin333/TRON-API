using System.Text.Json.Serialization;
using TRON_API.Library.Requests.BaseModels;

namespace TRON_API.Library.Requests.Transactions.Models
{
    public class GetTransactionSignResponseModel<T> where T: BaseTransactionContract
    {
        [JsonPropertyName("transaction")]
        public GetTransactionSignTransactionModel<T> Transaction { get; set; }
    }
}