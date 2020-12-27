using System;

namespace LABA_01
{
    class Program
    {
        static void Main(string[] args)
        {

            ////TEST_Разовой подписки
            //Person person1 = new Person("Аня", "Миронова", new Money(3000, 0));
            //Console.WriteLine($"{person1.ToString()}");

            ////создаём одноразовую подписку
            //OnePayment FastPlay = new OnePayment(new Money(100, 0));

            ////подписываем клиента
            //person1.PayingOne(FastPlay);
            //Console.WriteLine($"{person1.ToString()}\n");


            ////Создаём подписку на зачисление, также одноразовую
            //Person person2 = new Person("Сергей", "Степанов", new Money(1000, 0));
            //Console.WriteLine($"{person2.ToString()}");

            //OnePayment Bonus = new OnePayment(new Money(350, 0), '+');

            //person2.PayingOne(Bonus);
            //Console.WriteLine($"{person2.ToString()}\n");

            ////////////////////////////////////////
            ///////////////////////////////////////


            //TEST_Ежедневной подписки
            Person person3 = new Person("Владимир", "Уткин", new Money(14000, 0));
            Console.WriteLine($"{person3.ToString()}");

            //создаём ежедневную подписку на столько-то дней
            DaysPayment Donation = new DaysPayment(new Money(300, 0), '-', 15);

            //оплачиваем ежедневную подписку
            person3.PayingOne(Donation);
            Console.WriteLine($"{person3.ToString()}\n");

            //Задаём дату оформления подписки
            Donation.SetDate(2020, 12, 27);

            //Выводим даты оформления и окончания подписки
            Console.WriteLine($"Дата оформления подписки : {Donation.GetDateStart()}");
            Console.WriteLine($"Дата окончания подписки : {Donation.GetDateEnd()}\n");


            //int index = person3.AddPayingDays(Donation);
            //person3.RemovePayingDays(index);





            ////////////////////////////////////////
            ///////////////////////////////////////


            //TEST_Ежемесячной подписки
            Person person4 = new Person("Ольга", "Зайцева", new Money(200, 0));
            Console.WriteLine($"{person4.ToString()}");

            //создаём ежемесячную подписку 
            MonthsPayment Salary = new MonthsPayment(new Money(10, 0), '+', 27);

            //оплачиваем ежемесячную подписку
            person4.PayingOne(Salary);
            Console.WriteLine($"{person4.ToString()}\n");

            //Задаём дату оформления подписки
            Salary.SetDate(2021, 02, 16);


            //int indexs = person4.AddPayingMonths(Salary);
            //person4.RemovePayingMonths(indexs);

            //Выводим даты оформления и окончания подписки
            Console.WriteLine($"Дата оформления подписки : {Salary.GetDateStart()}");
            Console.WriteLine($"Дата окончания подписки : {Salary.GetDateEnd()}\n");

            Console.ReadLine();

           
        }
    }
}
