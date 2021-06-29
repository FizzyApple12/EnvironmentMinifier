using System.Collections.Generic;
using System.Runtime.CompilerServices;
using IPA.Config.Stores;
using IPA.Config.Stores.Attributes;
using IPA.Config.Stores.Converters;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace EnvironmentMinifier.Configuration {
    class PluginConfig {
        public static PluginConfig Instance { get; set; }
        [UseConverter(typeof(ListConverter<string>))]
        public virtual List<string> EnvironmentRemoval { get; set; } = new List<string>() {
            "TrackMirror",
            "TrackConstruction",
            "Spectrogram"
        };
    }
}
