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

namespace Trivia
{
    [Activity(Label = "WelcomeActivity", MainLauncher = true)]
    public class WelcomeActivity : Activity, View.IOnClickListener
    {

        private Button signBtn;
        private Button registerBtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            signBtn = FindViewById<Button>(Resource.Id.levelsBtn);
            registerBtn = FindViewById<Button>(Resource.Id.levelsBtn);
            signBtn.SetOnClickListener(this);
            registerBtn.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            if (v == signBtn)
            {
                Sign();
            }
            else
            {
                Register();
            }
        }
        public void Sign()
        {
            FirebaseData.CreateUser("omer200f@gmail.com", "123");
        }
        public void Register()
        {
            FirebaseData.SignIn("omer200f@gmail.com", "123");
        }
    }
}