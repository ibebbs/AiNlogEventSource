# AiNlogEventSource
Reproduction of issue combining ApplicationInsights, EventFlow and NLog

## Steps

1. Start new console app
1. Install Microsoft.ApplicationInsights.WindowsServer
1. Add an 'InstrumentationKey' (doesn't matter if it's valid or not) to the (automatically created) ApplicationInsights.config file.
1. Set BuildAction for ApplicationInsights.config to "Content"
1. Install Microsoft.ApplicationInsights.NLogTarget
1. Install Microsoft.Diagnostics.EventFlow.Inputs.EventSource
1. Install Microsoft.Diagnostics.EventFlow.Outputs.StdOutput
1. Install Microsoft.Diagnostics.EventFlow.Outputs.ApplicationInsights
1. Add eventFlowConfig.json and set Copy to Output Directory to "Copy if newer"
1. Add Instrumentation.cs