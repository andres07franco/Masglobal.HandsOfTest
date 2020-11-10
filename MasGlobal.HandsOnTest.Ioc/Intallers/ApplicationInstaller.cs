
using Ninject;
using System;

namespace MasGlobal.HandsOnTest.Ioc.Intallers
{

    using MasGlobal.HandsOnTest.Application.Interfaces.Employee;
    using MasGlobal.HandsOnTest.Application.UseCases.Employee;

    public class ApplicationInstaller 
    {

        public void Install(IKernel container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            container.Bind<IGetEmployeeUseCase>()
                     .To<GetEmployeeUseCase>();


        }
    }
}
