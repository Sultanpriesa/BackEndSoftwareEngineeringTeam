using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using tablApi.Data;

namespace tablApi.Services;

public class ClassEntryBackgroundService : BackgroundService
{
    private readonly ILogger<ClassEntryBackgroundService> _logger;
    private readonly IServiceProvider _serviceProvider;

    public ClassEntryBackgroundService(
        ILogger<ClassEntryBackgroundService> logger,
        IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    var generator = scope.ServiceProvider.GetRequiredService<ClassEntryGenerator>();

                    await generator.GenerateClassEntries();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while generating class entries.");
            }

            // Wait for 24 hours before the next run
            await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
        }
    }
} 