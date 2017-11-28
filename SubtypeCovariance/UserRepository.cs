using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    //changed class to use an interface with a generic type.  ----prv 11/27/17
    public class UserRepository : IEntityRepository<User>
    {
        //public override Entity GetByID(Guid id)
        
        //removed override from method signature ----prv 11/27/17
        public User GetByID(Guid id)
        {
            return new User(id);
        }
    }
}
