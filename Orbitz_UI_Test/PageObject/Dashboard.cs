using Demo_TestFrameWork.ComponentHelper;
using OpenQA.Selenium;
using Orbitz_UI_Test.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Orbitz_UI_Test.PageObject
{
   public class Dashboard : PageBase
    {

        #region IWebElements
        //By AccountLink = By.XPath("//a[contains(text(),'Account')]']"); // Account Link
        By AccountLink = By.XPath("//*[@id='toggle-items']/ul/li[6]/a"); // Account Link      
        By ProfileLink = By.XPath("//a[contains(text(),'Profile')]"); // Portfolio Textbox
        
        By Logout = By.Id("logout");
        #endregion IWebElements
      
        

        public Dashboard(IWebDriver _driver) : base(_driver)
        { }

        public void NavigteToPortolio()
        {
            Thread.Sleep(3000);
            MouseActionHelper.MouseHover(AccountLink);
            LinkHelper.ClickLink(ProfileLink);
           
        }
    }
}
