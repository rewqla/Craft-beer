using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Craft_beer_backend.Entities
{
    public class DbUser : IdentityUser<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public int RoleId { get; set; }
        public DbRole Role { get; set; }
        public IEnumerable<CustomerInfo> CustomerInfos { get; set; }
        public virtual ICollection<DbUserRole> UserRoles { get; set; }
    }
}
