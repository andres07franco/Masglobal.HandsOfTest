
using System;

namespace MasGlobal.HandsOnTest.Ioc.Intallers
{
    using MasGlobal.HandsOnTest.Domain.Interfaces.Employee;
    using MasGlobal.HandsOnTest.DataAcces.Rest.Employee;
    using Ninject;
    using System.Configuration;

    public class DataAccessInstaller
    {

        public void Install(IKernel container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            var UrlEmployee = ConfigurationManager.AppSettings["UrlEmployee"] ?? string.Empty;

            container.Bind<IEmployeeReadRepository>()
                     .To<EmployeeRestReadRepository>()
                     .WithConstructorArgument("resourceEndpoint", UrlEmployee);

        }
    }
}
