using Microsoft.AspNet.Identity.EntityFramework;

namespace CustomOAuthTutorial.WebAPI.Models
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext", throwIfV1Schema: false)
        {
        }

        public static AuthContext Create()
        {
            return new AuthContext();
        }
    }
}