using MarsQA.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA.PageObjects
{
    class Certifications
    {
        private static IWebElement ClickCertificationsTab => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
        private static IWebElement ClickAddNewCertficationBtn => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
        private static IWebElement CertificateTextBox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
        private static IWebElement CertificateFromTextBox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
        private static IWebElement YearDropDown => Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));
        private static IWebElement YearClick => Driver.driver.FindElement(By.XPath("//option[@value='2009']"));
        private static IWebElement AddCertificationsBtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement EditCertificationsBtn => Driver.driver.FindElement(By.XPath("//tbody/tr/td[4]/span[1]/i[1]"));
        private static IWebElement UpdateCertificationsBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement DeleteCertificationsBtn => Driver.driver.FindElement(By.XPath("//tbody/tr/td[4]/span[2]/i[1]"));


        public static void AddCertifications()
        {
            System.Threading.Thread.Sleep(5000);
            ClickCertificationsTab.Click();
            ClickAddNewCertficationBtn.Click();
            CertificateTextBox.SendKeys(ExcelLibHelper.ReadData(2, "Certificate "));
            CertificateFromTextBox.SendKeys(ExcelLibHelper.ReadData(2, "CertificateFrom"));
            YearDropDown.SendKeys(ExcelLibHelper.ReadData(2, "Year"));
            AddCertificationsBtn.Click();
        }
        public static void EditCertifications()
        {
            System.Threading.Thread.Sleep(5000);
            ClickCertificationsTab.Click();
            EditCertificationsBtn.Click();
            CertificateTextBox.Clear();
            CertificateFromTextBox.Clear();
            CertificateTextBox.SendKeys(ExcelLibHelper.ReadData(3, "Certificate "));
            CertificateFromTextBox.SendKeys(ExcelLibHelper.ReadData(3, "CertificateFrom"));
            YearDropDown.SendKeys(ExcelLibHelper.ReadData(3, "Year"));
            UpdateCertificationsBtn.Click();
        }
        public static void DeleteCertifications()
        {
            System.Threading.Thread.Sleep(5000);

            ClickCertificationsTab.Click();
            DeleteCertificationsBtn.Click();
        }
    }

}
