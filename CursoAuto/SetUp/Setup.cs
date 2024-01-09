using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace CursoAuto.SetUp
{
    public class Setup
    {
        public static IWebDriver driver;
        [OneTimeSetUp]
        public void SetUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
