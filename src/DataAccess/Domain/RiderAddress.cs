
namespace DataAccess.Domain
{
    public class RiderAddress : BaseDomain
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        public int RiderId { get; set; }

        public Rider Rider { get; set; }
    }
}