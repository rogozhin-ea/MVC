using Microsoft.AspNetCore.Identity;

namespace MvcMovie.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
