using System;
using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.Accounts.Models
{
    public class GetAccountResponseModel
    {
        [JsonPropertyName("address")] 
        public string Address { get; set; }

        [JsonPropertyName("balance")] 
        public long Balance { get; set; }

        [JsonPropertyName("create_time")] 
        public DateTime CreateTime { get; set; }

        [JsonPropertyName("account_resource")] 
        public object AccountResource { get; set; }

        [JsonPropertyName("owner_permission")] 
        public GetAccountOwnerPermission OwnerPermission { get; set; }

        [JsonPropertyName("active_permission")]
        public GetAccountActivePermission[] ActivePermission { get; set; }
    }

    public class GetAccountOwnerPermission
    {
        [JsonPropertyName("permission_name")] 
        public string PermissionName { get; set; }

        [JsonPropertyName("threshold")] 
        public int Threshold { get; set; }

        [JsonPropertyName("keys")] 
        public GetAccountKeys[] Keys { get; set; }
    }

    public class GetAccountActivePermission
    {
        [JsonPropertyName("type")] 
        public string Type { get; set; }

        [JsonPropertyName("id")] 
        public long Id { get; set; }

        [JsonPropertyName("permission_name")] 
        public string PermissionName { get; set; }

        [JsonPropertyName("threshold")] 
        public int Threshold { get; set; }

        [JsonPropertyName("operations")] 
        public string Operations { get; set; }

        [JsonPropertyName("keys")] 
        public GetAccountKeys[] Keys { get; set; }
    }

    public class GetAccountKeys
    {
        [JsonPropertyName("address")] 
        public string Address { get; set; }

        [JsonPropertyName("weight")] 
        public int Weight { get; set; }
    }
}