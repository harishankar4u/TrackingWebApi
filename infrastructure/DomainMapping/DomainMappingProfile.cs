using AutoMapper;
using TrackingApi.Data.Entity;
using TrackingApi.infrastructure.Response;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrackingApi.infrastructure.DomainMapping
{
    public class DomainMappingProfile: Profile
    {
        public DomainMappingProfile()
        {
            CreateMap<EmployeeEnt, EmployeeResponse>()
                .ForMember(dst => dst.id, opt => opt.MapFrom(src => src.E_Id))
                .ForMember(dst => dst.name, opt => opt.MapFrom(src => src.E_Name))
                .ForMember(dst => dst.age, opt => opt.MapFrom(src => src.E_Age))
                .ForMember(dst => dst.joiningdate, opt => opt.MapFrom(src => src.E_JoiningDate));
        }

    }
}
