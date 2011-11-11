using PROJETO_FINAL_LC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestProjetoFinal
{
    
    
    /// <summary>
    ///This is a test class for ConsultFormTest and is intended
    ///to contain all ConsultFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ConsultFormTest
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
///A test for ConsultForm Constructor
///</summary>
[TestMethod()]
public void ConsultFormConstructorTest()
{
    ConsultForm target = new ConsultForm();
    Assert.Inconclusive("TODO: Implement code to verify target");
}

/// <summary>
///A test for ConsultForm_Load
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void ConsultForm_LoadTest()
{
ConsultForm_Accessor target = new ConsultForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.ConsultForm_Load(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for Dispose
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void DisposeTest()
{
ConsultForm_Accessor target = new ConsultForm_Accessor(); // TODO: Initialize to an appropriate value
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
ConsultForm_Accessor target = new ConsultForm_Accessor(); // TODO: Initialize to an appropriate value
    target.InitializeComponent();
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for UpdateConsultTypeInfo
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void UpdateConsultTypeInfoTest()
{
ConsultForm_Accessor target = new ConsultForm_Accessor(); // TODO: Initialize to an appropriate value
RadioButton selected = null; // TODO: Initialize to an appropriate value
    target.UpdateConsultTypeInfo(selected);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}

/// <summary>
///A test for rbtnConsultType_CheckedChanged
///</summary>
[TestMethod()]
[DeploymentItem("PROJETO_FINAL_LC.exe")]
public void rbtnConsultType_CheckedChangedTest()
{
ConsultForm_Accessor target = new ConsultForm_Accessor(); // TODO: Initialize to an appropriate value
object sender = null; // TODO: Initialize to an appropriate value
EventArgs e = null; // TODO: Initialize to an appropriate value
    target.rbtnConsultType_CheckedChanged(sender, e);
    Assert.Inconclusive("A method that does not return a value cannot be verified.");
}
    }
}
