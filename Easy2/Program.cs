using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePromotion promotion = new EmployeePromotion();
            promotion.getEmployeeNames();
            promotion.checkPromotionPostion();
        }
    }
}
