using Core.Models;

namespace ConsoleApp_with_List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();
           bool f = false;
            string choice;

            do
            {
                Console.WriteLine("1.Sisteme girish edin.   0.EXIT.");
                 choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Sistemden cixildi");
                        f = true;
                    break;



                    case "1":
                        Console.WriteLine("1.Hotel elave et.  2.Butun Hotelleri gor.  3.Hotel sec.   0.Exit.");
                        string choice1 = Console.ReadLine();
                    break;
                    
                }


            }while (!f);
            

        }
    }
}
