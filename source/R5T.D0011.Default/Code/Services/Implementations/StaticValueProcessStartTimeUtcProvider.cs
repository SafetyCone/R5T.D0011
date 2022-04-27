using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0011.Default
{[ServiceImplementationMarker]
    public class StaticValueProcessStartTimeUtcProvider : IProcessStartTimeUtcProvider,IServiceImplementation
    {
        /// <summary>
        /// Note: not thread-safe.
        /// </summary>
        public static DateTime ProcessStartTimeUtc { get; set; }


        public Task<DateTime> GetProcessStartTimeUtcAsync()
        {
            return Task.FromResult(StaticValueProcessStartTimeUtcProvider.ProcessStartTimeUtc);
        }
    }
}
