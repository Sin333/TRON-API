using System.Text.Json.Serialization;
using TRON_API.Library.Requests.BaseModels;
using TRON_API.Library.Requests.BaseModels.TransactionContracts;

namespace TRON_API.Library.Requests.Transactions.Models
{
    public class GetTransactionSignTransactionModel<T> : TransactionModel<T> where T: BaseTransactionContract
    {
        public GetTransactionSignTransactionModel()
        {
            
        }

        public GetTransactionSignTransactionModel(TransactionModel<T> transactionModel, string[]? signature = null)
        {
            Visible = transactionModel.Visible;
            TxId = transactionModel.TxId;
            RawData = transactionModel.RawData;
            RawDataHex = transactionModel.RawDataHex;
            Signature = signature;
        }
        
        [JsonPropertyName("signature")] 
        public string[]? Signature { get; set; }
    }
}