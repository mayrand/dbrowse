namespace HardkorowyKodsu;

using Microsoft.Extensions.Configuration;

public class ConfigHelper
{
    private static IConfigurationRoot _configuration;

    static ConfigHelper()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        _configuration = builder.Build();
    }

    public static string GetApiHostname()
    {
        return _configuration["ApiSettings:Hostname"];
    }
}
