using System;
using System.Threading.Tasks;


namespace FreeCodeCampCourseCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Base Number:");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the power:");
            int powNum = Convert.ToInt32(Console.ReadLine());
            int powerdNum = GetPower(baseNum, powNum);
            Console.WriteLine($"{baseNum} to power {powNum} is {powerdNum}");
        }
        static int GetPower(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum;i++)
            {
                result *= baseNum;
            }

            return result;
        }

    }              
    
}
