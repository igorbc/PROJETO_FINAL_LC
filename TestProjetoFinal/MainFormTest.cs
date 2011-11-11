using PROJETO_FINAL_LC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjetoFinal
{
    
    
    /// <summary>
    ///This is a test class for MainFormTest and is intended
    ///to contain all MainFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MainFormTest
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
///A test for MainForm Constructor
///</summary>
[TestMethod()]
public void MainFormConstructorTest()
{
    MainForm target = new MainForm();
    Assert.Inconclusive("TODO: Implement code to verify target");
}

/// <summary>
///A test for Dispose
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void DisposeTest()
{
MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
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
MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
    target.InitializeComponent();
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for MainForm_Load
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void MainForm_LoadTest()
{
MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.MainForm_Load(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for MainForm_Shown
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void MainForm_ShownTest()
{
MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.MainForm_Shown(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for btnAddScreening_Click
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void btnAddScreening_ClickTest()
{
MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.btnAddScreening_Click(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for btnConsult_Click
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void btnConsult_ClickTest()
{
MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.btnConsult_Click(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for getUser
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void getUserTest()
{
MainForm_Accessor target = new MainForm_Accessor(); // TODO: Initialize to an appropriate value
string userName = string.Empty; // TODO: Initialize to an appropriate value
    target.getUser(userName);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}
    }
}
