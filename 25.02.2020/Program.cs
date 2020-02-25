using System;

namespace _25._02._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Please select only bottom number !");
                Console.WriteLine("4.Exit");
                Console.WriteLine("1.Go");
                Console.WriteLine("2.Top up");
                Console.WriteLine("3.Stop");
                Console.WriteLine(">>>>>");
                input = Console.ReadLine();
                if (IsEmpty(input))
                {
                    switch(input)
                        {

                        case "1":
                            Console.WriteLine("masin gedir");
                            break;
                        case "2":
                            Console.WriteLine("masina benzin vuruldu");
                            break;
                        case "3":
                            Console.WriteLine("masin dayandi");
                            break;
                        case "4":
                            
                            break;
                        default:
                            Console.WriteLine("yuxaridaki reqemlerden birini daxil edein");

                            break;


                    }
                }
            } while (input != "4");
            
        }
        static bool IsEmpty(string inp)
        {
            try
            {
                Convert.ToInt32(inp);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Please only numeric number");
                return false;
            }
        }
    }
}
