using PizzaStore;
internal class Program
{
    private static void Main(string[] args)
    {
        Pizza pizza1 = new Pizza("Vesuvio", 89.95);
        Pizza pizza2 = new Pizza("Magaritha", 79.95);
        Pizza pizza3 = new Pizza("Bearnaise", 99.95);
        // Console.WriteLine(pizza1);
        // Console.WriteLine(pizza2);
        // Console.WriteLine(pizza3);

        Customer customer1 = new Customer("Marie Antonette", "marie@letthemeatpizza.fr", "24568912");
        Customer customer2 = new Customer("It's a me, Mario!", "mario@luigi.it", "99776633");
        Customer customer3 = new Customer("Poul Henriksen", "pohe@zealand.com", "75396712");
        // Console.WriteLine(customer1);
        // Console.WriteLine(customer2);
        // Console.WriteLine(customer3);

        Order order1 = new Order(customer1, pizza1);
        Order order2 = new Order(customer2, pizza2);
        Order order3 = new Order(customer3, pizza3);
        Console.WriteLine(order1);
        Console.WriteLine(order2);
        Console.WriteLine(order3);
    }
}