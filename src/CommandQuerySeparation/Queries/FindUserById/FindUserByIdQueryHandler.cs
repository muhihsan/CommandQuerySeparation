using CommandQuerySeparation.Entities;
using System.Linq;

namespace CommandQuerySeparation.Queries
{
    public class FindUserByIdQueryHandler : IQueryHandler<FindUserByIdQuery, User>
    {
        private readonly Db _db;

        public FindUserByIdQueryHandler(Db db)
        {
            _db = db;
        }

        public User Handle(FindUserByIdQuery query)
        {
            return _db.Users?.FirstOrDefault(u => u.Id == query.Id);
        }
    }
}
