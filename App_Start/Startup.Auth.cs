using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.Facebook;

namespace SocialLoginWithoutIdentity
{
    public partial class Startup
    {
        private void ConfigureAuth(IAppBuilder app)
        {
            var cookieOptions = new CookieAuthenticationOptions
            {
                LoginPath = new PathString("/Account/Login")
            };

            app.UseCookieAuthentication(cookieOptions);

            app.SetDefaultSignInAsAuthenticationType(cookieOptions.AuthenticationType);

            app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions
            {
                ClientId = "rGaUsIUyGmqcuu194Xv9PKfmr",
                ClientSecret = "pewTG74M9fUiAfFU5S35BinksMSg3HWJszLq2nMTI614UTzULs"
            });
            app.UseFacebookAuthentication(new FacebookAuthenticationOptions
            {
                AppId = "208623500317955",
                AppSecret = "bb084821b9a0e5aaa13cb610db02a628"
            });


        }
    }
}