using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
namespace InfinityRadio
{
    public sealed class Plugin : Plugin<Config>
    {
        public override string Author => "Greyzer";
        public override string Name => "InfinityRadio";
        public override string Prefix => Name;
        public override void OnEnabled() { Exiled.Events.Handlers.Player.UsingRadioBattery += OnUsingRadioBatteryEventArgs; }
        public override void OnDisabled() { Exiled.Events.Handlers.Player.UsingRadioBattery -= OnUsingRadioBatteryEventArgs; }
        private void OnUsingRadioBatteryEventArgs(UsingRadioBatteryEventArgs ev) => ev.Drain = 0f;
    }
}