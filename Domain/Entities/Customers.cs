namespace Products_CleanArquitecture.Domain.Entities
{
    public class Customers
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}