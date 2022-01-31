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
    public class UserService:IUserService
    {
        private readonly IUserDal _userDal;
        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Create(LoginViewModel userLoginView)
        {

            User user = new User { Email = userLoginView.Email, Password = userLoginView.Password };
            _userDal.Add(user);
        }

        public Task<int> Delete(DeleteViewModel deleteViewModel)
        {
            var data=_userDal.GetById(deleteViewModel.Id);
            var affectedRow = _userDal.Delete(data.Result);
            return affectedRow;
           
        }

        public Task<IList<User>> Get(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll()
        {
           return _userDal.GetAll();
            
        }

        public Task<User> GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public async Task<int> Update(int id,UpdateViewModel updateViewModel)
        {
            var selectedUser = _userDal.GetById(id);
            selectedUser.Result.Name = updateViewModel.Name;
            selectedUser.Result.Email = updateViewModel.Email;
            selectedUser.Result.Password = updateViewModel.Password;
            selectedUser.Result.RoleId = updateViewModel.RoleId;
            return await _userDal.Update(selectedUser.Result);
        }
    }
}
