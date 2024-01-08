namespace RanApp.Models.Request
{
    public class CreateAppointmentRequest
    {
        public int RiderId { get; set; }

        public DateTime RideDate { get; set; }

        public int PickupAddressId { get; set; }

        public int DropoffAddressId { get; set; }

        public DateTime PickupTime { get; set; }

        public DateTime AppointmentTime { get; set; }
    }
}