using System;
using System.Threading.Tasks;


namespace R5T.D0011
{
    public static class IProcessStartTimeUtcProviderExtensions
    {
        public static async Task<DateTime> GetProcessStartTimeLocalAsync(this IProcessStartTimeUtcProvider processStartTimeUtcProvider)
        {
            var processStartTimeUtc = await processStartTimeUtcProvider.GetProcessStartTimeUtcAsync();

            var processStartTimeLocal = processStartTimeUtc.ToLocalTime();
            return processStartTimeLocal;
        }
    }
}
