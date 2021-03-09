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
    [Activity(Label = "GameActivity")]
    public class GameActivity : Activity, SeekBar.IOnSeekBarChangeListener
    {


        private RelativeLayout relativeLayout;
        private TextView statmentView, scoreView;
        private SeekBar answerBar;
        private ProgressBar scoreBar;
        //g
        //Intent i = getIntent
           
        //public Bank bank = new Bank(Intent.GetIntExtra("LEVEL", 1));
        private int questionNum = 0, scoreNum;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_game);


            relativeLayout = (RelativeLayout)FindViewById(Resource.Id.relativeLayout1);

            statmentView = (TextView)FindViewById(Resource.Id.statmentView);
            statmentView.Text = bank.questions[questionNum].statment;

            answerBar = (SeekBar)FindViewById(Resource.Id.answerBar);            
            answerBar.SetOnSeekBarChangeListener(this);
            answerBar.Progress = 2;

            scoreView = (TextView)FindViewById(Resource.Id.scoreView);
            scoreBar = (ProgressBar)FindViewById(Resource.Id.scoreBar);
            scoreBar.Max = bank.questions.Length;
            scoreBar.Progress = 0;
        }


       

        public void OnProgressChanged(SeekBar seekBar, int progress, bool fromUser)
        {
            //scoreView.Text = seekBar.Progress.ToString();
        }

        public void OnStartTrackingTouch(SeekBar seekBar)
        {
            //scoreView.Text = seekBar.Progress.ToString();
        }

        public void OnStopTrackingTouch(SeekBar seekBar)
        {
            Stopped();
        }

        public void Stopped()
        {            
            scoreBar.Max = bank.questions.Length;
            scoreNum += bank.questions[questionNum].answer * ((answerBar.Progress - 2) * 5);
            scoreBar.SetProgress(scoreBar.Progress + (scoreBar.Max / bank.questions.Length), true); 
            if (bank.questions.Length > questionNum + 1)
            {
                questionNum++;
                statmentView.Text = bank.questions[questionNum].statment;
            }
            scoreView.Text = scoreNum.ToString();
            answerBar.Progress = 2;
        }
    }
}