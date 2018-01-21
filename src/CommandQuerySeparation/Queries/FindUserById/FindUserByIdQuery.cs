using CommandQuerySeparation.Entities;

namespace CommandQuerySeparation.Queries
{
    public class FindUserByIdQuery : IQuery<User>
    {
        public string Id { get; set; }
    }
}
