using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLaba
{
    internal class EventBus
    {
        private List<EventHandler<MyEvent>> _eventHandlers = new List<EventHandler<MyEvent>>();
        private Timer _timer;
        private object _lockObj = new object();

        public void RegisterEventHandler(EventHandler<MyEvent> eventHandler)
        {
            lock (_lockObj)
            {
                _eventHandlers.Add(eventHandler);
            }
        }

        public void UnregisterEventHandler(EventHandler<MyEvent> eventHandler)
        {
            lock (_lockObj)
            {
                _eventHandlers.Remove(eventHandler);
            }
        }

        public void PublishEvent(MyEvent myEvent)
        {

            if (_timer == null)
            {
                _timer = new Timer(state =>
                {
                    lock (_lockObj)
                    {
                        _timer?.Dispose();
                        _timer = null;
                    }
                }, null, TimeSpan.FromSeconds(1), TimeSpan.Zero);
            }

            lock (_lockObj)
            {
                foreach (var eventHandler in _eventHandlers)
                {
                    eventHandler.Invoke(this, myEvent);
                }
            }
        }
    }
}

