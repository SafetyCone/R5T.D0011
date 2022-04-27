using System;
using System.Diagnostics;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0011.Default
{
    [ServiceImplementationMarker]
    public class OffsetProcessStartTimeUtcProvider : IProcessStartTimeUtcProvider, IServiceImplementation
    {
        #region Static

        public static OffsetProcessStartTimeUtcProvider NewFromOffset(TimeSpan offset)
        {
            var offsetProcessStartTimeUtcProvider = new OffsetProcessStartTimeUtcProvider(offset);
            return offsetProcessStartTimeUtcProvider;
        }

        /// <summary>
        /// Uses the <see cref="OffsetProcessStartTimeUtcProvider.NewFromOffset(TimeSpan)"/> as the default.
        /// </summary>
        public static OffsetProcessStartTimeUtcProvider New(TimeSpan offset)
        {
            var offsetProcessStartTimeUtcProvider = OffsetProcessStartTimeUtcProvider.NewFromOffset(offset);
            return offsetProcessStartTimeUtcProvider;
        }

        public static OffsetProcessStartTimeUtcProvider NewFromDesiredNowUtc(DateTime desiredNowUtc)
        {
            var offset = DateTime.UtcNow - desiredNowUtc;

            var offsetProcessStartTimeUtcProvider = OffsetProcessStartTimeUtcProvider.NewFromOffset(offset);
            return offsetProcessStartTimeUtcProvider;
        }

        public static OffsetProcessStartTimeUtcProvider NewFromDesiredNowLocal(DateTime desiredNowLocal)
        {
            var offset = DateTime.Now - desiredNowLocal;

            var offsetProcessStartTimeProvider = OffsetProcessStartTimeUtcProvider.NewFromOffset(offset);
            return offsetProcessStartTimeProvider;
        }

        #endregion


        private TimeSpan Offset { get; }


        public OffsetProcessStartTimeUtcProvider(
            [NotServiceComponent] TimeSpan offset)
        {
            this.Offset = offset;
        }

        public Task<DateTime> GetProcessStartTimeUtcAsync()
        {
            var currentProcess = Process.GetCurrentProcess();

            var currentProcessStartTime = currentProcess.StartTime;

            var currentProcessStartTimeUtc = currentProcessStartTime.ToUniversalTime();

            var offsetCurrentProcessStartTimeUtc = currentProcessStartTimeUtc + this.Offset;
            return Task.FromResult(offsetCurrentProcessStartTimeUtc);
        }
    }
}
