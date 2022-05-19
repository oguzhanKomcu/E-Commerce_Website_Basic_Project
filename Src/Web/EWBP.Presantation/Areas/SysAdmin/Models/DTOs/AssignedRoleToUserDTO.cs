using EWBP.Domain.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace EWBP.Presantation.Areas.SysAdmin.Models.DTOs
{
    public class AssignedRoleToUserDTO
    {
        public IdentityRole Role { get; set; }

        public IEnumerable<AppUser> HasRole { get; set; }
        public IEnumerable<AppUser> HasNoRole { get; set; }

        public string RoleName { get; set; }

        public string[] AddIds { get; set; }
        public string[] RemoveIds { get; set; }
    }
}
