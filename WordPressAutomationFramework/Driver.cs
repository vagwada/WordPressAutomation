﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System;

namespace WordPressAutomationFramework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        }

        public static void Close()
        {
           Instance.Close();
        }

        public static void Quit()
        {
            Instance.Quit();
        }
    }
}