namespace Infinite_Radio
{
    using Exiled.API.Features;
    using System;
    using Player = Exiled.Events.Handlers.Player;

    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "InfRadio";
        public override string Author { get; } = "RAPLX";
        public override string Prefix { get; } = "InfRadio";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new(8, 0, 0);

        public EventHandlers Handler;

        public override void OnEnabled()
        {
            Handler = new EventHandlers(this);

            Player.UsingRadioBattery += Handler.OnBatteryUsing;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.UsingRadioBattery -= Handler.OnBatteryUsing;

            Handler = null;
            
            base.OnDisabled();

        }

    }
}