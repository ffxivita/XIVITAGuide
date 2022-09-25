namespace XIVITAGuide.UI.Screens.DutyInfo;

using System.Numerics;
using ImGuiNET;
using XIVITAGuide.Base;
using XIVITAGuide.Managers;
using XIVITAGuide.Interfaces;
using XIVITAGuide.UI.Components.Duty;

sealed public class DutyInfoScreen : IScreen
{
    public DutyInfoPresenter presenter = new DutyInfoPresenter();

    public void Draw() => DrawInfoWindow();
    public void Dispose() => this.presenter.Dispose();
    public void Show() => this.presenter.isVisible = true;
    public void Hide() => this.presenter.isVisible = false;

    /// <summary>
    ///     Draws the duty info window.
    /// </summary>
    private void DrawInfoWindow()
    {
        if (!presenter.isVisible) return;

        var selectedDuty = presenter.selectedDuty;

        ImGui.SetNextWindowSize(new Vector2(380, 420), ImGuiCond.FirstUseEver);
        if (ImGui.Begin(TStrings.DutyInfoTitle, ref presenter.isVisible, ImGuiWindowFlags.NoScrollbar))
        {

            if (selectedDuty == null) { ImGui.TextWrapped(TStrings.DutyInfoNoneSelected); return; }
            if (selectedDuty.Sections == null || selectedDuty.Sections.Count == 0) { ImGui.TextWrapped(TStrings.DutyListNoGuide(selectedDuty.CanconicalName)); return; }
            if (!DutyManager.IsUnlocked(selectedDuty)) { ImGui.TextWrapped(TStrings.DutyInfoNotUnlocked); return; }

            DutyInfoComponent.Draw(selectedDuty);

            ImGui.End();
        }
    }
}
