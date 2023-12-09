using System.ComponentModel.DataAnnotations;

namespace Guildpoint.Core
{
    public abstract class Entity
    {
        [Key]
        public string Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
