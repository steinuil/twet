namespace Fabulous.DynamicViews


[<AutoOpen>]
module CircularUIExtension =
    open Tizen.Wearable.CircularUI.Forms

    let BarColorAttribKey = AttributeKey<_> "CircleListView_BarColor"
    let ContentAttribKey = AttributeKey<_> "CirclePage_Content"


    type Fabulous.DynamicViews.View with
        static member inline CirclePage
            (
                ?content : Fabulous.DynamicViews.ViewElement,
                // ?onSizeAllocated,
                ?anchorX,
                ?anchorY,
                ?appearing,
                ?automationId,
                ?backgroundColor,
                ?backgroundImage,
                ?backgroundImageSource,
                ?childrenReordered,
                ?classId,
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
            
            let attribCount = 0 + if Option.isSome content then 1 else 0

            let attribs =
                ViewBuilders.BuildPage(
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

            content |> Option.iter (fun v -> attribs.Add(ContentAttribKey, v))

            let create () = CirclePage()

            let update prevOpt source (target : CirclePage) =
                ViewBuilders.UpdatePage(prevOpt, source, target)
                source.UpdateElement(
                    prevOpt, target, ContentAttribKey,
                    (fun target -> target.Content),
                    (fun target v -> target.Content <- v)
                )

            ViewElement.Create(create, update, attribs)


        static member inline CircleListView
            (
                ?barColor : Xamarin.Forms.Color,

                ?anchorX,
                ?anchorY,
                ?automationId,
                ?backgroundColor,
                ?childrenReordered,
                ?classId,
                ?created,
                ?focused,
                ?footer,
                ?gestureRecognizers,
                ?hasUnevenRows,
                ?header,
                ?headerTemplate,
                ?heightRequest,
                ?horizontalOptions,
                ?horizontalScrollBarVisibility,
                ?inputTransparent,
                ?isEnabled,
                ?isGroupingEnabled,
                ?isPullToRefreshEnabled,
                ?isRefreshing,
                ?isTabStop,
                ?isVisible,
                ?itemAppearing,
                ?itemDisappearing,
                ?items,
                ?itemSelected,
                ?itemTapped,
                ?margin,
                ?measureInvalidated,
                ?minimumHeightRequest,
                ?minimumWidthRequest,
                ?opacity,
                ?ref,
                ?refreshCommand,
                ?refreshControlColor,
                ?refreshing,
                ?resources,
                ?rotation,
                ?rotationX,
                ?rotationY,
                ?rowHeight,
                ?scale,
                ?scaleX,
                ?scaleY,
                ?selectedItem,
                ?selectionMode,
                ?separatorColor,
                ?separatorVisibility,
                ?sizeChanged,
                ?style,
                ?styleClass,
                ?styleId,
                ?styles,
                ?styleSheets,
                ?tabIndex,
                ?translationX,
                ?translationY,
                ?unfocused,
                ?verticalOptions,
                ?verticalScrollBarVisibility,
                ?visual,
                ?widthRequest
            ) =

            let attribCount = 0 + if Option.isSome barColor then 1 else 0

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

            barColor |> Option.iter (fun v -> attribs.Add(BarColorAttribKey, v))

            let create () = CircleListView()

            let update
                (prevOpt : ViewElement voption)
                (source : ViewElement)
                (target : CircleListView) =
                ViewBuilders.UpdateListView(prevOpt, source, target)
                source.UpdatePrimitive(
                    prevOpt, target, BarColorAttribKey,
                    (fun target v -> target.BarColor <- v)
                )

            ViewElement.Create(create, update, attribs)


        static member inline CircleStackLayout
            (
                ?anchorX,
                ?anchorY,
                ?automationId,
                ?backgroundColor,
                ?children,
                ?childrenReordered,
                ?classId,
                ?created,
                ?focused,
                ?gestureRecognizers,
                ?heightRequest,
                ?horizontalOptions,
                ?inputTransparent,
                ?isClippedToBounds,
                ?isEnabled,
                ?isTabStop,
                ?isVisible,
                ?margin,
                ?measureInvalidated,
                ?minimumHeightRequest,
                ?minimumWidthRequest,
                ?opacity,
                ?orientation,
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
                ?spacing,
                ?style,
                ?styleClass,
                ?styleId,
                ?styles,
                ?styleSheets,
                ?tabIndex,
                ?translationX,
                ?translationY,
                ?unfocused,
                ?verticalOptions,
                ?visual,
                ?widthRequest
            ) =

            let attribs =
                ViewBuilders.BuildStackLayout(
                    0,
                    ?anchorX=anchorX,
                    ?anchorY=anchorY,
                    ?automationId=automationId,
                    ?backgroundColor=backgroundColor,
                    ?children=children,
                    ?childrenReordered=childrenReordered,
                    ?classId=classId,
                    ?created=created,
                    ?focused=focused,
                    ?gestureRecognizers=gestureRecognizers,
                    ?heightRequest=heightRequest,
                    ?horizontalOptions=horizontalOptions,
                    ?inputTransparent=inputTransparent,
                    ?isClippedToBounds=isClippedToBounds,
                    ?isEnabled=isEnabled,
                    ?isTabStop=isTabStop,
                    ?isVisible=isVisible,
                    ?margin=margin,
                    ?measureInvalidated=measureInvalidated,
                    ?minimumHeightRequest=minimumHeightRequest,
                    ?minimumWidthRequest=minimumWidthRequest,
                    ?opacity=opacity,
                    ?orientation=orientation,
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
                    ?spacing=spacing,
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
                    ?visual=visual,
                    ?widthRequest=widthRequest
                )

            let create () = CircleStackLayout()

            let update
                (prevOpt : ViewElement voption)
                (source : ViewElement)
                (target : CircleStackLayout) =
                ViewBuilders.UpdateStackLayout(prevOpt, source, target)

            ViewElement.Create(create, update, attribs)