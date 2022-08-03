using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace EventsGetInvocationListFormsApp.Extensions
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Unsubscribe from <see cref="eventName"/> for <see cref="control"/>
        /// </summary>
        /// <param name="control">Control to get details for</param>
        /// <param name="eventName">Event name to get details</param>
        /// <returns>Delegate array</returns>
        /// <remarks>
        /// If there are no events subscriptions an empty array is returned
        /// </remarks>
        public static Delegate[] DisableEvents(this Control control, string eventName)
        {
            var eventHandler = GetInformation(control, eventName);

            // no subscriptions 
            if (eventHandler == null)
            {
                return new Delegate[] { };
            }

            Delegate[] invocationList = eventHandler.GetInvocationList();

            foreach (var delegateItem in invocationList)
            {
                control.GetType().GetEvent(eventName).RemoveEventHandler(control, delegateItem);
            }

            return invocationList;

        }

        /// <summary>
        /// Get count of how many times <see cref="eventName"/> is subscribed to <see cref="control"/>
        /// </summary>
        /// <param name="control">Control to get details for</param>
        /// <param name="eventName">Event name to get details</param>
        /// <returns>Count of subscriptions for eventName</returns>
        public static int EventCount(this Control control, string eventName)
        {
            var eventHandler = GetInformation(control, eventName);

            // no subscriptions 
            return eventHandler == null ? 0 : eventHandler.GetInvocationList().Length;
        }

        private static Delegate GetInformation(Control control, string eventName)
        {
            PropertyInfo propertyInfo = control.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);

            var eventHandlerList = propertyInfo.GetValue(control, new object[] { }) as EventHandlerList;

            FieldInfo fieldInfo = typeof(Control).GetField("Event" + eventName,
                BindingFlags.NonPublic | BindingFlags.Static);

            var eventKey = fieldInfo.GetValue(control);
            var eventHandler = eventHandlerList[eventKey];

            return eventHandler;
        }
    }
}