namespace vehicleBooking.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Email { get; set; }

        public int phoneNumber { get; set; }

        public ICollection <Vehicles> vehicles { get; set; }

    }
}
