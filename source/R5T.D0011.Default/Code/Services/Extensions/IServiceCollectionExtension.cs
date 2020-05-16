using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0011.Default
{
    public static class IServiceCollectionExtension
    {
        /// <summary>
        /// Adds the <see cref="ProcessStartTimeUtcProvider"/> implmentation of <see cref="IProcessStartTimeUtcProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultProcessStartTimeUtcProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProcessStartTimeUtcProvider, ProcessStartTimeUtcProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ProcessStartTimeUtcProvider"/> implmentation of <see cref="IProcessStartTimeUtcProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IProcessStartTimeUtcProvider> AddDefaultProcessStartTimeUtcProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IProcessStartTimeUtcProvider>.New(() => services.AddDefaultProcessStartTimeUtcProvider());
            return serviceAction;
        }
    }
}
