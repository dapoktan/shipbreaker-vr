# Portable 0.4.27 beta validation

Prepared 2026-09-26. This is a packaging/diagnostic cleanup of the accepted 0.4.26 gameplay baseline. Tool alignment, HUD geometry, motion/menu bindings and haptics are unchanged. The additional-tool config description now distinguishes Pico triggers from Frame scanner bumpers.

## Build and artifact

- Release mod build: zero warnings/errors, using the pinned .NET SDK and the previously validated Unity 2020.3.17f1 dependency export.
- Managed regression suite: **320 checks passed**.
- ZIP: `ShipbreakerVR-0.4.27-beta-portable.zip`, 2,744,831 bytes.
- ZIP SHA-256: `AA0B8F2614AE47A4E12C944305E14B9EC3E1C763F717D12D23E2C7D28FABB850`.
- Plugin version: `0.4.27.0`.
- Plugin SHA-256: `072F019A27F1D742B788493BE36CAC4A3E834371BC2828FFC733F7BB6706B0A6`.
- 35 payload files; managed/native Unity exports verified against the same dependency player. No new Unity import/build was needed.

## Installer validation

Windows PowerShell 5.1 is used by the public CMD launchers and the tests.

- **35 isolated installer checks:** read-only preflight, paths with spaces, fresh install, repeat install, version update, section-aware obsolete-key cleanup, settings/save preservation, restoring a previous mod/native provider, conflicting shared loaders, modified package/installed files, traversal rejection, junction rejection, other-mod shared-loader retention, interrupted-operation recovery and automatic rollback after a copy failure.
- **18 full-package checks:** newly extracted ZIP checksums and content inspection; full 35-file fresh install/reinstall/uninstall; upgrade/reinstall/uninstall against a private fixture copied from the existing game installation; every owned file restored/removed and accepted HUD values retained.
- Steam registry/library auto-detection succeeded against the actual installation, without an explicit game path.
- Read-only package preflight passed against the live game. Its installed plugin remained `0.4.26.0`; no live installation was performed during release preparation.
- Initial package inspection found no game executable/assemblies, PDB files, personal mod configuration, logs, captured timings or backup folders. The initial path scan covered text files only and missed embedded CodeView paths in DLLs; see the correction below. Runtime license files and notices are included.

## Remaining hardware validation

The user reported accepted Pico gameplay, Frame native controls and Frame full-grip shortcuts in earlier builds. This does not constitute a headset test of the final portable 0.4.27 package. Run the checklist in `KNOWN-ISSUES.md` after installing it. Steam detection was exercised; the folder picker was not manually clicked during automated checks.

The package is an unsigned beta ZIP with integrity hashes, not an authenticated publisher signature. It has not been uploaded or published. New machines/headsets, protected-folder permissions and future game/runtime versions remain outside the local validation matrix.

## Hardware report and privacy correction — beta2

The user subsequently reported that the portable 0.4.27 build works fine. This is an overall acceptance report, not a recorded pass for every individual checklist item.

A binary privacy audit found the development username/workspace in CodeView PDB paths embedded in 12 locally compiled DLLs, including Unity managed exports. Omitting the PDB files had not removed those strings. The original beta ZIP should not be shared as anonymous.

`ShipbreakerVR-0.4.27-beta2-portable.zip` replaces that shareable artifact. SHA-256: `A572BAD99F29654B53A159F501CDBAE7D77FF08DDE26914FD2B3DCC7898160CA`.

- Debug path strings were reduced to bare PDB filenames, with the unused bytes zeroed. The sanitizer refuses signed assemblies.
- Independent byte comparison confirms that all payload changes are confined to those debug path regions. Code, resources and assembly versions remain identical to the tested build.
- All 63 ZIP files were scanned as bytes for the local username, computer name and workspace identifier. Both UnityFS asset bundles were decompressed and scanned too. No matches remained.
- All 18 full-package extraction/integrity/install/update/uninstall checks passed again, including upgrade from the installed portable version.
- Upstream authors' license notices and generic Pico/Frame compatibility names remain intentionally included. This is a bounded identifier/content audit, not a guarantee against every conceivable identifier encoding.
- Future packaging runs now strip those paths and scan binary contents for local username/computer-name strings. `PackagePrivacyChecks.py` provides the independent compressed-asset and byte-change audit.

The mod source retains its MIT license locally; the updated source has not yet been publicly published. Unity runtime packages retain their own license terms.

## Fresh source verification — 2026-09-27

- Copied the 246 Git candidate files to an isolated source directory and verified their SHA-256 hashes against the working source. The Unity project used a separate short path and started without `Library`, `Temp` or generated build output.
- Downloaded the two pinned .NET reference packages anew from the official NuGet endpoint. Locked restores of the mod, patcher and managed tests succeeded into a new package cache; content hashes matched all lockfiles. The sandbox's Windows TLS client could not connect, so an HTTPS download client supplied a local feed to NuGet. Direct online restore from that sandbox remains unverified.
- Unity **2020.3.17f1** completed the clean import, dependency-player build and debug material bundle build through the interactive editor. Batch mode rejected the existing licence before import, including outside the sandbox; the documented interactive fallback succeeded.
- Unity package manifest, package lockfile, editor version and build-method source remained unchanged by the import. This verifies a clean project import, not an empty global Unity package cache or byte-identical shader exports.
- Built the mod and patcher against the newly generated Unity exports: **zero warnings and zero errors**. The freshly restored managed suite compiled successfully and **all 320 checks passed**.
- This verification did not install the regenerated build or replace the accepted beta2 portable ZIP. A fresh source build is not an additional headset test.
