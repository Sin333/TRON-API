using System.Text.Json.Serialization;

namespace TRON_API.Library.Requests.BaseModels
{
    public class KeyAndValueModel
    {
        [JsonPropertyName("key")] 
        public string Key { get; set; }

        [JsonPropertyName("value")] 
        public long Value { get; set; }
    }
}