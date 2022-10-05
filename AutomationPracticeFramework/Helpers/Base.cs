﻿using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Helpers
{
    [Binding]
   public class Base
    {
        public static IWebDriver Driver { get; set; }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            var url = "http://automationpractice.com";
            Driver.Url = url;
        }
        [AfterScenario]
        public static void AfterScenario()
        {
            Driver.Quit();

        }
    }
}
