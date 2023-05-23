using System;

namespace Obserwator
{
    class Program
    {
        static void Main(string[] args)
        {
            Subscriber Marek = new Subscriber("Marek");
            Subscriber Ania = new Subscriber("Ania");
            Subscriber Michał = new Subscriber("Michał");

            Publisher publisher = new Publisher();

            publisher.Subscribe(Marek);
            publisher.Subscribe(Ania);
            publisher.Subscribe(Michał);

            publisher.Notify("Konsola jest już dostępna");

            publisher.Unsubscribe(Michał);

            publisher.Notify("Agd jest już dostępne");

        }
    }
}
