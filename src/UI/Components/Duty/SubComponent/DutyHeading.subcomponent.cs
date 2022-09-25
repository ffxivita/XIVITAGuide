namespace XIVITAGuide.UI.Components.Duty;

using XIVITAGuide.UI.Components;
using System;
using ImGuiNET;
using XIVITAGuide.Base;
using XIVITAGuide.Types;

/// <summary>
///     A subcomponent for displaying a duty heading.
/// </summary>
static class DutyHeadingComponent
{
    /// <summary> 
    ///     Draws the duty heading.
    /// </summary>
    /// <param name="duty"> The duty to draw information for. </param>
    public static void Draw(Duty duty)
    {
        try
        {
            var dutyName = duty.Name;
            if (duty.Difficulty != (int)DutyDifficulty.Normal) dutyName = $"{duty.Name} ({Enum.GetName(typeof(DutyDifficulty), duty.Difficulty)})";
            Common.TextHeading(TStrings.DutyHeadingTitle(dutyName));
        }
        catch (Exception e) { ImGui.TextColored(Colours.Error, $"Component Exception: {e.Message}"); }
    }
}