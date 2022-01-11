using IPA;
using IPALogger = IPA.Logging.Logger;
using IPA.Config;
using IPA.Config.Stores;
using SiraUtil.Zenject;

namespace EnvironmentMinifier {
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin {
        internal const string Name = "EnvironmentMinifier";

        [Init]
        public Plugin(IPALogger logger, Config config, Zenjector zenjector) {
            logger.Info($"{Name} started");
            zenjector.UseLogger(logger);
            zenjector.Install<Installers.PluginInstaller>(Location.App, config.Generated<Configuration.PluginConfig>());
            zenjector.Install<Installers.GameInstaller>(Location.GameCore);
        }
    }
}
