# DCLeap
***********************
WORK IN PROGRESS
***********************
Latest Realease : https://github.com/kariyann/DCLeap/tree/master/DCLeap/LatestRelease
Manual : 

![Image of Yaktocat](https://github.com/kariyann/DCLeap/blob/master/DCLeap/Assets/DCLeap.png)

<h2>Scenes</h2>
There's three scenes in DCLeap :
<ul>
<li>MainMenu : used to change and store datas, and to Start, exit or consult Help Menu</li>
<li>Help : used to show DCLeap's commands</li>
<li>DCLeap : used to run the core application</li>
</ul>
<h2>Scripts dependancies</h2>
<h3>Main Menu</h3>
<ul>
<li>SavedDatas.cs is used to set and save users settings. These settings are needed by DCLeap scene</li>
</ul>
<h3>Help Menu</h3>
No script in this scene.
<h3>DCLeap</h3>
<ul>
<li>Unity_SteamVR_Handler</li>
<ul>
<li>SceneManaging.cs : to manage scenes switches</li>
<li>FeaturesDisabler.cs : disable features in the DCLeap scene if toggle box are not ticked in the main menu</li>
<li>InputsScript.cs : listen input keys combination to quit DCLeap scene and revert to main menu</li>
</ul>
<li>LoPoly Rigged Hand ***</li>
<ul>
<li>RightClickVizualizor.cs : show user that right click is available by showing a blue cube, this script is called by PalmDirectionDetector.cs</li>
<li>PalmDirectionDetector.cs : core LeapMotion script, detect if palm is facing or not, call RightClickVizualizor.cs</li>
<li>activator.cs : uses PalmDirectionDetector to perform Right or Left clic</li>
<li>KnobScript.cs : used to calculate knob rotation</li>
<li>PinchKnobEnabler.cs : call KnobScript.cs when pinch is detected</li>
<li>PinchDetector.cs : core LeapMotion script detecting pinch gesture modified (line 134-135) to adjust pinch sensitivity set by user in main menu. Call activator and knob</li>
<li>ExtendedFingerDetector.cs : core LeapMotion script detecting trigger gesture. Call activator to perform index clic</li>
<li>FeaturesDisabler.cs : disable features in the DCLeap scene if toggle box are not ticked in the main menu</li>
<li>InputsScript.cs : listen input keys combination to quit DCLeap scene and revert to main menu</li>
<li>ClickManager.cs : allow clics methods regarding Playerprefs set in the main menu</li>
<li>mouseDebug.cs : allow debug mouse screen coordinates in the HMD, if allog debug mouse is ticked in the main menu</li>
<li>Keystroke.cs : create Key stroke functions used to perform Catapult alignment, ejection, etc...</li>
<li>VirtualMouse.cs : calculate mouse coordinates regarding palm localposition. Get informations from environmentSet.cs (User32.dll to control mouse, user desktop screen resolution to avoid mouse going out of DCS VR window</li>
</ul>

<br/>WILL BE FILLED LATER


