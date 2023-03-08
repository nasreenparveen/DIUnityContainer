using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DIUnityContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>("LuxuryCar");

            container.RegisterType<Driver>("LuxuryCarDriver",
                new InjectionConstructor(container.Resolve<ICar>("LuxuryCar")));

            Driver driver = container.Resolve<Driver>("LuxuryCar");
            driver.RunCar();

            Driver driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            Console.ReadLine();
        }
    }
}
