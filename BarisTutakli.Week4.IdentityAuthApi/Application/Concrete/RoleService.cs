using BarisTutakli.Week4.IdentityAuthApi.Application.Abstract;
using BarisTutakli.Week4.IdentityAuthApi.Application.ViewModels;
using BarisTutakli.Week4.IdentityAuthApi.Common.DataAccess;
using BarisTutakli.Week4.IdentityAuthApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.IdentityAuthApi.Application.Concrete
{
    public class RoleService : IRoleService
    {
        private readonly IRoleDal _roleDal;
        public RoleService(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void Create(CreateRoleViewModel CreateRoleViewModel)
        {

           Role role = new Role {  Name=CreateRoleViewModel.Name, Users = CreateRoleViewModel.Users };

            _roleDal.Add(role);
        }

        public Task<int> Delete(DeleteRoleViewModel deleteViewModel)
        {
            var data = _roleDal.GetById(deleteViewModel.Id);
            var affectedRow = _roleDal.Delete(data.Result);
            return affectedRow;
        }

        public Task<IList<Role>> Get(Expression<Func<Role, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<Role>> GetAll()
        {
           return  _roleDal.GetAll();
        }

        public Task<Role> GetById(int id)
        {
            return _roleDal.GetById(id);
        }

        public async Task<int> Update(int id, UpdateRoleViewModel updateViewModel)
        {
            var selectedRole = _roleDal.GetById(id);
            selectedRole.Result.Name = updateViewModel.Name;
            return await _roleDal.Update(selectedRole.Result);

        }
    }
}
