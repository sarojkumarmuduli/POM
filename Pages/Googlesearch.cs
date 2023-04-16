using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    internal class Googlesearch
    {
        IWebDriver driver;
        public Googlesearch(IWebDriver d)
        {
            this.driver = d;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "APjFqb")]        
        IWebElement txtSearch;

        [FindsBy(How = How.XPath, Using = "(//input[@name='btnK'])[2]")]
        IWebElement btnSearch;
        public void ToSearchInGoogle(string text)
        {
            txtSearch.SendKeys(text);
        }
        public void ClickSearchButton()
        {
            btnSearch.Click();
        }
        //
    }
}
