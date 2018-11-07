﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace MobileWebCoinManagement
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Button LoginButton = FindViewById<Button>(Resource.Id.loginButton);
            LoginButton.Click += delegate {

            };
        }
    }
}

