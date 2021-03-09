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
    public class Question
    {
        public string statment;
        public int answer;

        public Question(string statment, int answer)
        {
            this.statment = statment;
            this.answer = answer;
        }
    }
}