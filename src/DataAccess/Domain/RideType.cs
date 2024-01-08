namespace RanApp.DataAccess.Domain
{
    public class RideType
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int RiderAppointmentId { get; set; }

        public RiderAppointment RiderAppointment { get; set; }
    }
}