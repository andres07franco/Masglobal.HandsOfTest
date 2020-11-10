
namespace MasGlobal.HandsOnTest.Domain.Interfaces.Employee
{
    using MasGlobal.HandsOnTest.Domain.Entities;
    using System.Collections.Generic;

    public interface IGetEmployeeService
    {
        Employee GetById(int id);

        IEnumerable<Employee> GetAll();
    }
}
