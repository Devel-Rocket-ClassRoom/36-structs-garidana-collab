using System;
using System.Security.Cryptography.X509Certificates;

// README.md를 읽고 코드를 작성하세요.


InventoryItem[] items = new InventoryItem[5]
{
   new InventoryItem("검", 3.5, 1500),
   new InventoryItem("방패", 5.0, 1200),
   new InventoryItem("포션", 0.3, 50),
   new InventoryItem("활", 1.8, 1300),
   new InventoryItem("투구", 2.0, 800)
};

Console.WriteLine("=== 인벤토리 목록 ===");

foreach (InventoryItem item in items)
{
    Console.WriteLine($"{item.Name} - 무게: {item.Weight}kg, 가격: {item.Price} G");
}
Console.WriteLine();
Console.WriteLine("=== 인벤토리 통계 ===");
Console.WriteLine($"전체 무게: {(TotalWeight()):N2}");
Console.WriteLine($"전체 가격: {(TotalPrice())}");
Console.WriteLine($"평균 가격: {(AveragePrice())}");
Console.WriteLine($"가장 비싼 아이템: {(MostExpensiveItem())}");
Console.WriteLine($"가장 가벼운 아이템: {(MostLightestItem())}");

double TotalWeight()
{
    double sum = 0 ;
    for (int i = 0; i < 5; i++)
    {
        sum += items[i].Weight;
    }
    return sum;
}

int TotalPrice()
{
    int sum = 0;
    foreach (InventoryItem item in items)
    {
        sum += item.Price;
    }
    return sum;
}
int AveragePrice() => TotalPrice() / items.Length;

string MostExpensiveItem()
{
    string mostExpensiveItem = items[0].Name;
    int maxPrice = items[0].Price;
   for (int i = 0; i < items.Length; i++)
    {
        if (items[i].Price > maxPrice)
        {
            maxPrice = items[i].Price;
            mostExpensiveItem = items[i].Name.ToString();
        }
    }
    return mostExpensiveItem;
}

string MostLightestItem()
{
    string mostLightestItem = items[0].Name;
    double minWeight = items[0].Weight;
    for (int i = 0; i < items.Length; i++)
    {
        if (items[i].Weight < minWeight)
        {
            minWeight = items[i].Weight;
            mostLightestItem = items[i].Name.ToString();
        }
    }
    return mostLightestItem;
}
