using AutoMapper;
using SharedClasses.DTO;
using SharedClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Role, RoleDTO>().ReverseMap();
            CreateMap<UserRole, UserRoleDTO>().ReverseMap();
            CreateMap<UserDTO, UserDTO>();
            CreateMap<Demand, DemandDTO>().ReverseMap();
            CreateMap<Actual, ActualDTO>().ReverseMap();
            //New
            CreateMap<AllocationProject, AllocationProjectDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<EmployeeRolAllocationProject, EmployeeRolAllocationProjectDTO>().ReverseMap();
            CreateMap<EmployeeType, EmployeeTypeDTO>().ReverseMap();
            CreateMap<FundingType, FundingTypeDTO>().ReverseMap();
            CreateMap<SkillToEmployee, SkillToEmployeeDTO>().ReverseMap();
            CreateMap<Skill, SkillDTO>().ReverseMap();
            CreateMap<WorkCenter, WorkCenterDTO>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Allocation, AllocationDTO>().ReverseMap();
            CreateMap<Holiday, HolidayDTO>().ReverseMap();
            //End New
            CreateMap<CustomRatio, CustomRatioDTO>().ReverseMap();
            CreateMap<Manager, ManagerDTO>().ReverseMap();
        }
    }
}
