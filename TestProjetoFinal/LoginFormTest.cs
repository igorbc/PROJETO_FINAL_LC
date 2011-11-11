using PROJETO_FINAL_LC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjetoFinal
{
    
    
    /// <summary>
    ///This is a test class for LoginFormTest and is intended
    ///to contain all LoginFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LoginFormTest
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
///A test for LoginForm Constructor
///</summary>
[TestMethod()]
public void LoginFormConstructorTest()
{
    LoginForm target = new LoginForm();
    Assert.Inconclusive("TODO: Implement code to verify target");
}

/// <summary>
///A test for Dispose
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void DisposeTest()
{
LoginForm_Accessor target = new LoginForm_Accessor(); // TODO: Initialize to an appropriate value
bool disposing = false; // TODO: Initialize to an appropriate value
    target.Dispose(disposing);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for InitializeComponent
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void InitializeComponentTest()
{
LoginForm_Accessor target = new LoginForm_Accessor(); // TODO: Initialize to an appropriate value
    target.InitializeComponent();
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for LoginForm_Load
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void LoginForm_LoadTest()
{
LoginForm_Accessor target = new LoginForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.LoginForm_Load(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for LoginForm_Shown
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void LoginForm_ShownTest()
{
LoginForm_Accessor target = new LoginForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.LoginForm_Shown(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for btnLogIn_Click
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void btnLogIn_ClickTest()
{
LoginForm_Accessor target = new LoginForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.btnLogIn_Click(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for btnRegistration_Click
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void btnRegistration_ClickTest()
{
LoginForm_Accessor target = new LoginForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.btnRegistration_Click(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for checksIfUserAlreadyExists
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void checksIfUserAlreadyExistsTest()
{
LoginForm_Accessor target = new LoginForm_Accessor(); // TODO: Initialize to an appropriate value
string name = string.Empty; // TODO: Initialize to an appropriate value
bool expected = false; // TODO: Initialize to an appropriate value
    bool actual;
    actual = target.checksIfUserAlreadyExists(name);
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

/// <summary>
///A test for emptyFieldsWarning
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void emptyFieldsWarningTest()
{
LoginForm_Accessor target = new LoginForm_Accessor(); // TODO: Initialize to an appropriate value
    target.emptyFieldsWarning();
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for getUserName
///</summary>
[TestMethod()]
public void getUserNameTest()
{
LoginForm target = new LoginForm(); // TODO: Initialize to an appropriate value
string expected = string.Empty; // TODO: Initialize to an appropriate value
    string actual;
    actual = target.getUserName();
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}
    }
}
