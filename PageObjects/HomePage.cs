using OpenQA.Selenium;

namespace Practice_DEPT.PageObjects
{
    public class HomePage : BasePageObject
    {
        public HomePage()
            : base(By.XPath(".//body"))
        { }

        //public IWebElement LblTitle => driver.FindElement(By.CssSelector(""));
    }
}