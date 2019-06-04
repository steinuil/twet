module Twet


open Tizen.NUI
open Tizen.NUI.BaseComponents


type TwetApp () =
    inherit NUIApplication ()


    member __.Initialize() =
        Window.Instance.BackgroundColor <- Color.Black
        let mWindowSize = Window.Instance.Size

        let title = new TextLabel("ayy lmao")
        title.HorizontalAlignment <- HorizontalAlignment.Center
        title.VerticalAlignment <- VerticalAlignment.Center
        title.TextColor <- Color.White
        title.PositionUsesPivotPoint <- true
        title.ParentOrigin <- ParentOrigin.TopCenter
        title.PivotPoint <- PivotPoint.TopCenter
        title.Position2D <- new Position2D(0, mWindowSize.Height / 10)
        title.FontFamily <- "Samsung One 600"
        title.MultiLine <- false
        title.PointSize <- 10.0f
        Window.Instance.GetDefaultLayer().Add(title)


    override this.OnCreate() =
        base.OnCreate()
        this.Initialize()


[<EntryPoint>]
let main args =
    (new TwetApp()).Run(args)
    0