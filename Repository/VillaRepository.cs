using DummyWebApp.Application.Common.Interfaces;
using DummyWebApp.DataAccess.Data;
using DummyWebApp.Domain.Entities;
using System.Web.Mvc;

namespace DummyWebApp.Infrastructure.Repository
{
    public class VillaRepository : Repository<Villa>,IVillaRepository
    {
      //  private readonly ApplicationDbContext _context;
        public VillaRepository(ApplicationDbContext context) : base(context) { 
            //_context = context;
        }
     
    }
}
