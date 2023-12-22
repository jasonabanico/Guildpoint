namespace Guildpoint.Configuration
{
    public class ConfigurationItems
    {
        public string Module { get; set; } = string.Empty;
        public Dictionary<string, string> Items { get; set; } = new Dictionary<string, string>();
    }
}
