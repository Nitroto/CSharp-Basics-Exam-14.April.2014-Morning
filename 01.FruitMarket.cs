using System;
using System.Globalization;
using System.Threading;

class FruitMarket
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string dayOfWeek = Console.ReadLine();
        double quant1 = double.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();
        double quant2 = double.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();
        double quant3 = double.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();
        double totalPrice = 0.0;
        double priceOfFirst = (quant1 * GetPrice(product1));
        double priceOfSecond = (quant2 * GetPrice(product2));
        double priceOfThird = (quant3 * GetPrice(product3));
        if (dayOfWeek == "Friday" || dayOfWeek == "Sunday" || dayOfWeek == "Monday" || dayOfWeek == "Satyrday")
        {
            totalPrice = (priceOfFirst + priceOfSecond + priceOfThird) * GetDiscount(dayOfWeek);
        }
        else if (dayOfWeek == "Thursday")
        {
            if (product1 == "banana")
            {
                priceOfFirst *= GetDiscount(dayOfWeek);
            }
            if (product2 == "banana")
            {
                priceOfSecond *= GetDiscount(dayOfWeek);
            }
            if (product3 == "banana")
            {
                priceOfThird *= GetDiscount(dayOfWeek);
            }
            totalPrice = (priceOfFirst + priceOfSecond + priceOfThird);
        }
        else if (dayOfWeek == "Wednesday")
        {
            if (product1 == "cucumber" || product1 == "tomato")
            {
                priceOfFirst *= GetDiscount(dayOfWeek);
            }
            if (product2 == "cucumber" || product2 == "tomato")
            {
                priceOfSecond *= GetDiscount(dayOfWeek);
            }
            if (product3 == "cucumber" || product3 == "tomato")
            {
                priceOfThird *= GetDiscount(dayOfWeek);
            }
            totalPrice = (priceOfFirst + priceOfSecond + priceOfThird);
        }
        else
        {
            if (product1 == "banana" || product1 == "orange" || product1 == "apple")
            {
                priceOfFirst *= GetDiscount(dayOfWeek);
            }
            if (product2 == "banana" || product2 == "orange" || product2 == "apple")
            {
                priceOfSecond *= GetDiscount(dayOfWeek);
            }
            if (product3 == "banana" || product3 == "orange" || product3 == "apple")
            {
                priceOfThird *= GetDiscount(dayOfWeek);
            }
            totalPrice = (priceOfFirst + priceOfSecond + priceOfThird);
        }
        Console.WriteLine("{0:F2}", totalPrice);
    }
    static double GetPrice(string product)
    {
        double price = 0.00;
        switch (product)
        {
            case "banana": price = 1.80; break;
            case "cucumber": price = 2.75; break;
            case "tomato": price = 3.20; break;
            case "orange": price = 1.60; break;
            case "apple": price = 0.86; break;
        }
        return price;
    }
    static double GetDiscount(string dayOfWeek)
    {
        double discount = 0.00;
        switch (dayOfWeek)
        {
            case "Friday": discount = 0.90; break;
            case "Sunday": discount = 0.95; break;
            case "Tuesday": discount = 0.80; break;
            case "Wednesday": discount = 0.90; break;
            case "Thursday": discount = 0.70; break;
            default: discount = 1.00; break;
        }
        return discount;
    }
}
