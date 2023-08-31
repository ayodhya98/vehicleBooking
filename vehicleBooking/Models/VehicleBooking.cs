namespace vehicleBooking.Models
{
    public class VehicleBooking
    {
        public int BookingId { get; set; }

        public int PassengerId { get;  set; }

        public ICollection<Booking> Bookings { get; set;}

        public ICollection<Passenger> Passenger { get; set;}


    }
}
