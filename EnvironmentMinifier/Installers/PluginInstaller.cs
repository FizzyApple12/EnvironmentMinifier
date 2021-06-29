using EnvironmentMinifier.Configuration;
using IPA.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using SiraUtil;

namespace EnvironmentMinifier.Installers {
    internal class PluginInstaller : Installer<Logger, PluginConfig, PluginInstaller> {
        private readonly Logger logger;
        private readonly PluginConfig pluginConfig;

        internal PluginInstaller(Logger logger, PluginConfig pluginConfig) {
            this.logger = logger;
            this.pluginConfig = pluginConfig;
        }

        public override void InstallBindings() {
            Container.BindInstance(pluginConfig);
            Container.BindLoggerAsSiraLogger(logger);
            Container.BindInterfacesAndSelfTo<ConfigLogContainer>().AsSingle();
        }
    }
}
