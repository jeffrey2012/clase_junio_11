using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace App2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnAuth;
        EditText editTextUsername;
        EditText editTextPassword;
        EditText editTextToken;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnAuth = FindViewById<Button>(Resource.Id.btnAuth);
            editTextUsername = FindViewById<EditText>(Resource.Id.editTextUsername);
            editTextPassword = FindViewById<EditText>(Resource.Id.editTextPassword);
            editTextToken = FindViewById<EditText>(Resource.Id.editTextToken);
            btnAuth.Click += DoAuthentication;

        }

        private void DoAuthentication(object sender, EventArgs e) {
            if (editTextUsername.Text.Equals("bichito") && editTextUsername.Text.Equals("123456")) {
                Toast.MakeText(this, "usuario aweonado", ToastLength.Short).Show();

            }
            else {
                Toast.MakeText(this, "usuario invalido", ToastLength.Short).Show();

            }

        }
    }
}

