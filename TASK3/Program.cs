using RandDelayevent;

public class Program
{
    static void Main(string[] args)
    {
        EventBus eventBus = new EventBus(5, 1000, 5000, 1.5);
        Publish publisher = new Publish(eventBus);

        AcceptPrior sub1 = new AcceptPrior(1);
        AcceptPrior sub2 = new AcceptPrior(2);
        AcceptPrior sub3 = new AcceptPrior(3);

        eventBus.Register("OddEvent", sub1.Accept, new Action<object, EventArgs>(sub1.HandleEvent));
        eventBus.Register("EvenEvent", sub2.Accept, new Action<object, EventArgs>(sub2.HandleEvent));
        eventBus.Register("OddEvent", sub3.Accept, new Action<object, EventArgs>(sub3.HandleEvent));


        publisher.SendEvent();

        Console.ReadLine();
    }
}