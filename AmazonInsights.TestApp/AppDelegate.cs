﻿using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using AmazonInsights.Monotouch;

namespace AmazonInsights.TestApp
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		string APP_KEY = "";
		string PRIVATE_KEY = "";

		UIWindow window;
		AmazonInsights_TestAppViewController viewController;
		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			viewController = new AmazonInsights_TestAppViewController ();
			window.RootViewController = viewController;
			window.MakeKeyAndVisible ();

			AIInsightsCredentials credentials = AIAmazonInsights.CredentialsWithApplicationKey (APP_KEY, PRIVATE_KEY);
			AIAmazonInsights insights = AIAmazonInsights.InsightsWithCredentials (credentials);

			return true;
		}
	}
}

