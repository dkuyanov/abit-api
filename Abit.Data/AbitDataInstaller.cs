using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Abit.Entities;

namespace Abit.Data
{
    public class AbitDataInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IRepository<Enrolee, int>>()
                .ImplementedBy<EnroleeRepository>());

        }
    }
}
