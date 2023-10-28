namespace fammsApp.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string ImagePath { get; set; } = null!;

    }
}
