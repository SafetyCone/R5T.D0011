using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0011.Default;


namespace R5T.D0011.Standard
{
    public static class IServiceCollectionExtension
    {
        /// <summary>
        /// Adds the <see cref="IProcessStartTimeUtcProvider"/> service.
        /// </summary>
        public static IServiceCollection AddProcessStartTimeUtcProvider(this IServiceCollection services)
        {
            services.AddDefaultProcessStartTimeUtcProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IProcessStartTimeUtcProvider"/> service.
        /// </summary>
        public static ServiceAction<IProcessStartTimeUtcProvider> AddProcessStartTimeUtcProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IProcessStartTimeUtcProvider>.New(() => services.AddProcessStartTimeUtcProvider());
            return serviceAction;
        }
    }
}
