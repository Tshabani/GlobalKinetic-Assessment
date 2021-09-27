using System.Collections.Generic;

namespace Assessment.GlobalKinetic.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
