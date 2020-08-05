using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.Transactions.Models
{
    public class EasyTransferRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="passPhrase"></param>
        /// <param name="toAddress">Base58</param>
        /// <param name="amount"></param>
        public EasyTransferRequestModel(string passPhrase, string toAddress, int amount)
        {
            PassPhrase = passPhrase;
            ToAddress = ConverterHelpers.Base58ToHex(toAddress);
            Amount = amount;
        }

        [JsonPropertyName("passPhrase")]
        public string PassPhrase { get; set; }
        
        [JsonPropertyName("toAddress")]
        public string ToAddress { get; set; }
        
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
    }
}