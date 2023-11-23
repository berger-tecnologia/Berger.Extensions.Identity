using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class Reset : BaseEntity, IInput
    {
        public Guid DeviceId { get; }
    }
}