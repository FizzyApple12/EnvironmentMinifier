using IPA;
using IPALogger = IPA.Logging.Logger;
using IPA.Config;
using IPA.Config.Stores;
using SiraUtil.Zenject;
using FizzyUtils;

namespace EnvironmentMinifier {
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin {
        internal const string Name = "EnvironmentMinifier";

        UsageTracker.UsageTrackerUser usageTrackerUser;

        [Init]
        public Plugin(IPALogger logger, Config config, Zenjector zenjector) {
            logger.Info($"{Name} started");
            zenjector.OnApp<Installers.PluginInstaller>().WithParameters(logger, config.Generated<Configuration.PluginConfig>());
            zenjector.OnGame<Installers.GameInstaller>();

            usageTrackerUser = Utils.usageTracker.AddUser(Name);
        }
    }
}
