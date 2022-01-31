using BarisTutakli.Week4.IdentityAuthApi.Common.InMemory;
using BarisTutakli.Week4.IdentityAuthApi.Common.Repositories;
using BarisTutakli.Week4.IdentityAuthApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.IdentityAuthApi.Common.DataAccess
{
    public class UserDal : RepositoryBase<User>, IUserDal
    {
        public UserDal(InMemoryContext context) : base(context)
        {
        }
    }
}
