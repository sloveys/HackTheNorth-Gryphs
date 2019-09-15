using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Facebook.Unity;

public class LoginMenu : MonoBehaviour
{
        // Awake function from Unity's MonoBehavior
    public void Awake ()
    {
        if (!FB.IsInitialized) {
            // Initialize the Facebook SDK
            FB.Init(InitCallback, OnHideUnity);
        } else {
            // Already initialized, signal an app activation App Event
            FB.ActivateApp();
        }
    }

    public void InitCallback ()
    {
        if (FB.IsInitialized) {
            // Signal an app activation App Event
            FB.ActivateApp();
            // Continue with Facebook SDK
            // ...
        } else {
            Debug.Log("Failed to Initialize the Facebook SDK");
        }
    }

    public void OnHideUnity (bool isGameShown)
    {
        if (!isGameShown) {
            // Pause the game - we will need to hide
            Time.timeScale = 0;
        } else {
            // Resume the game - we're getting focus again
            Time.timeScale = 1;
        }
    }

    public void FacebookLogin() {
        var perms = new List<string>(){"public_profile", "email"};
        FB.LogInWithReadPermissions(perms, AuthCallback);
    }
    public void GetMyFacebookProfilePicture() {
        var API_KEY = "EAAFVOUTauOABAENdpCTJhRiyDMB2AmZBi38mo0FNZCbQrQYJc40a1WOVZAwQeiIw5AVUuvzgMTUM0XotZBz7HYlUxd1UYwtM4DJxUPNrl8yL1DyvjWZB3w4csIl1FK3Pywm7SiW9BQhtiO2rTlUD8UoZCGd8DlE3FLZCfP4pE8UUDTPghuAB4rzeKaZCARm6PIVlU9PpdrOPgwZDZD";
        var REQUEST = "https://graph.facebook.com/v4.0/me/picture?access_token=";
    }
    public void AuthCallback (ILoginResult result) {
        if (FB.IsLoggedIn) {
            // AccessToken class will have session details
            var aToken = Facebook.Unity.AccessToken.CurrentAccessToken;
            // Print current access token's User ID
            Debug.Log(aToken.UserId);
            // Print current access token's granted permissions
            foreach (string perm in aToken.Permissions) {
                Debug.Log(perm);
            }
        } else {
            Debug.Log("User cancelled login");
        }
    }
}

