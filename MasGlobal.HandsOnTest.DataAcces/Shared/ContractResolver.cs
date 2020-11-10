namespace MasGlobal.HandsOnTest.DataAcces.Shared
{
    using MasGlobal.HandsOnTest.Domain.Shared.Enums;
    using MasGlobal.HandsOnTest.DataAcces.Shared.Dtos;
    using MasGlobal.HandsOnTest.Domain.Entities;
    using System;
    using System.Collections.Generic;

    public class ContractResolver
    {
        private readonly Dictionary<string, Func<GetEmployeesDto, Contract>> contractResolve;

        public ContractResolver()
        {
            this.contractResolve = new Dictionary<string, Func<GetEmployeesDto, Contract>>();
            this.InitContractResolver();
        }

        private void InitContractResolver()
        {
            contractResolve.Add("HourlySalaryEmployee", (empDto) => new Contract() { Salary = empDto.HourlySalary, ContractType = ContractTypeEnum.Hourly });
            contractResolve.Add("MonthlySalaryEmployee", (empDto) => new Contract() { Salary = empDto.MonthlySalary, ContractType = ContractTypeEnum.Monthly });
        }

        public Contract Resolve(GetEmployeesDto getEmployeesDto)
        {
            if (contractResolve.ContainsKey(getEmployeesDto.ContractTypeName))
            {
                contractResolve.TryGetValue(getEmployeesDto.ContractTypeName, out var resolver);
                return resolver(getEmployeesDto);
            }
            throw new ArgumentException($"{getEmployeesDto.ContractTypeName} not support.");
        }
    }
}
