using System;
using System.Text.Json;
using System.Threading.Tasks;
using TRON_API.Library.Helpers;
using TRON_API.Library.Requests.BaseModels;
using TRON_API.Library.Requests.BaseModels.TransactionContracts;
using TRON_API.Library.Requests.Transactions.Models;

namespace TRON_API.Library.Requests.Transactions
{
    /// <summary>
    ///     Transaction related APIs. To sign or to broadcast. Or simply a TRX transfer.
    /// </summary>
    public class TransactionsRequests
    {
        private readonly TronApiConfiguration _tronApiConfiguration;

        public TransactionsRequests(TronApiConfiguration tronApiConfiguration)
        {
            _tronApiConfiguration = tronApiConfiguration;
        }
        
        /// <summary>
        ///     Create a TRX transfer transaction. If to_address does not exist, then create the account on the blockchain.
        /// </summary>
        /// <returns></returns>
        public async Task<TransactionModel<T>> CreateTransaction<T>(CreateTransactionRequestModel model) where T : BaseTransactionContract
        {
            var body = JsonSerializer.Serialize(model);
            return await HttpHelper.PostAsync<TransactionModel<T>>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/createtransaction",
                body
            );
        }

        /// <summary>
        ///     Sign the transaction, the api has the risk of leaking the private key, please make sure to call the api in a secure
        ///     environment
        /// </summary>
        /// <returns></returns>
        public async Task<GetTransactionSignResponseModel<T>> GetTransactionSign<T>(GetTransactionSignRequestModel<T> model) where T : BaseTransactionContract
        {
            var body = JsonSerializer.Serialize(model);
            return await HttpHelper.PostAsync<GetTransactionSignResponseModel<T>>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/gettransactionsign",
                body
            );
        }

        /// <summary>
        ///     Broadcast the signed transaction
        /// </summary>
        /// <returns></returns>
        public async Task<BroadcastTransactionResponseModel> BroadcastTransaction<T>(GetTransactionSignResponseModel<T> model) where T : BaseTransactionContract
        {
            var body = JsonSerializer.Serialize(model);
            return await HttpHelper.PostAsync<BroadcastTransactionResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/broadcasttransaction",
                body
            );
        }

        /// <summary>
        ///     Broadcast the protobuf encoded transaction hex string after sign
        /// </summary>
        /// <returns></returns>
        [Obsolete("Not tested function!")]
        public async Task<BroadcastTransactionResponseModel> BroadcastHex(string transaction)
        {
            var body = JsonSerializer.Serialize(new {transaction});
            return await HttpHelper.PostAsync<BroadcastTransactionResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/broadcasthex",
                body
            );
        }

        /// <summary>
        ///     Easily transfer from an address using the private key.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Not tested function!")]
        public async Task<object> EasyTransfer(EasyTransferRequestModel model)
        {
            var body = JsonSerializer.Serialize(model);
            return await HttpHelper.PostAsync<object>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/easytransfer",
                body
            );
        }
        
        /// <summary>
        ///     Easily transfer from an address using the password string. Only works with accounts created from
        ///     createAddress,integrated getransactionsign and broadcasttransaction.
        /// </summary>
        /// <returns></returns>
        [Obsolete("Not tested function!")]
        public async Task<object> EasyTransferByPrivate(EasyTransferRequestModel model)
        {
            var body = JsonSerializer.Serialize(model);
            return await HttpHelper.PostAsync<object>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/easytransferbyprivate",
                body
            );
        }
    }
}