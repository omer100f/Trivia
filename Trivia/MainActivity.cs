using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using System;
using Android.Content;

namespace Trivia
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, View.IOnClickListener
    {

        private Button levelsBtn;
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);            
            SetContentView(Resource.Layout.activity_main);

            levelsBtn = FindViewById<Button>(Resource.Id.levelsBtn);
            levelsBtn.SetOnClickListener(this); 
            
        }        

        public void OnClick(View v)
        {
            Intent intent = new Intent(this, typeof(LevelsActivity));
            Finish();
            StartActivity(intent);
        }
    }
}