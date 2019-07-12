using System;
using Android.App;
using Android.Content;
using Android.Views;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using MySql.Data.MySqlClient;
using System.Data;

namespace for_steel_challange
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]

    class Shooters : Activity
    {
      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Shooters);
           
            MySqlConnection con = new MySqlConnection("Server=192.168.43.40; Port=3306; database=steel_challange_db; User id=root; Password=''; charset=utf8;");
            if (con.State == ConnectionState.Closed)

            {
                con.Open();
            }
        }

    }
}