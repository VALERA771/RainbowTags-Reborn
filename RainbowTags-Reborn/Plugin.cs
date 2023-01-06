using System;
using Exiled.API.Features;

using PlayerHandlers = Exiled.Events.Handlers.Player;


namespace RainbowTags_Reborn
{
    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        public override string Name { get; } = "RainbowTags-Reborn";
        public override string Prefix { get; } = "RainbowTags";
        public override string Author { get; } = "VALERA771#1471";
        public override Version Version { get; } = new Version(1, 1, 1, 1);
        public override Version RequiredExiledVersion { get; } = new Version(6, 0, 0, 0);

        
        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers(this);
            PlayerHandlers.ChangingGroup += eventHandlers.OnChangingGroup;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            PlayerHandlers.ChangingGroup -= eventHandlers.OnChangingGroup;
            eventHandlers = null;
            base.OnDisabled();
        }

        public override void OnReloaded()
        {
            base.OnReloaded();
        }
    }
}