
using Models.Request.RiderAddress;
using RanApp.Models.RanModels;

namespace Business.Services
{
    public interface IRiderAddressService
    {
        Task<RiderAddressModel> Create(CreateRiderAddressRequest request);

        Task<RiderAddressModel> Update(UpdateRiderAddressRequest request);

        Task<bool> Delete(string id);
    }
}