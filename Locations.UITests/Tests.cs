﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Locations.UITests
{
  
    [TestFixture(Platform.iOS)]
    [TestFixture(Platform.Android)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
            app.WaitForElement(c => c.Id("DemoButton"));
            app.Tap(c => c.Id("DemoButton"));

            app.WaitForElement(c => c.Id("HomePage"), "Did not navigate to HomePage", new TimeSpan(0,0,0,10));
            app.Screenshot("Second screen.");
        }
    }
}

