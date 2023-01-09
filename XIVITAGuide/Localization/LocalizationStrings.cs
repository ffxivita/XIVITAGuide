using CheapLoc;
using XIVITAGuide.Base;

namespace XIVITAGuide.Localization
{
    /// <summary>
    ///     A collection translatable Command Help strings.
    /// </summary>
    internal sealed class TCommands
    {
        internal static string GuideListHelp => Loc.Localize("Commands.DutyList.Help", "Mostra la lista delle guide");
        internal static string SettingsHelp => Loc.Localize("Commands.Settings.Help", "Mostra il menu delle impostazioni");
        internal static string EditorHelp => Loc.Localize("Commands.Editor.Help", "Apri o Chiudi l'editor della guida");
        internal static string InfoHelp => Loc.Localize("Commands.Info.Help", "Apri o Chiudi la finestra delle guide");
    }

    /// <summary>
    ///     A collection of translatable window strings.
    /// </summary>
    internal sealed class TWindowNames
    {
        internal static string Settings => string.Format(Loc.Localize("Window.Settings", "{0} - Settings"), PluginConstants.PluginName);
        internal static string GuideList => string.Format(Loc.Localize("Window.GuideList", "{0} - Guide List"), PluginConstants.PluginName);
        internal static string GuideViewer => string.Format(Loc.Localize("Window.GuideViewer", "{0} - Guide Viewer"), PluginConstants.PluginName);
        internal static string GuideEditor => string.Format(Loc.Localize("Window.GuideEditor", "{0} - Guide Editor"), PluginConstants.PluginName);
    }

    /// <summary>
    ///     Translation strings used in the plugin.
    /// </summary>
    internal static class TGenerics
    {
        internal static string Donate => Loc.Localize("Generics.Donate", "Dona");
        internal static string OpenFile => Loc.Localize("Generics.OpenFile", "Apri File");
        internal static string SaveFile => Loc.Localize("Generics.SaveFile", "Salva File");
        internal static string Search => Loc.Localize("Generics.Search", "Cerca");
        internal static string Guide => Loc.Localize("Generics.Guide", "Guide");
        internal static string InDuty => Loc.Localize("Generics.InDuty", "In Duty");
        internal static string Mechanic => Loc.Localize("Generics.Mechanic", "Meccanica");
        internal static string Mechanics => Loc.Localize("Generics.Mechanics", "Meccaniche");
        internal static string Strategy => Loc.Localize("Generics.Strategy", "Strategia");
        internal static string Notes => Loc.Localize("Generics.Notes", "Note");
        internal static string Description => Loc.Localize("Generics.Description", "Descrizione");
        internal static string Level => Loc.Localize("Generics.Level", "Livello");
        internal static string Type => Loc.Localize("Generics.Type", "Tipo");
        internal static string Enabled => Loc.Localize("Generics.Enabled", "Abilitato");
        internal static string Disabled => Loc.Localize("Generics.Disabled", "Disabilitato");
        internal static string Unknown => Loc.Localize("Generics.Unknown", "Sconosciuto");
        internal static string Unspecified => Loc.Localize("Generics.Unspecified", "Non specificato");
        internal static string None => Loc.Localize("Generics.None", "Nessuno");
        internal static string InTerritory => Loc.Localize("Generics.InTerritory", "In Territory");
        internal static string Note => Loc.Localize("Generics.Note", "Note");
        internal static string Tips => Loc.Localize("Generics.Tips", "Tips");
    }

    /// <summary>
    ///     Translation strings used for the Guide type.
    /// </summary>
    internal static class TGuide
    {
        internal static string DutyUnnamed => Loc.Localize("Types.Duty.Name.None", "Guida senza nome");
        internal static string NoStrategy => Loc.Localize("Guide.NoStrategy", "Nessuna strategia disponibile.");
    }

    /// <summary>
    ///    Translation strings used in the Editor.
    /// </summary>
    internal static class TEditor
    {
        internal static string Problems => Loc.Localize("Editor.Problems", "Problemi");
        internal static string Preview => Loc.Localize("Editor.Preview", "Preview");
        internal static string Clear => Loc.Localize("Editor.Clear", "Pulisci");
        internal static string Format => Loc.Localize("Editor.Format", "Formatta");
        internal static string Metadata => Loc.Localize("Editor.Metadata", "Metadata");
        internal static string EnumList => Loc.Localize("Editor.EnumList", "Lista Enum");
        internal static string CannotParseNoPreview => Loc.Localize("Editor.CannotParse", "Non riesco a leggere il file, non posso visualizzare una anteprima.");
        internal static string ContributingGuide => Loc.Localize("Editor.ContributingGuide", "Guida alla contribuzione");
        internal static string ProblemUnsupported => Loc.Localize("Editor.Problem.Unsupported", "La guida contiente ID Invalidi o non supportati da questa versione.");
        internal static string NoProblems => Loc.Localize("Editor.Problem.None", "Nessun problema rilevato.");
        internal static string FileTooLarge => Loc.Localize("Editor.FileTooBig", "Il tuo file pesa troppo per essere caricato dentro questo editor.");
        internal static string FileSuccessfullyLoaded => Loc.Localize("Editor.FileLoaded", "File caricato con successo.");
        internal static string FileSuccessfullySaved => Loc.Localize("Editor.FileSaved", "File salvato con successo.");
    }

    /// <summary>
    ///     Translation strings used in the Settings.
    /// </summary>
    internal static class TSettings
    {
        internal static string Configuration => Loc.Localize("Settings.Configuration", "Configurazione");
        internal static string AutoOpenGuideForDuty => Loc.Localize("Settings.AutOpenGuideForDuty", "Apri guida quando in Duty");
        internal static string SettingsAutoOpenInDutyTooltip => Loc.Localize("Settings.AutoOpenDuty.Tooltip", "Apre la guida associata appena si entra in duty e la chiude quando si esce.");
        internal static string ShortenGuideText => Loc.Localize("Settings.ShortedGuideText", "Riassunto Guida");
        internal static string ShortenGuideTextTooltip => Loc.Localize("Settings.ShortenGuideText.Tooltip", "Riassume il testo nelle guide quando possibile per renderle più accessibili e salvare spazio.");
        internal static string ShowDonateButton => Loc.Localize("Settings.ShowDonateButton", "Mostra il pulsante di donazione");
        internal static string ShowDonateButtonTooltip => Loc.Localize("Settings.ShowDonateButton.Tooltip", "Mostra il pulsante di donazione per aiutare lo sviluppo di questo plugin.");
        internal static string HideLockedGuides => Loc.Localize("Settings.HideLockedGuides", "Nascondi guide per duty non ancora sbloccati");
        internal static string HideLockedGuidesTooltip => Loc.Localize("Settings.HideLockedGuides.Tooltip", "Nascondee le guide per i duty non ancora sbloccati.\nATTENZIONE: impostandolo su OFF, vedrete tutte le guide. Anche quelle per i duty non ancora sbloccati.");
        internal static string HiddenMechanics => Loc.Localize("Settings.HiddenMechanics", "Meccaniche nascoste");
        internal static string HiddenMechanicsTooltip => Loc.Localize("Settings.HiddenMechanics.Tooltip", "Nasconde la tipologia delle meccaniche, nascondendole così dalle guide.");
        internal static string EnabledIntegrations => Loc.Localize("Settings.EnabledIntegrations", "Integrazioni Abilitate");
        internal static string EnabledIntegrationsTooltip => Loc.Localize("Settings.EnabledIntegrations.Tooltip", "Abilita o Disabilita le integrazioni con altri plugin. Ovviamente i plugin abilitati devono essere prima installati.");
    }

    /// <summary>
    ///     Translation strings used in the Guide viewer window.
    /// </summary>
    internal static class TGuideViewer
    {
        internal static string NoGuideInfoAvailable => Loc.Localize("GuideViewer.NoGuideInfoAvailable", "Non ci sono informazioni disponili per questa guida al momento.");
        internal static string NoPhaseInfoAvailable => Loc.Localize("GuideViewer.NoPhaseInfoAvailable", "Non ci sono informazioni disponibili per questa fase al momento.");
        internal static string ReportIssueWithGuide => Loc.Localize("GuideViewer.ReportIssueWithGuide", "Riporta un problema con questa guida");
        internal static string UnlockWindowMovement => Loc.Localize("GuideViewer.UnlockWindowMovement", "Sblocca Finestra");
        internal static string LockWindowMovement => Loc.Localize("GuideViewer.LockWindowMovement", "Blocca Finestra");
        internal static string ToggleSettingsWindow => Loc.Localize("GuideViewer.ToggleSettingsWindow", "Mostra o nasconde il menù della finesta.");
        internal static string GuideHeading(string guideName) => string.Format(Loc.Localize("GuideViewer.GuideHeading", "Guida per {0}"), guideName);
        internal static string NoGuideSelected => Loc.Localize("GuideViewer.NoGuideSelected", "Non hai selezionato una guida, usa /xivita-list per vedere tutte le guide presenti.");
        internal static string GuideNotUnlocked => Loc.Localize("GuideViewer.GuideInfoNotUnlocked", "Non puoi vedere la guida per questo Duty perchè non lo hai ancora sbloccato.");
        internal static string GuideAvailableForDuty => Loc.Localize("GuideViewer.GuideAvailableForDuty", "Esiste una guida per questa duty. Use /xivita-info per vederla.");
        internal static string Lore => Loc.Localize("GuideViewer.Lore", "Lore");
    }

    /// <summary>
    ///     Translation strings used in the guide list window.
    /// </summary>
    internal static class TGuideListTable
    {
        internal static string NoneFoundForType => Loc.Localize("GuideListTable.NoneFoundForType", "Non ci sopno guide per questa tipologia di Duty.");
        internal static string NoGuidesUnlocked => Loc.Localize("GuideListTable.NoGuidesUnlocked", "Non hai ancora sbloccato guide per questa tipologia di Duty.");
        internal static string NoGuidesFoundForSearch => Loc.Localize("GuideListTable.NoGuidesFoundForSearch", "Non ho trovato guide dalla tua ricerca.");
        internal static string UnsupportedGuide(string guideName) => string.Format(Loc.Localize("GuideListTable.UnsupportedGuide", "La guida per {0} è per una versione differente del plugin e non può essere caricata"), guideName);
        internal static string NoGuideData(string guideName) => string.Format(Loc.Localize("GuideListTable.NoGuideData", "Non ho informazioni per {0} al momento."), guideName);
        internal static string NoGuidesFilesDetected => Loc.Localize("GuideListTable.NoGuidesFilesDetected", "Non ho trovato guide installate. Controlla la tua installazione.");
    }
}
