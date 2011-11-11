using PROJETO_FINAL_LC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjetoFinal
{
    
    
    /// <summary>
    ///This is a test class for UserTest and is intended
    ///to contain all UserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserTest
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
///A test for User Constructor
///</summary>
[TestMethod()]
public void UserConstructorTest()
{
string login = string.Empty; // TODO: Initialize to an appropriate value
string password = string.Empty; // TODO: Initialize to an appropriate value
string name = string.Empty; // TODO: Initialize to an appropriate value
    User target = new User(login, password, name);
    Assert.Inconclusive("TODO: Implement code to verify target");
}

/// <summary>
///A test for getEvaluetionMethodInfo
///</summary>
[TestMethod()]
public void getEvaluetionMethodInfoTest()
{
string login = string.Empty; // TODO: Initialize to an appropriate value
string password = string.Empty; // TODO: Initialize to an appropriate value
string name = string.Empty; // TODO: Initialize to an appropriate value
User target = new User(login, password, name); // TODO: Initialize to an appropriate value
EvaluetionMethodInfo expected = null; // TODO: Initialize to an appropriate value
    EvaluetionMethodInfo actual;
    actual = target.getEvaluetionMethodInfo();
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for getLogin
///</summary>
[TestMethod()]
public void getLoginTest()
{
string login = string.Empty; // TODO: Initialize to an appropriate value
string password = string.Empty; // TODO: Initialize to an appropriate value
string name = string.Empty; // TODO: Initialize to an appropriate value
User target = new User(login, password, name); // TODO: Initialize to an appropriate value
string expected = string.Empty; // TODO: Initialize to an appropriate value
    string actual;
    actual = target.getLogin();
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for getName
///</summary>
[TestMethod()]
public void getNameTest()
{
string login = string.Empty; // TODO: Initialize to an appropriate value
string password = string.Empty; // TODO: Initialize to an appropriate value
string name = string.Empty; // TODO: Initialize to an appropriate value
User target = new User(login, password, name); // TODO: Initialize to an appropriate value
string expected = string.Empty; // TODO: Initialize to an appropriate value
    string actual;
    actual = target.getName();
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for setEvaluetionMethodInfo
///</summary>
[TestMethod()]
public void setEvaluetionMethodInfoTest()
{
string login = string.Empty; // TODO: Initialize to an appropriate value
string password = string.Empty; // TODO: Initialize to an appropriate value
string name = string.Empty; // TODO: Initialize to an appropriate value
User target = new User(login, password, name); // TODO: Initialize to an appropriate value
EvaluetionMethod evaluetionMethod = new EvaluetionMethod(); // TODO: Initialize to an appropriate value
float lowerLimit = 0F; // TODO: Initialize to an appropriate value
float higherLimit = 0F; // TODO: Initialize to an appropriate value
float step = 0F; // TODO: Initialize to an appropriate value
    target.setEvaluetionMethodInfo(evaluetionMethod, lowerLimit, higherLimit, step);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}
    }
}
