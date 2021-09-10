using MyNUnitDemo.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    class CalculateScoreServiceTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        //given-when-then
        [Test]
        public void Score73_Execute_True()
        {
            var calc = new CalculateScoreService();
            var res = calc.Execute("73");

            //check unit
            Assert.True(res);
        }

        [Test]
        public void Score50_Execute_True()
        {
            var calc = new CalculateScoreService();
            var res = calc.Execute("50");

            //check unit
            Assert.True(res);
        }
        [Test]
        public void Score21_Execute_False()
        {
            var calc = new CalculateScoreService();
            var res = calc.Execute("21");

            //check unit
            Assert.False(res);
        }
        [Test]
        public void ScoreXXX_Execute_TrowException()
        {
            var expected = "Error! Please input number.";
            var calc = new CalculateScoreService();
            //var res = calc.Execute("xxx");
            var res = Assert.Throws<Exception>(() => calc.Execute("XXX"));

            //check unit
            Assert.AreEqual(expected, res.Message);
        }
        [Test]
        public void ScoreNull_Execute_TrowException()
        {
            var expected = "Error! Please input number.";
            var calc = new CalculateScoreService();
            //var res = calc.Execute("xxx");
            var res = Assert.Throws<Exception>(() => calc.Execute(null));

            //check unit
            Assert.AreEqual(expected, res.Message);
        }
        [Test]
        public void Score500point25_Execute_TrowException()
        {
            var expected = "Error! Please input number.";
            var calc = new CalculateScoreService();
            //var res = calc.Execute("xxx");
            var res = Assert.Throws<Exception>(() => calc.Execute("500.25"));

            //check unit
            Assert.AreEqual(expected, res.Message);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}