using System;
using Xamarin.Facebook;
using Xamarin.Facebook.Login;
using XFFacebookExample.Services;

namespace XFFacebookExample.Droid.Services
{
    public class FacebookLoginService : IFacebookLoginService
    {
        readonly MyAccessTokenTracker myAccessTokenTracker;
        public Action<string, string> AccessTokenChanged { get; set; }

        public FacebookLoginService()
        {
            myAccessTokenTracker = new MyAccessTokenTracker(this);
            // TODO: Stop tracking
            myAccessTokenTracker.StartTracking();
        }

        public string AccessToken => Xamarin.Facebook.AccessToken.CurrentAccessToken?.Token;

        public void Logout()
        {
            LoginManager.Instance.LogOut();
        }
    }

    class MyAccessTokenTracker : AccessTokenTracker
    {
        readonly IFacebookLoginService facebookLoginService;

        public MyAccessTokenTracker(FacebookLoginService facebookLoginService)
        {
            this.facebookLoginService = facebookLoginService;
        }

        protected override void OnCurrentAccessTokenChanged(AccessToken oldAccessToken, AccessToken currentAccessToken)
        {
            facebookLoginService.AccessTokenChanged?.Invoke(oldAccessToken?.Token, currentAccessToken?.Token);
        }
    }
}
