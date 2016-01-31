using Abit.Data;
using Abit.Entities;
using Castle.MicroKernel;
using Castle.Windsor;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abit.Tests.Data
{
    [TestFixture]
    public class EnroleeRepositoryTests
    {
        private readonly IWindsorContainer _container;

        public EnroleeRepositoryTests()
        {
            _container = new WindsorContainer();
            _container.Install(new AbitDataInstaller());
        }

        [Test]
        public void Get_Success()
        {
            var repository = _container.Resolve<IRepository<Enrolee, int>>();
            var item = repository.Get(1);
            Assert.IsNotNull(item);
            Assert.AreEqual(1, item.Id);
            Assert.AreEqual("Тестовый", item.LastName);
            Assert.AreEqual("Тест", item.FirstName);
            Assert.AreEqual("Тестович", item.MiddleName);
            Assert.AreEqual("город Энск", item.Address);
        }

        [Test]
        public void GetByIncorrectId_Null()
        {
            var repository = _container.Resolve<IRepository<Enrolee, int>>();
            var item = repository.Get(0);
            Assert.IsNull(item);
        }
        
    }
}
