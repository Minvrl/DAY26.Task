using DAY26.Task;

string countStr;
int count;

do
{
    Console.Write("Insert product count : ");
    countStr = Console.ReadLine();
} while (!int.TryParse(countStr, out count) || count<0);

Product[] products = new Product[count];

for (int i = 0; i < count; i++)
{
    string name,priceStr,typeStr;
    double price;
    ProductType type;

    do
    {
        Console.Write("Product's name - ");
        name = Console.ReadLine();

    } while (string.IsNullOrEmpty(name));
    do
    {
        Console.Write(" Price - ");
        priceStr = Console.ReadLine();  
    } while (!double.TryParse(priceStr, out price) || price < 0);

    do
    {
        Console.Write("  Type - ");
        typeStr = Console.ReadLine();
    } while (!Enum.TryParse(typeStr, out type) || !Enum.IsDefined(typeof(ProductType), type));


    Product product = new Product(name,price,type);
    Array.Resize(ref products, products.Length+1);
    products[products.Length-1] = product;
}

foreach (Product product in products)
{
    Console.WriteLine(product);
}
