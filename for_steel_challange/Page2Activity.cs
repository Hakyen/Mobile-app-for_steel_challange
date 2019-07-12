using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace for_steel_challange
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    class Page2Activity : Activity
    {
        private Button Shooter;
        private Button Attempt;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Page2);
            Shooter = FindViewById<Button>(Resource.Id.Shooters);
            Attempt = FindViewById<Button>(Resource.Id.Attempt);

            Shooter.Click += Shooter_Click;
            Attempt.Click += Attempt_Click;
        }
        private void Shooter_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Shooters));
            StartActivity(intent);
        }
        private void Attempt_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Attempt));
            StartActivity(intent);
        }
    }

 }
