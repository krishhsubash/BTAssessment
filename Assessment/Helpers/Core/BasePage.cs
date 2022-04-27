using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Helpers.Core
{
    public class BasePage
    {

        private readonly IWebDriver _webDriver;
        public BasePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
           // _webDriver.Manage().Window.FullScreen();
        }

        public void Click(string elem)
        {

                try
                {
                       WaitForElementToBeAvailable(elem);
                              _webDriver.FindElement(GetElement(elem)).Click();
                }
                catch (Exception)
                {
                    throw new BaseException("Element  with locator:" + elem + " is unavailable to be clicked in the page");
                }
        }

        public void JsClick(string elem)
        {
                try
                {
                WaitForElementToBeAvailable(elem);
                IWebElement element = _webDriver.FindElement(GetElement(elem));
                ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].click();", element);
                }
                catch (Exception)
                {
                    throw new BaseException("Element  with locator:" + elem + " is unavailable to be clicked in the page");
                }
        }

        public void Clear(string elem)
        {
                try
                {
                WaitForElementToBeAvailable(elem);
                _webDriver.FindElement(GetElement(elem)).Clear();
                _webDriver.FindElement(GetElement(elem)).SendKeys(Keys.Control + "A" + Keys.Delete);
                }
                catch (Exception ex)
                {
                    throw new BaseException("Element  with locator: " + elem + " cannot be cleared in the page" + ex.Message);
                }
        }

        public void ClearTextBox(string elem)
        {
                try
                {
                WaitForElementToBeAvailable(elem);
                _webDriver.FindElement(GetElement(elem)).SendKeys(Keys.Control + "A" + Keys.Delete);
                }
                catch (Exception ex)
                {
                    throw new BaseException("Unable to clear text box with element locator: " + elem + " " + ex.Message);
                }
        }

        public void WaitForElementToBeClickable(string elem)
        {
                try
                {
                WaitForElementToBeAvailable(elem);
            }
                catch (Exception ex)
                {
                    throw new BaseException("Unable to click to webElement having locator: " + elem + " " + ex.Message);
                }
        }

        public int CountWebElements(string element)
        {
                try
                {
                    return _webDriver.FindElements(GetElement(element)).Count;
                }
                catch (Exception ex)
                {
                    throw new BaseException("Unable to get count webElements having locator: " + element + " " + ex.Message);
                }
        }

        public void EnterText(string elem, string text)
        {
                try
                {
                    WaitForElementToBeAvailable(elem);
                _webDriver.FindElement(GetElement(elem)).SendKeys(Keys.Control + "A" + Keys.Delete);
                _webDriver.FindElement(GetElement(elem)).SendKeys(text);
                }
                catch (Exception ex)
                {
                    throw new BaseException("Unable to entere text to webElement having locator: " + elem + " " + ex.Message);
                }
        }

        public void WaitForElementToBeAvailable(string elem)
        {
                try
                {

                DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(_webDriver)
                {
                    Timeout = TimeSpan.FromSeconds(25),
                    PollingInterval = TimeSpan.FromMilliseconds(500)
                };
                fluentWait.Until(x => (CountWebElements(elem) > 0));

            }
                catch (Exception ex)
                {
                    throw new BaseException("Unable to get webElement having locator: " + elem + " " + ex.Message);
                }
        }

        public string GetText(string elem)
        {
            return _webDriver.FindElement(GetElement(elem)).Text;
        }

        public void KeyDown(string elem)
        {
            _webDriver.FindElement(GetElement(elem)).SendKeys(Keys.Down);
        }

        public void KeyEnter(string elem)
        {
            _webDriver.FindElement(GetElement(elem)).SendKeys(Keys.Enter);
        }

        public void ScrollToElement(string elem)
        {
                try
                {
                    IWebElement element = _webDriver.FindElement(GetElement(elem));
                ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].scrollIntoView();", element);

                }
                catch (Exception ex)
                {
                    throw new BaseException("Unable to scroll to webElement having locator: " + elem + " " + ex.Message);
                }
        }


        public string GetElement(string elem, params string[] values) => string.Format(elem, values);

    public By GetElement(string locator)
    {
        if (locator.StartsWith("xpath="))
        {
            return By.XPath(locator.Substring("xpath=".Length));
        }
        if (locator.StartsWith("id="))
        {
            return By.Id(locator.Substring("id=".Length));
        }
        if (locator.StartsWith("linktext="))
        {
            return By.LinkText(locator.Substring("linktext=".Length));
        }
        if (locator.StartsWith("tagname="))
        {
            return By.TagName(locator.Substring("tagname=".Length));
        }
        if (locator.StartsWith("//"))
        {
            return By.XPath(locator);
        }
        if (locator.StartsWith("name="))
        {
            return By.TagName(locator.Substring("name=".Length));
        }
        if (locator.StartsWith("class="))
        {
            return By.ClassName(locator.Substring("class=".Length));
        }
        if (locator.StartsWith("css="))
        {
            return By.CssSelector(locator.Substring("css=".Length));
        }
        throw new BaseException("Unsupported locator: " + locator);
    }
}
}
