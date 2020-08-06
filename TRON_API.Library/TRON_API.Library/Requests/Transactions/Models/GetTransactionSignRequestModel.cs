using System.Text.Json.Serialization;
using TRON_API.Library.Requests.BaseModels;
using TRON_API.Library.Requests.BaseModels.TransactionContracts;

namespace TRON_API.Library.Requests.Transactions.Models
{
    public class GetTransactionSignRequestModel<T> where T: BaseTransactionContract
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="privateKey">PrivateKey from ownerAddress</param>
        public GetTransactionSignRequestModel(string privateKey, TransactionModel<T> transactionInfo)
        {
            PrivateKey = privateKey;
            Transaction = new GetTransactionSignTransactionModel<T>(transactionInfo);
        }
        
        [JsonPropertyName("transaction")]
        public GetTransactionSignTransactionModel<T> Transaction { get; set; }
        
        [JsonPropertyName("privateKey")]
        public string PrivateKey { get; set; }
    }
}