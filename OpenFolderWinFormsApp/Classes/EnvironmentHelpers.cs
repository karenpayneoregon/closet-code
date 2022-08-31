using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.Versioning;

namespace OpenFolderWinFormsApp.Classes;

public static class EnvironmentHelpers
{

    /// <summary>
    /// Open folder using windows explorer
    /// </summary>
    /// <param name="folder">folder to open</param>
    /// <remarks>
    /// when using .net core the executable must be specified
    /// </remarks>
    public static void OpenFolderWithExplorer(string folder)
    {

        if (string.IsNullOrWhiteSpace(folder)) return;
        if (!Directory.Exists(folder)) return;

        if (IsNetCore())
        {
            _ = Process.Start("explorer.exe", folder);
        }
        else
        {
            _ = Process.Start(folder);
        }
    }


    /// <summary>
    /// Determine if .NET Framework or .NET Core Framework at runtime
    /// </summary>
    /// <returns>true if core, false if classic framework</returns>
    /// <remarks>
    /// Other options are reading windows registry but not all users have read permissions to the registry
    /// </remarks>
    public static bool IsNetCore()
    {
        var value = Assembly.GetEntryAssembly()?.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName.Contains("Core");
        if (value.HasValue)
        {
            return value.Value;
        }
        else
        {
            throw new Exception($"{nameof(IsNetCore)} failed to determine runtime framework.");
        }

    }
}
