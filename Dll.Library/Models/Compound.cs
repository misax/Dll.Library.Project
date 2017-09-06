using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll.Library.Data;

namespace Dll.Library.Models
{
    public class Compound : IFactoryCreate
    {
        public void CreateFactories(Factory factor)
        {
            factor.CreateFactory += Factor_CreateFactory;
        }

        private void Factor_CreateFactory(object o, FactoryEventArgs e)
        {
            Console.WriteLine($"{e.Factory.Factory1}");
        }
    }
}
