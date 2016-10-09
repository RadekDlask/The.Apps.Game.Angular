namespace The.Apps.Game.Core.Data.Models.Users
{
    public class User : NamedModelBase
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }        
    }
}
