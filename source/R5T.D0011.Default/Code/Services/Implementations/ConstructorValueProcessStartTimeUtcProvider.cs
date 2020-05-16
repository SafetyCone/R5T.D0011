using System;
using System.Threading.Tasks;


namespace R5T.D0011.Default
{
    public class ConstructorValueProcessStartTimeUtcProvider : IProcessStartTimeUtcProvider
    {
        #region Static

        public static ConstructorValueProcessStartTimeUtcProvider NewFromUtc(DateTime utcTime)
        {
            var constructorValueProcessStartTimeUtcProvider = new ConstructorValueProcessStartTimeUtcProvider(utcTime);
            return constructorValueProcessStartTimeUtcProvider;
        }

        /// <summary>
        /// Uses the <see cref="ConstructorValueProcessStartTimeUtcProvider.NewFromUtc(DateTime)"/> as the default.
        /// </summary>
        public static ConstructorValueProcessStartTimeUtcProvider New(DateTime utcTime)
        {
            var constructorValueProcessStartTimeUtcProvider = ConstructorValueProcessStartTimeUtcProvider.NewFromUtc(utcTime);
            return constructorValueProcessStartTimeUtcProvider;
        }

        public static ConstructorValueProcessStartTimeUtcProvider NewFromLocal(DateTime localTime)
        {
            var utcTime = localTime.ToUniversalTime();

            var constructorValueProcessStartTimeUtcProvider = ConstructorValueProcessStartTimeUtcProvider.NewFromUtc(utcTime);
            return constructorValueProcessStartTimeUtcProvider;
        }

        public static ConstructorValueProcessStartTimeUtcProvider NewFromOffset(TimeSpan offset)
        {
            var offsetNowUtc = DateTime.UtcNow + offset;

            var constructorValueProcessStartTimeUtcProvider = ConstructorValueProcessStartTimeUtcProvider.NewFromUtc(offsetNowUtc);
            return constructorValueProcessStartTimeUtcProvider;
        }

        #endregion


        private DateTime ProcessStartTimeUtc { get; }


        public ConstructorValueProcessStartTimeUtcProvider(DateTime processStartTimeUtc)
        {
            this.ProcessStartTimeUtc = processStartTimeUtc;
        }

        public Task<DateTime> GetProcessStartTimeUtcAsync()
        {
            return Task.FromResult(this.ProcessStartTimeUtc);
        }
    }
}
