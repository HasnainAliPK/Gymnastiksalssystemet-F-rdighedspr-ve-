namespace Gymnastiksalssystemet__Færdighedsprøve_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookingManager bookingManager = new BookingManager();

            Gruppe group1 = new Gruppe("Roskilde Håndbold Junior", "7-9", 10, 1);
            Gruppe group2 = new Gruppe("Danish Floorball Club (junior)", "9-11", 15, 2);

            try
            {
                bookingManager.AddBooking(group1, new DateTime(2024, 6, 17, 9, 0, 0), new DateTime(2024, 6, 17, 11, 0, 0));
                bookingManager.AddBooking(group2, new DateTime(2024, 6, 17, 11, 0, 0), new DateTime(2024, 6, 17, 13, 0, 0));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(bookingManager);

            Console.ReadKey();
        }
    }
    
}
