<div align="center">

🇩🇪 <a href="CHANGELOG.md">Deutsch</a> &nbsp;·&nbsp; 🇬🇧 <b>English</b>

# Changelog

**Everything new in FACommands, latest version first.**

[Download](../../releases/latest) · [README](README.md)

</div>

## 1.9.0

- Plugin ported to .NET 9
- Updated to TShock 6.2.1 (Terraria 1.4.5.8)
- Cooldowns are tracked per player with monotonic time, so changing the system clock no longer extends them
- Commands are registered only once and removed cleanly when the plugin unloads

## 1.8.0

- Ported to .NET 6
- Updated to TShock 5.1.3
- Added a README listing all commands and permissions

## 1.7.1

- Fixed player lookup (`FindPlayer`)
- Added missing NPCs to `/npcr`
- Error message when reloading the config fails
- `/binfo` now detects missing parameters correctly

## 1.7.0

- Updated to TShock 4.4.0
- Removed bundled libraries from the repo

## 1.6.0

- Plugin completely rewritten
- New config file `FACommands.json`, reloadable with `/facreload`

## 1.5.0

- Fixed `/slay`
- Various bug fixes

## 1.4.0

- New command `/diceroll`
- Adapted to the new TShock API

## 1.0.0

- First version
