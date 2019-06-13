namespace Fabulous.DynamicViews


[<AutoOpen>]
module CircularUIExtension_ =
    open Tizen.Wearable.CircularUI.Forms

    type Fabulous.DynamicViews.View with
        static member inline CirclePage
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

            let create () = Tizen.Wearable.CircularUI.Forms.CirclePage()

            let update (prevOpt : ViewElement voption) (source : ViewElement) (target : CirclePage) =
                ViewBuilders.UpdatePage(prevOpt, source, target)

            ViewElement.Create(create, update, attribs)