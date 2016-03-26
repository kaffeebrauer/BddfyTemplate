# BddfyTemplate
Visual Studio Item Template For Bddfy Tests (NUnit)

Contains two projects

BddfyTemplate: Contains the item template in the Class.cs

BddfyVsix: Contains the Vsix build configuration in addition with a Winform for setting up class variables.

Prerequisites
  - MS Visual Studio 2013 SDK (for recognising the project type)
  Project where you want to add the template should ideally have the following referenced libraries (for ease of use)
  - BDDfy (https://www.nuget.org/packages/TestStack.BDDfy/)
  - NUnit (https://www.nuget.org/packages/NUnit/)

Instruction
  - Download the VSIX under the dist folder
  - Double-click on the downloaded VSIX file to install the extension
  - Restart Visual Studio 
  - Do you add a new item on a project
  - Item should appear under Visual C# items with name 'Bddfy Unit Test Template'

TODO:
  - enable Humanizer to format the unit test methods
  - reformat forms to use MVP pattern for ease of testing
