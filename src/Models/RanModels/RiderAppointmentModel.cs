namespace Models.RanModels
{
    public class RiderAppointmentModel : BaseModel
    {
        public DateTime RideDate { get; set; }

        public int RiderId { get; set; }

        public int PickupAddressId { get; set; }

        public int DropoffAddressId { get; set; }

        public DateTime RiderPickupTime { get; set; }

        public DateTime RiderAppointmentTime { get; set; }

        public int RideTypeId { get; set; }

        public string RideComments { get; set; }
    }
}