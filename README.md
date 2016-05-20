# HealthInformatics1

#### The 2D Map 
* How to Run:
 1. Open the Microsoft Visual Studio Solution file in the root folder named Visualizer.
 2. Press f5 or click the start button.
 

* Controls:
 - Use ArrowUp, ArrowDown, ArrowLeft, ArrowRight to move the character.
 - Use w, a, s, d to move the map.
 - Use esc to exit the screen.


#### The Unity Environment
* How to Run:
 1. Run the 2D Map using steps above
 2. Open the console (see below), to view environment information
 3. Open Unity and select the VR Map folder (CleVR Map Test)
 4. Press the play button to start the environment.

* Controls:
 - Use w, a, s, d to move through the environment
 - Use spacebar to jump
 - Use the mouse cursor to look around you
 - Press ctrl + shift + c to show the console, this prints the messages that we send and the errors that appear


#### Tools
- *NOTE! We use VISUAL STUDIO 2013, any later edition should work fine.*

1. StyleCop. This makes sure our code has the same and desired syntax. This can be installed from https://visualstudiogallery.msdn.microsoft.com/cac2a05b-6eb6-4fa2-95b9-1f8d011e6cae
2. NUnit. This is our testing framework. It can be downloaded from http://nunit.org/?p=download. The msi file.
3. To run the NUnit test an adapter is needed. This can be installed from VS2013. Go to Tools -> Extensions and updates (in the middle) -> online and search then for "NUnit adapter". Instal then NUnit 3 test adapter. The normal test running tool in VS should now also run NUnit tests.
4. We also use Productivity Power Tools 2013, GhostDoc and CodeMaid. This cannot be checked that we use it. As it does not generate reports. The power tools give us some extra buttons to use. GhostDoc is helping us to create comments/documentation. CodeMaid cleans up our code to reduce StyleCop warnings.
5. As CI we tried many kinds as explained in issue https://github.com/RubenMeeuw/HealthInformatics1/issues/21#issue-155910101. For now we use the local Jenkins CI. 
