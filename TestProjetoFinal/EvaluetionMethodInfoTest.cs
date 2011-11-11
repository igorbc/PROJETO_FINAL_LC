using PROJETO_FINAL_LC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjetoFinal
{
    
    
    /// <summary>
    ///This is a test class for EvaluetionMethodInfoTest and is intended
    ///to contain all EvaluetionMethodInfoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EvaluetionMethodInfoTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


/// <summary>
///A test for EvaluetionMethodInfo Constructor
///</summary>
[TestMethod()]
public void EvaluetionMethodInfoConstructorTest()
{
EvaluetionMethod evaluetionMethod = new EvaluetionMethod(); // TODO: Initialize to an appropriate value
float lowerLimit = 0F; // TODO: Initialize to an appropriate value
float higherLimit = 0F; // TODO: Initialize to an appropriate value
float step = 0F; // TODO: Initialize to an appropriate value
    EvaluetionMethodInfo target = new EvaluetionMethodInfo(evaluetionMethod, lowerLimit, higherLimit, step);
    Assert.Inconclusive("TODO: Implement code to verify target");
}

/// <summary>
///A test for getEvaluetionMethod
///</summary>
[TestMethod()]
public void getEvaluetionMethodTest()
{
EvaluetionMethod evaluetionMethod = new EvaluetionMethod(); // TODO: Initialize to an appropriate value
float lowerLimit = 0F; // TODO: Initialize to an appropriate value
float higherLimit = 0F; // TODO: Initialize to an appropriate value
float step = 0F; // TODO: Initialize to an appropriate value
EvaluetionMethodInfo target = new EvaluetionMethodInfo(evaluetionMethod, lowerLimit, higherLimit, step); // TODO: Initialize to an appropriate value
EvaluetionMethod expected = new EvaluetionMethod(); // TODO: Initialize to an appropriate value
    EvaluetionMethod actual;
    actual = target.getEvaluetionMethod();
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for getHigherLimit
///</summary>
[TestMethod()]
public void getHigherLimitTest()
{
EvaluetionMethod evaluetionMethod = new EvaluetionMethod(); // TODO: Initialize to an appropriate value
float lowerLimit = 0F; // TODO: Initialize to an appropriate value
float higherLimit = 0F; // TODO: Initialize to an appropriate value
float step = 0F; // TODO: Initialize to an appropriate value
EvaluetionMethodInfo target = new EvaluetionMethodInfo(evaluetionMethod, lowerLimit, higherLimit, step); // TODO: Initialize to an appropriate value
float expected = 0F; // TODO: Initialize to an appropriate value
    float actual;
    actual = target.getHigherLimit();
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for getLowerLimit
///</summary>
[TestMethod()]
public void getLowerLimitTest()
{
EvaluetionMethod evaluetionMethod = new EvaluetionMethod(); // TODO: Initialize to an appropriate value
float lowerLimit = 0F; // TODO: Initialize to an appropriate value
float higherLimit = 0F; // TODO: Initialize to an appropriate value
float step = 0F; // TODO: Initialize to an appropriate value
EvaluetionMethodInfo target = new EvaluetionMethodInfo(evaluetionMethod, lowerLimit, higherLimit, step); // TODO: Initialize to an appropriate value
float expected = 0F; // TODO: Initialize to an appropriate value
    float actual;
    actual = target.getLowerLimit();
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for getStep
///</summary>
[TestMethod()]
public void getStepTest()
{
EvaluetionMethod evaluetionMethod = new EvaluetionMethod(); // TODO: Initialize to an appropriate value
float lowerLimit = 0F; // TODO: Initialize to an appropriate value
float higherLimit = 0F; // TODO: Initialize to an appropriate value
float step = 0F; // TODO: Initialize to an appropriate value
EvaluetionMethodInfo target = new EvaluetionMethodInfo(evaluetionMethod, lowerLimit, higherLimit, step); // TODO: Initialize to an appropriate value
float expected = 0F; // TODO: Initialize to an appropriate value
    float actual;
    actual = target.getStep();
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}
    }
}
