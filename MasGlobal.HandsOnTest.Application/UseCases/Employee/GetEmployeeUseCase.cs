namespace MasGlobal.HandsOnTest.Application.UseCases.Employee
{
    using System.Collections.Generic;
    using MasGlobal.HandsOnTest.Domain.Entities;
    using MasGlobal.HandsOnTest.Domain.Interfaces.Employee;
    using MasGlobal.HandsOnTest.Application.Interfaces.Employee;
    using MasGlobal.HandsOnTest.Application.Shared.Dtos;
    using MasGlobal.HandsOnTest.Application.Shared.Helpers;

    public class GetEmployeeUseCase : IGetEmployeeUseCase
    {
        private readonly IGetEmployeeService getEmployeeService;

        public GetEmployeeUseCase(IGetEmployeeService getEmployeeService)
        {
            this.getEmployeeService = getEmployeeService;
        }

        Response<IEnumerable<Employee>> IGetEmployeeUseCase.GetAll()
        {
            return ApplicationTry.Try(() =>     
                this.getEmployeeService.GetAll()
            );
        }

        Response<Employee> IGetEmployeeUseCase.GetById(int id)
        {
            return ApplicationTry.Try(() =>
                this.getEmployeeService.GetById(id)
            );
        }
    }
}
