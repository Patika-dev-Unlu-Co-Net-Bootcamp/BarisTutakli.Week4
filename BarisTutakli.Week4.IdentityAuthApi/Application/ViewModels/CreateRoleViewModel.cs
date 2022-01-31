using BarisTutakli.Week4.IdentityAuthApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.IdentityAuthApi.Application.ViewModels
{
    public class CreateRoleViewModel
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
