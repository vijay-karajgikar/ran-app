
namespace Models.Request.RiderAddress
{
    public class CreateRiderAddressRequest
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }
    }
}