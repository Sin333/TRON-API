using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.BaseModels
{
    public class AddressModel
    {
        public AddressModel(string address, bool visible = false)
        {
            Address = address;
            Visible = visible;
        }

        [JsonPropertyName("address")]
        public string Address { get; set; }
        
        [JsonPropertyName("visible")]
        public bool Visible { get; set; }
    }
}