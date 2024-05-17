namespace Sample.Entities.Model
{
    public sealed class Category
    {
        public int ID_Category { get; set; }
        public int Category_Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
