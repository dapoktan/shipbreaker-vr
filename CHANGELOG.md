# Changes

## 0.4.27 beta — portable release preparation

- Package the accepted 0.4.26 controls, tool calibration, HUD and haptics.
- Disable automatic performance recording on fresh installs; retain F9 and the explicit one-shot option.
- Remove retired performance-comparison switches and the unused early debug-ray setting.
- Add portable install/update/uninstall, Steam library detection, manual folder selection, verified backups, conflict detection and interrupted-operation recovery.
- Preserve user settings while removing known obsolete keys; include clean fresh BepInEx defaults with the console hidden.
- Replace historical setup instructions with current Pico/Frame controls, build instructions, known limitations and a test checklist.

## Accepted gameplay baseline

0.4.25 added native Steam Frame split-gamepad input. 0.4.26 added right full grip as Y and left full grip as D-pad Up while retaining the physical buttons. Earlier work added tracked tools/movement/menus, calibrated visuals, curved HUD, loading/menu fixes, structural scanner room/pressure labels, haptics and cached UI geometry. Detailed engineering history is retained in the source checkout.
