namespace RanApp.DataAccess.Domain
{
    public class Rider : BaseDomain
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNo { get; set; }

        public ICollection<RiderAddress> Addresses { get; set; }

        public ICollection<RiderAppointment> Appointments { get; set; }
    }
}