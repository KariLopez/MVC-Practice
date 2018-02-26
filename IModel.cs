using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    interface IModel
    {
        string Name
        {get;
            set;
        }
        string Flavor
        {
            get;
            set;
        }
        int Count
        {
            get;
            set;
        }
        
    }
}
