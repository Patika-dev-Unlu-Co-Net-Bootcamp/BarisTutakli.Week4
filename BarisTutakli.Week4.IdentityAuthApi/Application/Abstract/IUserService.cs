using BarisTutakli.Week4.IdentityAuthApi.Application.ViewModels;
using BarisTutakli.Week4.IdentityAuthApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.IdentityAuthApi.Application.Abstract
{
    public interface IUserService
    {
        public void Create(LoginViewModel userLoginView);
        public Task<List<User>> GetAll();
        public Task<int> Delete(DeleteViewModel deleteViewModel);
        public Task<int> Update(int id,UpdateViewModel updateViewModel);

        public Task<User> GetById(int id);
        public Task<IList<User>> Get(Expression<Func<User, bool>> filter);
    }
}
