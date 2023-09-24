using SharpEngine.Core.Manager;

namespace SharpEngine.Python;

/// <summary>
/// Static class with extensions and add version functions
/// </summary>
public static class SEPython
{
    /// <summary>
    /// Add versions to DebugManager
    /// </summary>
    public static void AddVersions()
    {
        DebugManager.Versions.Add("SharpEngine.Python", "1.0.0");
    }
}
