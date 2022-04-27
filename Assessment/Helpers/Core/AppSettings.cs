using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Helpers.Core
{
    public interface IAppSettings
    {
        string Browser { get; }
        string Username { get; }
        string Password { get; }
        string Url { get; }

    }
    public sealed class AppSettings : IAppSettings
    {
        public string Browser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
    }
}
