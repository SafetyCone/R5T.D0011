using System;
using System.Diagnostics;
using System.Threading.Tasks;


namespace R5T.D0011.Default
{
    public class ProcessStartTimeUtcProvider : IProcessStartTimeUtcProvider
    {
        public Task<DateTime> GetProcessStartTimeUtcAsync()
        {
            var currentProcess = Process.GetCurrentProcess();

            var currentProcessStartTime = currentProcess.StartTime;

            var currentProcessStartTimeUtc = currentProcessStartTime.ToUniversalTime();
            return Task.FromResult(currentProcessStartTimeUtc);
        }
    }
}
