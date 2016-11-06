namespace The.Apps.Game.Web.ViewModels.User
{
    public class DetailsViewModel
    {
        public string Name { get; set; }

        public AddressViewModel Address { get; set; }

        public DetailViewModel Detail { get; set; }

        public PersonalViewModel Personal { get; set; }

        public string CustomError { get; set; }
    }
}