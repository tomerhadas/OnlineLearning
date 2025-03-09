namespace Online_Learning_Project;

static class AppConfig
{
    public static readonly string ConnectionString;

    static AppConfig()
    {
        IConfigurationRoot settings = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        ConnectionString = settings.GetConnectionString("OnlineLearning")!;
    }
}
