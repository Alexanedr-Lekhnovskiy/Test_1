using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_01
{
     public class MonthsPayment : Subscriptions
    {
        private int Number = 1;

        private static Money Prize = new Money(5500, 70);

        public MonthsPayment(Money _total, char symbol, int _months) : base(_total, symbol, _months)
        {
            new Subscriptions(_total, symbol, _months);
        }


        public override Money GetTotal()
        {
            Money Sum = new Money(0, 0);


            while (Number != period + 1)
            {
                //Начисление премии к 13-ой зарплате
                if(Number % 13 == 0)
                {
                    Sum += Total + Prize;
                }
                else
                {
                    Sum += Total;
                }
                Number++;

            }

            return Sum;
        }


        public override DateTime GetDateEnd()
        {
            DateEnd = DateStart.AddMonths(period);
            return DateEnd;
        }


    }
}
