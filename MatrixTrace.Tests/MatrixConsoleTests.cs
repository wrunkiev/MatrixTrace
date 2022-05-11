using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MatrixTrace.Tests
{
    [TestClass]
    public class MatrixConsoleTests
    {
        [TestMethod]
        public void MatrixToConsole_Queue_Pass()
        {
            //arrange
            MatrixConsole m = new MatrixConsole();
            Queue<MatrixFormattedItem> matrixItems = new Queue<MatrixFormattedItem>();
            matrixItems.Enqueue(new MatrixFormattedItem()
            {
                Color = ConsoleColor.Red,
                ItemString = "1"
            });
            matrixItems.Enqueue(new MatrixFormattedItem()
            {
                Color = ConsoleColor.Red,
                ItemString = "2"
            });
            matrixItems.Enqueue(new MatrixFormattedItem()
            {
                Color = ConsoleColor.Red,
                ItemString = "3"
            });

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            string expected = $"{"1",4}{"2",4}{"3",4}";
            //act
            m.MatrixToConsole(matrixItems);
            //assert
            Assert.AreEqual(expected, stringWriter.ToString());
        }

        [TestMethod]
        public void MatrixSnakeToConsole_String_Pass()
        {
            //arrange
            MatrixConsole m = new MatrixConsole();
            string input = "tests";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            string expected = "test" + Environment.NewLine;
            //act
            m.MatrixSnakeToConsole(input);

            //assert
            Assert.AreEqual(expected, stringWriter.ToString());
        }

        [TestMethod]
        public void PrintMessage_String_Pass()
        {
            //arrange            
            string input = "tests";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            string expected = "tests" + Environment.NewLine;

            //act
            MatrixConsole.PrintMessage(input);

            //assert
            Assert.AreEqual(expected, stringWriter.ToString());
        }
    }
}
