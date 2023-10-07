namespace Craft_beer_backend.Entities
{
    public class CustomerInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public long DbUserId { get; set; }
        public DbUser DbUser { get; set; }
    }
}
