using BarisTutakli.Week4.IdentityAuthApi.Application.ViewModels;
using BarisTutakli.Week4.IdentityAuthApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.IdentityAuthApi.Application.Abstract
{
    public interface IRoleService
    {
        public void Create(CreateRoleViewModel CreateRoleViewModel);
        public Task<List<Role>> GetAll();
        public Task<int> Delete(DeleteRoleViewModel deleteRoleViewModel);
        public Task<int> Update(int id, UpdateRoleViewModel updateRoleViewModel);

        public Task<Role> GetById(int id);
        public Task<IList<Role>> Get(Expression<Func<Role, bool>> filter);
    }
}
