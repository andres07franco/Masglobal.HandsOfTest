
namespace MasGlobal.HandOnTest.Domain.Interfaces.Employee
{
    using MasGlobal.HandOnTest.Domain.Entities;
    using System.Collections.Generic;

    public interface IGetEmployeeService
    {
        Employee GetById(int id);

        IEnumerable<Employee> GetAll();
    }
}
