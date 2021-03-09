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
using Android.Gms.Tasks;
using Firebase.Storage;
using Android.Graphics;
using Firebase;
using Firebase.Auth;
using Firebase.Firestore;

namespace Trivia
{
    class FirebaseData
    {
        private FirebaseFirestore firestore;
        private FirebaseAuth auth;
        private FirebaseApp app;

        public FirebaseData()
        {
            app = FirebaseApp.InitializeApp(Application.Context);
            if (app is null)
            {
                FirebaseOptions options = GetMyOptions();
                app = FirebaseApp.InitializeApp(Application.Context, options);
            }
            firestore = FirebaseFirestore.GetInstance(app);
            auth = FirebaseAuth.Instance;
        }

        private FirebaseOptions GetMyOptions()
        {
            return new FirebaseOptions.Builder()
                    .SetProjectId("")
                    .SetApplicationId("")
                    .SetApiKey("")
                    .SetDatabaseUrl("")
                    .SetStorageBucket("")
                    .Build();
        }
        public Task CreateUser(string email, string password)
        {
            return auth.CreateUserWithEmailAndPassword(email, password);
        }

        public Task SignIn(string email, string password)
        {
            return auth.SignInWithEmailAndPassword(email, password);
        }

        public void AddSnapshotListener(string cName, MainActivity activity)
        {
            firestore.Collection(cName).AddSnapshotListener(activity);
        }

    }
}