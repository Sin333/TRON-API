using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.Transactions.Models
{
    public class CreateTransactionRequestModel
    {
        public CreateTransactionRequestModel(string toAddress, string ownerAddress, long amount, int? permissionId = null, bool? visible = null)
        {
            ToAddress = toAddress;
            OwnerAddress = ownerAddress;
            Amount = amount;
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