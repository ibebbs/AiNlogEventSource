using Microsoft.Diagnostics.EventFlow;
using NLog.Fluent;
using System;
using System.Threading.Tasks;

namespace AiNlogEventSource
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var pipeline = DiagnosticPipelineFactory.CreatePipeline("eventFlowConfig.json"))
            {
                Instrumentation.Log.Started();

                // Give other eventsources a chance to load and be enabled
                Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith(
                    _ =>
                    {
                        Log.Trace().Message("Trace").Write();
                        Log.Debug().Message("Debug").Write();
                        Log.Info().Message("Info").Write();
                        Log.Warn().Message("Warn").Write();
                        Log.Error().Message("Error").Write();
                        Log.Fatal().Message("Fatal").Write();
                    }
                );

                Console.WriteLine("Hit <Return> to exit");
                Console.ReadLine();

                Instrumentation.Log.Stopped();
            }
        }
    }
}
