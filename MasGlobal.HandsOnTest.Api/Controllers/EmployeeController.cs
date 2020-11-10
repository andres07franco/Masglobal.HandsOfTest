namespace MasGlobal.HandsOnTest.Api.Controllers
{
    using MasGlobal.HandsOnTest.Domain.Entities;
    using MasGlobal.HandsOnTest.Application.Interfaces.Employee;
    using System.Collections.Generic;
    using MasGlobal.HandsOnTest.Api.Models;

    public class EmployeeController : BaseApiController<EmployeeViewModel, Employee>
    {

        private readonly IGetEmployeeUseCase getEmployeeUseCase;

        public EmployeeController(IGetEmployeeUseCase getEmployeeUseCase)
        {
            this.getEmployeeUseCase = getEmployeeUseCase;
        }


        public IEnumerable<EmployeeViewModel> GetAllEployees()
        {
           return Process(this.getEmployeeUseCase.GetAll());
        }

        public EmployeeViewModel GetEmployee(int id)
        {
            return Process(this.getEmployeeUseCase.GetById(id));
        }
    }
}
