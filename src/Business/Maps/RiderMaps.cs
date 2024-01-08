using AutoMapper;
using RanApp.DataAccess.Domain;
using RanApp.Models.Request.Rider;

namespace Business.Maps
{
    public class RiderMaps :Profile
    {
        public RiderMaps()
        {
            this.CreateMap<CreateRiderRequest, Rider>()
                .ForMember(
                    destination => destination.Id,
                    source => source.MapFrom(x => Guid.NewGuid().ToString())
                )
                .ForMember(
                    destination => destination.CreatedDate,
                    source => source.MapFrom(x => DateTime.UtcNow.ToString())
                );
        }
    }
}