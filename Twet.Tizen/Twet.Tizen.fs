module Twet.Tizen.Main

open Xamarin.Forms


type Program () =
    inherit Platform.Tizen.FormsApplication ()

    override this.OnCreate () =
        base.OnCreate()
        this.LoadApplication(App.FabulousApp())
        // this.LoadApplication(App.XamlApp())

[<EntryPoint>]
let main args =
    Tizen.Wearable.CircularUI.Forms.Renderer.FormsCircularUI.Init()
    let app = new Program()
    Platform.Tizen.Forms.Init app
    app.Run args
    0