using Blauhaus.Reactive.Abstractions.Schedulers;
using Blauhaus.Reactive.Schedulers;
using Microsoft.Extensions.DependencyInjection;

namespace Blauhaus.Reactive._Ioc
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddReactiveScheduler(this IServiceCollection services)
        {
            services.AddTransient<IReactiveSchedulers, ReactiveSchedulers>();
            return services;
        }
    }
}