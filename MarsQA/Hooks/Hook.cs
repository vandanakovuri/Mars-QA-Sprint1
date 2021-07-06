using MarsQA.Helpers;
using MarsQA.StepDefiniitions;
using MarsQA.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA.Hooks
{
    [Binding]
    public class Hook 
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

       // IWebDriver driver;
         
        [BeforeScenario]
        public void BeforeScenario()
        {
            //launch the browser
            Driver.Initialize();
       
            ExcelLibHelper.PopulateInCollection($@"{login.path}Data\MarsQA.xlsx", "Login");

            //login 
            Start.SigninStep();
           // Driver.driver = new ChromeDriver(); 
        }

        [AfterScenario]
        public void AfterScenario()
        {
          //  Driver.driver.Quit();
          //  Driver.driver.Dispose();
        }
    }
}
