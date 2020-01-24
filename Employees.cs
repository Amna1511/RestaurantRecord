using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace RestaurantRecord
{
    class Employees
    {
        public String e_fname, e_lname;
        public int e_id, e_sal;
        public Employees()
        {
            e_fname = "";
            e_lname = "";
            e_id = 0;
            e_sal = 0;

        }
        public Employees(String fname, String lname, int id, int sal)
        {
            e_fname = fname; 
            e_lname = lname;
            e_id = id;
            e_sal = sal;
        }

    }

}
