# XF Facebook LoginButton Example
Xamarin.Forms application that uses an abstraction over platform specific Xamarin.Facebook.[iOS/Android] NuGet packages
in order to catch the Facebook Login Events on the Xamarin.Froms level.

## Native Login Button
Each platform rendering a native built-in Facebook Login Button:
* Facebook.LoginKit.LoginButton for iOS
* Xamarin.Facebook.Login.Widget.LoginButton for Android

The abstraction is handling the next events:
* OnSuccess(string authToken)
* OnError(string errDescription)
* OnCancel

## Facebook SDK
* Token changed event
* Programmatically logout

More details in the [blogpost](https://evgenyzborovsky.com/2018/03/09/using-native-facebook-login-button-in-xamarin-forms/).
