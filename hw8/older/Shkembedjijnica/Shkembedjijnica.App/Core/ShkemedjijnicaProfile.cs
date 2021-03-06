﻿using System;
using System.Collections.Generic;
using System.Text;
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
                .ForMember(x => x.EmployeeDtos, y => y.MapFrom(z => z.Employees))
                .ReverseMap();
            CreateMap<Employee, EmployeeFullInfoDto>().ReverseMap();
            CreateMap<Employee, SortedByAgeEmployeeDto>().ReverseMap();
        }
    }
}
