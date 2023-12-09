using System.ComponentModel.DataAnnotations;

namespace Guildpoint.Core
{
    public abstract class AuditableEntity : Entity
    {
        [Required]
        public string CreatedBy { get; set; } = string.Empty;
        [Required]
        public DateTime CreatedDate { get; private set; }

        protected AuditableEntity() : base()
        {
            CreatedDate = DateTime.UtcNow;
        }
    }
}
