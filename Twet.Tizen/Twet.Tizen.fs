﻿module Twet.Tizen


open Tizen
open Tizen.NUI
open Tizen.NUI.BaseComponents


type App () =
    inherit NUIApplication ()


    member this.Initialize() =
        Window.Instance.BackgroundColor <- Color.Black
        let mWindowSize = Window.Instance.Size

        let title =
            new TextLabel(
                "ayy lmao",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                TextColor = Color.White,
                PositionUsesPivotPoint = true,
                ParentOrigin = ParentOrigin.TopCenter,
                PivotPoint = PivotPoint.TopCenter,
                Position2D = new Position2D(0, mWindowSize.Height / 10),
                MultiLine = false,
                PointSize = 10.0f
            )
        Window.Instance.GetDefaultLayer().Add(title)

        // Works only when compiling in release mode
        // (possibly related to FSharp.Core bundling?)
        // match Some "A" with
        // | Some x -> Log.Debug("Twet", x)
        // | _ -> ()

        Window.Instance.KeyEvent.Add(fun ev ->
            match ev.Key.State, ev.Key.KeyPressedName with
            | Key.StateType.Down, "XF86Back" -> this.Exit()
            | _ -> ()
        )


    override this.OnCreate() =
        base.OnCreate()
        this.Initialize()


[<EntryPoint>]
let main args =
    (new App()).Run(args)
    0