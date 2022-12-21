using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Drivers
{
    public class BaseDriver
    {
        public static IWebDriver driver;

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ecommercewebsitedemo.com/");
            driver.Manage().Window.Maximize();
        }

        public void closedriver()
        {
            driver.Quit();
        }
    }
}
