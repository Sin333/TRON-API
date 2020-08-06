using System;
using System.Text.Json.Serialization;
using TRON_API.Library.Requests.BaseModels;

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
            Visible = transactionInfo.Visible ?? false;
            TxId = transactionInfo.TxId ?? throw new ArgumentException("TxId is null");
            PrivateKey = privateKey;
            Transaction = new GetTransactionSignResponseModel<T>(transactionInfo)
            {
                // Visible = null, 
                // TxId = null
            };
        }
        
        [JsonPropertyName("txID")] 
        public string TxId { get; set; }
        
        [JsonPropertyName("visible")]
        public bool Visible { get; set; }

        [JsonPropertyName("transaction")]
        public GetTransactionSignResponseModel<T> Transaction { get; set; }
        
        [JsonPropertyName("privateKey")]
        public string PrivateKey { get; set; }
    }
}