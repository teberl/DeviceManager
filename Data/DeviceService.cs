using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManager.Data
{
    public class DeviceService: IDeviceSerivce
    {
        private static readonly IList<Device> ExampleDevices = new[]
        {
            new Device {
                Id = "1glmLrTZqf9YZleN",
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
            new Device {
                Id = "1glmLrTZqf9YZleN",
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
            new Device {
                Id = "9RLMugEpCVSeemZ5",
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
            new Device {
                Id = "9RLMugEbCVSeemZ4",
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

        public Task<IList<Device>> GetDevicesAsync() => Task.FromResult(ExampleDevices);

        public Task<Device> GetDeviceByIdAsync(string id) => Task.FromResult(ExampleDevices.FirstOrDefault(device => device.Id == id));
    }
}
