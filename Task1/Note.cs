using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Note
    {
        /// <summary>
        /// The method shows note.
        /// </summary>
        /// <param name="sender">0object of class clock</param>
        /// <param name="eventArgs">Set info about event</param>
        private void ShowNote(Object sender, NewEventArgs eventArgs)
        {
            Console.WriteLine("You need to know :");
            Console.WriteLine("Text = {0}, Time = {1} hh:mm:ss", eventArgs.Message, eventArgs.Time);
        }

        public void Unregister(Clock clock)
        {
            clock.NewEvent -= ShowNote;
        }

        public void Register(Clock clock)
        {
            clock.NewEvent += ShowNote;
        }
    }
}
