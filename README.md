# ItemEquipEditor

A Windows Forms application for editing `item_Equip.xml` files used by [Melia](https://github.com/aura-project/melia), a Tree of Savior emulator.

## Features

- Search items by ClassID
- View and edit item properties:
  - Use Level
  - Item Grade
  - Equip Group
  - Sell Price
  - Max Socket Count
- Add/modify combat stats and attributes:
  - Physical/Magical Attack & Defense
  - Critical stats (Hit Rate, Attack, Defense Rate)
  - Primary stats (STR, DEX, CON, INT, SPR)
  - Elemental resistances and attacks
  - Size-based damage modifiers
  - HP/SP/Stamina stats
  - And many more...

## Requirements

- .NET 8.0 SDK (Windows)
- Visual Studio 2022 or later (recommended)

## Building

```bash
cd ItemEquipEditor/src
dotnet build
```

## Usage

1. Place your `item_Equip.xml` file in the same directory as the executable
2. Run the application
3. Enter a ClassID and click Search
4. Edit the desired properties
5. Click Update to save changes

## License

This project is provided as-is for use with Melia server development.
