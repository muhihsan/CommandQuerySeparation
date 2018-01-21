using System.Collections.Generic;

namespace CommandQuerySeparation.Entities
{
    public class Db
    {
        public IList<User> Users { get; set; }

        public Db()
        {
            Users = new List<User>
            {
                new User
                {
                    Id = "1"
                },
                new User
                {
                    Id = "2"
                }
            };
        }
    }
}
