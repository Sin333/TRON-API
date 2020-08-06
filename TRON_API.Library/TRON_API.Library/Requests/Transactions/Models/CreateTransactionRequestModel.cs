using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.Transactions.Models
{
    public class CreateTransactionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="toAddress">Base58</param>
        /// <param name="ownerAddress">Base58</param>
        /// <param name="amount">SUN</param>
        /// <param name="permissionId">Optional not required</param>
        /// <param name="visible">Optional not required</param>
        public CreateTransactionRequestModel(string toAddress, string ownerAddress, decimal amount, int? permissionId = null, bool? visible = null)
        {
            ToAddress = ConverterHelpers.Base58ToHex(toAddress);
            OwnerAddress = ConverterHelpers.Base58ToHex(ownerAddress);
            Amount = ConverterHelpers.TRXToSun(amount);
            PermissionId = permissionId;
            Visible = visible;
        }

        [JsonPropertyName("to_address")]
        public string ToAddress { get; set; }
        
        [JsonPropertyName("owner_address")]
        public string OwnerAddress { get; set; }
        
        [JsonPropertyName("amount")]
        public long Amount { get; set; }
        
        [JsonPropertyName("permission_id")]
        public int? PermissionId { get; set; }
        
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }
    }
}