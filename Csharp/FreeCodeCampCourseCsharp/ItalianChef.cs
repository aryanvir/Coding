using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCampCourseCsharp
{
    class ItalianChef : Chef
    {
       public void MakePasta()
        {
            Console.WriteLine("Made Pasta");

        }
        public override void MakespecialDish()
        {
            Console.WriteLine("The chef made chicken parm ");
        }
    }
}
