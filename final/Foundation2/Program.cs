using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("Bachweg 25", "Magden", "Aarau", "Schweiz");
        Customer customer1 = new Customer("Frédric Johannes", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("General Calculator T200", "GC200", 65.99, 1);
        Product p1002 = new Product("Notebook", "NB50", 3.50, 5);
        Product p1003 = new Product("Metallic Pencil", "MP05", 1.99, 10);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        
        Address address2 = new Address("Almanenweg 235", "Tislan", "Thurgau", "Liechtenstein");
        Customer customer2 = new Customer("Hans Joseph", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("Highlighter Set", "HLSET", 4.99, 3);
        Product p2002 = new Product("Index Cards", "IC100", 1.75, 2);
        Product p2003 = new Product("Scientific Calculator", "SCC1000", 12.50, 1);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        
        Address address3 = new Address("Rue des Soleils 21", "St Clément", "Montpellier", "France");
        Customer customer3 = new Customer("Esteban Guilhermes", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Pencil Case", "PC100", 8.99, 2);
        Product p3002 = new Product("Highlighter Set", "HLSET", 4.99, 4);

        productsList3.Add(p3001);
        productsList3.Add(p3002);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}