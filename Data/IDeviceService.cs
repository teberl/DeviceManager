using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeviceManager.Data
{
    public interface IDeviceSerivce
    {
        Task<IList<Device>> GetDevicesAsync();
        Task<Device> GetDeviceByIdAsync(string id);
    }
}