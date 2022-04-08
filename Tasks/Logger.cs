using System;
using System.Collections.Generic;
using System.Text;

/*Kreirajte singleton koji predstavlja logger. Navedeni logger treba omogućiti logiranje u zadanu datoteku koju
se postavlja preko odgovarajućeg svojstva, a u konstruktoru se postavlja na neku podrazumijevanu
vrijednost.*/

namespace Tasks
{
    internal class Logger
    {
        private string filePath;
        private static Logger instance;
        private Logger(){

            this.filePath = "D:/Faks/4.semestar/RPPOON/LV/loger.txt";   
        }

        private void SetFilePath(string filePath) {
            
            this.filePath = filePath;
        }

        public static Logger GetInstance()
        {
            if(instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }


        public void Log(string message)
        {     
            using (System.IO.StreamWriter writer =
              new System.IO.StreamWriter(this.filePath, true))
            {
               writer.WriteLine(message);
            }
            
        }
    }
}
