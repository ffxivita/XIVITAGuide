using XIVITAGuide.Attributes;

namespace XIVITAGuide.IPC
{
    /// <summary>
    ///     Contains all IPC IDs for the plugin which are automatically added to the UI.
    /// </summary>
    internal enum IPCProviders
    {
        [Description("Integrate with Wotsit to provide search capibilities.")]
        Wotsit = 0,

        // [Description("Integrate with Tippy to provide awful tooltips.")]
        // Tippy
    }
}
