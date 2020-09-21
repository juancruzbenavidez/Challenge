using AutoMapper;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public static class EmployeeHelper
    {
        public static List<EmployeeDTO> GetAllEmployees()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.AnnualSalary, act => act.MapFrom(src=> (src.contractTypeName == "HourlySalaryEmployee") ? (120*src.hourlySalary*12) : (src.monthlySalary * 12))));
            var myEmployees = EmployeeDB.GetEmployees();
            var mapper = new Mapper(config);
            List<EmployeeDTO> employeesDTO = mapper.Map<List<Employee>, List<EmployeeDTO>>(myEmployees);
            return employeesDTO;
        }
    }
}
