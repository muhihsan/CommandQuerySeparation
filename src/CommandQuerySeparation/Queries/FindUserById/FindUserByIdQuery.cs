using CommandQuerySeparation.Entities;
using System.ComponentModel.DataAnnotations;

namespace CommandQuerySeparation.Queries
{
    public class FindUserByIdQuery : IQuery<User>
    {
        [Required]
        public string Id { get; set; }
    }
}
