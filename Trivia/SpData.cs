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
    class SpData
    {
        private ISharedPreferences sp;
        private Context context;

        public SpData(Context ctx)
        {
            this.context = ctx;
            sp = ctx.GetSharedPreferences(General.SP_FILE_NAME, FileCreationMode.Private);
        }


        public string GetData(string keyName)
        {
            return sp.GetString(keyName, string.Empty);
        }

        public bool SetData(string keyName, string value)
        {
            ISharedPreferencesEditor editor = sp.Edit();
            editor.PutString(keyName, value);
            return editor.Commit();
        }
    }
}