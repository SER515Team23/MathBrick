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

        [TestMethod]
        public void TestLinearEquation()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("3x+9=12");
            Assert.AreEqual("x=1", theCalcul.LinearEquation());
        }

        [TestMethod]
        public void TestLinearEquation_Nosolution()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("3x=3x");
            Assert.AreEqual("No Solution!", theCalcul.LinearEquation());
        }

        [TestMethod]
        public void TestLinearEquation_Error()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("3x*2=3x");
            Assert.AreEqual("error", theCalcul.LinearEquation());
        }

        [TestMethod]
        public void TestQuadraticEquation()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("x^2-2x-3=0");
            Assert.AreEqual("x1=3    x2=-1", theCalcul.QuadraticEquation());
        }

        [TestMethod]
        public void TestQuadraticEquation_SameSolution()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("x^2+4x+4=0");
            Assert.AreEqual("x1=-2    x2=-2", theCalcul.QuadraticEquation());
        }

        public void TestQuadraticEquation_NoSolution()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("x^2-x+9=0");
            Assert.AreEqual("No Solution!", theCalcul.QuadraticEquation());
        }

        public void TestQuadraticEquation_Error()
        {
            MathBrick.Calculation theCalcul = new MathBrick.Calculation("x^2*x-x+9=0");
            Assert.AreEqual("error", theCalcul.QuadraticEquation());
        }
    }
}
