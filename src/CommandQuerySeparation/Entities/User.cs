using System.ComponentModel.DataAnnotations;

namespace CommandQuerySeparation.Entities
{
    public class User
    {
        [Required]
        public string Id { get; set; }
    }
}
