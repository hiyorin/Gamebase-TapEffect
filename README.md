# Gamebase-TapEffect

<br><br><br><br>
## Table Of Contents
- [Description](#description)
- [Install](#install)
- [Usege](#usage)
  - [Setup](#setup)
  - [Create TapEffect Prefab](#create-tapeffect-prefab)
- [NodeCanvas Integration](#nodecanvas-integration)
- [License](#license)

<br><br><br><br>
## Description

<br><br><br><br>
## Install
Find `Packages/manifest.json` in your project and edit it to look like this:
```json
{
  "scopedRegistries": [
  {
    "name": "OpenUPM",
    "url": "https://package.openupm.com",
    "scopes": [
      "com.neuecc",
      "com.cysharp",
      "com.svermeulen",
      "com.coffee",
      "com.demigiant",
      ...
    ]
  }],
  "dependencies": {
    "com.coffee.git-dependency-resolver": "1.1.3",
    "com.coffee.upm-git-extension": "1.1.0-preview.12",
    "com.gamebase.tapeffect": "https://github.com/hiyorin/Gamebase-TapEffect.git",
    ...
  }
}
```
To update the package, change `#{version}` to the target version.  
Or, use [UpmGitExtension](https://github.com/mob-sakai/UpmGitExtension.git) to install or update the package.

<br><br><br><br>
## Usage

#### Setup
- Create Installer
  - Right Click in folder within the Project tag and Choose `Create/Installers/Gamebase/TapEffectInstaller`.
  - Assign TapEffect Prefab.
  
#### Create TapEffect Prefab.
- Shuriken
  - Add ParticleTapEffect to GameObject.
  - VisualEffect component is attached, please implement the effect.
- VFX
  - Add VfxTapEffect to GameObject.
  - ParticleSystem component is attached, please implement the effect.

<br><br><br><br>
## NodeCanvas Integration
[NodeCanvas](https://assetstore.unity.com/packages/tools/visual-scripting/nodecanvas-14914) is the Complete Visual Behaviour Authoring solution for Unity. For more details see the [NodeCanvas docs](https://nodecanvas.paradoxnotion.com/documentation/).  

Gamebase integration with NodeCanvas is disabled by default. To enable, you must add the define `GAMEBASE_ADD_NODECANVAS` to your project, which you can do by selecting Edit -> Project Settings -> Player and then adding `GAMEBASE_ADD_NODECANVAS` in the `Scripting Define Symbols` section.

<br><br><br><br>
## License
This library is under the MIT License.  
[here](LICENSE.md)