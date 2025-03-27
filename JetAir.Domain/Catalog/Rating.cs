namespace JetAir.Domain.Catalog
{
    public class Rating
    {
        public int Id { get; set; }  // EF Core needs this for primary key
        public int Stars { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }

        // Foreign key and navigation property
        public int ItemId { get; set; }
        public Item Item { get; set; }

        // Parameterless constructor for EF Core
        public Rating() { }

        // Optional constructor to enforce validation
        public Rating(int stars, string userName, string review)
        {
            if (stars < 1 || stars > 5)
                throw new ArgumentException("Star rating must be between 1 and 5.");

            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentException("User name cannot be empty.");

            Stars = stars;
            UserName = userName;
            Review = review;
        }
    }
}
