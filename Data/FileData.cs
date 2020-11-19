using System.Text.Json.Serialization;

namespace DeviceManager.Data
{
    public record FileData
    {
        [JsonPropertyName("devices")]
        public Device[] Devices { get; init; }
    }
}