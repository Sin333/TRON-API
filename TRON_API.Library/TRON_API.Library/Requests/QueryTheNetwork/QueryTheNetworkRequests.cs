using System;
using System.Text.Json;
using System.Threading.Tasks;
using TRON_API.Library.Helpers;
using TRON_API.Library.Requests.QueryTheNetwork.Models;

namespace TRON_API.Library.Requests.QueryTheNetwork
{
    public class QueryTheNetworkRequests
    {
        private readonly TronApiConfiguration _tronApiConfiguration;

        public QueryTheNetworkRequests(TronApiConfiguration tronApiConfiguration)
        {
            _tronApiConfiguration = tronApiConfiguration;
        }

        /// <summary>
        ///     Returns the Block Object corresponding to the 'Block Height' specified (number of blocks preceding it).
        /// </summary>
        /// <param name="num">num is the block height</param>
        /// <returns></returns>
        public async Task<GetBlockByNumResponseModel> GetBlockByNum(int num)
        {
            var body = JsonSerializer.Serialize(new {num}, DefaultJsonOptions.GetDefaultJsonOptions());
            return await HttpHelper.PostAsync<GetBlockByNumResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/getblockbynum",
                body
            );
        }

        /// <summary>
        ///     Query block by ID(block hash).
        /// </summary>
        /// <param name="blockId">Block ID</param>
        /// <returns></returns>
        public async Task<GetBlockByIdResponseModel> GetBlockById(string blockId)
        {
            var body = JsonSerializer.Serialize(new {value = blockId}, DefaultJsonOptions.GetDefaultJsonOptions());
            return await HttpHelper.PostAsync<GetBlockByIdResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/getblockbyid",
                body
            );
        }

        /// <summary>
        ///     Returns a list of block objects.
        /// </summary>
        /// <param name="num">The number of blocks to query</param>
        /// <returns></returns>
        [Obsolete("Not tested function!")]
        public async Task<object> GetBlockByLatestNum(int num)
        {
            var body = JsonSerializer.Serialize(new {num}, DefaultJsonOptions.GetDefaultJsonOptions());
            return await HttpHelper.PostAsync<object>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/getblockbylatestnum",
                body
            );
        }

        /// <summary>
        ///     Returns the list of Block Objects included in the 'Block Height' range specified.
        /// </summary>
        /// <param name="startNum">Starting block height, including this block.</param>
        /// <param name="endNum">Ending block height, excluding that block.</param>
        /// <returns></returns>
        [Obsolete("Not tested function!")]
        public async Task<object> GetBlockByLimitNext(int startNum, int endNum)
        {
            var body = JsonSerializer.Serialize(new {startNum, endNum}, DefaultJsonOptions.GetDefaultJsonOptions());
            return await HttpHelper.PostAsync<object>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/getblockbylimitnext",
                body
            );
        }

        /// <summary>
        ///     Query the latest block information
        /// </summary>
        /// <returns></returns>
        public async Task<GetNowBlockResponseModel> GetNowBlock()
        {
            return await HttpHelper.PostAsync<GetNowBlockResponseModel>(
                $"{_tronApiConfiguration.FullNodeURL}wallet/getnowblock"
            );
        }
    }
}