namespace DataAccess.Domain
{
    public class RiderAppointment
    {
        public DateTime RideDate { get; set; }

        public int RiderId { get; set; }

        public Rider Rider { get; set; }

        public int PickupAddressId { get; set; }

        public RiderAddress PickupAddress { get; set; }

        public int DropoffAddressId { get; set; }

        public RiderAddress DropoffAddress { get; set; }

        public DateTime RiderPickupTime { get; set; }

        public DateTime RiderAppointmentTime { get; set; }

        public int RideTypeId { get; set; }

        public RideType RideType { get; set; }

        public string RideComments { get; set; }
    }
}