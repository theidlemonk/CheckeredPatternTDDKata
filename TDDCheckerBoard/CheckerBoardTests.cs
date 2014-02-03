using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckerBoard;

namespace TDDCheckerBoard
{
    [TestClass]
    public class CheckerBoardTests
    {
        [TestMethod]
        public void IsEvenTests()
        {
            Assert.IsTrue(CheckeredPatterns.IsEven(2));
            Assert.IsFalse(CheckeredPatterns.IsEven(3));
            Assert.IsTrue(CheckeredPatterns.IsEven(6));
            Assert.IsFalse(CheckeredPatterns.IsEven(9));
        }

        [TestMethod]
        public void OnPassingOddNumbersReturnsRowOneCrissCrossPattern()
        {
            string rowOneCrissCrossPattern = "- x - x - x - x - x";
            Assert.AreEqual(rowOneCrissCrossPattern, CheckeredPatterns.GetCrissCrossPatternForRow(1));
            Assert.AreEqual(rowOneCrissCrossPattern, CheckeredPatterns.GetCrissCrossPatternForRow(3));
            Assert.AreEqual(rowOneCrissCrossPattern, CheckeredPatterns.GetCrissCrossPatternForRow(5));
        }

        [TestMethod]
        public void OnPassingEvenNumbersReturnsRowTwoCrissCrossPattern()
        {
            string rowTwoCrissCrossPattern = "x - x - x - x - x -";
            Assert.AreEqual(rowTwoCrissCrossPattern, CheckeredPatterns.GetCrissCrossPatternForRow(2));
            Assert.AreEqual(rowTwoCrissCrossPattern, CheckeredPatterns.GetCrissCrossPatternForRow(6));
            Assert.AreEqual(rowTwoCrissCrossPattern, CheckeredPatterns.GetCrissCrossPatternForRow(8));
        }

        [TestMethod]
        public void OnPassingOddNumbersReturnRowTwoCrissCrossInvesterPattern()
        {
            string rowOneCrissCrossInvertedPattern = "x - x - x - x - x -";
            Assert.AreEqual(rowOneCrissCrossInvertedPattern, CheckeredPatterns.GetCrissCrossInvertedPatternForRow(1));
            Assert.AreEqual(rowOneCrissCrossInvertedPattern, CheckeredPatterns.GetCrissCrossInvertedPatternForRow(3));
            Assert.AreEqual(rowOneCrissCrossInvertedPattern, CheckeredPatterns.GetCrissCrossInvertedPatternForRow(5));
        }

        [TestMethod]
        public void OnPassingEvenNumbersReturnRowOneCrissCrossInvesterPattern()
        {
            string rowOneCrissCrossInvertedPattern = "- x - x - x - x - x";
            Assert.AreEqual(rowOneCrissCrossInvertedPattern, CheckeredPatterns.GetCrissCrossInvertedPatternForRow(4));
            Assert.AreEqual(rowOneCrissCrossInvertedPattern, CheckeredPatterns.GetCrissCrossInvertedPatternForRow(6));
            Assert.AreEqual(rowOneCrissCrossInvertedPattern, CheckeredPatterns.GetCrissCrossInvertedPatternForRow(10));
        }

        [TestMethod]
        public void OnPassingEvenNumbersReturnRowOneZebraPattern()
        {
            string rowOneZebraPattern = "x x x x x x x x x x";
            Assert.AreEqual(rowOneZebraPattern, CheckeredPatterns.GetZebraPatternForRow(0));
            Assert.AreEqual(rowOneZebraPattern, CheckeredPatterns.GetZebraPatternForRow(2));
            Assert.AreEqual(rowOneZebraPattern, CheckeredPatterns.GetZebraPatternForRow(8));
            Assert.AreEqual(rowOneZebraPattern, CheckeredPatterns.GetZebraPatternForRow(6));
        }

        [TestMethod]
        public void OnPassingOddNumbersReturnRowTwoZebraPattern()
        {
            string rowTwoZebraPattern = "- - - - - - - - - -";
            Assert.AreEqual(rowTwoZebraPattern, CheckeredPatterns.GetZebraPatternForRow(1));
            Assert.AreEqual(rowTwoZebraPattern, CheckeredPatterns.GetZebraPatternForRow(3));
            Assert.AreEqual(rowTwoZebraPattern, CheckeredPatterns.GetZebraPatternForRow(5));
            Assert.AreEqual(rowTwoZebraPattern, CheckeredPatterns.GetZebraPatternForRow(9));
        }

        [TestMethod]
        public void OnPassingEvenNumbersReturnRowOneZebraInvertedPattern()
        {
            string rowOneZebraPattern = "- - - - - - - - - -";
            Assert.AreEqual(rowOneZebraPattern, CheckeredPatterns.GetZebraInvertedPatternForRow(0));
            Assert.AreEqual(rowOneZebraPattern, CheckeredPatterns.GetZebraInvertedPatternForRow(2));
            Assert.AreEqual(rowOneZebraPattern, CheckeredPatterns.GetZebraInvertedPatternForRow(8));
            Assert.AreEqual(rowOneZebraPattern, CheckeredPatterns.GetZebraInvertedPatternForRow(6));
        }

        [TestMethod]
        public void OnPassingOddNumbersReturnRowTwoZebraInvertedPattern()
        {
            string rowTwoZebraPattern = "x x x x x x x x x x";
            Assert.AreEqual(rowTwoZebraPattern, CheckeredPatterns.GetZebraInvertedPatternForRow(1));
            Assert.AreEqual(rowTwoZebraPattern, CheckeredPatterns.GetZebraInvertedPatternForRow(3));
            Assert.AreEqual(rowTwoZebraPattern, CheckeredPatterns.GetZebraInvertedPatternForRow(5));
            Assert.AreEqual(rowTwoZebraPattern, CheckeredPatterns.GetZebraInvertedPatternForRow(9));
        }
    }
}
