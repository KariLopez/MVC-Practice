using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    class Cupcakes : IModel
    {
        

        string IModel.Name { get =>n; set => throw new NotImplementedException(); }
        string IModel.Flavor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IModel.Count { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public Cupcakes(string n, string f, int c)
    {
        Name = n;
        Flavor = f;
        Count = c;

    }
    public string n
    {
        get
        {
            return Name;
        }
        set
        {
            Name = value;
        }
    }
}
