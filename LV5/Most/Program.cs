using System;

namespace Most
{
    class Program
    {
        static void Main(string[] args)
        {
            ReminderNote note = new ReminderNote("Hello, who is this?", new DarkTheme());

            note.Show();
        }
    }
}
