﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Runtime;
using Android.Views;
using System;

namespace BopApp
{
    [Activity(Label = "BopApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button mBtnSignUp, mBtnSignIn;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mBtnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);
            mBtnSignIn = FindViewById<Button>(Resource.Id.btnSignIn);
            mBtnSignUp.Click += (object sender, EventArgs args) =>
            {
                //Pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                DialogSignUp dialogSignUp = new DialogSignUp();
                dialogSignUp.Show(transaction, "dialog fragment");
            };
            mBtnSignIn.Click += (object sender, EventArgs args) =>
            {
                //Pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                DialogSignIn dialogSignIn = new DialogSignIn();
                dialogSignIn.Show(transaction, "dialog fragment");
            };
        }
    }
}

