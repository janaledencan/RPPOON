using System;
using System.Collections.Generic;
using System.Text;

/*5.zad Dati implementaciju metoda gdje ona nedostaje u primjeru 3 te ga testirati doradom teksta programa danog
u nastavku. Metoda WriteMessage() u klasi FileLogger treba uz poruku zapisati i njen tip i vrijeme zapisa.*/

namespace ChainOfResponsibility
{
    class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using (System.IO.StreamWriter writer =
             new System.IO.StreamWriter(this.filePath, true))
            {
                writer.WriteLine(message);
                writer.WriteLine("Type:" + type);
                writer.Write(" Time: "+ DateTime.Now);
            }
            

        }
    }
}
