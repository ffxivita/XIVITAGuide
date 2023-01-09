using System.Linq;
using XIVITAGuide.Base;
using XIVITAGuide.Types;

namespace XIVITAGuide.Utils
{
    /// <summary>
    ///     Common utilities for guides.
    /// </summary>
    internal static class GuideUtil
    {
        /// <summary>
        ///     Get the guide for the current territory.
        /// </summary>
        /// <returns> The guide for the current territory. </returns>
        internal static Guide? GetGuideForCurrentTerritory() => PluginService.GuideManager.GetAllGuides().Find(guide => guide.TerritoryIDs.Contains(PluginService.ClientState.TerritoryType));
    }
}