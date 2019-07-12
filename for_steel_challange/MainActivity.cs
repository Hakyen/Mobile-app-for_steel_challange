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
    public class MainActivity : AppCompatActivity
    {
        private EditText etUsername, etPassword;
        private Button btnInsert;
        private TextView txtSysLog;
        private TextView TestLog;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.activity_main);

            etUsername = FindViewById<EditText>(Resource.Id.XetUsername);
            etPassword = FindViewById<EditText>(Resource.Id.XetPassword);
            btnInsert = FindViewById<Button>(Resource.Id.XbtnInsert);
            txtSysLog = FindViewById<TextView>(Resource.Id.XtxtSysLog);
            TestLog = FindViewById<TextView>(Resource.Id.test);
           
            btnInsert.Click += BtnInsert_Click;
            
            
        }
         private void BtnInsert_Click(object sender, EventArgs e)
         {
           MySqlConnection con = new MySqlConnection("Server=192.168.43.40; Port=3306; database=steel_challange_db; User id=root; Password=''; charset=utf8;");
        
           try
           {
                if (con.State == ConnectionState.Closed)

                  {
                   con.Open();
                    string log = etUsername.Text;
                    string sqlstr = "SELECT  password FROM user WHERE login = '"+ log + "';";
                    MySqlCommand command = new MySqlCommand(sqlstr, con);
                   string username = command.ExecuteScalar().ToString();

                    TestLog.Text =username;
                    if (etPassword.Text != username)
                    {

                            txtSysLog.Text = "Неверный логин или пароль";  
                    }
                    else
                    {
                        txtSysLog.Text = "Вход выполнен";
                        Intent intent = new Intent(this, typeof(Page2Activity) );
                        StartActivity(intent);
                    }
                   
                }
            }
            catch(MySqlException ex)
              {
                txtSysLog.Text = ex.ToString ();
              }
            finally
              {
                con.Close();
              }
          }

       

    }
}