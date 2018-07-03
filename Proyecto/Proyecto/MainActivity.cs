﻿using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;


namespace Proyecto
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnIngresar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnIngresar = FindViewById<Button>(Resource.Id.btnIngresar);
            btnIngresar.Click += DoAuthentication;
        }
        private void DoAutentication(object sender, EventArgs e)
        {

        }
        Button btnRegistrar;
        
    }
}

