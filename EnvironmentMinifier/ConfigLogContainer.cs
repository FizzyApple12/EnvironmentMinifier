using EnvironmentMinifier.Configuration;
using SiraUtil.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace EnvironmentMinifier {
    class ConfigLogContainer {
        private readonly PluginConfig pluginConfig;

        internal ConfigLogContainer(PluginConfig pluginConfig) {
            this.pluginConfig = pluginConfig;
        }
    }
}
