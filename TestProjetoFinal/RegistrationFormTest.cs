using PROJETO_FINAL_LC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjetoFinal
{
    
    
    /// <summary>
    ///This is a test class for RegistrationFormTest and is intended
    ///to contain all RegistrationFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RegistrationFormTest
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
///A test for RegistrationForm Constructor
///</summary>
[TestMethod()]
public void RegistrationFormConstructorTest()
{
string login = string.Empty; // TODO: Initialize to an appropriate value
string password = string.Empty; // TODO: Initialize to an appropriate value
    RegistrationForm target = new RegistrationForm(login, password);
    Assert.Inconclusive("TODO: Implement code to verify target");
}

/// <summary>
///A test for Dispose
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void DisposeTest()
{
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
RegistrationForm_Accessor target = new RegistrationForm_Accessor(param0); // TODO: Initialize to an appropriate value
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
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
RegistrationForm_Accessor target = new RegistrationForm_Accessor(param0); // TODO: Initialize to an appropriate value
    target.InitializeComponent();
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for RegistrationForm_Load
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void RegistrationForm_LoadTest()
{
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
RegistrationForm_Accessor target = new RegistrationForm_Accessor(param0); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.RegistrationForm_Load(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for RegistrationForm_Shown
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void RegistrationForm_ShownTest()
{
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
RegistrationForm_Accessor target = new RegistrationForm_Accessor(param0); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.RegistrationForm_Shown(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for btnFinishRegistration_Click
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void btnFinishRegistration_ClickTest()
{
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
RegistrationForm_Accessor target = new RegistrationForm_Accessor(param0); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.btnFinishRegistration_Click(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for cbbHigherLimit_SelectedIndexChanged
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void cbbHigherLimit_SelectedIndexChangedTest()
{
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
RegistrationForm_Accessor target = new RegistrationForm_Accessor(param0); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.cbbHigherLimit_SelectedIndexChanged(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for createTheUser
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void createTheUserTest()
{
PrivateObject param0 = null; // TODO: Initialize to an appropriate value
RegistrationForm_Accessor target = new RegistrationForm_Accessor(param0); // TODO: Initialize to an appropriate value
bool expected = false; // TODO: Initialize to an appropriate value
    bool actual;
    actual = target.createTheUser();
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}
    }
}
