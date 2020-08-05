using System;
using System.Text.Json;
using System.Threading.Tasks;
using TRON_API.Library.Helpers;
using TRON_API.Library.Requests.AccountResources.Models;
using TRON_API.Library.Requests.BaseModels;

namespace TRON_API.Library.Requests.AccountResources
{
    /// <summary>
    ///     To manipulate account resources. Bandwidth or energy.
    /// </summary>
    public class AccountResourcesRequests
    {
        private readonly TronApiConfiguration _tronApiConfiguration;

        public AccountResourcesRequests(TronApiConfiguration tronApiConfiguration)
        {
            _tronApiConfiguration = tronApiConfiguration;
        }

        /// <summary>
        ///     Query the resource information of an account(bandwidth,energy,etc)
        /// </summary>
        /// <param name="address">Base58</param>
        /// <returns></returns>
        public async Task<GetAccountResourceResponseModel> GetAccountResource(string address)
        {
            var body = JsonSerializer.Serialize(new AddressModel(address));
            return await HttpHelper.PostAsync<GetAccountResourceResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/getaccountresource",
                body
            );
        }

        /// <summary>
        ///     Query bandwidth information.
        /// </summary>
        /// <param name="address">Base58</param>
        /// <returns></returns>
        public async Task<GetAccountNetResponseModel> GetAccountNet(string address)
        {
            var hexAddress = ConverterHelpers.Base58ToHex(address);
            var body = JsonSerializer.Serialize(new AddressModel(hexAddress));
            return await HttpHelper.PostAsync<GetAccountNetResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/getaccountnet",
                body
            );
        }

        /// <summary>
        ///     Freezes an amount of TRX. Will give bandwidth OR Energy and TRON Power (voting rights) to the owner of the frozen
        ///     tokens. Optionally, can freeze TRX to grant Energy or Bandwidth to other users. Balance amount in the denomination
        ///     of Sun.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<FreezeBalanceResponseModel> FreezeBalance(FreezeBalanceRequestModel model)
        {
            var body = JsonSerializer.Serialize(model);
            return await HttpHelper.PostAsync<FreezeBalanceResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/freezebalance",
                body
            );
        }

        /// <summary>
        ///     Unfreeze TRX that has passed the minimum freeze duration. Unfreezing will remove bandwidth and TRON Power. Returns
        ///     unfrozen TRX transaction.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Obsolete("Not tested function!")]
        public async Task<object> UnfreezeBalance(UnfreezeBalanceRequestModel model)
        {
            var body = JsonSerializer.Serialize(model);
            return await HttpHelper.PostAsync<object>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/unfreezebalance",
                body
            );
        }

        /// <summary>
        ///     Returns all resources delegations from an account to another account. The fromAddress can be retrieved from the
        ///     GetDelegatedResourceAccountIndex API.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Obsolete("Not tested function!")]
        public async Task<object> GetDelegatedResource(GetDelegatedResourceRequestModel model)
        {
            var body = JsonSerializer.Serialize(model);
            return await HttpHelper.PostAsync<object>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/getdelegatedresource",
                body
            );
        }

        /// <summary>
        ///     Query the energy delegation by an account. i.e. list all addresses that have delegated resources to an account.
        /// </summary>
        /// <param name="address">Base58</param>
        /// <returns></returns>
        [Obsolete("Not tested function!")]
        public async Task<object> GetDelegatedResourceAccountIndex(string address)
        {
            var hexAddress = ConverterHelpers.Base58ToHex(address);
            var body = JsonSerializer.Serialize(new {value = hexAddress, visible = false});
            return await HttpHelper.PostAsync<object>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/getdelegatedresourceaccountindex",
                body
            );
        }
    }
}