using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.Accounts.Models
{
    public class CreateAccountRequestModel
    {
        public CreateAccountRequestModel(string ownerAddress, string accountAddress, bool visible = false, int? permissionId = null)
        {
            OwnerAddress = ownerAddress;
            AccountAddress = accountAddress;
            Visible = visible;
            PermissionId = permissionId;
        }

        [JsonPropertyName("owner_address")] 
        public string OwnerAddress { get; set; }

        [JsonPropertyName("owner_address")] 
        public string AccountAddress { get; set; }

        [JsonPropertyName("visible")] 
        public bool Visible { get; set; }

        [JsonPropertyName("permission_id")] 
        public int? PermissionId { get; set; }
    }
}