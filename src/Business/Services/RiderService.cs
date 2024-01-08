using Models.Request.Rider;
using RanApp.Business.Services;
using RanApp.Models.RanModels;
using RanApp.Models.Request.Rider;

namespace Business.Services
{
    public class RiderService : IRiderService
    {
        public Task<RiderModel> Create(CreateRiderRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RiderModel>> Search(SearchRiderRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RiderModel> Update(UpdateRiderRequest request)
        {
            throw new NotImplementedException();
        }
    }
}