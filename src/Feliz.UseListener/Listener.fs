namespace Feliz.UseListener

open Browser.Types
open Browser.Dom
open Fable.Core
open Feliz

[<Erase;RequireQualifiedAccess>]
module React =
    [<Erase>]
    type useListener =
        static member inline on (eventType: string, action: #Event -> unit) =
            let action = React.useCallbackRef(action)
            React.useEffect((fun () ->
                let fn = unbox<#Event> >> action
                document.addEventListener(eventType, fn, false)        
                React.createDisposable(fun () -> document.removeEventListener(eventType, fn))
            ), [| eventType :> obj; action :> obj |])

        static member inline onAbort (action: ProgressEvent -> unit) = useListener.on("abort", action)
        static member inline onAbort (action: UIEvent -> unit) = useListener.on("abort", action)
        static member inline onAnimationEnd (action: AnimationEvent -> unit) = useListener.on("animationend", action)
        static member inline onAnimationIteration (action: AnimationEvent -> unit) = useListener.on("animationiteration", action)
        static member inline onAnimationStart (action: AnimationEvent -> unit) = useListener.on("animationstart", action)
        static member inline onBlur (action: FocusEvent -> unit) = useListener.on("blur", action)
        static member inline onCanPlay (action: Event -> unit) = useListener.on("canplay", action)
        static member inline onCanPlayThrough (action: Event -> unit) = useListener.on("canplaythrough", action)
        static member inline onChange (action: Event -> unit) = useListener.on("change", action)
        static member inline onClick (action: MouseEvent -> unit) = useListener.on("click", action)
        static member inline onCompositionEnd (action: CompositionEvent -> unit) = useListener.on("compositionend", action)
        static member inline onCompositionStart (action: CompositionEvent -> unit) = useListener.on("compositionstart", action)
        static member inline onCompositionUpdate (action: CompositionEvent -> unit) = useListener.on("compositionupdate", action)
        static member inline onContextMenu (action: MouseEvent -> unit) = useListener.on("contextmenu", action)
        static member inline onCopy (action: ClipboardEvent -> unit) = useListener.on("copy", action)
        static member inline onCut (action: ClipboardEvent -> unit) = useListener.on("cut", action)
        static member inline onDblClick (action: MouseEvent -> unit) = useListener.on("dblClick", action)
        static member inline onDrag (action: DragEvent -> unit) = useListener.on("drag", action)
        static member inline onDragEnd (action: DragEvent -> unit) = useListener.on("dragend", action)
        static member inline onDragEnter (action: DragEvent -> unit) = useListener.on("dragenter", action)
        static member inline onDragExit (action: DragEvent -> unit) = useListener.on("dragexit", action)
        static member inline onDragLeave (action: DragEvent -> unit) = useListener.on("dragleave", action)
        static member inline onDragOver (action: DragEvent -> unit) = useListener.on("dragover", action)
        static member inline onDragStart (action: DragEvent -> unit) = useListener.on("dragstart", action)
        static member inline onDrop (action: DragEvent -> unit) = useListener.on("drop", action)
        static member inline onDurationChange (action: Event -> unit) = useListener.on("durationchange", action)
        static member inline onEmptied (action: Event -> unit) = useListener.on("emptied", action)
        static member inline onEncrypted (action: Event -> unit) = useListener.on("encrypted", action)
        static member inline onEnded (action: Event -> unit) = useListener.on("ended", action)
        static member inline onError (action: ProgressEvent -> unit) = useListener.on("error", action)
        static member inline onError (action: UIEvent -> unit) = useListener.on("error", action)
        static member inline onFocus (action: FocusEvent -> unit) = useListener.on("focus", action)
        static member inline onFocusIn (action: FocusEvent -> unit) = useListener.on("focusin", action)
        static member inline onFocusOut (action: FocusEvent -> unit) = useListener.on("focusout", action)
        static member inline onGotPointerCapture (action: PointerEvent -> unit) = useListener.on("gopPointercapture", action)
        static member inline onInput (action: UIEvent -> unit) = useListener.on("input", action)
        static member inline onInvalid (action: Event -> unit) = useListener.on("invalid", action)
        static member inline onKeyDown (action: KeyboardEvent -> unit) = useListener.on("keydown", action)
        static member inline onKeyPress (action: KeyboardEvent -> unit) = useListener.on("keypress", action)
        static member inline onKeyUp (action: KeyboardEvent -> unit) = useListener.on("keyup", action)
        static member inline onLoad (action: ProgressEvent -> unit) = useListener.on("load", action)
        static member inline onLoad (action: UIEvent -> unit) = useListener.on("load", action)
        static member inline onLoadedData (action: Event -> unit) = useListener.on("loadeddata", action)
        static member inline onLoadedMetadata (action: Event -> unit) = useListener.on("loadedmetadata", action)
        static member inline onLoadStart (action: ProgressEvent -> unit) = useListener.on("loadstart", action)
        static member inline onLostPointerCapture (action: PointerEvent -> unit) = useListener.on("lostpointercapture", action)
        static member inline onMouseDown (action: MouseEvent -> unit) = useListener.on("mousedown", action)
        static member inline onMouseEnter (action: MouseEvent -> unit) = useListener.on("mouseenter", action)
        static member inline onMouseLeave (action: MouseEvent -> unit) = useListener.on("mouseleave", action)
        static member inline onMouseMove (action: MouseEvent -> unit) = useListener.on("mousemove", action)
        static member inline onMouseOut (action: MouseEvent -> unit) = useListener.on("mouseout", action)
        static member inline onMouseOver (action: MouseEvent -> unit) = useListener.on("mouseover", action)
        static member inline onMouseUp (action: MouseEvent -> unit) = useListener.on("mouseup", action)
        static member inline onPaste (action: ClipboardEvent -> unit) = useListener.on("paste", action)
        static member inline onPause (action: Event -> unit) = useListener.on("pause", action)
        static member inline onPlay (action: Event -> unit) = useListener.on("play", action)
        static member inline onPlaying (action: Event -> unit) = useListener.on("playing", action)
        static member inline onPointerCancel (action: PointerEvent -> unit) = useListener.on("pointercancel", action)
        static member inline onPointerDown (action: PointerEvent -> unit) = useListener.on("pointerdown", action)
        static member inline onPointerEnter (action: PointerEvent -> unit) = useListener.on("pointerenter", action)
        static member inline onPointerLeave (action: PointerEvent -> unit) = useListener.on("pointerleave", action)
        static member inline onPointerMove (action: PointerEvent -> unit) = useListener.on("pointermove", action)
        static member inline onPointerOut (action: PointerEvent -> unit) = useListener.on("pointerout", action)
        static member inline onPointerOver (action: PointerEvent -> unit) = useListener.on("pointerover", action)
        static member inline onPointerUp (action: PointerEvent -> unit) = useListener.on("pointerup", action)
        static member inline onPopState (action: Event -> unit) = useListener.on("popstate", action)
        static member inline onProgress (action: ProgressEvent -> unit) = useListener.on("progress", action)
        static member inline onRateChange (action: Event -> unit) = useListener.on("ratechange", action)
        static member inline onReset (action: Event -> unit) = useListener.on("reset", action)
        static member inline onScroll (action: Event -> unit) = useListener.on("scroll", action)
        static member inline onSeeked (action: Event -> unit) = useListener.on("seeked", action)
        static member inline onSeeking (action: Event -> unit) = useListener.on("seeking", action)
        static member inline onSelect (action: MouseEvent -> unit) = useListener.on("select", action)
        static member inline onStalled (action: Event -> unit) = useListener.on("stalled", action)
        static member inline onSubmit (action: Event -> unit) = useListener.on("submit", action)
        static member inline onSuspend (action: Event -> unit) = useListener.on("suspend", action)
        static member inline onTimeUpdate (action: Event -> unit) = useListener.on("timeupdate", action)
        static member inline onTouchCancel (action: TouchEvent -> unit) = useListener.on("touchcancel", action)
        static member inline onTouchEnd (action: TouchEvent -> unit) = useListener.on("touchend", action)
        static member inline onTouchMove (action: TouchEvent -> unit) = useListener.on("touchmove", action)
        static member inline onTouchStart (action: TouchEvent -> unit) = useListener.on("touchstart", action)
        static member inline onTransitionEnd (action: TransitionEvent -> unit) = useListener.on("transitionend", action)
        static member inline onVolumeChange (action: Event -> unit) = useListener.on("volumechange", action)
        static member inline onWaiting (action: Event -> unit) = useListener.on("waiting", action)
        static member inline onWheel (action: MouseEvent -> unit) = useListener.on("wheel", action)
