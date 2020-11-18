namespace DeviceManager.Data
{
    public static class SeedData
    {
        public static void Initialize(DeviceStoreContext db)
        {
            var devices = new DeviceEntity[]
            {
                new DeviceEntity {
                    DeviceId = "1glmLrTZqf9YZleN",
                    Name = "S7-150009",
                    DeviceTypeId = "Beweis",
                    Failsafe = true,
                    TempMin = 0,
                    TempMax = 60,
                    InstallationPosition = "horizontal",
                    InsertInto19InchCabinet = true,
                    MotionEnable = true,
                    SiplusCatalog = true,
                    SimaticCatalog = true,
                    RotationAxisNumber = 0,
                    PositionAxisNumber = 0
                },
                new DeviceEntity {
                    DeviceId = "1glmLrTZqf9YZleN",
                    Name = "S7-1500",
                    DeviceTypeId = "S7_1500",
                    Failsafe = true,
                    TempMin = 0,
                    TempMax = 50,
                    InstallationPosition = "horizontal",
                    InsertInto19InchCabinet = true,
                    MotionEnable = true,
                    SiplusCatalog = false,
                    SimaticCatalog = true,
                    RotationAxisNumber = 0,
                    PositionAxisNumber = 0,
                    AdvancedEnvironmentalConditions = false
                },
                new DeviceEntity {
                    DeviceId = "9RLMugEpCVSeemZ5",
                    Name = "ET 200SP",
                    DeviceTypeId = "ET200_SP",
                    Failsafe = false,
                    TempMin = 0,
                    TempMax = 40,
                    InstallationPosition = "horizontal",
                    InsertInto19InchCabinet = true,
                    MotionEnable = true,
                    SiplusCatalog = false,
                    SimaticCatalog = true,
                    RotationAxisNumber = 0,
                    PositionAxisNumber = 0,
                    TerminalElement = true,
                    AdvancedEnvironmentalConditions = false
                },
                new DeviceEntity {
                    DeviceId = "9RLMugEbCVSeemZ4",
                    Name = "S7-300",
                    DeviceTypeId = "S7_300",
                    Failsafe = true,
                    TempMin = 0,
                    TempMax = 40,
                    InstallationPosition = "vertical",
                    InsertInto19InchCabinet = false,
                    MotionEnable = false,
                    SiplusCatalog = false,
                    SimaticCatalog = false,
                    RotationAxisNumber = 0,
                    PositionAxisNumber = 0,
                    TerminalElement = true,
                    AdvancedEnvironmentalConditions = false
                }
            };
            db.Devices.AddRange(devices);
            db.SaveChanges();
        }
    }
}