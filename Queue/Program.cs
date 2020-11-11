using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier();

            cashier.AddOrder(new Customer("Петя", "Хотдог"));
            cashier.AddOrder(new Customer("Вася", "Бургер"));
            cashier.AddOrder(new Customer("Андрей", "Мак комбо"));

            cashier.DeliverOrder();
            cashier.DeliverOrder();
            cashier.DeliverOrder();

            Console.WriteLine("");

            DanceFloor danceFloor = new DanceFloor(@"C:\Users\nikit\Source\Repos\nikitazyz\Queue\Queue\Dance.txt");
            Console.WriteLine(danceFloor.Dance());
        }
    }
}
