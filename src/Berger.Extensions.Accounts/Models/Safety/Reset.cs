using Berger.Extensions.Devices;

namespace Berger.Extensions.Accounts
{
    public class Reset : IDevice
    {
        #region Properties
        public Guid DeviceID { get; set; }
        public Device Device { get; set; }
        #endregion
    }
}