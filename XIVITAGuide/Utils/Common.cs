namespace XIVITAGuide.Utils;

using System.Diagnostics;

/// <summary>
///     A collection of common reusable utility functions.
/// </summary>
public class Common
{
    /// <summary> 
    ///     Open a link in the default browser.
    /// </summary>
    /// <param name="url"> The url to open. </param>
    public static void OpenBrowser(string url)
    {
        Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
    }
}