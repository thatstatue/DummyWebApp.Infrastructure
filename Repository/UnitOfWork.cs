using DummyWebApp.Application.Common.Interfaces;
using DummyWebApp.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyWebApp.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context) {
            _context = context;
            Villa = new VillaRepository(context);
            VillaNumber = new VillaNumberRepository(context);
            Amenity = new AmenityRepository(context);
            Booking = new BookingRepository(context);
            ApplicationUser = new ApplicationUserRepository(context);

        }
        public IVillaRepository Villa { get; private set; }
        public IVillaNumberRepository VillaNumber { get; private set; }

        public IAmenityRepository Amenity { get; private set; }
        public IBookingRepository Booking { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
    }
}
