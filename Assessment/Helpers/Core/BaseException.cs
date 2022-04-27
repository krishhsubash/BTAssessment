using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Helpers.Core
{
    public class BaseException : SystemException
    {
        public BaseException() { }
        public BaseException(string message) : base(message) { }
        public BaseException(WebDriverTimeoutException timeoutException) : base(timeoutException.Message) { }
        public BaseException(string message, Exception exception) : base(message, exception) { }
    }
}
