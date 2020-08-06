using System;
using System.Threading.Tasks;
using TRON_API.Library;
using TRON_API.Library.Requests.Accounts;

namespace TRON_API.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var tronConfig = new TronApiConfiguration("https://api.shasta.trongrid.io/", "https://api.shasta.trongrid.io/");
            var accountsRequests = new AccountsRequests(tronConfig);
            var getAccountInfo = await accountsRequests.GetAccount("TLFXzKWczwZJbrVz3QEsrnH2F4zb4BeFqh");
            Console.WriteLine("Hello World!");
        }
    }
}