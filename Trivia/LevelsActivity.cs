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

namespace Trivia
{
    [Activity(Label = "LevelsActivity")]
    public class LevelsActivity : Activity, View.IOnClickListener
    {
        private ImageButton levelOne, levelTwo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_levels);

            levelOne = FindViewById<ImageButton>(Resource.Id.levelOneBtn);
            levelOne.SetOnClickListener(this);
            levelTwo = FindViewById<ImageButton>(Resource.Id.levelTwoBtn);
            levelTwo.SetOnClickListener(this);
        }
        
        public void OnClick(View v)
        {
            int level;
            switch (v.Id)
            {
                case Resource.Id.levelOneBtn:
                    level = 1;
                    break;
                case Resource.Id.levelTwoBtn:
                    level = 2;
                    break;

                default:
                    level = 1;
                    break;
            }
            Intent intent = new Intent(this, typeof(GameActivity));
            intent.PutExtra("LEVEL", level);
            Finish();
            StartActivity(intent);
        }
    }
}