namespace XIVITAGuide.Interfaces;

using System;
using XIVITAGuide.Managers.IPC;

/// <summary>
///     Provides a common interface that IPC providers must implement to be used by the plugin.
/// </summary>
public interface IIPCProvider : IDisposable
{
    IPCProviders ID { get; }
}