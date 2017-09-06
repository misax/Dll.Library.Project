using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Library.Models
{
    public class FactoryEventArgs : EventArgs
    {
        public Factory Factory { get; set; }
    }
}
