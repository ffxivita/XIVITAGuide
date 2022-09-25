namespace XIVITAGuide.UI.Screens.DutyInfo;

using System;
using XIVITAGuide.Base;
using XIVITAGuide.Types;
using XIVITAGuide.Managers;

sealed public class DutyInfoPresenter : IDisposable
{
    public DutyInfoPresenter()
    {
        PluginService.ClientState.TerritoryChanged += this.OnTerritoryChange;
    }

    public void Dispose()
    {
        PluginService.ClientState.TerritoryChanged -= this.OnTerritoryChange;
    }

    public bool isVisible = false;

    /// <summary> 
    ///     The currently selected duty to show in the info window.
    /// </summary>
    public Duty? selectedDuty = null;

    /// <summary>
    ///     Handles territory change even and changes the UI state accordingly.
    /// </summary>
    public void OnTerritoryChange(object? sender, ushort e)
    {
        var playerDuty = DutyManager.GetPlayerDuty();

        // If the player has entered a duty with data and has the setting enabled, show the duty info window.
        if (playerDuty != null && playerDuty?.Sections?.Count > 0)
        {
            this.selectedDuty = playerDuty;
            if (PluginService.Configuration.autoOpenDuty) this.isVisible = true;
        }

        // If the player has entered a territory that does not have any data, deselect the duty & hide the UI
        else if (playerDuty == null)
        {
            this.selectedDuty = null;
            this.isVisible = false;
        }
    }
}