using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_01
{
    public class DaysPayment : Subscriptions
    {


        public DaysPayment(Money _total, char symbol, int _days) : base(_total, symbol, _days)
        {
            new Subscriptions(_total, symbol, _days);
        }

        public override Money GetTotal()
        {
            Money Sum = new Money(0, 0);

            for (int i = 0; i < period; i++)
            {
                Sum += Total; 
            }

            return Sum;
        }

        public override DateTime GetDateEnd()
        {
            DateEnd = DateStart.AddDays(period);
            return DateEnd;
        }

    }
}
