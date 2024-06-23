using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPassports
{
    public class AgeComparator:IComparer<Information>
    {
        public int Compare(Information x, Information y)
        {
            int result = x.Name.CompareTo(y.Name);
            if (result == 0)
            {
                result = y.Age.CompareTo(x.Age);
            }
            return result;
        }
    }
}
