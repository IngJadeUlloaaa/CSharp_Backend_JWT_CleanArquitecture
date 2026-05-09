namespace Products_CleanArquitecture.Domain.Interfaces
{
    public interface IDeleteCustomersRepository
    {
        Task DeleteCustomersById(int Id);
    }
}
