using Microsoft.AspNetCore.Identity;

namespace Craft_beer_backend.Entities
{
    public class DbUserRole : IdentityUserRole<long>
    {
        public virtual DbUser User { get; set; }
        public virtual DbRole Role { get; set; }
    }
}
