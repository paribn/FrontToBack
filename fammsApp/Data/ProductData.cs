namespace fammsApp.Data;
using fammsApp.Entities;
public class ProductData
{
    private static List<Products> Products = new()
    {
        new(){Id=1,Name="Men's shirt",Price=65,ImagePath="p1.png"},
        new(){Id=2,Name="Men's shirt",Price=30,ImagePath="p2.png"},
        new(){Id=3,Name="Women's shirt",Price=44,ImagePath="p3.png"},
        new(){Id=4,Name="Women's dress",Price=75,ImagePath="p4.png"},
        new(){Id=5,Name="Men's shirt",Price=35,ImagePath="p5.png"},
        new(){Id=6,Name="Women's shirt",Price=45,ImagePath="p6.png"},
        new(){Id=7,Name="Women's shirt",Price=74,ImagePath="p7.png"},
        new(){Id=8,Name="Men's shirt",Price=11,ImagePath="p8.png"},
        new(){Id=9,Name="Men's shirt",Price=22,ImagePath="p9.png"},
        new(){Id=10,Name="Men's shirt",Price=25,ImagePath="p10.png"},
        new(){Id=11,Name="Men's shirt",Price=12,ImagePath="p11.png"},
        new(){Id=12,Name="Women's dress",Price=84,ImagePath="p12.png"},

    };
    public static List<Products> ListProducts()
    {
        return Products;
    }
}
