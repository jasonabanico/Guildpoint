using System.ComponentModel.DataAnnotations;

namespace Guildpoint.Core
{
    public abstract class Item : ModifiableEntity
    {
        [Required]
        public string Type { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Metadata { get; set; } = string.Empty;
    }
}
