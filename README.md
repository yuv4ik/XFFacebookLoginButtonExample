# XF Facebook LoginButton Example
Is a Xamarin.Forms application that uses an abstraction over platform specific Xamarin.Facebook.[iOS/Android] NuGet packages
in order to catch the Facebook Login Events on the Xamarin.Froms level.

Each platform rendering a native built-in Facebook Login Button:
* Facebook.LoginKit.LoginButton for iOS
* Xamarin.Facebook.Login.Widget.LoginButton for Android

The abstraction is handling the next events:
* OnSuccess(string authToken)
* OnError(string errDescription)
* OnCancel

More details in the [blogpost](https://smellyc0de.wordpress.com/2018/03/09/using-native-facebook-login-button-in-xamarin-forms/).
