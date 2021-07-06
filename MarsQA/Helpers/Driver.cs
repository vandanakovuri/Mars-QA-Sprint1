﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA.Helpers
{
     class Driver
    {
        public static IWebDriver driver { get; set; }
        public static string Url = "http://localhost:5000";
        public static void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();
            TurnOnWait();

            //Maximise the window
            driver.Manage().Window.Maximize();
        }

        public static string BaseUrl
        {
            get { return Url; }
        }


        //Implicit Wait
        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        //Close the browser
        public void Close()
        {
            driver.Quit();

        }
    }
}
