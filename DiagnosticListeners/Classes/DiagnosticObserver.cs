using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace DiagnosticListeners.Classes
{
    public class DiagnosticObserver : IObserver<DiagnosticListener>
    {
        public void OnCompleted()
            => throw new NotImplementedException();

        public void OnError(Exception error)
            => throw new NotImplementedException();

        public void OnNext(DiagnosticListener value)
        {
            if (value.Name == DbLoggerCategory.Name) // "Microsoft.EntityFrameworkCore"
            {
                value.Subscribe(new KeyValueObserver());
            }
        }
    }
}