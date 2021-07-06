using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefiniitions
{
    [Binding]
    public class login
    {
      public static string path= Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
        IWebDriver driver;
        [Given(@"Launch Url")]
        public void GivenLaunchUrl()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
           driver.Manage().Window.Maximize();
           Thread.Sleep(3000);

        }

        [Given(@"Click on the Sign In button")]
        public void GivenClickOnTheSignInButton()
        {
            IWebElement signin = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signin.Click();
        }
        
        [Given(@"valid Email Address and Password")]
        public void GivenValidEmailAddressAndPassword()
        {
            IWebElement emailAddress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailAddress.Click();
            emailAddress.Clear();
            emailAddress.SendKeys("vandana.kovuri@gmail.com");


            IWebElement password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            password.Click();
            password.Clear();
            password.SendKeys("saikarthik29");


        }

        [When(@"Click on the Login button")]
        public void WhenClickOnTheLoginButton()
        {
            IWebElement rememberme = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
            rememberme.Click();
            IWebElement login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            login.Click();

        }

        [Then(@"Login Successful")]
        public void ThenLoginSuccessful()
        {
           // Console.WriteLine("ThenLoginSuccessful");
           // Assert.Pass(); 
           

        }
    }
}
