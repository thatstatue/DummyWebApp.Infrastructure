using DummyWebApp.Application.Common.Interfaces;
using DummyWebApp.DataAccess.Data;
using DummyWebApp.Domain.Entities;
using System.Linq.Expressions;

namespace DummyWebApp.Infrastructure.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        //private readonly ApplicationDbContext _context;
        public VillaNumberRepository(ApplicationDbContext context) : base(context)
        {
          //  _context = context;

        }

        public bool Any(Func<VillaNumber, bool> filter)
        {
            return _set.Any(filter);
        }

    }
}
