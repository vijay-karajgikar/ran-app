namespace Models.RanModels
{
    public class RiderAddressModel : BaseModel
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }
    }
}