using System;
using System.Threading.Tasks;
using TRON_API.Library;
using TRON_API.Library.Requests.Accounts;
using TRON_API.Library.Requests.BaseModels;
using TRON_API.Library.Requests.BaseModels.TransactionContracts;
using TRON_API.Library.Requests.Transactions;
using TRON_API.Library.Requests.Transactions.Models;

namespace TRON_API.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var tronConfig = new TronApiConfiguration("https://api.shasta.trongrid.io/", "https://api.shasta.trongrid.io/");

            const string ownerAddress = "TLFXzKWczwZJbrVz3QEsrnH2F4zb4BeFqh";
            var accountsRequests = new AccountsRequests(tronConfig);
            var getAccountInfo = await accountsRequests.GetAccount(ownerAddress);
            
            var transactionRequests = new TransactionsRequests(tronConfig);

            const string toAddress = "TL6tL2sTsMRErMx5aCQ7sG2bsrck93w8q8";
            var amount = new decimal(0.5); //0.5TRX
            var createTransactionRequestModel = new CreateTransactionRequestModel(
                ConverterHelpers.Base58ToHex(toAddress),
                ConverterHelpers.Base58ToHex(ownerAddress), 
                amount);
            var createTransaction = await transactionRequests.CreateTransaction<CreateTransactionContract>(createTransactionRequestModel);
            
            const string privateKeyOwnerAddress = "225DDC32C0CFEA1F12E8B3B1773429C1A85DFC239BF7845C51CA927751EFE6C1";
            var getTransactionSignRequestModel = new GetTransactionSignRequestModel<CreateTransactionContract>(
                privateKeyOwnerAddress,
                createTransaction
                );
            var transactionSign = await transactionRequests.GetTransactionSign(getTransactionSignRequestModel);
            
            var broadcastTransaction = await transactionRequests.BroadcastTransaction(transactionSign);
            Console.WriteLine(broadcastTransaction.Result 
                ? "Transaction Successful!" 
                : "Some error operation");
            
            Console.ReadKey();
        }
    }
}