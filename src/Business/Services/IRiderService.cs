using Models.Request.Rider;
using RanApp.Models.RanModels;
using RanApp.Models.Request.Rider;

namespace RanApp.Business.Services
{
    public interface IRiderService
    {
        Task<RiderModel> Create(CreateRiderRequest request);

        Task<RiderModel> Update(UpdateRiderRequest request);

        Task<List<RiderModel>> Search(SearchRiderRequest request);

        Task<bool> Delete(string id);
    }
}