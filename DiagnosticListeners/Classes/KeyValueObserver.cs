using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DiagnosticListeners.Classes
{
    public class KeyValueObserver : IObserver<KeyValuePair<string, object>>
    {
        public void OnCompleted()
            => throw new NotImplementedException();

        public void OnError(Exception error)
            => throw new NotImplementedException();

        public void OnNext(KeyValuePair<string, object> value)
        {
            if (value.Key == CoreEventId.ContextInitialized.Name)
            {
                var payload = (ContextInitializedEventData)value.Value;
                Console.WriteLine($"EF is initializing {payload.Context.GetType().Name} ");
            }

            if (value.Key == RelationalEventId.ConnectionOpening.Name)
            {
                var payload = (ConnectionEventData)value.Value;
                Console.WriteLine($"EF is opening a connection to {payload.Connection.ConnectionString} ");
            }
        }
    }
}