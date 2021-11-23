using System;
using System.Threading;


namespace FreeCodeCampCourseCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
           Chef chef = new Chef();
           chef.MakeChiken();
           ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChiken();
            italianChef.MakePasta();
            italianChef.MakespecialDish();


        }

    }

}
