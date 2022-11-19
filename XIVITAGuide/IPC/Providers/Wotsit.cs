using System.Collections.Generic;
using CheapLoc;
using Dalamud.Plugin.Ipc;
using XIVITAGuide.Base;
using XIVITAGuide.IPC.Interfaces;
using XIVITAGuide.Localization;
using XIVITAGuide.Managers;
using XIVITAGuide.Types;
using XIVITAGuide.UI.Windows.Editor;
using XIVITAGuide.UI.Windows.GuideList;
using XIVITAGuide.UI.Windows.GuideViewer;

namespace XIVITAGuide.IPC.Providers
{
    /// <summary>
    ///     Provider for Wotsit
    /// </summary>
    public sealed class WotsitIPC : IIPCProvider
    {
        public IPCProviders ID { get; } = IPCProviders.Wotsit;

        /// <summary>
        ///     The IconID that represents XIVITAGuide in Wotsit.
        /// </summary>
        private const uint WotsitIconID = 21;

        /// <summary>
        ///     Available label.
        /// </summary>
        private const string LabelProviderAvailable = "FA.Available";

        /// <summary>
        ///     Register label.
        /// </summary>
        private const string LabelProviderRegister = "FA.Register";

        /// <summary>
        ///     UnregisterAll label.
        /// </summary>
        private const string LabelProviderUnregisterAll = "FA.UnregisterAll";

        /// <summary>
        ///     Invoke label.
        /// </summary>
        private const string LabelProviderInvoke = "FA.Invoke";

        /// <summary>
        ///     Register CallGateSubscriber.
        /// </summary>
        private ICallGateSubscriber<string, string, uint, string>? wotsitRegister;

        /// <summary>
        ///     Unregister CallGateSubscriber.
        /// </summary>
        private ICallGateSubscriber<string, bool>? wotsitUnregister;

        /// <summary>
        ///     Available CallGateSubscriber.
        /// </summary>
        private ICallGateSubscriber<bool>? wotsitAvailable;

        /// <summary>
        ///     Invoke CallGateSubscriber.
        /// </summary>
        private ICallGateSubscriber<string, bool>? wotsitInvoke;

        /// <summary>
        ///     Stored GUID for OpenListIPC.
        /// </summary>
        private string? wotsitOpenListIpc;

        /// <summary>
        ///     Stored GUID for OpenEditorIPC.
        /// </summary>
        private string? wotsitOpenEditorIpc;

        /// <summary>
        ///     Stored GUIDs for Guides's.
        /// </summary>
        private readonly Dictionary<string, Guide> wotsitGuideIpcs = new();

        public void Enable()
        {
            try
            { this.Initialize(); }
            catch { /* Ignore */ }

            this.wotsitAvailable = PluginService.PluginInterface.GetIpcSubscriber<bool>(LabelProviderAvailable);
            this.wotsitAvailable.Subscribe(this.Initialize);
        }

        public void Dispose()
        {
            try
            {
                PluginService.PluginInterface.LanguageChanged += this.OnLanguageChange;
                this.wotsitUnregister?.InvokeFunc(PluginConstants.PluginName);
                this.wotsitAvailable?.Unsubscribe(this.Initialize);
                this.wotsitInvoke?.Unsubscribe(this.HandleInvoke);
            }
            catch { /* Ignore */ }
        }

        /// <summary>
        ///     Initializes IPC for Wotsit.
        /// </summary>
        private void Initialize()
        {
            this.wotsitRegister = PluginService.PluginInterface.GetIpcSubscriber<string, string, uint, string>(LabelProviderRegister);
            this.wotsitUnregister = PluginService.PluginInterface.GetIpcSubscriber<string, bool>(LabelProviderUnregisterAll);
            this.wotsitInvoke = PluginService.PluginInterface.GetIpcSubscriber<string, bool>(LabelProviderInvoke);

            PluginService.PluginInterface.LanguageChanged += this.OnLanguageChange;

            this.wotsitInvoke?.Subscribe(this.HandleInvoke);
            this.RegisterAll();
        }

        /// <summary>
        ///     Registers / Reloads the listings for this plugin.
        /// </summary>
        private void RegisterAll()
        {
            if (this.wotsitRegister == null)
            {
                return;
            }

            foreach (var guide in GuideManager.GetGuides())
            {
                var guid = this.wotsitRegister.InvokeFunc(PluginConstants.PluginName, WotsitTranslations.WotsitIPCOpenGuideFor(guide.CanonicalName), WotsitIconID);
                this.wotsitGuideIpcs.Add(guid, guide);
            }

            this.wotsitOpenListIpc = this.wotsitRegister.InvokeFunc(PluginConstants.PluginName, WotsitTranslations.WotsitIPCOpenGuideList, WotsitIconID);
            this.wotsitOpenEditorIpc = this.wotsitRegister.InvokeFunc(PluginConstants.PluginName, WotsitTranslations.WotsitIPCOpenGuideEditor, WotsitIconID);
        }

        /// <summary>
        ///     Handles IPC invocations for Wotsit.
        /// </summary>
        /// <param name="guid">The GUID of the invoked method.</param>
        private void HandleInvoke(string guid)
        {
            if (this.wotsitGuideIpcs.TryGetValue(guid, out var guide))
            {
                if (PluginService.WindowManager.GetWindow(TWindowNames.GuideViewer) is GuideViewerWindow guideViewerWindow)
                {
                    guideViewerWindow.Presenter.SelectedGuide = guide;
                    guideViewerWindow.IsOpen = true;
                }
            }
            else if (guid == this.wotsitOpenListIpc)
            {
                if (PluginService.WindowManager.GetWindow(TWindowNames.GuideList) is GuideListWindow guideListWIndow)
                {
                    guideListWIndow.IsOpen = true;
                }
            }
            else if (guid == this.wotsitOpenEditorIpc)
            {
                if (PluginService.WindowManager.GetWindow(TWindowNames.GuideEditor) is EditorWindow guideEditorWindow)
                {
                    guideEditorWindow.IsOpen = true;
                }
            }
        }

        /// <summary>
        ///     When the resources are updated, we need to re-register in-case of a language change.
        /// </summary>
        /// <param name="language"></param>
        private void OnLanguageChange(string language)
        {
            this.wotsitUnregister?.InvokeFunc(PluginConstants.PluginName);
            this.RegisterAll();
        }

        /// <summary>
        ///     Translations for Wotsit.
        /// </summary>
        private static class WotsitTranslations
        {
            public static string WotsitIPCOpenGuideList => Loc.Localize("IPC.Wotsit.OpenGuideList", "Open Guide List");
            public static string WotsitIPCOpenGuideEditor => Loc.Localize("IPC.Wotsit.OpenGuideEditor", "Open Guide Editor");
            public static string WotsitIPCOpenGuideFor(string guideName) => string.Format(Loc.Localize("IPC.Wotsit.OpenGuideFor", "Open Guide for {0}"), guideName);
        }
    }
}
