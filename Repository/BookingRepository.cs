using DummyWebApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyWebApp.Application.Common.Interfaces;
using DummyWebApp.DataAccess.Data;
using DummyWebApp.Application.Utility;


namespace DummyWebApp.Infrastructure.Repository
{
    internal class BookingRepository : Repository<Booking>, IBookingRepository
    {
        public BookingRepository(ApplicationDbContext _context) : base(_context)
        {
        }

        public void UpdateStatus(int bookingId, string bookingStatus)
        {
            var booking = _context.Bookings.FirstOrDefault(u=> u.Id == bookingId);
            if (booking!=null)
            {
                booking.Status = bookingStatus;

                if (booking.Status == SD.StatusCheckedIn)
                {
                    booking.ActualCheckInDate = DateTime.Now;
                }
                if (booking.Status == SD.StatusCompleted)
                {
                    booking.ActualCheckOutDate = DateTime.Now;
                }
            }
        }

        public void UpdatePaymentStatus(int bookingId, string sessionId, string stripePaymentId)
        {
            var booking = _context.Bookings.FirstOrDefault(u => u.Id == bookingId);
            if (booking != null)
            {
                if (!string.IsNullOrEmpty(sessionId))
                {
                    booking.StripeSessionId = sessionId;
                }
                if (!string.IsNullOrEmpty(stripePaymentId))
                {
                    booking.StripePaymentIntentId = stripePaymentId;
                    booking.IsPaymentSuccessful = true;
                    booking.PaymentDate = DateTime.Now;
                }

            }
        }
    }
}
