using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.Accounts.Models
{
    public class UpdateAccountRequestModel
    {
        public UpdateAccountRequestModel(string accountName, string ownerAddress, int permissionId, bool visible = false)
        {
            AccountName = accountName;
            OwnerAddress = ownerAddress;
            PermissionId = permissionId;
            Visible = visible;
        }

        [JsonPropertyName("account_name")] 
        public string AccountName { get; set; }

        [JsonPropertyName("owner_address")] 
        public string OwnerAddress { get; set; }

        [JsonPropertyName("visible")] 
        public bool Visible { get; set; }

        [JsonPropertyName("permission_id")] 
        public int PermissionId { get; set; }
    }
}