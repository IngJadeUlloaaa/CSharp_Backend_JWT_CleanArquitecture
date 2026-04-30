namespace Products_CleanArquitecture.Domain.Entities
{
    public class Customers
    {
        public int Id { get; private set; }

        public string Username { get; private set; }

        public string LastName { get; private set; }

        public string Email { get; private set; }

        public string Phone { get; private set; }

        public DateTime CreatedAt { get; private set; }
    }
}
