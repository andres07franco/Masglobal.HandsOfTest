
namespace MasGlobal.HandsOnTest.DataAcces.Rest.Employee
{

    using MasGlobal.HandsOnTest.Domain.Entities;
    using MasGlobal.HandsOnTest.Domain.Interfaces.Employee;
    using System.Collections.Generic;
    using System.Net.Http;
    using MasGlobal.HandsOnTest.DataAcces.Shared;
    using MasGlobal.HandsOnTest.DataAcces.Shared.Dtos;
    using System.Linq;
    using MasGlobal.HandsOnTest.DataAcces.Rest.Base;

    public class EmployeeRestReadRepository : BaseRestReadRepositorie<GetEmployeesDto>, IEmployeeReadRepository
    {

        private readonly HttpClient client;
        private readonly string resourceEndpoint;
        private readonly ContractResolver contractResolver;


        public EmployeeRestReadRepository(string resourceEndpoint):base(resourceEndpoint)
        {
            this.client = new HttpClient();
            this.resourceEndpoint = resourceEndpoint;
            this.contractResolver = new ContractResolver();
        }

        public IEnumerable<Employee> GetAll()
        {   
                var employeesDto = base.GetList();
                var employees = new List<Employee>();

                employeesDto.ForEach(employeeDto => {
                    employees.Add(new Employee()
                    {
                        Name = employeeDto.Name,
                        Id = employeeDto.Id,
                        Role = new Role() { Id = employeeDto.RoleId, Name = employeeDto.RoleName },
                        Contract = contractResolver.Resolve(employeeDto)
                    });
                  
                });
                return employees;
        }


        public Employee GetById(int id)
        {
            var employees = this.GetAll();
            return employees.ToList().FirstOrDefault(e=>e.Id == id);
        }
    }
}
