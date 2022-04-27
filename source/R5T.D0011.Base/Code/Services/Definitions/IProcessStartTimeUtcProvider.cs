using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0011
{
    [ServiceDefinitionMarker]
    public interface IProcessStartTimeUtcProvider : IServiceDefinition
    {
        Task<DateTime> GetProcessStartTimeUtcAsync();
    }
}
