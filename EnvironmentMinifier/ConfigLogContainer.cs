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
        private readonly SiraLog siraLog;
        private readonly PluginConfig pluginConfig;

        internal ConfigLogContainer(SiraLog siraLog, PluginConfig pluginConfig) {
            this.siraLog = siraLog;
            this.pluginConfig = pluginConfig;
        }
    }
}
