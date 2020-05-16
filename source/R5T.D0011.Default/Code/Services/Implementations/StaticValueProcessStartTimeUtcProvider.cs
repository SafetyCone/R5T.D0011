using System;
using System.Threading.Tasks;


namespace R5T.D0011.Default
{
    public class StaticValueProcessStartTimeUtcProvider : IProcessStartTimeUtcProvider
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
