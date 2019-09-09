using System;
using Facebook.LoginKit;
using Foundation;
using XFFacebookExample.Services;

namespace XFFacebookExample.iOS.Services
{
    public class FacebookLoginService : IFacebookLoginService
    {
        public string AccessToken => Facebook.CoreKit.AccessToken.CurrentAccessToken?.TokenString;

        public Action<string, string> AccessTokenChanged { get; set; }

        public FacebookLoginService()
        {
            // TODO: Remove observer
            NSNotificationCenter.DefaultCenter.AddObserver(
                new NSString(Facebook.CoreKit.AccessToken.DidChangeNotification),
                (n) =>
                {
                    AccessTokenChanged?.Invoke(
                        n.UserInfo[Facebook.CoreKit.AccessToken.OldTokenKey]?.ToString(),
                        n.UserInfo[Facebook.CoreKit.AccessToken.NewTokenKey]?.ToString());
                });
        }

        public void Logout()
        {
            using (var loginManager = new LoginManager())
            {
                loginManager.LogOut();
            }
        }
    }
}
