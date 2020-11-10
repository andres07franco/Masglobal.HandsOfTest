using System;
using MasGlobal.HandsOnTest.Ioc.Intallers;
using Ninject;

namespace MasGlobal.HandsOnTest.Ioc
{
    public class RootInstaller 
    {
        public void Install(IKernel container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            new DataAccessInstaller().Install(container);
            new DomainInstaller().Install(container);
            new ApplicationInstaller().Install(container);

        }
    }
}
