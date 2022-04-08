using System;
using System.Collections.Generic;
using Tasks.Task4;
using Tasks.Task5;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dataset CSVData = new Dataset("D:/Faks/4.semestar/RPPOON/LV/primjerCSV.csv");
            IList<List<string>> data = CSVData.GetData(); 
            
            for(int i=0; i < data.Count; i++)
            {
                for(int j=0; j < data[i].Count; j++)
                {
                    Console.WriteLine(data[i][j]);
                }
                
            }

            Dataset dataClone =(Dataset) CSVData.Clone();
            IList<List<string>> clones = CSVData.GetData();

            for (int i = 0; i < clones.Count; i++)
            {
                for (int j = 0; j < clones[i].Count; j++)
                {
                    Console.WriteLine(clones[i][j]);
                }

            }

           dataClone.ClearData();


             dataClone = (Dataset)CSVData.Clone();
            IList<List<string>> cloner = CSVData.GetData();

            for (int i = 0; i < cloner.Count; i++)
            {
                for (int j = 0; j < cloner[i].Count; j++)
                {
                    Console.WriteLine(cloner[i][j]);
                }

            }


            //2.zad.

            MatrixGenerator matrixGenerator = MatrixGenerator.GetInstance();
            double[][] matrix = matrixGenerator.GenerateRandomMatrix(3, 4);

            for(int i=0; i<matrix.Length; i++)
            {                   
                for(int j=0; j<matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]+ " ");    
                }
                Console.Write("\n");
            }


            //3.zad.

            Logger logger = Logger.GetInstance();
            logger.Log("How are you?");

            //4.zad.
            ConsoleNotification notification = new ConsoleNotification("Jana", "mi smo tu", "hi, bye", DateTime.Now, Category.INFO, ConsoleColor.Blue);
            NotificationManager manager = new NotificationManager();

            manager.Display(notification);

            //5.zad.
            NotificationBuilder builder = new NotificationBuilder();
            ConsoleNotification consoleNotification = builder.Build();
            manager.Display(consoleNotification);  // !!!

         
            builder.SetAuthor("Tia");
            builder.SetColor(ConsoleColor.Green);

            consoleNotification = builder.Build(); // pazi
            manager.Display(consoleNotification);

            //6.zad

            Director director = new Director();
            NotificationBuilder note = (NotificationBuilder)director.ConstructNotificationAlert("Filipa");
            ConsoleNotification notif = note.Build();
            manager.Display(notif);

            director.ConstructNotificationError("Luka");
            director.ConstructNotificationInfo("Family");

            //7.zad
            ConsoleNotification clonedNotification = (ConsoleNotification)consoleNotification.Clone();
            manager.Display(consoleNotification);


        }
    }
}
