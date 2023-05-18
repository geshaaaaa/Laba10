using EventLaba;

class Program
{
    static void Main(string[] args)
    {
        EventBus eventBus = new EventBus();


        MyEventHandler eventHandler = new MyEventHandler();
        EventHandler<MyEvent> eventDelegate = eventHandler.HandleEvent;

        // Реєстрація обробника подій
        eventBus.RegisterEventHandler(eventDelegate);

        // Відправлення подій
        for (int i = 1; i <= 10; i++)
        {
            MyEvent myEvent = new MyEvent { Message = $"Event {i}" };
            eventBus.PublishEvent(myEvent);
            Thread.Sleep(100);
        }

    
        eventBus.UnregisterEventHandler(eventDelegate);

        Console.ReadLine();
    }
}