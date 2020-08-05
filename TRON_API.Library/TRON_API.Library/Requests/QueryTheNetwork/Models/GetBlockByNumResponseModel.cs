using System.Text.Json.Serialization;
using TRON_API.Library.Requests.QueryTheNetwork.Models.BaseModels;

namespace TRON_API.Library.Requests.QueryTheNetwork.Models
{
    public class GetBlockByNumResponseModel
    {
        [JsonPropertyName("blockID")]
        public string BlockId { get; set; } 

        [JsonPropertyName("block_header")]
        public BaseBlockHeader<BaseBlockHeaderRawData> BlockHeader { get; set; } 
    }
}