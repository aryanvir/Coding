using System;
using System.Threading.Tasks;


namespace FreeCodeCampCourseCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celeb;
            Console.Write("Enter a color : ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun : ");
            pluralNoun = Console.ReadLine(); 
            Console.Write("Enter a celebrity : ");
            celeb = Console.ReadLine();
            
            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I love {celeb}");
        }

    }              
    
}
