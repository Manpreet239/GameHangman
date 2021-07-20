using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameHangman
{
    [Activity(Label = "Login")]
    public class Login : Activity
    {
        Android.Widget.EditText txtUserName;
        Android.Widget.EditText txtpwd;
        Android.Widget.Button btnLogin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login_Design);

            txtUserName = FindViewById<EditText>(Resource.Id.edtLoginUser);

            txtpwd = FindViewById<EditText>(Resource.Id.edtLoginpssword);


            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            //   btn.Click += Btntest_Clicked;
            btnLogin.Click += new EventHandler(BtnLoginCheck_Clicked);

            // Create your application here
        }

        private void BtnLoginCheck_Clicked(object sender, EventArgs e)
        {
            String usr = txtUserName.Text.ToString();
            String pwd = txtpwd.Text.ToString();
            if (usr.Equals("username") && pwd.Equals("username"))
            {
                Intent intent = new Intent(this, typeof(GamePlay));
                StartActivity(intent);
            }
            else
            {
                btnLogin.Text = "Invalid";
            }


        }
    }
}