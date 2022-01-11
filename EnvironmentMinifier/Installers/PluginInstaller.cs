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
    internal class PluginInstaller : Installer<PluginConfig, PluginInstaller> {
        private readonly PluginConfig pluginConfig;

        internal PluginInstaller(PluginConfig pluginConfig) {
            this.pluginConfig = pluginConfig;
        }

        public override void InstallBindings() {
            Container.BindInstance(pluginConfig);
            Container.BindInterfacesAndSelfTo<ConfigLogContainer>().AsSingle();
        }
    }
}
