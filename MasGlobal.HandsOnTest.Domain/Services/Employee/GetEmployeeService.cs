
namespace MasGlobal.HandsOnTest.Domain.Services.Employee
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MasGlobal.HandOnTest.Domain.Entities;
    using MasGlobal.HandOnTest.Domain.Interfaces.Employee;
    using MasGlobal.HandsOnTest.Domain.Interfaces.Contract;
    using MasGlobal.HandsOnTest.Domain.Shared.Exceptions;

    public class GetEmployeeService: IGetEmployeeService
    {
        private readonly IEmployeeReadRepository employeeReadRepository;
        private readonly IContractFactoryMethod contractFactory;

        public GetEmployeeService(IEmployeeReadRepository employeeReadRepository, IContractFactoryMethod contractFactory)
        {
            this.employeeReadRepository = employeeReadRepository;
            this.contractFactory = contractFactory;
        }

        /// <summary>
        /// Get All Employees with their annual salary
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetAll()
        {
            var employees = this.employeeReadRepository.GetAll();
            employees.ToList().ForEach(employee=>{
                this._calculeAnnualSalary(employee);
            });
            return employees;
        }

        /// <summary>
        /// Get an Employee by id with his annual salary
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee GetById(int id)
        {
            var employee = this.employeeReadRepository.GetById(id);
            if(employee == null){
                throw new EmployeeNotFoundException();
            }
            this._calculeAnnualSalary(employee);
            return employee;
        }


        /// <summary>
        /// Clacule Annual Salary by Employee
        /// </summary>
        /// <param name="employee"></param>
        private void _calculeAnnualSalary(Employee employee)
        {
            try
            {
                var contract = contractFactory.CreateContract(employee.ContractType);
                employee.AnualSalary = contract.CalculeAnnualSalary(employee.Salary);
            }
            catch (DomainException)
            {
                employee.AnualSalary = 0;
            }

        }

    }
}
