using System;
using System.Linq;
using NullCoalescingOperatorApp.Models;

namespace NullCoalescingOperatorApp.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// If <see cref="key"/> not found, create it
        /// </summary>
        /// <param name="account">instance of an <see cref="Account"/></param>
        /// <param name="key">Key to find</param>
        /// <param name="newIfNull">if true create else null</param>
        /// <returns><see cref="Setting"/></returns>
        public static Setting GetSetting(this Account account, string key, bool newIfNull = true) =>
            account.Settings
                .FirstOrDefault(setting =>
                    setting.Key.Equals(key, StringComparison.CurrentCultureIgnoreCase)) ??
            (newIfNull ? new Setting { Key = key } : null);
    }
}
