double CalculateDiscount(double price)
{
    double discount = price * 0.20;
    double finalPrice = price - discount;

    return finalPrice;
}

double price1 = CalculateDiscount(100);
double price2 = CalculateDiscount(250);
double price3 = CalculateDiscount(80);

Console.WriteLine(price1);
Console.WriteLine(price2);
Console.WriteLine(price3);
