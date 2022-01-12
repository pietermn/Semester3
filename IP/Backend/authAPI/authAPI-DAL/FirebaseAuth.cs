using System;
using Firebase.Auth;

namespace authAPI_DAL
{
    public class FirebaseAuth
    {
        private static FirebaseAuthProvider authProvider = new(new FirebaseConfig(Environment.GetEnvironmentVariable("ApiKey")));

        public static FirebaseAuthProvider AuthProvider { get => authProvider; set => authProvider = value; }
    }
}
