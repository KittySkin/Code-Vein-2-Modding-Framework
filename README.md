# Code Vein 2 Modding Framework
A tool to make modding Code Vein 2 easier.
It should work for most UE5 games too though.
* The tool enables the user to select a workspace that will be using as their modding space.
* Creating new mods from the UI.
* Created mods have a .modproj file that stores the mod Description, Name, Version, src path and Nexus Mods link.
* Edit existing .modproj to update Description, Version and Nexus Mods link.
* Setting up the pre created mod directory structure.
* Unpacking game files.
* Packing mod files.
* Deploy packaged mods to the game's ~mods directory.
* Launch the game directly from the UI.
* Directly open uasset files in UAssetGUI from the built in mod content explorer (this requires that you use the provided usmap or one named CV2.usmap).
* Creating SymLinks to the game files to avoid managing gamefiles updates by hand.
* Creating a txt file along loaded mods and newly created ones that can be edited from the tool UI.
* You can also compare 2 directories to check files for binary differences, useful for knowing when a game update requires you to update your mod or not.
* Launching common modding tools along with offering download links to them:
  * UAssetGUI
  * FModel
  * DDS Tools
  * Unreal Locres Tool
  * CV2 Locres Decryption Tool (pending support)
<img width="1544" height="984" alt="image" src="https://github.com/user-attachments/assets/4e197e96-9095-4669-95d0-f28837741881" />
<img width="566" height="402" alt="image" src="https://github.com/user-attachments/assets/535b9acb-2551-4159-ad9a-7a3b0852609e" />
<img width="811" height="487" alt="image" src="https://github.com/user-attachments/assets/042f4e08-6d61-423d-a7b3-fb75931c5b73" />
<img width="1537" height="1006" alt="image" src="https://github.com/user-attachments/assets/a83a0399-2dc6-46fb-ab9e-a8c1cdfda896" />
<img width="814" height="496" alt="image" src="https://github.com/user-attachments/assets/8cab9fea-ae27-4aa3-96fe-3a740d5d56bd" />
<img width="655" height="500" alt="image" src="https://github.com/user-attachments/assets/4c9591cc-9647-4327-bd14-2cb4634babc7" />

# License
<a href="https://github.com/KittySkin/Code-Vein-2-Modding-Framework/">CV2 Modding Framework</a> © 2026 by <a href="https://github.com/KittySkin">Alexis Schwindt</a> is licensed under <a href="https://creativecommons.org/licenses/by-nd/4.0/">CC BY-ND 4.0</a><img src="https://mirrors.creativecommons.org/presskit/icons/cc.svg" alt="" style="max-width: 1em;max-height:1em;margin-left: .2em;"><img src="https://mirrors.creativecommons.org/presskit/icons/by.svg" alt="" style="max-width: 1em;max-height:1em;margin-left: .2em;"><img src="https://mirrors.creativecommons.org/presskit/icons/nd.svg" alt="" style="max-width: 1em;max-height:1em;margin-left: .2em;">
