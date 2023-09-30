using Exiled.API.Interfaces;

namespace Infinite_Radio
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}
