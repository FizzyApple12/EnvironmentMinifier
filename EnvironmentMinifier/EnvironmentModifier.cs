using EnvironmentMinifier.Configuration;
using IPA.Logging;
using SiraUtil.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace EnvironmentMinifier {
    class EnvironmentModifier : IInitializable {
        private readonly SiraLog siraLog;
        private readonly PluginConfig pluginConfig;

        internal EnvironmentModifier(SiraLog siraLog, PluginConfig pluginConfig) {
            siraLog.Info("EnvironmentModifier");
            this.siraLog = siraLog;
            this.pluginConfig = pluginConfig;
        }

        public void Initialize() {
            siraLog.Info("Modifying Environment...");

            // Definitely not code from chroma not at all ;)

            if (pluginConfig.EnvironmentRemoval != null) {
                IEnumerable<GameObject> gameObjects = Resources.FindObjectsOfTypeAll<GameObject>();

                foreach (string name in pluginConfig.EnvironmentRemoval) {
                    foreach (GameObject gameObject in gameObjects.Where(gameObject => gameObject.name.Contains(name))) {
                        if (name == "TrackLaneRing" && gameObject.name.Contains("Big")) continue;

                        gameObject.SetActive(false);
                    }
                }
            }

            siraLog.Info("Done!");
        }
    }
}
