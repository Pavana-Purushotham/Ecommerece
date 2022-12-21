using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Pages
{
    public class HomePage
    {

        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div/div/div[1]/div[1]/div/span[2]/a")]
        public IWebElement shop { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div/div/div[1]/div[1]/div/span[3]/a")]
        public IWebElement Slay { get; set; }

        
        [FindsBy(How = How.ClassName, Using = "advance-filter__checkbox-checkmark")]
        public IWebElement Lsize { get; set; }

    }
}
