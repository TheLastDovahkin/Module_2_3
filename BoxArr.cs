using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_3
{
    public class BoxArr : IComparable
    {
        public int Quantity { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public double Weight { get; set; }

        public bool IsSalty { get; set; }

        public int CompareTo(object o)
        {
            BoxArr p = o as BoxArr;
            if (p != null)
            {
                return Weight.CompareTo(p.Weight);
            }
            else
            {
                throw new Exception("I can't compare 2 objects");
            }
        }

        public override string ToString()
        {
            return $"{Name},{Type}";
        }
    }
}
