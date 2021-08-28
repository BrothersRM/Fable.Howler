module Fable.Howler

open System
open Fable.Core

type preloadOption =
    | Preload of bool
    | Metadata of string

type Sprite = {
    test: string
}


type IHowlerOptions = 
    abstract src: string array option
    abstract volume: double option
    abstract html5: bool option
    abstract loop: bool option
    abstract preload: preloadOption option
    abstract autoplay: bool option
    abstract mute: bool option
    abstract sprite: Sprite option
    abstract rate: double option
    abstract pool: int option
    abstract format: string array option
    abstract xhr: string
    abstract onload: (obj -> obj) option
    abstract onloaderror: (obj -> obj) option
    abstract onplay: (obj -> obj) option
    abstract onend: (obj -> obj) option
    abstract onpause: (obj -> obj) option
    abstract onstop: (obj -> obj) option
    abstract onmute: (obj -> obj) option
    abstract onvolume: (obj -> obj) option
    abstract onrate: (obj -> obj) option
    abstract onseek: (obj -> obj) option
    abstract onfade: (obj -> obj) option
    abstract onunlock: (obj -> obj) option    




type IHowl =
    abstract play: unit -> unit
    abstract pause: unit -> unit
    abstract stop: unit -> unit
    abstract mute: unit -> bool
    abstract mute: bool -> unit
    abstract volume: unit ->  double
    abstract volume: double -> unit
    abstract fade: (double*double*double) -> unit
    abstract rate: unit -> double
    abstract rate: double -> unit
    abstract seek: unit -> double
    abstract seek: double -> unit
    abstract loop: unit -> bool
    abstract loop: bool -> unit
    abstract state: unit -> string
    abstract playing: unit -> bool
    abstract duration: unit -> double
    abstract load: unit -> unit
    abstract unload: unit -> unit
    
type Howl =
    [<Emit("new Howl($1)")>]
    abstract Create: IHowlerOptions -> IHowl



[<Import("Howl", "howler")>]
let Howl: Howl = jsNative