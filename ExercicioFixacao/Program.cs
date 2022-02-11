using System.Globalization;
using ExercicioFixacao.Entities;
using ExercicioFixacao.Entities.Enums;

Console.WriteLine("Enter Client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime date = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, date);

Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.Write("How many items to this order? ");
int numberItems = int.Parse(Console.ReadLine());

Order order = new Order(DateTime.Now, status, client);

for (int i = 1; i <= numberItems; i++)
{
    Console.WriteLine($"Enter #{i} item data: ");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, productPrice);
    OrderItem newItem = new OrderItem(productQuantity, productPrice, product);

    order.AddItems(newItem);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);