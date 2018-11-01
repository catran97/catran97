using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Буква_т;

namespace Буква_т_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void enter_3_letters_T()
        {
            // arrange
            string str = "ттт";
            // act
            int result = Form1.Found_count_T(str);
            int expected = 3;
            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void enter_word_no_T()
        {
            // arrange
            string str = "арбуз";
            // act
            int result = Form1.Found_count_T(str);
            int expected = 0;
            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void enter_eng()
        {
           // arrange
            string str = "Test";
            // act
            int result = Form1.Found_count_T(str);
            int expected = 0;
            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void enter_word_T_not_null()
        {
            // arrange
            string str = "вата";
            // act
            int result = Form1.Found_count_T(str);
            int expected = 0;
            // assert
            Assert.AreNotEqual(expected, result);
        }
    }
}
