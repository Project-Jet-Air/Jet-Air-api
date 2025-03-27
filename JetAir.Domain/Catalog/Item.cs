namespace JetAir.Domain.Catalog
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }  
        public string Brand { get; set; }         
        public decimal Price { get; set; }

        public List<Rating> Ratings { get; set; } = new();

        public void AddRating(Rating rating)
        {
            this.Ratings.Add(rating);
        }
    }
}
