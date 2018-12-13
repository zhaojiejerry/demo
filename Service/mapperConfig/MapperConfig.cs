
using Model;
using Model.ViewModel;
using AutoMapper;

namespace Service.mapperConfig
{
        public class MapperConfig : Profile
        {
            public MapperConfig()
            {
                CreateMap<Vehicle, VehicleDTO>();
            }
        }
}
