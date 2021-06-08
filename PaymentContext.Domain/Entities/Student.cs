using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _substriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _substriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Adress { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _substriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            // se ja tiver uma assinatura ativa , cancela!

            // Cancela todas as outras assinaturas e coloca esta
            // como principal.

            foreach (var sub in Subscriptions)
                sub.Inactivate();

            _substriptions.Add(subscription);

        }
    }
}