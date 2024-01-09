using CursoAuto.PageObject;
using CursoAuto.SetUp;
using NUnit.Framework;

namespace CursoAuto.Tests
{
    [TestFixture]
    public class TestButtonsPage : Setup
    {
        public static ButtonsPage buttonsPage = new ButtonsPage();
        [Test]
        public void CheckButtonsPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/elements");
            buttonsPage.CLickButtonsOptions();
        }
    }
}
