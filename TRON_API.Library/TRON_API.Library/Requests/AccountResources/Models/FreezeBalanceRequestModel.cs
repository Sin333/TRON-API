using System;
using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.AccountResources.Models
{
    public class FreezeBalanceRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ownerAddress"></param>
        /// <param name="frozenBalance"></param>
        /// <param name="frozenDuration"></param>
        /// <param name="resource">must be -> ENERGY or BANDWIDTH</param>
        public FreezeBalanceRequestModel(
            string ownerAddress,
            long frozenBalance,
            int frozenDuration,
            string resource,
            string? receiverAddress = null,
            int? permissionId = null,
            bool? visible = null)
        {
            OwnerAddress = ConverterHelpers.Base58ToHex(ownerAddress);
            FrozenDuration = frozenDuration;
            if(resource != "ENERGY" || resource != "BANDWIDTH")
                throw new ArgumentException("Invalid 'resource' field");
            
            Resource = resource;
            PermissionId = permissionId;
            Visible = visible;
            ReceiverAddress = receiverAddress;
            FrozenBalance = frozenBalance;
        }
        
        [JsonPropertyName("owner_address")]
        public string OwnerAddress { get; set; } 

        /// <summary>
        /// TRX freeze amount, the unit is sun
        /// </summary>
        [JsonPropertyName("frozen_balance")]
        public long FrozenBalance { get; set; }
        
        /// <summary>
        /// TRX freeze duration, only be specified as 3 days
        /// </summary>
        [JsonPropertyName("frozen_duration")]
        public int FrozenDuration { get; set; }

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