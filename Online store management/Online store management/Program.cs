using Online_store_management;
var P1 = new Electronic
{
    Name = "smart phone",
    Price = 1000,
    WarrantyPeriod = 3
};
P1.ApplyDiscount(10);



var p2 = new Clothing
{
    Name = "T-shirt",
    Price = 1000,
    Material="katon",
    Size = "M"
};


Console.WriteLine(P1.GetProductDetails());
Console.WriteLine("----------------------------------------");
Console.WriteLine(p2.GetProductDetails());