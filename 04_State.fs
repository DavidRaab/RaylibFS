namespace MyGame
open Storage
open Sto2

module State =
    /// Initialized Random Number Generator to be used
    let rng = System.Random ()

    /// Stores information on how many DrawTexture() calls
    /// happened in draw. Resets every frame.
    let mutable drawed   = 0

    // Camera objects, initialized on game startup
    let mutable camera   = Unchecked.defaultof<Raylib_cs.Camera2D>
    let mutable uiCamera = Unchecked.defaultof<Raylib_cs.Camera2D>

    // State variables
    let Transform          = Storage.create<Entity,Transform> ()
    let View               = Sto2.create<Layer, Entity, View> ()
    let Animation          = Storage.create<Entity,Animation> ()
    let AutoMovement       = Storage.create<Entity,AutoMovement> ()
    let AutoTargetPosition = Storage.create<Entity,AutoTargetPosition> ()
    let PathWalking        = Storage.create<Entity,PathWalking> ()