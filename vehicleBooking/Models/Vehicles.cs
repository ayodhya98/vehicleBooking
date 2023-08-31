namespace vehicleBooking.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        public int Capacity { get; set; }

        public String Type { get; set; }

        public string Location { get; set; }

        public  Boolean Availablity { get; set; } = true;



    }
}
