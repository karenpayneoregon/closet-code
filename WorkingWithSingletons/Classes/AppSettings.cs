
using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;

namespace WorkingWithSingletons.Classes
{


    public sealed class AppSettings
    {
        private static readonly Lazy<AppSettings> Lazy =
            new(() => new AppSettings());

        private const int _max = 5;
        public static AppSettings Instance => Lazy.Value;
        public string PresentValue { get; set; }
        public string NormalValue { get; set; }
        public string[] PValue { get; set; } = new string[_max];
        public string[] NValue { get; set; } = new string[_max];
        public int Index { get; set; }

        public void Increment()
        {
            if (Index + 1 < _max)
            {
                Index++;
            }
            else
            {
                Index = 0;
            }
        }

        public void Decrement()
        {
            Index--;
            if (Index < 0)
            {
                Index = _max - 1;
            }
        }

        public string GetPValue() => PValue[Index];
        public string GetNValue() => NValue[Index];

        public void SetPValue(string sender)
        {
            PValue[Index] = sender;
        }

        public void SetNValue(string sender)
        {
            NValue[Index] = sender;
        }
    }


}