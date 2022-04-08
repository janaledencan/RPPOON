using System;
using System.Collections.Generic;
using System.Text;

/*Kreirajte singleton koji predstavlja generator matrica. Klasa treba pružiti metodu kojoj se predaju dimenzije
matrice (broj redaka i broj stupaca) i koja vraća matricu popunjenu realnim pseudo-slučajnim brojevima iz
intervala [0,1). Koliko odgovornosti ima navedena metoda?*/

namespace Tasks
{
    internal class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random generator;
        private MatrixGenerator()
        {
            this.generator = new Random();
        }
        public double[][] GenerateRandomMatrix(int rows, int columns)
        {
            double[][] realNumMatrix = new double[rows][];
            //Random generator = new Random();

            for (int i = 0; i < rows; i++)
            {
                realNumMatrix[i] = new double[columns];
                for(int j=0; j < columns; j++)
                {
                    realNumMatrix[i][j] = generator.NextDouble();
                }
            }
            return realNumMatrix;
        }

        public static MatrixGenerator GetInstance()
        {
            if(instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }
    }
}
