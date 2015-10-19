namespace BrunchTaskRunner
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidBrunchPackageString = "4da50b2f-e51e-448a-8fa7-cdb0a5013ee9";
        public const string guidBrunchPackageCmdSetString = "8a146367-3169-459c-80ed-3c012ec0e380";
        public const string guidTaskRunnerExplorerCmdSetString = "9e78b319-2142-4381-873c-6ec83f092915";
        public static Guid guidBrunchPackage = new Guid(guidBrunchPackageString);
        public static Guid guidBrunchPackageCmdSet = new Guid(guidBrunchPackageCmdSetString);
        public static Guid guidTaskRunnerExplorerCmdSet = new Guid(guidTaskRunnerExplorerCmdSetString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int cmdDebug = 0x0100;
        public const int IDG_TASKRUNNER_TOOLBAR_CUSTOM_COMMANDS = 0x2002;
    }
}