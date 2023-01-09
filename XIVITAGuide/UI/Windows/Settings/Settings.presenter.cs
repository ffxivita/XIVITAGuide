using System;
using System.IO;
using CheapLoc;
using Dalamud.Interface.ImGuiFileDialog;
using Dalamud.Interface.Internal.Notifications;
using XIVITAGuide.Base;
using XIVITAGuide.IPC;
using XIVITAGuide.Utils;

namespace XIVITAGuide.UI.Windows.Settings
{
    internal sealed class SettingsPresenter : IDisposable
    {
        public void Dispose() { }

        /// <summary>
        ///     Pulls the configuration from the plugin service.
        /// </summary>
        internal static Configuration Configuration => PluginService.Configuration;

        /// <summary>
        ///     Sets an IPCProvider as enabled.
        /// </summary>
        /// <param name="provider"> The provider to enable. </param>
        internal static void SetIPCProviderEnabled(IPCProviders provider) => PluginService.IPC.EnableProvider(provider);

        /// <summary>
        ///     Sets an IPCProvider as disabled.
        /// </summary>
        /// <param name="provider"> The provider to disable. </param>
        internal static void SetIPCProviderDisabled(IPCProviders provider) => PluginService.IPC.DisableProvider(provider);

#if DEBUG
        internal FileDialogManager DialogManager = new();

        /// <summary>
        ///     Handles the directory select event and saves the location to that directory.
        /// </summary>
        /// <param name="cancelled">Whether the dialog was cancelled.</param>
        /// <param name="path">The path to the selected directory.</param>
        internal static void OnDirectoryPicked(bool cancelled, string path)
        {
            if (!cancelled)
            {
                return;
            }

            var directory = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(path);
            Loc.ExportLocalizable();
            File.Copy(Path.Combine(path, "XIVITAGuide_Localizable.json"), Path.Combine(path, "en.json"), true);
            Directory.SetCurrentDirectory(directory);
            Notifications.ShowToast(message: "Localization exported successfully", type: NotificationType.Success);
        }
#endif
    }
}