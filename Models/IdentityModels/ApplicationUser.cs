
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = "Jack";
        public int Zip { get; set; }
        public string Location { get; set; } = "The Lab";

        public DateTime DateCreated { get; set; }
        [NotMapped]
        public string? RoleId { get; set; }
        [NotMapped]
        public string? Role { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? RoleList { get; set; }
    }
}
