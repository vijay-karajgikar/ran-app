using Models.Request.RiderAddress;
using RanApp.Models.RanModels;

namespace RanApp.Models.Request.Rider
{
    public class CreateRiderRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNo { get; set; }

        public List<CreateRiderAddressRequest> RiderAddresses { get; set; }
    }
}