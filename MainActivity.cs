﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace exercise_android
{
    [Activity(Label = "exercise_android", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
            {
                StartActivity(typeof(Activity1));
            };
            //
            var button2 = FindViewById<Button>(Resource.Id.button2);
            var textview1 = FindViewById<TextView>(Resource.Id.textView1);

            button2.Click += delegate
            {
                textview1.Text = "Tekst muutus";
            };
               

            


           
        }
    }
}

    