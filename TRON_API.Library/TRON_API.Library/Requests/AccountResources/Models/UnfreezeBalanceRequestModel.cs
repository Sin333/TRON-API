using System;
using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.AccountResources.Models
{
    public class UnfreezeBalanceRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ownerAddress"></param>
        /// <param name="resource">must be -> ENERGY or BANDWIDTH</param>
        public UnfreezeBalanceRequestModel(
            string ownerAddress,
            string resource,
            string? receiverAddress = null,
            int? permissionId = null,
            bool? visible = null)
        {
            OwnerAddress = ConverterHelpers.Base58ToHex(ownerAddress);
            if(resource != "ENERGY" || resource != "BANDWIDTH")
                throw new ArgumentException("Invalid 'resource' field");
            
            Resource = resource;
            PermissionId = permissionId;
            Visible = visible;
            ReceiverAddress = receiverAddress;
        }
        
        [JsonPropertyName("owner_address")]
        public string OwnerAddress { get; set; }

        /// <summary>
        /// TRX freeze type, 'BANDWIDTH' or 'ENERGY'
        /// </summary>
        [JsonPropertyName("resource")]
        public string Resource { get; set; }
        
        [JsonPropertyName("receiver_address")]
        public string? ReceiverAddress { get; set; }
        
        [JsonPropertyName("permission_id")]
        public int? PermissionId { get; set; }
        
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }
    }
}