module Twet.Main


open Xamarin.Forms


type Program () =
    inherit Platform.Tizen.FormsApplication ()

    override this.OnCreate() =
        base.OnCreate()
        this.LoadApplication(App.App())



[<EntryPoint>]
let main args =
    let app = new Program()
    Platform.Tizen.Forms.Init(app)
    Tizen.Wearable.CircularUI.Forms.Renderer.FormsCircularUI.Init()
    app.Run(args)
    0