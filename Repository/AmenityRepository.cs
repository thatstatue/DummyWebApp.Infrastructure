using DummyWebApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyWebApp.Application.Common.Interfaces;
using DummyWebApp.DataAccess.Data;


namespace DummyWebApp.Infrastructure.Repository
{
    internal class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
