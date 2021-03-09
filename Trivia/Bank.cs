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
    public class Bank
    {
        public Question[][] questionsB;
        public Question[] questions;
        public Question[] level1;
        private Question q11 = new Question("I e", 1);
        private Question q12 = new Question("I e", -1);
        private Question q13 = new Question("A n", -1);
        private Question q14 = new Question("AndQT", 1);
        private Question q15 = new Question("lm     ..", 1);
        
 

        public Question[] level2;
        private Question q21 = new Question("I e", 1);
        private Question q22 = new Question("I a", -1);
        private Question q23 = new Question("A ma", -1);
        private Question q24 = new Question("Andan", -1);
        private Question q25 = new Question("Nataiai", 1);

        public Question[] level3;
        private Question q31 = new Question("I e", 1);
        private Question q32 = new Question("I e", -1);
        private Question q33 = new Question("A mman", -1);
        private Question q34 = new Question("An", -1);
        private Question q35 = new Question("Nai", 1);
        public Bank(int level)
        {
            level1 = new Question[] { q11, q12, q13, q14, q15 };
            level2 = new Question[] { q21, q22, q23, q24, q25 };
            level3 = new Question[] { q31, q32, q33, q34, q35 };

            questionsB = new Question[][] { level1, level2, level3};
            questions = questionsB[level - 1];
            
        }
    }
}

