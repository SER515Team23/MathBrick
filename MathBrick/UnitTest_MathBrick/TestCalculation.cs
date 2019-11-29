using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_MathBrick
{
    [TestClass]
    public class TestCalculation
    {
        [TestMethod]
        public void TestCalculate_Add()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("87+5+3");
            Assert.AreEqual("95", theCalcul.Calculate());
        }

        [TestMethod]
        public void TestCalculate_Sub()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("110-9-1");
            Assert.AreEqual("100", theCalcul.Calculate());
        }

        [TestMethod]
        public void TestCalculate_Mult()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("6*5*1.1");
            Assert.AreEqual("33.0", theCalcul.Calculate());
        }

        [TestMethod]
        public void TestCalculate_Divide()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("65/5/13");
            Assert.AreEqual("1", theCalcul.Calculate());
        }

        [TestMethod]
        public void TestCalculate_DivideByZero()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("9/0");
            Assert.IsTrue(double.IsInfinity(Convert.ToDouble(theCalcul.Calculate())));
        }
    }
}
