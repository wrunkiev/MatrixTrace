using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixTrace
{
    public class MatrixConsole
    {
        public void MatrixToConsole(Queue<MatrixFormattedItem> matrixItems)
        {            
            foreach (MatrixFormattedItem item in matrixItems)
            {
                Console.ForegroundColor = item.Color;
                Console.Write("{0, 4}", item.ItemString);
            }            
        }

        public void MatrixSnakeToConsole(string matrixSnakeString)
        {
            string matrixSnake = matrixSnakeString.Substring(0, matrixSnakeString.Length - 1);
            Console.WriteLine(matrixSnake);
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintMsg(string msg)
        {
            Console.Write(msg);
        }      
    }
}
