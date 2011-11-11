using PROJETO_FINAL_LC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjetoFinalTest
{
    
    
    /// <summary>
    ///This is a test class for VideoRegistrationFormTest and is intended
    ///to contain all VideoRegistrationFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class VideoRegistrationFormTest
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
        ///A test for updateDuration
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PROJETO_FINAL_LC.exe")]
        public void updateDurationTest0000()
        {
            VideoRegistrationForm_Accessor target = new VideoRegistrationForm_Accessor(); 
            target.mtbDuration.Text = "0000";
            target.updateDuration();
            Assert.AreEqual(0, target.duration);
        }

        [TestMethod()]
        public void updateDurationTest9999()
        {
            VideoRegistrationForm_Accessor target = new VideoRegistrationForm_Accessor();
            target.mtbDuration.Text = "9999";
            target.updateDuration();
            Assert.AreEqual(9999, target.duration);
        }

        [TestMethod()]
        public void updateDurationTest9999inHours()
        {
            VideoRegistrationForm_Accessor target = new VideoRegistrationForm_Accessor();
            target.mtbDuration.Text = "9999";
            target.rbInHours.Checked = true;
            target.updateDuration();
            Assert.AreEqual(6039, target.duration);
        }

        [TestMethod()]
        public void updateDurationTestEmptyString()
        {
            VideoRegistrationForm_Accessor target = new VideoRegistrationForm_Accessor();
            target.mtbDuration.Text = "";
            target.updateDuration();
            Assert.AreEqual(0, target.duration);
        }
        
        [TestMethod()]
        public void updateDurationTestEmptyString2()
        {
            VideoRegistrationForm_Accessor target = new VideoRegistrationForm_Accessor();
            target.mtbDuration.Text = "9999";
            target.updateDuration();
            target.mtbDuration.Text = "";
            target.updateDuration();
            Assert.AreEqual(0, target.duration);
        }

        [TestMethod()]
        public void updateDurationTest220min()
        {
            VideoRegistrationForm_Accessor target = new VideoRegistrationForm_Accessor(); 
            target.mtbDuration.Text = "0220";
            target.updateDuration();
            Assert.AreEqual(220, target.duration);
        }
    }
}
