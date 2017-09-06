using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll.Library.Data;

namespace Dll.Library.Models
{
    public class Factory : IFactoryCreate
    {
        public delegate void FactoryEventHandler(object o, FactoryEventArgs e);

        public event FactoryEventHandler CreateFactory;

        public string Factory1 { get; set; }

        public Factory():this(String.Empty)
        {
        }
        public Factory(string factor)
        {
            Factory1 = factor;
        }

        public void NameOfDelegate(IFactoryCreate factor)
        {
            Console.WriteLine("Spusteni udalost ze tridy factory.");
            Fired(factor);
        }

        protected virtual void Fired(IFactoryCreate factor)
        {
     
            CreateFactory?.Invoke(this, new FactoryEventArgs(){Factory = factor as Factory});
        }

        void IFactoryCreate.CreateFactories(Factory factor)
        {
            Factory1 = factor.Factory1;
        }
    }
}
