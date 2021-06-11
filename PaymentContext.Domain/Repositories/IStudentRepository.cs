using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories
{
    // abstração - criação de Repositorios
    public interface IStudentRepository
    {
        bool DocumentExists(string document);
        bool EmailExists(string email);
        void CreateSubscription(Student student);
    }
}