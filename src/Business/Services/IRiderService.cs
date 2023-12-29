using Models.RanModels;

namespace Business.Services
{
    public interface IRiderService
    {
        RiderModel AddRider(RiderModel riderModel);

        RiderModel UpdateRider(RiderModel riderModel);

        RiderModel AddRiderAddress(RiderModel riderModel);
    }
}