using System.Diagnostics.Tracing;

namespace AiNlogEventSource
{
    [EventSource(Name = "AiNlogEventSource-Instrumentation")]
    public class Instrumentation : EventSource
    {
        public static readonly Instrumentation Log = new Instrumentation();

        [Event(1, Message = "Started")]
        public void Started()
        {
            WriteEvent(1);
        }


        [Event(2, Message = "Stopped")]
        public void Stopped()
        {
            WriteEvent(2);
        }
    }
}
