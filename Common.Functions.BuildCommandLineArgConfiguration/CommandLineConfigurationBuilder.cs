using Microsoft.Extensions.Configuration;

namespace Common.Functions.BuildCommandLineArgConfiguration
{
    public static class CommandLineConfigurationBuilder
    {
        public static IConfigurationRoot Configuration(string[] args)
            => new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();
    }
}
