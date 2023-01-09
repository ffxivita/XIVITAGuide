using XIVITAGuide.Base;
using XIVITAGuide.IPC;

namespace XIVITAGuide.UI.ImGuiFullComponents.IPCProviderCombo
{
    internal sealed class IPCProviderComboPresenter
    {
        internal static Configuration Configuration => PluginService.Configuration;
        internal static IPCLoader IPC => PluginService.IPC;
    }
}