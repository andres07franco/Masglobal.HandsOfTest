using System;
using MasGlobal.HandOnTest.Domain.Shared.Enums;
using MasGlobal.HandsOnTest.Domain.Interfaces.Contract;
using MasGlobal.HandsOnTest.Domain.Services.Contract;
using MasGlobal.HandsOnTest.Domain.Shared.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasGlobal.HandsOnTest.UnitTests
{
    [TestClass]
    public class CalculeAnnualSalaryTests
    {

        private readonly int HoursOfMonth = 120;
        private readonly int MonthsOfYear = 12;

        private readonly IContractFactoryMethod contractFactory;

        public CalculeAnnualSalaryTests()
        {
            this.contractFactory = new ContractFactoryMethod(HoursOfMonth, MonthsOfYear);
        }

        [DataTestMethod]
        [DataRow(20, 28800)]
        [DataRow(0, 0)]
        public void Given_ContracType_Is_Houryly_And_Salay_Then_ReturnValue(double salary, double anualSalaryExpected)
        {
            var contract = contractFactory.CreateContract(ContractTypeEnum.Hourly);
            double anualSalary = contract.CalculeAnnualSalary(salary);
            Assert.AreEqual(anualSalary,anualSalaryExpected);
        }

        [DataTestMethod]
        [DataRow(2400, 28800)]
        [DataRow(0, 0)]
        public void Given_ContracType_Is_Monthly_And_Salay_Then_ReturnValue(int salary, int anualSalaryExpected)
        {
            var contract = contractFactory.CreateContract(ContractTypeEnum.Monthly);
            double anualSalary = contract.CalculeAnnualSalary(salary);
            Assert.AreEqual(anualSalary, anualSalaryExpected);
        }

        [TestMethod]
        public void Given_ContracType_None_Then_TrowsContratTypeNotSupportException()
        {
            Action actual = () => contractFactory.CreateContract(ContractTypeEnum.None);
            Assert.ThrowsException<ContratTypeNotSupportException>(actual);
        }
    }
}
