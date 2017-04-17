using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{

    internal class Clock
    {
        public delegate void NewEventHandler(object sender, NewEventArgs e);
        public event NewEventHandler NewEvent;
        protected virtual void OnNewEvent(object sender, NewEventArgs e)
        {
            NewEvent?.Invoke(sender, e);
        }
        /// <summary>
        /// The method set new event.
        /// </summary>
        /// <param name="message">Input message</param>
        /// <param name="time">Input time</param>
        public void SetNewEvent(string message, string time)
        {
            if (ReferenceEquals(message, null) || ReferenceEquals(time, null)) throw new ArgumentException("one or bouth arguments are null");
            int milliseconds;
            string[] splitedTime = time.Split(':');
            int[] timeInt = new int[splitedTime.Length];
            for (int i = 0; i < splitedTime.Length; i++)
                if (!int.TryParse(splitedTime[i], out timeInt[splitedTime.Length - 1 - i]))
                    throw new ArgumentException("Invalid value of time");
            switch (timeInt.Length)
            {
                case 3:
                    timeInt[1] += timeInt[2] * 60;
                    goto case 2;
                case 2:
                    timeInt[0] += timeInt[1] * 60;
                    goto case 1;
                case 1:
                    milliseconds = timeInt[0] * 1000;
                    break;
                default:
                    throw new ArgumentException("Invalid value of time");
            }
            Thread.Sleep(milliseconds);
            OnNewEvent(this, new NewEventArgs(message, time));
        }
    }
    internal sealed class NewEventArgs : EventArgs
    {
        private readonly string message, time;
        public NewEventArgs(string message, string time)
        {
            this.message = message;
            this.time = time;
        }
        public string Message => message;
        public string Time => time;
    }
}
