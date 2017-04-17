using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class CUI
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Note note = new Note();
            AlarmClock alarmClock = new AlarmClock(clock);
            note.Register(clock);
            Console.WriteLine("message :");
            string message = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("set time (format hh:mm:ss)");
            string time = Console.ReadLine();
            clock.SetNewEvent(message, time);
            Console.ReadKey();
        }
    }
}
