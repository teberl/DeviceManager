using System.Threading.Tasks;

namespace DeviceManager.Data
{
    public interface IDeviceSerivce
    {
        Task<Device[]> GetDevicesAsync();
    }
}