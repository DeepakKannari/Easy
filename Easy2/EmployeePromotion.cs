using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Easy2
{
    class EmployeePromotion
    {
        private List<string> EmployeeNames = new List<string>();
        public List<string> employeesList { 
            
            get { return EmployeeNames; }

            set { employeesList = EmployeeNames; }
       
        }

        private  TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
        public void getEmployeeNames()
        {
            Regex rgx_name = new Regex(@"^[a-zA-Z]+\s*[a-zA-Z]*$");
            bool flag = true;
            Console.WriteLine("Please enter the employees name in the  order of their eligiblity for promotion(Please enter blank to stop)");
            do
            {
            ReadName: string name = Console.ReadLine();
                if (isValid(name, rgx_name))
                {
                    EmployeeNames.Add(myTI.ToTitleCase(name));
                }
                else if (string.IsNullOrEmpty(name))
                {

                    flag = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid Name");
                    goto ReadName;
                }
            } while (flag);
        }
        public void checkPromotionPostion()
        {
            Regex rgx_name = new Regex(@"^[a-zA-Z]+\s*[a-zA-Z]*$");
            ReadName: Console.WriteLine("Please enter the name of the employee to check promotion position");
            string name = Console.ReadLine();
            if (isValid(name, rgx_name))
            {
                int position = EmployeeNames.IndexOf(myTI.ToTitleCase(name));

                if (position != -1)
                    Console.WriteLine($"{name} is in position {position + 1} for promotion");
                else
                    Console.WriteLine("The employee not found");
                Console.Read();
            }
            else 
            {
                Console.WriteLine("Enter a valid Name");
                goto ReadName;
            }
        }
        private bool isValid(string vlaue, Regex regex)
        {
            //if (string.IsNullOrEmpty(vlaue) || !regex.IsMatch(vlaue))                        // create and call isvalid with para rgx and string value if invalid go to the start
            //{
            //    Console.WriteLine("Invalid value please enter a valid value");
            //    return false;
            //}
            //return true;
            if (string.IsNullOrEmpty(vlaue))                        // create and call isvalid with para rgx and string value if invalid go to the start
            {
                return false;
            }
            if (!regex.IsMatch(vlaue))
            {
                Console.WriteLine("Invalid value please enter a valid value");
                return false;
            }
            return true;
        }

    }
}
