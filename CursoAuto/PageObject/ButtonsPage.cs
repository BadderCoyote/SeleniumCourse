using CursoAuto.Enums;
using CursoAuto.SetUp;
using NUnit.Framework;

namespace CursoAuto.PageObject
{
    public class ButtonsPage : Setup
    {
        private readonly ButtonsPageElements buttonsPageElements;

        public ButtonsPage()
        {
            buttonsPageElements = new ButtonsPageElements();
        }

        public void CLickButtonsOptions()
        {
            var buttonOptionsResult = driver.FindElement(buttonsPageElements.ButtonOption);
            Assert.IsTrue(buttonOptionsResult.Displayed, "Verify");
            

        }
    }
}
