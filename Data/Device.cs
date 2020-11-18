using System;

namespace DeviceManager.Data
{
    public record Device
    {
        public string DeviceId { get; init; }
        public string Name { get; init; }
        public string DeviceTypeId { get; init; }
        public bool Failsafe { get; init; }
        public int TempMin { get; init; }
        public int TempMax { get; init; }
        public string InstallationPosition { get; init; }
        public bool InsertInto19InchCabinet { get; init; }
        public bool MotionEnable { get; init; }
        public bool SiplusCatalog { get; init; }
        public bool SimaticCatalog { get; init; }
        public int RotationAxisNumber { get; init; }
        public int PositionAxisNumber { get; init; }
        public bool? TerminalElement { get; init; }
        public bool? AdvancedEnvironmentalConditions { get; init; }
    }
}
