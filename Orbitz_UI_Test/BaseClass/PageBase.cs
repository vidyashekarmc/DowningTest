using Demo_TestFrameWork.ComponentHelper;
using Demo_TestFrameWork.Repository;
using OpenQA.Selenium;
using Orbitz_UI_Test.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orbitz_UI_Test.BaseClass
{
    public class PageBase
    {
        protected static string baseUrl = ObjectRepository.Config.GetWebSite();
        protected IWebDriver driver;
        public PageBase(IWebDriver _driver)
        {
            driver = _driver;
        }
        #region IWebElements



        #endregion Main Header Menus




        /*
             #region Actions
             public void SignOut()
             {
                 ButtonHelper.ClickButton(HelloUserMenu);
                 LinkHelper.ClickLink(AccountSignOutLnk);
             }

             #region Navigation
             public VacationRentals NavigateToVacationRentals()
             {
                 ButtonHelper.ClickButton(VacationRentals_Hmenu);
                 return new VacationRentals(driver);
             }

             public Cars NavigateToCars()
             {
                 ButtonHelper.ClickButton(Cars_Hmenu);
                 return new Cars(driver);
             }

             public SignIn NavigateToSignIn()
             {
                 ButtonHelper.ClickButton(AccountMenu);
                 ButtonHelper.ClickButton(SignInMenuBtn);
                 return new SignIn(driver);
             }
             #endregion Navigation

        #endregion Actions

         }*/
    }
}
