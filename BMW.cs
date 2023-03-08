using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIUnityContainer
{
    public class BMW : ICar
    {
        public int miles = 0;

        public int Run()
        {
          return ++miles;
        }
    }
}
