# HealthInformatics1
Master:[![Build status](https://ci.appveyor.com/api/projects/status/845bwkn77x1y995u/branch/master?svg=true)](https://ci.appveyor.com/project/RubenMeeuw/healthinformatics1/branch/master)
Developer: [![Build status](https://ci.appveyor.com/api/projects/status/845bwkn77x1y995u/branch/master?svg=true)](https://ci.appveyor.com/project/RubenMeeuw/healthinformatics1/branch/dev)

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
3. To run the NUnit test an adapter is needed. This can be installed from VS2013. Go to Tools -> Extensions and updates (in the middle) -> online and search then for "NUnit adapter". Instal then NUnit 3 test adapter. The normal test running tool in VS should now also run NUnit tests. A screen shot of the test coverage is inside the deliverables map. 
4. We also use Productivity Power Tools 2013, GhostDoc and CodeMaid. This cannot be checked that we use it. As it does not generate reports. The power tools give us some extra buttons to use. GhostDoc is helping us to create comments/documentation. CodeMaid cleans up our code to reduce StyleCop warnings.
5. As CI we use Appveyor, this builds and tests every commit and pullrequest. You can see a green checkmark if the tests succeed or a red cross if the tests fail. If you click on the commit and click on details, you go to the appveyor page and you can see the log of the build and also which tests succeeded or failed.

