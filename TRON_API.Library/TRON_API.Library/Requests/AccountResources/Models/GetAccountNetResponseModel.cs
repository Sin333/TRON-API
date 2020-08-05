using System.Text.Json.Serialization;
using TRON_API.Library.Requests.BaseModels;

namespace TRON_API.Library.Requests.AccountResources.Models
{
    public class GetAccountNetResponseModel {
        
        [JsonPropertyName("freeNetLimit")]
        public int FreeNetLimit { get; set; } 

        [JsonPropertyName("assetNetUsed")]
        public KeyAndValueModel[] AssetNetUsed { get; set; } 

        [JsonPropertyName("assetNetLimit")]
        public KeyAndValueModel[] AssetNetLimit { get; set; } 

        [JsonPropertyName("TotalNetLimit")]
        public long TotalNetLimit { get; set; } 

        [JsonPropertyName("TotalNetWeight")]
        public long TotalNetWeight { get; set; } 
    }

}