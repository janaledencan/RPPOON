using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Task4;

/*Napisati konkretnu klasu NotificationBuilder koja implementira sučelje IBuilder. Klasa mora omogućiti sve
metode koje propisuje sučelje, a sama treba brinuti o čuvanju privremenih vrijednosti sve dok objekt
ConsoleNotification nije izgrađen kao i o podrazumijevanim vrijednostima istih. Taj se objekt izgrađuje
metodom Build() korištenjem parametarskog konstruktora klase čiji se objekt izgrađuje.*/

namespace Tasks.Task5
{
    class NotificationBuilder : IBuilder
    {
        private string author= "Jana";
        private ConsoleColor color = ConsoleColor.Blue;
        private Category level = Category.ERROR;
        private string text = "Hello";
        private DateTime time = DateTime.Now;
        private string title = "Pale sam na svijetu";

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, time, level, color );
        }

        public IBuilder SetAuthor(string author)
        {
            this.author = author;
            return this;
        }

        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }

        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }

        public IBuilder SetText(string text)
        {
            this.text = text;
            return this;
        }

        public IBuilder SetTime(DateTime time)
        {
            this.time = time;
            return this;
        }

        public IBuilder SetTitle(string title)
        {
            this.title = title;
            return this;
        }
    }
}
