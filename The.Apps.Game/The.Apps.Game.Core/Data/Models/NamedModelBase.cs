using System.ComponentModel.DataAnnotations;

namespace The.Apps.Game.Core.Data.Models
{
    public class NamedModelBase
    {
        public int Id { get; set; }
        [MaxLength(14)]
        public string Name { get; set; }
    }
}
