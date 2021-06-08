using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Firstname, 3, "Name.Firstname", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(Lastname, 3, "Name.Lastname", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(Firstname, 40, "Name.Firstname", "Nome deve conter até 40 caracteres")
            );
        }

        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
    }
}