using System.ComponentModel.DataAnnotations;

namespace Guildpoint.Core
{
    public class UserAction : Item
    {
        [Required]
        public string NodeId { get; set; } = string.Empty;
        [Required]
        public string UserId { get; set; } = string.Empty;
    }
}
