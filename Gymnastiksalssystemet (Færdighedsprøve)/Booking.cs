using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet__Færdighedsprøve_
{
    internal class Booking
    {
        public int BookingId { get; set; }
        public Gruppe Group { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Booking(int bookingId, Gruppe group, DateTime startTime, DateTime endTime)
        {
            BookingId = bookingId;
            Group = group;
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"BookingId: {BookingId}, Group: {Group}, StartTime: {StartTime}, EndTime: {EndTime}";
        }
    }
}
