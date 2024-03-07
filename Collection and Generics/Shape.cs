using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_and_Generics
{
    public abstract class Shape
    {

        public abstract decimal calculateArea();
        
    }

    public class Circle : Shape
    {
        public override decimal calculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
