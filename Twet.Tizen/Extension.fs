namespace Fabulous.DynamicViews


[<AutoOpen>]
module CircularUIExtension =
    open Fabulous.Core
    open Xamarin.Forms
    open Tizen.Wearable.CircularUI.Forms


    let ColorAttribKey = AttributeKey "CircularUI_Check_Color"
    let DisplayStyleAttribKey = AttributeKey "CircularUI_Check_DisplayStyle"


    type Fabulous.DynamicViews.View with
        static member Check
            (
            ?color: Color, ?displayStyle: CheckDisplayStyle,
             // Switch boilerplate
            ?childrenReordered, ?focused, ?isTabStop, ?isToggled, ?measureInvalidated, ?onColor,
            ?ref, ?scaleX, ?scaleY, ?sizeChanged, ?tabIndex, ?toggled, ?unfocused, ?visual,
            // Boilerplate
            ?horizontalOptions, ?verticalOptions, ?margin,
            ?gestureRecognizers, ?anchorX, ?anchorY, ?backgroundColor,
            ?heightRequest, ?inputTransparent, ?isEnabled, ?isVisible,
            ?minimumHeightRequest, ?minimumWidthRequest, ?opacity,
            ?rotation, ?rotationX, ?rotationY, ?scale, ?style,
            ?translationX, ?translationY, ?widthRequest, ?resources,
            ?styles, ?styleSheets, ?classId, ?styleId, ?automationId,
            ?created, ?styleClass
            ) =

            let attribCount =
                0 + if Option.isSome color then 0 else 1
                  + if Option.isSome displayStyle then 0 else 1

            // More boilerplate
            let attribs = 
                ViewBuilders.BuildSwitch(
                    attribCount, ?anchorX=anchorX, ?anchorY=anchorY, ?automationId=automationId,
                    ?backgroundColor=backgroundColor, ?childrenReordered=childrenReordered,
                    ?classId=classId, ?created=created, ?focused=focused,
                    ?gestureRecognizers=gestureRecognizers, ?heightRequest=heightRequest,
                    ?horizontalOptions=horizontalOptions, ?inputTransparent=inputTransparent,
                    ?isEnabled=isEnabled, ?isTabStop=isTabStop, ?isToggled=isToggled,
                    ?isVisible=isVisible, ?margin=margin, ?measureInvalidated=measureInvalidated,
                    ?minimumHeightRequest=minimumHeightRequest,
                    ?minimumWidthRequest=minimumWidthRequest,
                    ?onColor=onColor, ?opacity=opacity, ?ref=ref, ?resources=resources,
                    ?rotation=rotation, ?rotationX=rotationX, ?rotationY=rotationY, ?scale=scale,
                    ?scaleX=scaleX, ?scaleY=scaleY, ?sizeChanged=sizeChanged, ?style=style,
                    ?styleClass=styleClass, ?styleId=styleId, ?styles=styles,
                    ?styleSheets=styleSheets, ?tabIndex=tabIndex, ?toggled=toggled,
                    ?translationX=translationX, ?translationY=translationY, ?unfocused=unfocused,
                    ?verticalOptions=verticalOptions, ?visual=visual, ?widthRequest=widthRequest
                )

            color |> Option.iter (fun v -> attribs.Add(ColorAttribKey, v))
            displayStyle |> Option.iter (fun v -> attribs.Add(DisplayStyleAttribKey, v))

            let create () =
                Tizen.Wearable.CircularUI.Forms.Check()

            let update (prevOpt : ViewElement voption) (source: ViewElement) (target: Check) =
                ViewBuilders.UpdateView(prevOpt, source, target)
                source.UpdatePrimitive(prevOpt, target, ColorAttribKey,
                    (fun target v -> target.Color <- v))
                source.UpdatePrimitive(prevOpt, target, DisplayStyleAttribKey,
                    (fun target v -> target.DisplayStyle <- v))


            ViewElement.Create(create, update, attribs)

        static member CirclePage
            (
            ?anchorX,
            ?anchorY,
            ?appearing,
            ?automationId,
            ?backgroundColor,
            ?backgroundImage,
            ?backgroundImageSource,
            ?childrenReordered,
            ?classId,
            ?content,
            ?created,
            ?disappearing,
            ?focused,
            ?heightRequest,
            ?icon,
            ?iconImageSource,
            ?inputTransparent,
            ?isBusy,
            ?isEnabled,
            ?isTabStop,
            ?isVisible,
            ?layoutChanged,
            ?measureInvalidated,
            ?minimumHeightRequest,
            ?minimumWidthRequest,
            ?onSizeAllocated,
            ?opacity,
            ?padding,
            ?ref,
            ?resources,
            ?rotation,
            ?rotationX,
            ?rotationY,
            ?scale,
            ?scaleX,
            ?scaleY,
            ?sizeChanged,
            ?style,
            ?styleClass,
            ?styleId,
            ?styles,
            ?styleSheets,
            ?tabIndex,
            ?title,
            ?toolbarItems,
            ?translationX,
            ?translationY,
            ?unfocused,
            ?useSafeArea,
            ?visual,
            ?widthRequest
            ) =

            let attribCount = 0

            let attribs =
                ViewBuilders.BuildContentPage(
                    attribCount,
                    ?anchorX=anchorX,
                    ?anchorY=anchorY,
                    ?appearing=appearing,
                    ?automationId=automationId,
                    ?backgroundColor=backgroundColor,
                    ?backgroundImage=backgroundImage,
                    ?backgroundImageSource=backgroundImageSource,
                    ?childrenReordered=childrenReordered,
                    ?classId=classId,
                    ?content=content,
                    ?created=created,
                    ?disappearing=disappearing,
                    ?focused=focused,
                    ?heightRequest=heightRequest,
                    ?icon=icon,
                    ?iconImageSource=iconImageSource,
                    ?inputTransparent=inputTransparent,
                    ?isBusy=isBusy,
                    ?isEnabled=isEnabled,
                    ?isTabStop=isTabStop,
                    ?isVisible=isVisible,
                    ?layoutChanged=layoutChanged,
                    ?measureInvalidated=measureInvalidated,
                    ?minimumHeightRequest=minimumHeightRequest,
                    ?minimumWidthRequest=minimumWidthRequest,
                    ?onSizeAllocated=onSizeAllocated,
                    ?opacity=opacity,
                    ?padding=padding,
                    ?ref=ref,
                    ?resources=resources,
                    ?rotation=rotation,
                    ?rotationX=rotationX,
                    ?rotationY=rotationY,
                    ?scale=scale,
                    ?scaleX=scaleX,
                    ?scaleY=scaleY,
                    ?sizeChanged=sizeChanged,
                    ?style=style,
                    ?styleClass=styleClass,
                    ?styleId=styleId,
                    ?styles=styles,
                    ?styleSheets=styleSheets,
                    ?tabIndex=tabIndex,
                    ?title=title,
                    ?toolbarItems=toolbarItems,
                    ?translationX=translationX,
                    ?translationY=translationY,
                    ?unfocused=unfocused,
                    ?useSafeArea=useSafeArea,
                    ?visual=visual,
                    ?widthRequest=widthRequest
                )

            let create () =
                Tizen.Wearable.CircularUI.Forms.CirclePage()

            let update (prevOpt : ViewElement voption) (source: ViewElement) (target: CirclePage) =
                ViewBuilders.UpdatePage(prevOpt, source, target)

            ViewElement.Create(create, update, attribs)


        static member CircleListView
            (
            ?barColor: Color,
            //getCancelEffect
            // ListView boilerplate
            ?childrenReordered,
            ?focused,
            ?isTabStop,
            ?measureInvalidated,
            ?ref,
            ?scaleX,
            ?scaleY,
            ?sizeChanged,
            ?tabIndex,
            ?unfocused,
            ?visual,
            ?footer,
            ?hasUnevenRows,
            ?header,
            ?headerTemplate,
            ?horizontalScrollBarVisibility,
            ?isGroupingEnabled,
            ?isPullToRefreshEnabled,
            ?isRefreshing,
            ?itemAppearing,
            ?itemDisappearing,
            ?items,
            ?itemSelected,
            ?itemTapped,
            ?refreshCommand,
            ?refreshControlColor,
            ?refreshing,
            ?rowHeight,
            ?selectedItem,
            ?selectionMode,
            ?separatorColor,
            ?separatorVisibility,
            ?verticalScrollBarVisibility,
            // Boilerplate
            ?horizontalOptions, ?verticalOptions, ?margin,
            ?gestureRecognizers, ?anchorX, ?anchorY, ?backgroundColor,
            ?heightRequest, ?inputTransparent, ?isEnabled, ?isVisible,
            ?minimumHeightRequest, ?minimumWidthRequest, ?opacity,
            ?rotation, ?rotationX, ?rotationY, ?scale, ?style,
            ?translationX, ?translationY, ?widthRequest, ?resources,
            ?styles, ?styleSheets, ?classId, ?styleId, ?automationId,
            ?created, ?styleClass
            ) =
            let attribCount = 0

            let attribs =
                ViewBuilders.BuildListView(
                    attribCount,
                    ?anchorX=anchorX,
                    ?anchorY=anchorY,
                    ?automationId=automationId,
                    ?backgroundColor=backgroundColor,
                    ?childrenReordered=childrenReordered,
                    ?classId=classId,
                    ?created=created,
                    ?focused=focused,
                    ?footer=footer,
                    ?gestureRecognizers=gestureRecognizers,
                    ?hasUnevenRows=hasUnevenRows,
                    ?header=header,
                    ?headerTemplate=headerTemplate,
                    ?heightRequest=heightRequest,
                    ?horizontalOptions=horizontalOptions,
                    ?horizontalScrollBarVisibility=horizontalScrollBarVisibility,
                    ?inputTransparent=inputTransparent,
                    ?isEnabled=isEnabled,
                    ?isGroupingEnabled=isGroupingEnabled,
                    ?isPullToRefreshEnabled=isPullToRefreshEnabled,
                    ?isRefreshing=isRefreshing,
                    ?isTabStop=isTabStop,
                    ?isVisible=isVisible,
                    ?itemAppearing=itemAppearing,
                    ?itemDisappearing=itemDisappearing,
                    ?items=items,
                    ?itemSelected=itemSelected,
                    ?itemTapped=itemTapped,
                    ?margin=margin,
                    ?measureInvalidated=measureInvalidated,
                    ?minimumHeightRequest=minimumHeightRequest,
                    ?minimumWidthRequest=minimumWidthRequest,
                    ?opacity=opacity,
                    ?ref=ref,
                    ?refreshCommand=refreshCommand,
                    ?refreshControlColor=refreshControlColor,
                    ?refreshing=refreshing,
                    ?resources=resources,
                    ?rotation=rotation,
                    ?rotationX=rotationX,
                    ?rotationY=rotationY,
                    ?rowHeight=rowHeight,
                    ?scale=scale,
                    ?scaleX=scaleX,
                    ?scaleY=scaleY,
                    ?selectedItem=selectedItem,
                    ?selectionMode=selectionMode,
                    ?separatorColor=separatorColor,
                    ?separatorVisibility=separatorVisibility,
                    ?sizeChanged=sizeChanged,
                    ?style=style,
                    ?styleClass=styleClass,
                    ?styleId=styleId,
                    ?styles=styles,
                    ?styleSheets=styleSheets,
                    ?tabIndex=tabIndex,
                    ?translationX=translationX,
                    ?translationY=translationY,
                    ?unfocused=unfocused,
                    ?verticalOptions=verticalOptions,
                    ?verticalScrollBarVisibility=verticalScrollBarVisibility,
                    ?visual=visual,
                    ?widthRequest=widthRequest
                )
            
            let create () =
                Tizen.Wearable.CircularUI.Forms.CircleListView()

            let update (prevOpt : ViewElement voption) (source: ViewElement)
                (target: CircleListView) =
                ViewBuilders.UpdateView(prevOpt, source, target)
            
            ViewElement.Create(create, update, attribs)