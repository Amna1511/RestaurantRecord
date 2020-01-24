using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantRecord
{
    class Employee_list
    {
     //List<Employees> empList = new List<Employees>();
        Employees[] emp = new Employees[10];
        static int index = 0;
        public void getemp()
        {
            
            String fname, lname;
            int id, sal;
            Console.WriteLine("Enter First Name of employee:");
            fname = Console.ReadLine();
            Console.WriteLine("Enter second Name of employee");
            lname = Console.ReadLine();
            Console.WriteLine("id of emp:");
            id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("salary of emp:");
            sal = Int32.Parse(Console.ReadLine());
            emp[index] = new Employees(fname, lname, id, sal);
            index++;
        }
        public void showemp()
        {
            Console.WriteLine("FirstName\t LastName\t ID\tSalary  ");
            for (int i =0;i<index;i++)
            {
            
             Console.WriteLine(" {0}    \t {1}     \t{2}     \t{3}", emp[i].e_fname, emp[i].e_lname, emp[i].e_id, emp[i].e_sal);
           
            }

        }

    }

}



