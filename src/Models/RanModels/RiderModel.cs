namespace Models.RanModels
{
    public class RiderModel : BaseModel
    {
        public string FirstName { get; set; }

        public string LastName  { get; set; }

        public string PhoneNo { get; set; }

        public List<RiderAddressModel> RiderAddresses { get; set; }
    }
}