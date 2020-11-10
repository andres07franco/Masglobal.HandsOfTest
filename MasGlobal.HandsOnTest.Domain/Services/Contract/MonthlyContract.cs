
namespace MasGlobal.HandsOnTest.Domain.Services.Contract
{
    using MasGlobal.HandsOnTest.Domain.Interfaces.Contract;

    public class MonthlyContract : IContractCalculator
    {
        private readonly int MonthsOfYear;

        public MonthlyContract( int MonthsOfYear)
        {
            this.MonthsOfYear = MonthsOfYear;
        }

        public double CalculeAnnualSalary(double monthlySalary)
        {
            double annualSalary =  monthlySalary * MonthsOfYear;
            return annualSalary;
        }
    }
}
