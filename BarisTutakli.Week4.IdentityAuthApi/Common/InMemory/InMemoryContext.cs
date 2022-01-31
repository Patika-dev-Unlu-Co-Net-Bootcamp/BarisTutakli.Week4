using BarisTutakli.Week4.IdentityAuthApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarisTutakli.Week4.IdentityAuthApi.Common.InMemory
{
    public class InMemoryContext:DbContext
    {
       
        public InMemoryContext(DbContextOptions<InMemoryContext> options) :base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
