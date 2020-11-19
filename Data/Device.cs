using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DeviceManager.Data
{
    public record Device
    {
        [JsonIgnore]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [JsonPropertyName("id")]
        public string DeviceId { get; init; }

        [JsonPropertyName("name")]
        public string Name { get; init; }

        [JsonPropertyName("deviceTypeId")]
        public string DeviceTypeId { get; init; }

        [JsonPropertyName("failsafe")]
        public bool Failsafe { get; init; }

        [JsonPropertyName("tempMin")]
        public int TempMin { get; init; }

        [JsonPropertyName("tempMax")]
        public int TempMax { get; init; }

        [JsonPropertyName("installationPosition")]
        public string InstallationPosition { get; init; }

        [JsonPropertyName("insertInto19InchCabinet")]
        public bool InsertInto19InchCabinet { get; init; }

        [JsonPropertyName("motionEnabled")]
        public bool MotionEnable { get; init; }

        [JsonPropertyName("siplusCatalog")]
        public bool SiplusCatalog { get; init; }

        [JsonPropertyName("simaticCatalog")]
        public bool SimaticCatalog { get; init; }

        [JsonPropertyName("rotationAxisNumber")]
        public int RotationAxisNumber { get; init; }

        [JsonPropertyName("positionAxisNumber")]
        public int PositionAxisNumber { get; init; }

        [JsonPropertyName("terminalElement")]
        public bool? TerminalElement { get; init; }

        [JsonPropertyName("advancedEnvironmentalConditions")]
        public bool? AdvancedEnvironmentalConditions { get; init; }
    }
}
