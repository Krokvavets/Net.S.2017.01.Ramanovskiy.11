using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class AlarmClock
    {
        public AlarmClock(Clock clock)
        {
            clock.NewEvent += ShowNote;
        }
        /// <summary>
        /// The method shows message.
        /// </summary>
        /// <param name="sender">0object of class clock</param>
        /// <param name="eventArgs">Set info about event</param>
        private void ShowNote(Object sender, NewEventArgs eventArgs)
        {
            Console.WriteLine("wake up and remember :");
            Console.WriteLine("Text = {0}, You sleep = {1} hh:mm:ss", eventArgs.Message, eventArgs.Time);
        }

        public void Unregister(Clock clock)
        {
            clock.NewEvent -= ShowNote;
        }
    }
}
