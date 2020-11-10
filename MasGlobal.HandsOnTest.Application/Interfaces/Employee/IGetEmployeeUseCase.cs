using System.Collections.Generic;

namespace MasGlobal.HandsOnTest.Application.Interfaces.Employee
{
    using MasGlobal.HandsOnTest.Application.Shared.Dtos;
    using MasGlobal.HandsOnTest.Domain.Entities;

    public interface IGetEmployeeUseCase
    {
        Response<Employee> GetById(int id);

        Response<IEnumerable<Employee>> GetAll();

    }
}
