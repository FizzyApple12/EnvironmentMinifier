using EnvironmentMinifier.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace EnvironmentMinifier.Installers {
    class GameInstaller : MonoInstaller {
        public override void InstallBindings() {
            Container.Resolve<PluginConfig>();
            Container.BindInterfacesTo<EnvironmentModifier>().AsSingle();
        }
    }
}
