using System;
using System.Diagnostics;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0011.Default
{[ServiceImplementationMarker]
    public class ProcessStartTimeUtcProvider : IProcessStartTimeUtcProvider,IServiceImplementation
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
