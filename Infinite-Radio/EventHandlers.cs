namespace Infinite_Radio
{
    using Exiled.Events.EventArgs.Player;

    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void OnBatteryUsing(UsingRadioBatteryEventArgs ev)
        {
            ev.Drain = 0;
        }
    }
}