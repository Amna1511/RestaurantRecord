using System;

namespace RestaurantRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee_list emplist = new Employee_list();
            bool value= true;
            while (value)
            {
                
                Console.WriteLine("Main Menue");
                Console.WriteLine("===========================");
                Console.WriteLine("1.Add an Employee Record");
                Console.WriteLine("2.Display Employee Record(s)");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your choice");
                int ch = Int32.Parse(Console.ReadLine());
              
                switch (ch)
                {
                    case 1:
                        emplist.getemp();
                        break;
                    case 2:
                        emplist.showemp();
                        break;
                    case 3:
                         value =false;
                        break;

                }
            }
        }

    }
}
