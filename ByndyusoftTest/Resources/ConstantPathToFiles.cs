using System.Reflection;

namespace ByndyusoftTest.Resources
{
    public static class ConstantPathToFiles
    {
        public static string ConfigurationFile { get; } = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Resources\configuration.json";
    }
}
