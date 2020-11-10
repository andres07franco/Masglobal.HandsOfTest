

namespace MasGlobal.HandsOnTest.Ioc.Intallers
{
    using MasGlobal.HandsOnTest.Domain.Interfaces.Employee;
    using MasGlobal.HandsOnTest.Domain.Interfaces.Contract;
    using MasGlobal.HandsOnTest.Domain.Services.Contract;
    using MasGlobal.HandsOnTest.Domain.Services.Employee;
    using System;
    using Ninject;
    using System.Configuration;

    public class DomainInstaller 
    {

        public void Install(IKernel container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            container.Bind<IGetEmployeeService>()
                     .To<GetEmployeeService>();

            int.TryParse(ConfigurationManager.AppSettings["HoursOfMonth"], out var hoursOfMonth);
            int.TryParse(ConfigurationManager.AppSettings["MonthOfYear"], out var monthOfYear);

            container.Bind<IContractFactoryMethod>()
                    .To<ContractFactoryMethod>()
                    .WithConstructorArgument("HoursOfMonth", hoursOfMonth)
                    .WithConstructorArgument("MonthOfYear", monthOfYear);

        }

    }
}
