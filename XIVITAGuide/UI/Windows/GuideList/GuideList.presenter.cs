using System;
using System.Collections.Generic;
using XIVITAGuide.Base;
using XIVITAGuide.Localization;
using XIVITAGuide.Types;
using XIVITAGuide.UI.Windows.GuideViewer;

namespace XIVITAGuide.UI.Windows.GuideList
{
    internal sealed class GuideListPresenter : IDisposable
    {
        public void Dispose() { }

        /// <summary>
        ///     Gets the guide list from the GuideManager.
        /// </summary>
        internal static List<Guide> GetGuides() => PluginService.GuideManager.GetAllGuides();

        /// <summary>
        ///     Handles a guide list selection event.
        /// </summary>
        /// <param name="guide">The guide that was selected.</param>
        internal static void OnGuideListSelection(Guide guide)
        {
            if (PluginService.WindowManager.GetWindow(TWindowNames.GuideViewer) is GuideViewerWindow guideViewerWindow)
            {
                guideViewerWindow.IsOpen = true;
                guideViewerWindow.Presenter.SetSelectedGuide(guide);
            }
        }

        /// <summary>
        ///     Pulls the configuration from the plugin service.
        /// </summary>
        internal static Configuration GetConfiguration() => PluginService.Configuration;
    }
}