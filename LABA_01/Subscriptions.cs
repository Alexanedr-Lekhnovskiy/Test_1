using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_01
{
    public class  Subscriptions
    {
        protected Money Total;

        protected bool IsKey;

        protected DateTime DateStart;
  
        protected DateTime DateEnd;

        public int period;

      

        public Subscriptions(Money _total)
        {
            Total = _total;
            IsKey = false;
        }


        public Subscriptions(Money _total, char symbol)
        {
            Total = _total;
            if (symbol == '+' ) 
            {
                IsKey = true;
            }
            else if(symbol == '-')
            {
                IsKey = false;
            }
        }

        public Subscriptions(Money _total, char symbol, int _period)
        {
            Total = _total;
            if (symbol == '+')
            {
                IsKey = true;
            }
            else if (symbol == '-')
            {
                IsKey = false;
            }
            period = _period;
        }


        public bool GetIsKey()
        {
            return IsKey;
        }

        public virtual Money GetTotal()
        {
            return new Money(0, 0);
        }

        public  DateTime SetDate(int year, int month, int day)
        {
            DateStart = new DateTime(year, month, day); // год - месяц - день
            return DateStart;
        }
        public DateTime GetDateStart()
        {
            return DateStart;
        }

        public  virtual DateTime GetDateEnd()
        {
            return DateStart;
        }
        //printInfo
    }
}
