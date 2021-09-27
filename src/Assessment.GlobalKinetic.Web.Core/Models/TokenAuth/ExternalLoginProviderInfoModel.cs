using Abp.AutoMapper;
using Assessment.GlobalKinetic.Authentication.External;

namespace Assessment.GlobalKinetic.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
