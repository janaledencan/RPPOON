using System;
using System.Collections.Generic;
using System.Text;

/*Napisati konkretnu klasu za direktora koja izlaže metode za stvaranje podrazumijevanih INFO, ALERT i
ERROR razina obavijesti (koristiti enum Category). Jedini parametar koji se predaje metodi je autor, sve
ostale parametre postavlja se na podrazumijevane vrijednosti prema Vašem izboru.*/

namespace Tasks.Task5
{
    class Director
    {
        public IBuilder ConstructNotificationAlert(string author)
        {
            IBuilder builder = new NotificationBuilder();
            builder.SetTitle("My life").SetAuthor(author).SetColor(ConsoleColor.Red).SetLevel(Task4.Category.ALERT);
            return builder;
        }

        public IBuilder ConstructNotificationInfo(string author)
        {
            IBuilder builder = new NotificationBuilder();
            builder.SetTitle("My knife").SetAuthor(author).SetLevel(Task4.Category.INFO);
            return builder;
        }

        public IBuilder ConstructNotificationError(string author)
        {
            IBuilder builder = new NotificationBuilder();
            builder.SetTitle("My Nike").SetAuthor(author).SetLevel(Task4.Category.ERROR);
            return builder;
        }
    }
}
