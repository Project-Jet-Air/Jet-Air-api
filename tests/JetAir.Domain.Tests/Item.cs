namespace JetAir.Domain
{
    public class Item
    {
        public string Name { get; }
        public string Description { get; }
        public string Brand { get; }
        public decimal Price { get; }
        
        public list<Rating> Rating { get; }

        public void AddRating(Rating rating){
            this.Ratings.Add(rating);
        }
        public Item(string name, string description, string brand, decimal price){
            if (string.IsNullOrEmpty(name)){
                throw new ArgumentException(name);
        }
            if(string.IsNullOrEmpty(description)) {
                throw new ArgumentException(description);
            }
            if(string.IsNullOrEmpty(brand)) {
                throw new ArgumentException(brand);
            }
            if(price < 0) {
                throw new ArgumentException("Price has to be non-negative");
            }
            Name = name;
            Description = description;
            Brand = brand;
            Price = price;
        }
        public void AddRating(Rating rating)
        {
            _ratings.Add(rating);
        }
        }
    }
}
