using Conesoft.Plugin.TrayIcon.Features.TrayIcon.Services;

namespace Conesoft.Plugin.TrayIcon.Features.TrayIcon.Extensions;

static class AddTrayIconExtensions
{
    public static HostApplicationBuilder AddTrayIcon(this HostApplicationBuilder builder)
    {
        builder.Services.AddHostedService<TrayIconService>();
        return builder;
    }
}