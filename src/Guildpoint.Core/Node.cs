using System.ComponentModel.DataAnnotations;

namespace Guildpoint.Core
{
    public class Node : Item
    {
        [Required]
        public string Module { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        public string ParentNodeId { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public Node() { }
    }
}
