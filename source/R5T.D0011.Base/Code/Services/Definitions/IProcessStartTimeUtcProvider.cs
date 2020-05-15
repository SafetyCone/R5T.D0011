using System;
using System.Threading.Tasks;


namespace R5T.D0011
{
    public interface IProcessStartTimeUtcProvider
    {
        Task<DateTime> GetProcessStartTimeUtcAsync();
    }
}
