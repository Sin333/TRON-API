using System.Text.Json;
using System.Threading.Tasks;
using TRON_API.Library.Helpers;
using TRON_API.Library.Requests.AddressUtilities.Models;

namespace TRON_API.Library.Requests.AddressUtilities
{
    /// <summary>
    ///     These APIs won't make any changes on-chain and have nothing to do with on-chain data.
    /// </summary>
    public class AddressUtilitiesRequests
    {
        private readonly TronApiConfiguration _tronApiConfiguration;

        public AddressUtilitiesRequests(TronApiConfiguration tronApiConfiguration)
        {
            _tronApiConfiguration = tronApiConfiguration;
        }

        /// <summary>
        ///     Generates a random private key and address pair. Returns a private key, the corresponding address in hex, and
        ///     base58.
        /// </summary>
        /// <returns></returns>
        public async Task<GenerateAddressResponseModel> GenerateAddress()
        {
            return await HttpHelper.GetAsync<GenerateAddressResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/generateaddress"
            );
        }

        /// <summary>
        ///     Create address from a specified password string (NOT PRIVATE KEY)
        /// </summary>
        /// <returns></returns>
        public async Task<CreateAddressResponseModel> CreateAddress(string value)
        {
            var body = JsonSerializer.Serialize(new {value});
            return await HttpHelper.PostAsync<CreateAddressResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/createaddress",
                body
            );
        }

        /// <summary>
        ///     Validates address, returns either true or false.
        /// </summary>
        /// <param name="address">Base58 or HEX format</param>
        /// <returns></returns>
        public async Task<ValidateAddressResponseModel> ValidateAddress(string address)
        {
            var body = JsonSerializer.Serialize(new {address});
            return await HttpHelper.PostAsync<ValidateAddressResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/validateaddress",
                body
            );
        }
    }
}