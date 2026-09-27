# Controls — 0.4.27 beta

The active layout follows controller capabilities. Steam Frame exposes the native split gamepad layout; Pico uses the compact VR layout. Begin with both controllers tracked, sticks centered and buttons released. Release triggers after changing tools, tracking recovery or resuming.

## Shared actions

| Input | Action |
| --- | --- |
| Left stick | Thrust |
| Right stick | Turn |
| A / B | Up / down in gameplay; confirm / back in menus |
| Stick clicks | Roll; both together brake |
| Right trigger | Stinger cut, grapple grab, Splitsaw cut, or demo-charge place/throw/detonate according to tool mode |
| Left trigger | Grapple retract/tether, or cutter/demo angle adjustment according to tool state |
| X | Interact / grapple push; contextual X in menus |
| Left stick in menus | Navigate |
| Right stick in menus | Scroll |

Stock range, upgrades, heat, tether capacity and other tool rules remain in effect. The mod changes aim/input/presentation, not reach. Tool guides indicate applicable effective range; visual guides do not extend it.

## Steam Frame

| Input | Action |
| --- | --- |
| Y **or right full grip click** | Hold for tool wheel, select with **left stick**, release to equip; contextual Y in menus |
| D-pad up **or left full grip click** | Scanner in gameplay; navigate up in menus |
| D-pad down | Recall tethers |
| D-pad left | Flashlight |
| D-pad right | Tool mode |
| LB / RB | Native hand-grab actions; previous/next scanner mode while scanning; previous/next tab in menus/options |
| Menu | Pause/resume |
| View | Native View/tasks action, where available in the current game mode |

The grip shortcuts use the full squeeze **click** stage, not the analog half squeeze or the index-finger trigger. Original Y and D-pad up still work. If both Y and its grip alias are held, release both to close the wheel. Frame scanner mode switching uses bumpers.

## Pico Neo 3 / compact VR layout

| Input | Action |
| --- | --- |
| Y | Hold for tool wheel, select with **right stick**, release to equip |
| Right grip | Tool mode in gameplay; RB / next tab in menus |
| Left grip + left stick | D-pad: up scanner, down recall tethers, left flashlight, right tool mode |
| Left grip in menus | LB / previous tab |
| B + Y | Pause/resume; release both before repeating |
| X + Y | Native View/tasks; release both before repeating |
| Left / right trigger while scanning | Previous / next scanner mode |
| X / Y in menus | Contextual X / Y |

Recenter the left stick after using shifted D-pad input before thrust resumes. Menu actions remain subject to the game's available actions and bindings.

## VR toggle and diagnostics

Center both sticks. Press and hold both stick clicks **first**, then both grips/full grip clicks for two seconds. Release all four afterward. This toggles the view while retaining the runtime connection. It requires a connected OpenXR session; use F3 if initial connection failed.

| Key | Action |
| --- | --- |
| F3 | Toggle VR/desktop; retry OpenXR initialization when needed |
| F5 | Original mod shortcut: lowest quality preset |
| F6 | Original mod shortcut: toggle scene lights |
| F7 | Log UI snapshot |
| F8 | Toggle gameplay HUD following the head |
| F9 | Start/stop optional performance capture |

F5/F6 are diagnostic/upstream shortcuts, not required performance settings. Automatic timing tests are disabled by default. Menu laser clicking is not implemented. The game window must be focused; SteamVR dashboard input can prevent game control.

## Settings

Close the game before editing `BepInEx/config/ShipbreakerVr.cfg`. It is generated on first launch. Controls, HUD and tool defaults already include the tuning accepted during development. `Haptics.Strength` defaults to 0.5. `Presentation.ShowDebugRays` is an optional diagnostic setting, off by default.

Pico menu bindings are configurable in `[Menus]`. Frame's native full-gamepad route uses the fixed physical layout above; motion gameplay adapters do not honor every in-game gamepad remapping. Use stock game bindings for initial testing. Mixed controller pairs and left-handed tool use are unverified.
