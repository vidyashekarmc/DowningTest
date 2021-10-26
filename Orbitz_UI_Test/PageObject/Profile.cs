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
    public class Profile : PageBase
    {
        #region IWebElements

        By EditButton = By.XPath("//*[@class='btn edit-btn edit-btn--corner']"); // Edit button
        By PhonoNumberTextBox = By.XPath("//*[@type='tel']"); // PhoneNumber Textbox       
        By UpdateButton = By.XPath("//button[contains(text(),'Update')]");//update button
        By SuccessMsg = By.XPath("//h4[contains(text(),'Thank you, your personal details have been updated')]");
        By ChangePasswordButton = By.XPath("//button[contains(text(),'Password')]");//Change Password  button
        By UploadButton = By.XPath("//*[@type='file']");//Change Password  button
        By AgeMessage = By.XPath("//p[contains(text(),'You must be at least 18 years of age.')]");
        #endregion IWebElements

        public Profile(IWebDriver _driver) : base(_driver)
        { }

        public void UpdatePhoneNumber(String mobileno)
        {
            //Thread.Sleep(3000);
            WaitHelper.WaitForTitle("Downing Crowd", 10, 2);
            ButtonHelper.ClickButton(EditButton);
            Thread.Sleep(1000);
            TextBoxHelper.TypeInTextBox(PhonoNumberTextBox, mobileno);
            ButtonHelper.ClickButton(UpdateButton);
            Thread.Sleep(1000);
            GenericHelper.TakeScreenShot();
            
            GenericHelper.TakeScreenShotForReport();
        }

        public void ClearPhoneNumber()
        {
            //Thread.Sleep(3000);
            WaitHelper.WaitForTitle("Downing Crowd", 10, 2);
            ButtonHelper.ClickButton(EditButton);
            Thread.Sleep(1000);
            //TextBoxHelper.ClearTextBox(PhonoNumberTextBox);
           //TextBoxHelper.TypeInTextBox(PhonoNumberTextBox, "acbd");          
            //Thread.Sleep(2000);
            //ButtonHelper.ClickButton(UpdateButton);
            TextBoxHelper.ClearTextBox(PhonoNumberTextBox);
            TextBoxHelper.TypeInTextBox(PhonoNumberTextBox, Keys.Tab);
            Thread.Sleep(2000);
            ButtonHelper.ClickButton(UpdateButton);
            
           
        }


        public void UpdatePassword()
        {
            Thread.Sleep(3000);
            WaitHelper.WaitForTitle("Downing Crowd", 10, 2);
            ButtonHelper.ClickButton(ChangePasswordButton);
            Thread.Sleep(1000);
        }

        public void UploadFile(String filepath)
        {
           
            WaitHelper.WaitForTitle("Downing Crowd", 10, 2);
            Thread.Sleep(3000);
            TextBoxHelper.UploadFile(UploadButton, filepath);
            Thread.Sleep(3000);
        }


        public void ClickEdit()
        {

            WaitHelper.WaitForTitle("Downing Crowd", 10, 2);
            Thread.Sleep(2000);
            ButtonHelper.ClickButton(EditButton);
            Thread.Sleep(2000);
            ButtonHelper.ClickButton(AgeMessage);

        }
    }
}
