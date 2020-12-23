using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Caculate
    {
        private const double  MULTIPLIER = 1.06;
        public int getAge(string dob)
        {
            int converDate = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int converDob = int.Parse(dob);
            return ((converDate - converDob) / 10000);
        }
        public int getYear(string startDate)
        {
            return (Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(startDate.Substring(0, 3)));
        }
        public int getMonth(string startDate)
        {
            return (Convert.ToInt32(DateTime.Now.Month) - Convert.ToInt32(startDate.Substring(3,5)));
        }
        public double getSalCurrent(string startSal, string startDate)
        {
            return Math.Pow(MULTIPLIER, getYear(startDate)) * Convert.ToDouble(startSal);
        }
    }
}
