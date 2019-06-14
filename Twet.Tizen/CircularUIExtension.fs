namespace Fabulous.DynamicViews


[<AutoOpen>]
module CircularUIExtension =
    open Tizen.Wearable.CircularUI.Forms

    let ContentAttribKey = AttributeKey<_> "CirclePage_Content"

    let ListBarColorAttribKey = AttributeKey<_> "CircleListView_BarColor"
    let FooterAttribKey = AttributeKey<_> "CircleListView_Footer"
    let HasUnevenRowsAttribKey = AttributeKey<_> "CircleListView_HasUnevenRows"
    let HeaderAttribKey = AttributeKey<_> "CircleListView_Header"
    let HeaderTemplateAttribKey = AttributeKey<_> "CircleListView_HeaderTemplate"
    let HorizontalScrollBarVisibilityAttribKey = AttributeKey<_> "CircleListView_HorizontalScrollbarVisibility"
    let IsGroupingEnabledAttribKey = AttributeKey<_> "CircleListView_IsGroupingEnabled"
    let ItemsAttribKey = AttributeKey<_> "CircleListView_Items"

    let ScrollBarColorAttribKey = AttributeKey<_> "CircleScrollView_BarColor"


    type Fabulous.DynamicViews.View with
        static member inline CirclePage
            (
                ?content : Fabulous.DynamicViews.ViewElement,
                // ?onSizeAllocated,

                //#region args
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
                //#endregion
            ) =
            
            let attribCount = 0 + if Option.isSome content then 1 else 0

            let attribs =
                //#region attribs
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
                //#endregion

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

                ?footer : ViewElement,
                ?hasUnevenRows : bool,
                ?header : ViewElement,
                ?headerTemplate : Xamarin.Forms.DataTemplate,
                ?horizontalScrollBarVisibility : Xamarin.Forms.ScrollBarVisibility,
                ?isGroupingEnabled : bool,
                ?isPullToRefreshEnabled : bool,
                ?isRefreshing : bool,
                ?itemAppearing : int -> unit,
                ?itemDisappearing : int -> unit,
                ?items : seq<ViewElement>,
                ?itemSelected : int option -> unit,
                ?itemTapped : int -> unit,
                ?refreshCommand : unit -> unit,
                ?refreshControlColor : Xamarin.Forms.Color,
                ?refreshing : unit -> unit,
                ?rowHeight : int,
                ?selectedItem : int option,
                ?selectionMode : Xamarin.Forms.ListViewSelectionMode,
                ?separatorColor : Xamarin.Forms.Color,
                ?separatorVisibility : Xamarin.Forms.SeparatorVisibility,
                ?verticalScrollBarVisibility : Xamarin.Forms.ScrollBarVisibility,

                //#region args
                ?anchorX,
                ?anchorY,
                ?automationId,
                ?backgroundColor,
                ?childrenReordered,
                ?classId,
                ?created,
                ?focused,
                ?gestureRecognizers,
                ?heightRequest,
                ?horizontalOptions,
                ?inputTransparent,
                ?isEnabled,
                ?isTabStop,
                ?isVisible,
                ?margin,
                ?measureInvalidated,
                ?minimumHeightRequest,
                ?minimumWidthRequest,
                ?opacity,
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
                ?translationX,
                ?translationY,
                ?unfocused,
                ?verticalOptions,
                ?visual,
                ?widthRequest
                //#endregion
            ) =

            let attribCount =
                0
                + if Option.isSome barColor then 1 else 0
                + if Option.isSome footer then 1 else 0
                + if Option.isSome hasUnevenRows then 1 else 0
                + if Option.isSome header then 1 else 0
                + if Option.isSome headerTemplate then 1 else 0
                + if Option.isSome horizontalScrollBarVisibility then 1 else 0
                + if Option.isSome isGroupingEnabled then 1 else 0
                + if Option.isSome items then 1 else 0

            let attribs =
                //#region attribs
                ViewBuilders.BuildItemsView(
                    attribCount,
                    ?anchorX=anchorX,
                    ?anchorY=anchorY,
                    ?automationId=automationId,
                    ?backgroundColor=backgroundColor,
                    ?childrenReordered=childrenReordered,
                    ?classId=classId,
                    ?created=created,
                    ?focused=focused,
                    ?gestureRecognizers=gestureRecognizers,
                    ?heightRequest=heightRequest,
                    ?horizontalOptions=horizontalOptions,
                    ?inputTransparent=inputTransparent,
                    ?isEnabled=isEnabled,
                    ?isTabStop=isTabStop,
                    ?isVisible=isVisible,
                    ?margin=margin,
                    ?measureInvalidated=measureInvalidated,
                    ?minimumHeightRequest=minimumHeightRequest,
                    ?minimumWidthRequest=minimumWidthRequest,
                    ?opacity=opacity,
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
                    ?translationX=translationX,
                    ?translationY=translationY,
                    ?unfocused=unfocused,
                    ?verticalOptions=verticalOptions,
                    ?visual=visual,
                    ?widthRequest=widthRequest
                )
                //#endregion

            barColor |> Option.iter (fun v -> attribs.Add(ListBarColorAttribKey, v))
            footer |> Option.iter (fun v -> attribs.Add(FooterAttribKey, v))
            hasUnevenRows |> Option.iter (fun v -> attribs.Add(HasUnevenRowsAttribKey, v))
            header |> Option.iter (fun v -> attribs.Add(HeaderAttribKey, v))
            headerTemplate |> Option.iter (fun v -> attribs.Add(HeaderTemplateAttribKey, v))
            horizontalScrollBarVisibility |> Option.iter (fun v -> attribs.Add(HorizontalScrollBarVisibilityAttribKey, v))
            isGroupingEnabled |> Option.iter (fun v -> attribs.Add(IsGroupingEnabledAttribKey, v))
            items |> Option.iter (fun v -> attribs.Add(ItemsAttribKey, v))

            let create () = CircleListView()

            let update
                (prevOpt : ViewElement voption)
                (source : ViewElement)
                (target : CircleListView) =
                ViewBuilders.UpdateListView(prevOpt, source, target)
                source.UpdatePrimitive(
                    prevOpt, target, ListBarColorAttribKey,
                    (fun target v -> target.BarColor <- v)
                )
                source.UpdateElement(
                    prevOpt, target, FooterAttribKey,
                    (fun target -> target.Footer),
                    (fun target v -> target.Footer <- v)
                )
                source.UpdatePrimitive(
                    prevOpt, target, HasUnevenRowsAttribKey,
                    (fun target v -> target.HasUnevenRows <- v)
                )

            ViewElement.Create(create, update, attribs)


        static member inline CircleStackLayout
            (
                //#region args
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
                //#endregion
            ) =

            let attribs =
                //#region attribs
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
                //#endregion

            let create () = CircleStackLayout()

            let update
                (prevOpt : ViewElement voption)
                (source : ViewElement)
                (target : CircleStackLayout) =
                ViewBuilders.UpdateStackLayout(prevOpt, source, target)

            ViewElement.Create(create, update, attribs)


        static member inline CircleScrollView
            (
                ?barColor : Xamarin.Forms.Color,

                //#region args
                ?anchorX,
                ?anchorY,
                ?automationId,
                ?backgroundColor,
                ?childrenReordered,
                ?classId,
                ?content,
                ?created,
                ?focused,
                ?gestureRecognizers,
                ?heightRequest,
                ?horizontalOptions,
                ?horizontalScrollBarVisibility,
                ?inputTransparent,
                ?isClippedToBounds,
                ?isEnabled,
                ?isTabStop,
                ?isVisible,
                ?layoutAreaOverride,
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
                ?scrolled,
                ?scrollTo,
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
                //#endregion
            ) =

            let attribCount = 0 + if Option.isSome barColor then 1 else 0

            let attribs =
                //#region attribs
                ViewBuilders.BuildScrollView(
                    attribCount,
                    ?anchorX=anchorX,
                    ?anchorY=anchorY,
                    ?automationId=automationId,
                    ?backgroundColor=backgroundColor,
                    ?childrenReordered=childrenReordered,
                    ?classId=classId,
                    ?content=content,
                    ?created=created,
                    ?focused=focused,
                    ?gestureRecognizers=gestureRecognizers,
                    ?heightRequest=heightRequest,
                    ?horizontalOptions=horizontalOptions,
                    ?horizontalScrollBarVisibility=horizontalScrollBarVisibility,
                    ?inputTransparent=inputTransparent,
                    ?isClippedToBounds=isClippedToBounds,
                    ?isEnabled=isEnabled,
                    ?isTabStop=isTabStop,
                    ?isVisible=isVisible,
                    ?layoutAreaOverride=layoutAreaOverride,
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
                    ?scrolled=scrolled,
                    ?scrollTo=scrollTo,
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
                //#endregion

            barColor |> Option.iter (fun v -> attribs.Add(ScrollBarColorAttribKey, v))

            let create () = CircleScrollView()

            let update prevOpt source (target : CircleScrollView) =
                ViewBuilders.UpdateScrollView(prevOpt, source, target)
                source.UpdatePrimitive(
                    prevOpt, target, ScrollBarColorAttribKey,
                    (fun target v -> target.BarColor <- v)
                )

            ViewElement.Create(create, update, attribs)