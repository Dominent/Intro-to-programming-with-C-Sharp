using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrixSpiralCSharp
{
    class PrintMatrixSpiralCSharp
    {
        static void Main(string[] args)
        {
            int input = 0;
            int[,] spiralMatrix;
            int column = 0;
            int row = 0;
            int direction = 2;              //[0]- DOWN, [1]-UP, [2]-RIGHT, [3]-LEFT

            Console.WriteLine("Enter N: ");
            input = Convert.ToInt32(Console.ReadLine());

            int counter = input * input;

            spiralMatrix = new int[input, input];

            for (int i = 1; i <= counter; ++i)         //Clockwise change of direction - right, down ,left ,up
            {
                if (direction == 0 && (row > input - 1 || spiralMatrix[row, column] != 0))            // Down
                {
                    direction = 3;
                    column--;
                    row--;
                }
                else if (direction == 1 && (row < 0 || spiralMatrix[row, column] != 0))                //Up
                {
                    direction = 2;
                    column++;
                    row++;
                }
                else if (direction == 2 && (column > input - 1 || spiralMatrix[row, column] != 0))    //Right
                {
                    direction = 0;
                    column--;
                    row++;
                }
                else if (direction == 3 && (column < 0 || spiralMatrix[row, column] != 0))          //Left
                {
                    direction = 1;
                    column++;
                    row--;
                }

                spiralMatrix[row, column] = i;

                switch (direction)
                {
                    case 0:
                        row++;
                        break;
                    case 1:
                        row--;
                        break;
                    case 2:
                        column++;
                        break;
                    case 3:
                        column--;
                        break;
                }
            }
            for (int i = 0; i < input; ++i) // for each iteration of i, j is iterated n times !
            {
                for (int j = 0; j < input; ++j)
                {
                    Console.Write("{0,3}", spiralMatrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
