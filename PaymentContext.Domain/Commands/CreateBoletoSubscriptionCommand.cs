using System;
using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CreateBoletoSubscriptionCommand : Notifiable, ICommand
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }

        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
        public string PaymentNumber { get; set; }

        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; }
        public EDocumentType PayerDocumentType { get; set; }
        public string PayerEmail { get; set; }

        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        public void Validdate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Firstname, 3, "Name.Firstname", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(Lastname, 3, "Name.Lastname", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(Firstname, 40, "Name.Firstname", "Nome deve conter até 40 caracteres")
            );
        }
    }
}