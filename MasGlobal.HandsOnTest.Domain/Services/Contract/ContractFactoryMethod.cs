namespace MasGlobal.HandsOnTest.Domain.Services.Contract
{

    using MasGlobal.HandsOnTest.Domain.Interfaces.Contract;
    using MasGlobal.HandsOnTest.Domain.Shared.Enums;
    using MasGlobal.HandsOnTest.Domain.Shared.Exceptions;

    public class ContractFactoryMethod: IContractFactoryMethod
    {
        private readonly int HoursOfMonth;
        private readonly int MonthOfYear;

        public ContractFactoryMethod(int HoursOfMonth, int MonthOfYear)
        {
            this.HoursOfMonth = HoursOfMonth;
            this.MonthOfYear = MonthOfYear;
        }

        public IContractCalculator CreateContract(ContractTypeEnum contractType)
        {
            switch (contractType)
            {
                case ContractTypeEnum.Hourly:
                        return new HourlyContract(HoursOfMonth, MonthOfYear);
                case ContractTypeEnum.Monthly:
                    return new MonthlyContract(MonthOfYear);
                default:
                    throw new ContratTypeNotSupportException();
            }
        }

    }
}
