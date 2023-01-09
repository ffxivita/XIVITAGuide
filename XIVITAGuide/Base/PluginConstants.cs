namespace XIVITAGuide.Base
{
    /// <summary>
    ///     A collection of constants used throughout the plugin.
    /// </summary>
    internal sealed class PluginConstants
    {
        /// <summary>
        ///    This is the name that will be shown in all UI elements, does not change InternalName.
        /// </summary>
        internal const string PluginName = "XIVITA Guide";

        /// <summary>
        ///     The repository to linked to this plugin.
        /// </summary>
        internal const string RepoUrl = "https://github.com/BitsOfAByte/KikoGuide/";

        /// <summary>
        ///     The production branch of the repository.
        /// </summary>
        internal const string RepoBranch = "main";

        /// <summary>
        ///     The resources directory relative to the base of the repository.
        /// </summary>
        internal const string RepoResourcesDir = "XIVITAGuide/Resources/";

        /// <summary>
        ///     The support button URL.
        /// </summary>
        internal const string DonateButtonUrl = "https://github.com/sponsors/DarkArtek";

        /// <summary>
        ///     The path to the plugin's resources folder with trailing slashes, relative to the plugin assembly location with trailing slashes.
        /// </summary>
        internal static readonly string PluginResourcesDir = $"{PluginService.PluginInterface.AssemblyLocation.DirectoryName}\\Resources\\";

        /// <summary>
        ///     The path to the plugin's localization folder with trailing slashes.
        /// </summary>
        internal static readonly string PluginlocalizationDir = PluginResourcesDir + "Localization\\";

        /// <summary>
        ///    The fallback language to use if the user's language is not supported for localization (ISO 639-1 code).
        /// </summary>
        internal const string FallbackLanguage = "it";
    }
}
