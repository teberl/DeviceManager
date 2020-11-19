using Microsoft.EntityFrameworkCore;

namespace DeviceManager.Data
{
    public class DeviceStoreContext: DbContext
    {
        public DeviceStoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Device> Devices { get; set; }
    }
}