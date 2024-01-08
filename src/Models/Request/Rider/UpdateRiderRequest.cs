using RanApp.Models.RanModels;

namespace RanApp.Models.Request.Rider
{
    public class UpdateRiderRequest
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNo { get; set; }

        public List<RiderAddressModel> RiderAddresses { get; set; }
    }
}