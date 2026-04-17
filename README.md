# Deep Dungeon Tracker [![Download count](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fkamori.goats.dev%2FPlugin%2FDownloadCounts&query=DeepDungeonTracker&style=for-the-badge&logo=github&label=Downloads&color=brightgreen)](https://github.com/marconsou/deep-dungeon-tracker)
<img src="https://user-images.githubusercontent.com/27457164/195154649-f18da733-842a-4a77-ac72-9fad9343bbad.png" width="256" height="256">

A Final Fantasy XIV [Dalamud](https://github.com/goatcorp/Dalamud) plugin to track things inside Deep Dungeons (Solo only).

Type `/ddt` to open the configuration menu.

Type `/ddtmain` to open the Main Window showing saved files and backups.

Type `/ddttracker` to toggle the Tracker Window visibility.

Type `/ddttime` to toggle the Floor Set Time Window visibility.

Type `/ddtscore` to toggle the Score Window visibility.

Type `/ddtload` to load the last saved slot and open the Statistics Window.

## How to install

### Install .NET 10.0
Go to the official microsoft website, and install .NET 10.0

https://dotnet.microsoft.com/fr-fr/download/dotnet/10.0

### Build the project
Open a terminal (Powershell on Windows for example)

Navigate to the project and use the following command:
```
dotnet build
```

It should generate a new file in the project:
```
DeepDungeonTracker\bin\x64\Debug\DeepDungeonTracker.dll
```

### Add the plugin in Dalamud

- Go to the Dalamud settings, open the tab "Experimental"
- In the development plugin section, add the full path to the file generated, for example `C:\Users\Coccis\Documents\deep-dungeon-tracker\DeepDungeonTracker\bin\x64\Debug\DeepDungeonTracker.dll`
- Check the `Enabled` checkbox
- Click on the save button in the bottom right
- In the list of Dalamud plugins, you should have a new `Developer tools` section, with the DDT plugin compatible with PT.
- Disable the official DDT if you only play PT. Switch if you want to go into the old DDs.

## Features
- Keep track of the number of kills, coffers opened, regeneration potions consumed, potsherds obtained, total time and more.
- Examine the collected data.
- Scoring.

## Examples
![image1](https://user-images.githubusercontent.com/27457164/206748558-13186221-83b2-4bc2-9513-2dd1507ec1ea.png)

![image2](https://user-images.githubusercontent.com/27457164/231744638-fddc95fd-e745-44fb-8ec3-0c746ba396b7.png)

![image3](https://user-images.githubusercontent.com/27457164/231744641-442f307e-5af0-446a-a3e2-56e3a1763974.png)

![image4](https://user-images.githubusercontent.com/27457164/231744643-c7477507-2054-4ce1-becd-20f82a175486.png)

## Credits
Scoring formula testing by Alpha ([#1](https://docs.google.com/document/d/1MnR2Xtj2lol1LESgscI6yi_1xcAeP3FBwJecbD-EiwE) and [#2](https://docs.google.com/spreadsheets/d/1FJGDlSI7yHVVoD3wXRYDjxMWfId8QOkEZkRXpZgH9Yk)).

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/marconsou)
