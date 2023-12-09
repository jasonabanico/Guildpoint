using System.ComponentModel.DataAnnotations;

namespace Guildpoint.Core
{
    public class User : Item
    {
        [Required]
        public string Username { get; set; } = string.Empty;
    }
}
