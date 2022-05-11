using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixTrace.Tests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void GetMatrixTrace_Array_Int()
        {
            //arrange
            int[,] array =  {{23, 34, 45},
                             {14, 67, 12},
                             {54, 89, 99},
                             {22, 11, 33}};
            Matrix matrix = new Matrix(array);

            int expected = 189;
            //act
            int result = matrix.GetMatrixTrace();
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetMatrix_Array_Queue()
        {
            //arrange
            int[,] array =  {{23, 34, 45},
                             {14, 67, 12}};
            Matrix matrix = new Matrix(array);

            Queue<MatrixFormattedItem> expected = new Queue<MatrixFormattedItem>();
            expected.Enqueue(new MatrixFormattedItem()
            {
                Color = ConsoleColor.Red,
                ItemString = "23"
            });
            expected.Enqueue(new MatrixFormattedItem()
            {
                Color = ConsoleColor.White,
                ItemString = "34"
            });
            expected.Enqueue(new MatrixFormattedItem()
            {
                Color = ConsoleColor.White,
                ItemString = "45" + "\n"
            });
            expected.Enqueue(new MatrixFormattedItem()
            {
                Color = ConsoleColor.White,
                ItemString = "14"
            });
            expected.Enqueue(new MatrixFormattedItem()
            {
                Color = ConsoleColor.Red,
                ItemString = "67"
            });
            expected.Enqueue(new MatrixFormattedItem()
            {
                Color = ConsoleColor.White,
                ItemString = "12" + "\n"
            });


            //act
            Queue<MatrixFormattedItem> result = matrix.GetMatrix();
            //assert
            for (int i = 0; i < expected.Count; i++)
            {
                MatrixFormattedItem itemExpected = expected.Dequeue();
                MatrixFormattedItem itemResult = result.Dequeue();
                Assert.AreEqual(itemExpected.Color, itemResult.Color);
                Assert.AreEqual(itemExpected.ItemString, itemResult.ItemString);
            }
        }

        [TestMethod]
        public void GetMatrixSnake_Array_String()
        {
            //arrange
            int[,] array =  {{23, 34, 45},
                             {14, 67, 12},
                             {54, 89, 99},
                             {22, 11, 33}};
            Matrix matrix = new Matrix(array);

            string expected = "23;34;45;12;99;33;11;22;54;14;67;89;";
            //act
            string result = matrix.GetMatrixSnake();
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
