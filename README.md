# Saints Row: The Third Nintendo Switch Save Editor

A simple Windows Forms application for editing save files from **Saints Row: The Third - Switch Edition** (`.sr3s_nx64` format). It simply allows you to modify in-game attributes such as money and respect level.

Ensure you have the [.NET Framework](https://dotnet.microsoft.com/) installed.

--- 

## Notes

- This tool is provided as-is and comes with no guarantees of compatibility or safety. Use at your own risk.

--- 

## Save File Offsets

Here are all the offsets I could find; maybe they will be helpful to you.

```csharp
OffsetForAppearance = 2864;
OffsetForActivityCompletion = 11716;
OffsetForActivityDiscovery = 12488;
OffsetForGangOperationDiscovery = 13416;
OffsetForGangOperationCompletion = 13672;
OffsetForMissionCompletion = 14880;
OffsetForHomies = 17764;
OffsetForRespectLevel = 18000;
OffsetForUpgradesList = 18008;
OffsetForUpgradesUnlocked = 19408;
OffsetForUpgradesAvailable = 19452;
OffsetForUpgradesNew = 19496;
OffsetForLuchadoresNotorietyDecayRateMultiplier = 19540;
OffsetForDeckersNotorietyDecayRateMultiplier = 19544;
OffsetForMorningstarNotorietyDecayRateMultiplier = 19548;
OffsetForPoliceNotorietyDecayRateMultiplier = 19552;
OffsetForBulletDamageTakenMultiplier = 19556;
OffsetForExplosiveDamageTakenMultiplier = 19560;
OffsetForVehicleDamageTakenMultiplier = 19564;
OffsetForFireDamageTakenMultiplier = 19568;
OffsetForFallingDamageTakenMultiplier = 19572;
OffsetForHealthRegenMultiplier = 19580;
OffsetForRespectMultiplier = 19596;
OffsetForMeleeDamageMultiplier = 19600;
OffsetForBonusHourlyCityIncome = 19614;
OffsetForMoney = 19616;
OffsetForWeaponSlots = 19624;
OffsetForWeaponUpgrades = 19960;
OffsetForWeaponUpgradeLevels = 20160;
OffsetForCribs = 47504;
OffsetForWeaponUnlocks = 21436;
OffsetForGarage = 47504;
OffsetForChunks = 64536;
OffsetForPropertyOwnership = 69580;
OffsetForPropertyDiscovery = 69589;
OffsetForTerritories = 71152;
OffsetForDlcHomies = 92356;
```

--- 

## Contributing

- Feel free to contribute as long as you don't break things.

--- 

## Special Thanks

- [**Corrodias**](https://www.saintsrowmods.com/forum/threads/sr3-save-editor-c.1042/)

--- 

## License

- [**GPL-2.0 License**](https://github.com/reprehenderit/SR3-Switch-Save-Editor/blob/main/LICENSE.txt)
