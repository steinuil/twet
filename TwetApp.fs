namespace Twet.App

open Xamarin.Forms
open Xamarin.Forms.Xaml
open Tizen.Wearable.CircularUI.Forms


[<XamlCompilation(XamlCompilationOptions.Compile)>]
type App() =
    inherit Application()

    let list = CircleListView(ItemTemplate = DataTemplate(fun () -> box <| TextCell()), ItemsSource = ["tfw", "nogf"])

    do base.MainPage <- CirclePage(Content = list)