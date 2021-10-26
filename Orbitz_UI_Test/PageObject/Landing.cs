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
   public class Landing : PageBase
    {
        public By Login_Btn = By.XPath("//a[contains(text(),'Log')]"); // Login Button
        public Landing(IWebDriver _driver) : base(_driver)
        { }

        #region Actions
        public void LoginClick()
        {
            
            ButtonHelper.ClickButton(Login_Btn);
        }

        public Login NavigateToLoginPage()
        {
            ButtonHelper.ClickButton(Login_Btn);
            return new Login(driver);
        }

        #endregion Actions
    }
}
