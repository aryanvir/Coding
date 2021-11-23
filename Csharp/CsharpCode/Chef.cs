using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCampCourseCsharp
{
    internal class Chef
    {
        public void MakeChiken()
        {
            Console.WriteLine("The Chef made chicken ");

        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }

        public virtual void MakespecialDish()
        {
            Console.WriteLine("The chef made BBQ Spicy Chicken ");
        }

    }
}
