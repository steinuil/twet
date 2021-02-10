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
            content = View.CircleStackLayout(
                orientation = StackOrientation.Horizontal,
                horizontalOptions = LayoutOptions.Center,
                verticalOptions = LayoutOptions.CenterAndExpand,
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
