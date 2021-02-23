using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_3
{
    public class Sweet : ACandy
    {
        public Sweet()
        {
            Boxes = new BoxArr[]
            {
                new BoxArr { Name = "Korovka", Type = "Caramel", IsSalty = false, Weight = 0.15, Quantity = 10 },
                new BoxArr { Name = "Rachok", Type = "Caramel", IsSalty = false, Weight = 0.07, Quantity = 10 },
                new BoxArr { Name = "ChupaChups", Type = "Caramel", IsSalty = false, Weight = 0.30, Quantity = 5 },
                new BoxArr { Name = "Worms", Type = "toffee", IsSalty = true, Weight = 0.10, Quantity = 5 },
                new BoxArr { Name = "Grand", Type = "toffee", IsSalty = false, Weight = 0.15, Quantity = 4 }
            };
        }
    }
}
