﻿using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Android.Views;


namespace PierwszaAplikacja
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            EditText phoneNumber = FindViewById<EditText>(Resource.Id.PhoneNumber);
            Button callButton = FindViewById<Button>(Resource.Id.CallButton);
            callButton.Click += (object sender, EventArgs e) =>
            {
                var callIntent = new Intent(Intent.ActionCall);
                callIntent.SetData(Android.Net.Uri.Parse("tel:" + phoneNumber.Text));
                StartActivity(callIntent);
            };

        }
        
    }
}

