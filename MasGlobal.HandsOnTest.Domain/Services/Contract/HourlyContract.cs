using MasGlobal.HandsOnTest.Domain.Interfaces.Contract;

namespace MasGlobal.HandsOnTest.Domain.Services.Contract
{
    public class HourlyContract : IContractCalculator
    {
        private readonly int HoursOfMonth;
        private readonly int MonthsOfYear;

        public HourlyContract(int HoursOfMonth, int MonthsOfYear)
        {
            this.HoursOfMonth = HoursOfMonth;
            this.MonthsOfYear = MonthsOfYear;
        }

        public double CalculeAnnualSalary(double hourlySalary)
        {
            double annualSalary = HoursOfMonth * hourlySalary * MonthsOfYear;
            return annualSalary;
        }
    }
}
