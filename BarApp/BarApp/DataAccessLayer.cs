using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarApp
{
    class DataAccessLayer
    {
        public void InsertIngredient(string name)
        {
            using (GitBuzzedBarEntities barEntities = new GitBuzzedBarEntities())
            {
                barEntities.InsertIngredient(name);
            }
        }
    }
}
