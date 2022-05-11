using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixTrace.Tests
{
    [TestClass]
    public class MatrixValidatorTests
    {
        [TestMethod]
        public void ValidateSizeInput_StringNull_String()
        {
            //arrange
            string input = null;
            string expected = "The input can't be empty";
            //act
            string result = MatrixValidator.ValidateSizeInput(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidateSizeInput_StringEmpty_String()
        {
            //arrange
            string input = "";
            string expected = "The input can't be empty";
            //act
            string result = MatrixValidator.ValidateSizeInput(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidateSizeInput_StringStr_String()
        {
            //arrange
            string input = "f";
            string expected = "The input must be integer";
            //act
            string result = MatrixValidator.ValidateSizeInput(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidateSizeInput_StringInt_String()
        {
            //arrange
            string input = "5";
            string expected = "";
            //act
            string result = MatrixValidator.ValidateSizeInput(input);
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
