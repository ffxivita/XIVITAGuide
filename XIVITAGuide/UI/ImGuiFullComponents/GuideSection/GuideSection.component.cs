using System;
using System.Collections.Generic;
using System.Numerics;
using ImGuiNET;
using XIVITAGuide.Localization;
using XIVITAGuide.Types;
using XIVITAGuide.UI.ImGuiBasicComponents;
using XIVITAGuide.UI.ImGuiFullComponents.MechanicTable;

namespace XIVITAGuide.UI.ImGuiFullComponents.GuideSection
{
    /// <summary>
    ///     A component for displaying guide section information.
    /// </summary>
    internal static class GuideSectionComponent
    {
        /// <summary>
        ///     Draws the guide sections for the given guide.
        /// </summary>
        /// <param name="sections"></param>
        public static void Draw(List<Guide.Section> sections)
        {
            try
            {
                if (ImGui.BeginTabBar("##GuideSectionComponentTabs", ImGuiTabBarFlags.FittingPolicyScroll | ImGuiTabBarFlags.TabListPopupButton))
                {
                    foreach (var section in sections)
                    {
                        if (ImGui.BeginTabItem(section.Name))
                        {
                            if (section.Phases == null || section.Phases.Count == 0)
                            {
                                Colours.TextWrappedColoured(Colours.Warning, "No phase data found for this section.");
                            }

                            else if (ImGui.BeginTabBar("##GuideSectionComponentPhaseTabs", ImGuiTabBarFlags.FittingPolicyScroll | ImGuiTabBarFlags.TabListPopupButton))
                            {
                                foreach (var phase in section.Phases)
                                {
                                    var hasContent = false;

                                    if (ImGui.BeginTabItem($"Phase {phase.TitleOverride ?? (section.Phases.IndexOf(phase) + 1).ToString()}"))
                                    {
                                        ImGui.BeginChild($"##GuideSectionComponentPhaseTabsChild#{section.Name}{section.Phases.IndexOf(phase)}");

                                        // Draw strategy.
                                        if (!string.IsNullOrEmpty(phase.Strategy?.Trim()) || !string.IsNullOrEmpty(phase.StrategyShort?.Trim()))
                                        {
                                            Common.TextHeading(TGenerics.Strategy);

                                            if (GuideSectionPresenter.Configuration.Accessiblity.ShortenGuideText && !string.IsNullOrEmpty(phase.StrategyShort?.Trim()))
                                            {
                                                ImGui.TextWrapped(phase.StrategyShort);
                                            }
                                            else if (string.IsNullOrEmpty(phase.Strategy?.Trim()) && !string.IsNullOrEmpty(phase.StrategyShort?.Trim()))
                                            {
                                                ImGui.TextWrapped(phase.StrategyShort);
                                            }
                                            else
                                            {
                                                ImGui.TextWrapped(phase.Strategy);
                                            }
                                            hasContent = true;
                                        }

                                        // Draw mechanics
                                        if (phase.Mechanics != null)
                                        {
                                            ImGui.Dummy(new Vector2(0, 5));
                                            Common.TextHeading(TGenerics.Mechanics);
                                            MechanicTableComponent.Draw(phase.Mechanics);
                                            hasContent = true;
                                        }

                                        // Draw notes
                                        if (phase.Notes != null && phase.Notes.Count > 0)
                                        {
                                            ImGui.Dummy(new Vector2(0, 5));
                                            Common.TextHeading(TGenerics.Notes);
                                            foreach (var note in phase.Notes)
                                            {
                                                if (string.IsNullOrEmpty(note.Text?.Trim()) && string.IsNullOrEmpty(note.TextShort?.Trim()))
                                                {
                                                    continue;
                                                }

                                                if (GuideSectionPresenter.Configuration.Accessiblity.ShortenGuideText && !string.IsNullOrEmpty(note.TextShort?.Trim()))
                                                {
                                                    ImGui.TextWrapped($"- {note.TextShort}");
                                                }
                                                else if (string.IsNullOrEmpty(note.Text?.Trim()) && !string.IsNullOrEmpty(note.TextShort?.Trim()))
                                                {
                                                    ImGui.TextWrapped($"- {note.TextShort}");
                                                }
                                                else
                                                {
                                                    ImGui.TextWrapped($"- {note.Text}");
                                                }
                                            }

                                            hasContent = true;
                                        }

                                        if (!hasContent)
                                        {
                                            ImGui.TextWrapped(TGuideViewer.NoPhaseInfoAvailable);
                                        }

                                        ImGui.EndChild();
                                        ImGui.EndTabItem();
                                    }
                                }
                                ImGui.EndTabBar();
                            }
                            ImGui.EndTabItem();
                        }
                    }
                    ImGui.EndTabBar();
                }
            }
            catch (Exception e) { ImGui.TextColored(Colours.Error, $"Component Exception: {e.Message}"); }
        }
    }
}
