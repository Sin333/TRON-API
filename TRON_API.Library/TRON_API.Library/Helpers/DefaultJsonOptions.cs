using System.Text.Json;

namespace TRON_API.Library.Helpers
{
    public class DefaultJsonOptions
    {
        public static JsonSerializerOptions GetDefaultJsonOptions() => new JsonSerializerOptions()
        {
            AllowTrailingCommas = true,
            PropertyNameCaseInsensitive = true,
            IgnoreNullValues = true
        };
    }
}