# Beta status and final smoke test

The gameplay baseline has been exercised on Pico Neo 3 over Steam Link and Steam Frame through SteamVR. Other headsets/runtimes, mixed controller pairs, left-handed tools and arbitrary custom game bindings are unverified. This mod depends on the game's internal Mono/Harmony interfaces; future game updates can break those hooks.

Menus use gamepad navigation, not a controller laser mouse. Menu hands/controller meshes are intentionally absent. A held button during a transition can temporarily gate input; release controls and center sticks. Native tasks/View is context dependent.

UI, loading composition, structural room/pressure markers and tool alignment were iterated in headset. Unseen screens/ships may still need adjustments. Old Unity/OpenXR dependencies remain pinned for game compatibility; this release does not modernize the engine itself. The scanner fix and haptics are optional patches that log a warning if a game update prevents them from attaching.

The UI cache reduced measured mod work. Smoothness on High was reported on the development PC, but this is not a promise of native headset refresh. Game timing, headset refresh, reprojection and streaming rate differ. Automatic captures are off; F9 is available for diagnosis. No SteamVR settings are changed by the installer.

## Before calling the portable beta hardware-tested

Install the extracted package with the game closed, then verify:

1. Log identifies ShipbreakerVr 0.4.27; VR starts, both hands track, release/center restores input.
2. Main menu, new/load game, habitat computer and backing out, workyard loading text over static, pause/options tabs and Free Play ship-card clipping.
3. Movement/brake/roll, tool wheel, scanner, flashlight, recall tethers, Menu/View and Frame full-click shortcuts or Pico chords.
4. Stinger first shot and muzzle, grapple/retract/tether/push, Splitsaw angle, demo charge placement and detonator.
5. Structural scanner room labels and pressure indicators, readable HUD and haptics.
6. VR toggle both directions, dashboard/focus loss and tracking recovery. Release controls before resuming.
7. Quit and relaunch. Inspect the log for repeated errors.

The final packaged 0.4.27 headset pass is pending. Automated build/installer checks do not replace this pass. No new performance comparison is required merely to validate packaging.
