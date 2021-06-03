using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _substriptions;
        public Student(string firstname, string lastname, string document, string email)
        {
            Firstname = firstname;
            Lastname = lastname;
            Document = document;
            Email = email;
            _substriptions = new List<Subscription>();
        }

        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Adress { get; private set; }
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