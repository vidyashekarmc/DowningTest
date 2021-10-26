using Demo_TestFrameWork.ComponentHelper;
using OpenQA.Selenium;
using Orbitz_UI_Test.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Orbitz_UI_Test.PageObject
{
   public class Login : PageBase
    {
        #region IWebElements
        By EmailTextBox = By.XPath("//input[@type='email']"); // Email address Textbox
        By PasswordTextBox = By.XPath("//input[@type='password']"); // Password Textbox
        By SubmitBtn = By.XPath("//button[contains(text(),'Log in')]"); // Login Button
        #endregion IWebElements

        public Login(IWebDriver _driver) : base(_driver)
        { }
        #region Actions
        public void doLogin(string username, string password)
        {
            TextBoxHelper.TypeInTextBox(EmailTextBox, username);
            TextBoxHelper.TypeInTextBox(PasswordTextBox, password);
            ButtonHelper.ClickButton(SubmitBtn);
        }
        #endregion Actions
    }
}
