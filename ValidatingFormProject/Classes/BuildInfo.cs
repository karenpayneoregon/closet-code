

using System;
using System.Reflection;

namespace ValidatingFormProject.Classes
{
    public static class BuildInfo
    {
        private const long              BUILD_DATE_BINARY_UTC       = 0x48da328cde293691;    // May 10, 2022 1:56:23.039963 PM UTC

        private static AssemblyName     BuildAssemblyName { get; }  = Assembly.GetExecutingAssembly().GetName();
        public static DateTimeOffset    BuildDateUtc { get; }       = DateTime.FromBinary(BUILD_DATE_BINARY_UTC);
        public static string            ModuleText { get; }         =  BuildAssemblyName.Name;
        public static string            VersionText { get; }        = "v" + BuildAssemblyName.Version.ToString()
#if DEBUG
                                                                                + " [DEBUG]"
#endif
                                                                                ;

        public static string            BuildDateText { get; }      = "Tuesday, May 10, 2022 1:56:23 PM UTC";
        public static string            DisplayText { get; }        = $"{ModuleText} {VersionText} (Build Date: {BuildDateText})";
    }
}