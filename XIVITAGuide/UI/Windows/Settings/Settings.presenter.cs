using System;
using System.IO;
using CheapLoc;
using Dalamud.Interface.ImGuiFileDialog;
using Dalamud.Interface.Internal.Notifications;
using XIVITAGuide.Base;
using XIVITAGuide.IPC;

namespace XIVITAGuide.UI.Windows.Settings
{
    public sealed class SettingsPresenter : IDisposable
    {
        public void Dispose() { }

        /// <summary>
        ///     Pulls the configuration from the plugin service.
        /// </summary>
        internal static Configuration Configuration => PluginService.Configuration;

        /// <summary>
        ///     Sets an IPCProvider as enabled.
        /// </summary>
        public static void SetIPCProviderEnabled(IPCProviders provider) => PluginService.IPC.EnableProvider(provider);

        /// <summary>
        ///     Sets an IPCProvider as disabled.
        /// </summary>
        public static void SetIPCProviderDisabled(IPCProviders provider) => PluginService.IPC.DisableProvider(provider);

#if DEBUG
        internal FileDialogManager DialogManager = new();

        /// <summary>
        ///     Handles the directory select event and saves the location to that directory.
        /// </summary>
        public static void OnDirectoryPicked(bool success, string path)
        {
            if (!success)
            {
                return;
            }

            var directory = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(path);
            Loc.ExportLocalizable();
            File.Copy(Path.Combine(path, "XIVITAGuide_Localizable.json"), Path.Combine(path, "en.json"), true);
            Directory.SetCurrentDirectory(directory);
            PluginService.PluginInterface.UiBuilder.AddNotification("Localization exported successfully.", PluginConstants.PluginName, NotificationType.Success);
        }
#endif
    }
}