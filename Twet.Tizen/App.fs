namespace Twet.Tizen.App

open Xamarin.Forms


module Core =
    type Msg =
        | Pressed

    type Model =
        { Text : string }

    let init () =
        { Text = "aaa" }

    let update msg model =
        match msg with
        | Pressed -> { model with Text = model.Text + "A" }

    open Fabulous.DynamicViews

    let view model dispatch =
        View.CirclePage(
            content = View.StackLayout(
                orientation = StackOrientation.Horizontal,
                horizontalOptions = LayoutOptions.Center,
                children = [
                    View.Label(
                        text = model.Text,
                        gestureRecognizers = [
                            View.TapGestureRecognizer(command = (fun () -> dispatch Pressed))
                        ]
                    )
                ]
            )
        )


type FabulousApp () as app =
    inherit Application ()

    do
        Fabulous.Core.Program.mkSimple Core.init Core.update Core.view
        |> Fabulous.Core.Program.runWithDynamicView app
        |> ignore


open Tizen.Wearable.CircularUI.Forms

type XamlApp () =
    inherit Application()

    do
        let stackLayout(children: list<View>) =
            let l =
                StackLayout(
                    Orientation = StackOrientation.Vertical,
                    HorizontalOptions = LayoutOptions.Center
                )
            for child in children do l.Children.Add(child)
            l
        base.MainPage <- CirclePage(
            Content = stackLayout([
                Label(Text = "SUP")
                Label(Text = "XAML")
            ])
        )