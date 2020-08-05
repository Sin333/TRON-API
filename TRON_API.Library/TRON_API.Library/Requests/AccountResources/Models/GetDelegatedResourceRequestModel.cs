using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.AccountResources.Models
{
    public class GetDelegatedResourceRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromAddress">Base58</param>
        /// <param name="toAddress">Base58</param>
        /// <param name="visible"></param>
        public GetDelegatedResourceRequestModel(string fromAddress, string toAddress, bool? visible = null)
        {
            FromAddress = ConverterHelpers.Base58ToHex(fromAddress);
            ToAddress = ConverterHelpers.Base58ToHex(toAddress);
            Visible = visible;
        }

        [JsonPropertyName("fromAddress")]
        public string FromAddress { get; set; }
        
        [JsonPropertyName("toAddress")]
        public string ToAddress { get; set; }
        
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }
    }
}