using PROJETO_FINAL_LC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjetoFinal
{
    
    
    /// <summary>
    ///This is a test class for AddScreeningFormTest and is intended
    ///to contain all AddScreeningFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AddScreeningFormTest
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
///A test for AddScreeningForm Constructor
///</summary>
[TestMethod()]
public void AddScreeningFormConstructorTest()
{
    AddScreeningForm target = new AddScreeningForm();
    Assert.Inconclusive("TODO: Implement code to verify target");
}

/// <summary>
///A test for AddScreeningForm_Load
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void AddScreeningForm_LoadTest()
{
AddScreeningForm_Accessor target = new AddScreeningForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.AddScreeningForm_Load(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for Dispose
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void DisposeTest()
{
AddScreeningForm_Accessor target = new AddScreeningForm_Accessor(); // TODO: Initialize to an appropriate value
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
AddScreeningForm_Accessor target = new AddScreeningForm_Accessor(); // TODO: Initialize to an appropriate value
    target.InitializeComponent();
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for btnRegisterVideo_Click
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void btnRegisterVideo_ClickTest()
{
AddScreeningForm_Accessor target = new AddScreeningForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.btnRegisterVideo_Click(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for btnSaveScreening_Click
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void btnSaveScreening_ClickTest()
{
AddScreeningForm_Accessor target = new AddScreeningForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.btnSaveScreening_Click(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}
    }
}
