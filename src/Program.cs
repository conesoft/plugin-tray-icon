using Conesoft.Hosting;
using Conesoft.Plugin.TrayIcon.Features.TrayIcon.Extensions;

var builder = Host.CreateApplicationBuilder(args);

builder
    .AddHostConfigurationFiles()
    .AddHostEnvironmentInfo()
    .AddLoggingService()
    .AddNotificationService()
    .AddTrayIcon()
    ;

var host = builder.Build();
await host.RunAsync();