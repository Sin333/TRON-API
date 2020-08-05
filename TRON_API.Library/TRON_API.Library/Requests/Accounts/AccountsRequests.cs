using System;
using System.Text.Json;
using System.Threading.Tasks;
using TRON_API.Library.Helpers;
using TRON_API.Library.Requests.Accounts.Models;
using TRON_API.Library.Requests.BaseModels;

namespace TRON_API.Library.Requests.Accounts
{
    /// <summary>
    ///     To manipulate account on-chain.
    /// </summary>
    public class AccountsRequests
    {
        private readonly TronApiConfiguration _tronApiConfiguration;

        public AccountsRequests(TronApiConfiguration tronApiConfiguration)
        {
            _tronApiConfiguration = tronApiConfiguration;
        }

        /// <summary>
        ///     Create an account. Uses an already activated account to create a new account
        /// </summary>
        /// <returns></returns>
        [Obsolete("Not tested function!")]
        public async Task<object> CreateAccount(CreateAccountRequestModel model)
        {
            var body = JsonSerializer.Serialize(model);
            return await HttpHelper.PostAsync<object>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/createaccount",
                body
            );
        }

        /// <summary>
        ///     Create an account. Uses an already activated account to create a new account
        /// </summary>
        /// <returns></returns>
        public async Task<GetAccountResponseModel> GetAccount(string address)
        {
            var body = JsonSerializer.Serialize(new AddressModel(address));
            return await HttpHelper.PostAsync<GetAccountResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/getaccount",
                body
            );
        }

        /// <summary>
        ///     Modify account name
        /// </summary>
        /// <returns></returns>
        [Obsolete("Not tested function!")]
        public async Task<UpdateAccountResponseModel> UpdateAccount(UpdateAccountRequestModel model)
        {
            var body = JsonSerializer.Serialize(model);
            return await HttpHelper.PostAsync<UpdateAccountResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/updateaccount",
                body
            );
        }

        /// <summary>
        ///     Update the account's permission.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Obsolete("Not finishing function!")]
        public async Task<object> AccountPermissionUpdate(object model)
        {
            var body = JsonSerializer.Serialize(model);
            return await HttpHelper.PostAsync<object>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/accountpermissionupdate",
                body
            );
        }
    }
}