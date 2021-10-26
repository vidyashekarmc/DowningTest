
using Demo_TestFrameWork.ComponentHelper;
using Demo_TestFrameWork.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Orbitz_UI_Test.PageObject;
using Orbitz_UI_Test.BaseClass;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using System.Configuration;

namespace Orbitz_UI_Test.TestScripts
{
    [TestClass]
    public class Downing_UI_Testscript
    {
        public TestContext TestContext { get; set; }
        private static LogHelper log = new LogHelper();
        public string email = ConfigurationManager.AppSettings["Downing"];
        public string password = ConfigurationManager.AppSettings["Downing"];
       
       

        [TestCategory("POM")]
        [TestMethod]
        public void Test_To_Be_Failed()
        {
            log.Info("Starting Test: " + TestContext.TestName);
            BaseClass.BaseClass.test = BaseClass.BaseClass.report.StartTest(TestContext.TestName);
            Landing Lp = new Landing(ObjectRepository.Driver);
            Lp.NavigateToLoginPage();
            log.Info("Navigated To Downing Login Page");
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Navigated To Downing Login Page");
            Login Login = new Login(ObjectRepository.Driver);
            email = ConfigurationManager.AppSettings["UserName"];
            password = ConfigurationManager.AppSettings["Password"];
            Login.doLogin(email, password);
            log.Info("We are intensionally making the test fail here");
            BaseClass.BaseClass.test.Log(LogStatus.Fail, "We are intensionally making the test fail here");
            Assert.IsTrue(false);
        }

        [TestCategory("POM")]
        [TestMethod]
        public void Update_MobileNumber_With_ValidData()
        {
            log.Info("Starting Test: " + TestContext.TestName);
            BaseClass.BaseClass.test = BaseClass.BaseClass.report.StartTest(TestContext.TestName);
            Landing Lp = new Landing(ObjectRepository.Driver);
            Lp.NavigateToLoginPage();
            log.Info("Navigated To Downing Login Page");
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Navigated To Downing Login Page");
            Login Login= new Login(ObjectRepository.Driver);
            email = ConfigurationManager.AppSettings["UserName"];
            password = ConfigurationManager.AppSettings["Password"];
            Login.doLogin(email, password);
            log.Info("Login is successfull");
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Login is successfull");
            Dashboard Db = new Dashboard(ObjectRepository.Driver);
            Db.NavigteToPortolio();
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Profile page  navigation is successfull");
            Profile profile = new Profile(ObjectRepository.Driver);
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Edit button click is successfull");
            profile.UpdatePhoneNumber("5643456732");
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//h4[contains(text(),'Thank you, your personal details have been updated')]")));
            BaseClass.BaseClass.test.Log(LogStatus.Pass, "Phone Number update is successfull");
            BaseClass.BaseClass.test.Log(LogStatus.Pass, BaseClass.BaseClass.test.AddScreenCapture(GenericHelper.TakeScreenShotForReport()));

        }
        [TestCategory("POM")]
        [TestMethod]
        public void Update_MobileNumber_With_InvalidData()
        {
            log.Info("Starting Test: " + TestContext.TestName);
            BaseClass.BaseClass.test = BaseClass.BaseClass.report.StartTest(TestContext.TestName);
            Landing Lp = new Landing(ObjectRepository.Driver);
            Lp.NavigateToLoginPage();
            log.Info("Navigated To Downing Login Page");
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Navigated To Downing Login Page");
            Login Login = new Login(ObjectRepository.Driver);
            email = ConfigurationManager.AppSettings["UserName"];
            password = ConfigurationManager.AppSettings["Password"];
            Login.doLogin(email, password);
            log.Info("Login is successfull");
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Login is successfull");
            Dashboard Db = new Dashboard(ObjectRepository.Driver);
            Db.NavigteToPortolio();
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Profile page navigation is successfull");
            Profile profile = new Profile(ObjectRepository.Driver);
            profile.UpdatePhoneNumber("abcd");       
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//p[contains(text(),'Phone number is not valid')]")));
            BaseClass.BaseClass.test.Log(LogStatus.Pass, "Phone Number Error message validation successfull");
            BaseClass.BaseClass.test.Log(LogStatus.Pass, BaseClass.BaseClass.test.AddScreenCapture(GenericHelper.TakeScreenShotForReport()));


        }
        [TestCategory("POM")]
        [TestMethod]
        public void Update_MobileNumber_With_NoData()
        {
            log.Info("Starting Test: " + TestContext.TestName);
            BaseClass.BaseClass.test = BaseClass.BaseClass.report.StartTest(TestContext.TestName);
            DoLogin();
            Dashboard Db = new Dashboard(ObjectRepository.Driver);
            Db.NavigteToPortolio();
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Portfolio navigation is successfull");
            Profile profile = new Profile(ObjectRepository.Driver);
            profile.ClearPhoneNumber();           
            BaseClass.BaseClass.test.Log(LogStatus.Pass, "Phone Number Empty Error message validation successfull");
            BaseClass.BaseClass.test.Log(LogStatus.Pass, BaseClass.BaseClass.test.AddScreenCapture(GenericHelper.TakeScreenShotForReport()));
        }

        [TestCategory("POM")]
        [TestMethod]
        public void Update_Password_And_VerifyErrorMsg()
        {
            log.Info("Starting Test: " + TestContext.TestName);
            BaseClass.BaseClass.test = BaseClass.BaseClass.report.StartTest(TestContext.TestName);
            DoLogin();
            Dashboard Db = new Dashboard(ObjectRepository.Driver);
            Db.NavigteToPortolio();
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Profile page navigation is successfull");
            Profile profile = new Profile(ObjectRepository.Driver);
            profile.UpdatePassword();
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//p[contains(text(),'Password is a required field')]")));
            BaseClass.BaseClass.test.Log(LogStatus.Pass, "Password Error message validation successfull");
            BaseClass.BaseClass.test.Log(LogStatus.Pass, BaseClass.BaseClass.test.AddScreenCapture(GenericHelper.TakeScreenShotForReport()));


        }

       
        [TestCategory("POM")]
        [TestMethod]
        public void Atleast18Years_VerifyMessage()
        {
            log.Info("Starting Test: " + TestContext.TestName);
            BaseClass.BaseClass.test = BaseClass.BaseClass.report.StartTest(TestContext.TestName);
            DoLogin();
            Dashboard Db = new Dashboard(ObjectRepository.Driver);
            Db.NavigteToPortolio();
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Profile page navigation is successfull");
            Profile profile = new Profile(ObjectRepository.Driver);
            profile.ClickEdit();
            BaseClass.BaseClass.test.Log(LogStatus.Pass, "Age message validation successfull");
            BaseClass.BaseClass.test.Log(LogStatus.Pass, BaseClass.BaseClass.test.AddScreenCapture(GenericHelper.TakeScreenShotForReport()));

            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//p[contains(text(),'You must be at least 18 years of age.')]")));
          

            
        }
        [TestCategory("POM")]
        [TestMethod]
        public void UploadFile_VerifyMessage()
        {
            log.Info("Starting Test: " + TestContext.TestName);
            BaseClass.BaseClass.test = BaseClass.BaseClass.report.StartTest(TestContext.TestName);
            DoLogin();
            Dashboard Db = new Dashboard(ObjectRepository.Driver);
            Db.NavigteToPortolio();
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Profile page navigation is successfull");
            Profile profile = new Profile(ObjectRepository.Driver);
            String filepath = @"C:\ScreenShot\testfile.jpeg";
            profile.UploadFile(filepath);
            BaseClass.BaseClass.test.Log(LogStatus.Pass, "File uploaded successfull");
            BaseClass.BaseClass.test.Log(LogStatus.Pass, BaseClass.BaseClass.test.AddScreenCapture(GenericHelper.TakeScreenShotForReport()));
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath(" //h3[contains(text(),'Thank you. Your upload was successful')]")));         


        }

        public void DoLogin()
        {
            Landing Lp = new Landing(ObjectRepository.Driver);
            Lp.NavigateToLoginPage();
            log.Info("Navigated To Downing Login Page");
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Navigated To Downing Login Page");
            Login Login = new Login(ObjectRepository.Driver);
            email = ConfigurationManager.AppSettings["UserName"];
            password = ConfigurationManager.AppSettings["Password"];
            Login.doLogin(email, password);
            log.Info("Login is successfull");
            BaseClass.BaseClass.test.Log(LogStatus.Info, "Login is successfull");
        }
        [TestCleanup]
        public void TestCleanup()
        {        
            if (TestContext.CurrentTestOutcome.ToString().Equals("Passed"))
            {
                BaseClass.BaseClass.test.Log(LogStatus.Pass, "Test completed and passed");                
            }
            else if (TestContext.CurrentTestOutcome.ToString().Equals("Failed"))
            {
                string path = GenericHelper.TakeScreenShotForReport();
                string imagePath = BaseClass.BaseClass.test.AddScreenCapture(path);
                BaseClass.BaseClass.test.Log(LogStatus.Fail, "Test Failed in " + TestContext.TestName , imagePath);
            }
        }    
    }
}
