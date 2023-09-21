using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Craft_beer_backend.Entities
{
    public class DbRole: IdentityRole<long>
    {
        public virtual ICollection<DbUserRole> UserRoles { get; set; }
    }
}
