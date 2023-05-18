using publications_subscriptions;

public class Program
{
    static void Main(string[] args)
    {
        EventBus eventBus = new EventBus(2000);
        Accpeter sub1 = new Accpeter(1);
        Accpeter sub2 = new Accpeter(2);
        Accpeter sub3 = new Accpeter(3);
        Accpeter sub4 = new Accpeter(4);
        eventBus.Register("EvenEvent", 1, new EventHandler(sub1.HandleEvent));
        eventBus.Register("EvenEvent", 2, new EventHandler(sub2.HandleEvent));
        eventBus.Register("OddEvent", 3, new EventHandler(sub3.HandleEvent));
        eventBus.Register("OddEvent", 4, new EventHandler(sub4.HandleEvent));
        Publisher publisher = new Publisher(eventBus);
        publisher.SendEvent();
    }
}