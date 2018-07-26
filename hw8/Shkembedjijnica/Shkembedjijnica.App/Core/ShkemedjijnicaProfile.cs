
using AutoMapper;
using Shkembedjijnica.App.Core.DTOs;
using Shkembedjijnica.Models;

namespace Shkembedjijnica.App.Core
{
    public class ShkemedjijnicaProfile : Profile
    {
        public ShkemedjijnicaProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();

            CreateMap<Employee, ManagerDto>()
                .ForMember(dest => dest.EmployeeDtos,
                            opt => opt.MapFrom(src => src.EmployeesManager))
                .ReverseMap();

            CreateMap<Employee, EmployeeFullInfoDto>().ReverseMap();

            CreateMap<Employee, AgeComparingEmployeeDto>().ReverseMap();
        }
    }
}
