using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet__Færdighedsprøve_
{
    internal class BookingManager
    {
        private List<Booking> bookings;
        private int nextBookingId;

        public BookingManager()
        {
            bookings = new List<Booking>();
            nextBookingId = 1;
        }

        public void AddBooking(Gruppe group, DateTime startTime, DateTime endTime)
        {
            if (startTime.DayOfWeek == DayOfWeek.Sunday)
            {
                if (startTime.Hour < 10 || endTime.Hour > 18)
                {
                    throw new Exception("On Sundays, the gym can be booked from 10 AM to 6 PM only.");
                }
            }
            else
            {
                if (startTime.Hour < 8 || endTime.Hour > 20)
                {
                    throw new Exception("On other days, the gym can be booked from 8 AM to 8 PM only.");
                }
            }

            if ((endTime - startTime).TotalHours > 2)
            {
                throw new Exception("Bookings can be for a maximum of 2 hours.");
            }

            if (bookings.Any(b => b.StartTime < endTime && b.EndTime > startTime))
            {
                throw new Exception("The gym is already booked for the selected time slot.");
            }

            var booking = new Booking(nextBookingId++, group, startTime, endTime);
            bookings.Add(booking);
        }

        public List<Booking> GetBookings()
        {
            return bookings;
        }

        public override string ToString()
        {
            string result = "Bookings:\n";
            foreach (var booking in bookings)
            {
                result += booking.ToString() + "\n";
            }
            return result;
        }
    }
}
