
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject2.Pages;

namespace TestProject2
{
    

    public class Tests
    {
        IWebDriver driver;
        Googlesearch googlesearch;

        [SetUp]
        public void Setup()
        {
            driver=new ChromeDriver("C:\\Users\\user\\source\\repos\\TestProject2\\TestProject2\\Driver\\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.google.in");
            googlesearch = new Googlesearch(driver);

        }

        [Test]
        public void To_verify_google_search_box()
        {
            googlesearch.ToSearchInGoogle("Facebook");
            googlesearch.ClickSearchButton();
        }
        [Test]
        public void To_verify_Gmail_in_google_saerch()
        {
            googlesearch.ToSearchInGoogle("Gmail");
            googlesearch.ClickSearchButton();
        }
        [TearDown]
        public void Clean()
        {
            driver.Close();
        }
    }
}