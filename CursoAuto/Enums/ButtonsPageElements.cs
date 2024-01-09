using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoAuto.Enums
{
    public class ButtonsPageElements
    {
        public By ButtonOption { get; set; } = By.XPath("//span[text()='Buttons']");
    }
}
