using Abp.Application.Services.Dto;

namespace Assessment.GlobalKinetic.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

