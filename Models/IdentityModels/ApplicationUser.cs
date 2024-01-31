
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.DataModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; } 
        public string? StreetAddress { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; } 
        public string? State { get; set; } 

        public DateTime DateCreated { get; set; }
        [NotMapped]
        public string? RoleId { get; set; }
        [NotMapped]
        public string? Role { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? RoleList { get; set; }
        public int? CompanyId { get; set; }
        [ValidateNever]
        public Company Company { get; set; }
    }
}
