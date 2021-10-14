using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessLayer dal = new DataAccessLayer();

            String ing = "Gin";

            dal.InsertIngredient(ing);
        }
    }
}
