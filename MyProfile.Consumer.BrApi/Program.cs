using MyProfile.Consumer.BrApi;
using MyProfile.Infra.IoC;
using MyProfile.Shared;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostBuilder, services) =>
    {
        var settings = MyProfileSettings.GetInstance();
        hostBuilder.Configuration.GetSection("ConnectionStrings").Bind(settings);
        hostBuilder.Configuration.GetSection("AppSettings").Bind(settings);

        services.AddRepositoriesDependencies();
        services.AddServicesDependencies();
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
