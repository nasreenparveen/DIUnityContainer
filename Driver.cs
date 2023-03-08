using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIUnityContainer
{
   public class Driver
    {
        public ICar _car;

        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} miles", _car.GetType().Name, _car.Run());
        }
    }
}
