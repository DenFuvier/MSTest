using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Army
{

    namespace Army
    {

        public class TestPeople
        {
            public int ColVoPriziv { get; private set; }
            public int ColVoOtclon { get; private set; }

            public void addPrizivnik(PrizivnikInfo prizivnik)
            {
                ColVoPriziv++;
                if (!IsFitForService(prizivnik))
                {
                    ColVoOtclon++;
                }
            }

            public double CalculateSuccessRate()
            {
                if (ColVoPriziv == 0)
                    return 0;

                return (double)(ColVoPriziv - ColVoOtclon) / ColVoPriziv * 100;
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




}
