# x4skillbooster
## About

The X4 Skill Booster is a simple program for boosting the skills of your crew and employees and will boost any skill *already trained (that is, the skill already has a partial star or higher)* from its current level to five stars. The program works by editing the X4 savegame XML file so reloading a save is required for the boosting to take affect. Therefore, it is recommended to create a new save immediately prior to using the program.

In order to help minimize the chances of damaging a savegame, the X4 Skill Booster backs up any save file it modifies prior to making any changes. While I cannot guarantee that no harm will ever come to your save, I use and test this tool personally and have never encountered a problem. If an issue does occur, restoring the backup file is as simple as renaming a file. If you want to be extra-cautious, you can always create multiple saves in separate slots prior to using this program. 

That being said. This software is provided "as is", without warranty of any kind, express or implied. In no event shall the authors be liable for any claim, damages, or other liability. This software is licensed under the MIT License. For more information, please see the LICENSE file. 

## Usage

#### Disabling Save Compression 

The X4 Skill Booster requires that savegame compression be disabled. This will cause the size of savegame data to increase, but does not otherwise affect your gameplay experience. 

To disable savegame compression:

1. Within X4, open the Options Menu.
2. Select "Settings"
3. Select "Game Settings"
4. Toggle "Savegame Compression (Experts)" from "on" to "off".
5. Save your game and take note of the save slot (#01, #02, quicksave, etc.)

#### Boosting

1. (Optional) If you haven't recently, save your game and take note of the save slot (#01, #02, quicksave, etc.)
2. Download the program from the releases page.
3. Launch the application and click on the "Open Save..." button 
4. Navigate to your X4 savegame directory and select the save file that you want to boost. (Typically, your savegame directory is C:\Users\\[username]\\Documents\\Egosoft\\X4\\[steam_id]\save)
5. Once the program is finished loading your save. Click "Boost!" and your save will be backed up and then boosted.
6. Return to X4 and load the save file which you boosted. Enjoy your highly skilled crew!

## Problems

Please report any issues that you encounter through the GitHub issue tracker, or by messaging /u/zyamada on reddit.

#### Help! My save is broken.

First, don't worry! To restore a savegame backup:

1. Open Windows Explorer and navigate to your savegame folder (typically C:\Users\\[username]\\Documents\\Egosoft\\X4\\[steam_id]\save). 
2. You should see one or more backup files ending with a string of numbers (which are, conveniently, a timestamp). 
3. Locate and rename the broken savegame file. (e.g. quicksave.xml to quicksave_broken.xml)
4. Locate the savegame file you would like to restore, and remove the timestamp from the file extension. (e.g. quicksave.xml.201812221652 to quicksave.xml)
5. Load your save file and get back to your profits!

## Planned Features

* Ability to boost skills which have not already been developed.
* Ability to specify which skills are boosted.
* Ability to specify what rank a skill is boosted (or lowered) to.

## Attribution

"[Round Varieties](https://www.shareicon.net/pack/round-varieties)" by [Creaticca Creative Agency](https://www.shareicon.net/author/creaticca-creative-agency) is licensed under [CC BY 3.0](https://creativecommons.org/licenses/by/3.0/)