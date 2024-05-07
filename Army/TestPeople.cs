using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Army
{

    public class TestPeople
    {
        public int TotalConscripts { get; private set; }
        public int RejectedConscripts { get; private set; }

        public void addPrizivnik(PrizivnikInfo prizivnik)
        {
            TotalConscripts++;
            if (!IsFitForService(prizivnik))
            {
                RejectedConscripts++;
            }
        }

        public double CalculateSuccessRate()
        {
            if (TotalConscripts == 0)
                return 0;

            return (double)(TotalConscripts - RejectedConscripts) / TotalConscripts * 100;
        }

        private bool IsFitForService(PrizivnikInfo prizivnik)
        {
            return prizivnik.Age >= 18;
        }
    }

    public class PrizivnikInfo
    {
        public int Age { get; set; }

        public PrizivnikInfo(int age)
        {
            Age = age;
        }
    }




}
