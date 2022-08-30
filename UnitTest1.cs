using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAutomation
{
    [TestFixture]
    public class Tests
    {


        [OneTimeSetUp]
        public void Setup()
        {
            ChromeDriver driver = new ChromeDriver();
            Global.chrome_driver = driver;
            Global.chrome_driver.Manage().Window.Maximize();
           


        }

        [Test]
        public void GoogleSearch()
        {
            Console.WriteLine("Hello World");
            Global.chrome_driver.Url = "https://www.google.com";
            WebDriverWait wait = activity.CreatWait(new TimeSpan(0, 0 ,Global.timeSpan));
            IWebElement test = Global.chrome_driver.FindElement(By.XPath("//input[@name='q']"));
            test.SendKeys("Selensium"+Keys.Enter);
            
        }
    }
}