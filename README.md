# Project-Sample-For-Shared-Workspace
 A Project to demonstrate the structure of the working environment

You will need unity version 2021.3.13f1 to open the project

All the details related to the project are in the Assets/ReadMe file

Note:All the details below are available in the project as well


1-This is an example of how to do your work independently and without interfering with other persons work.

2-The first important thing is keeping everything organized , if you notice the folder structure you will notice every folder followed a folder by the name of the game that you are making an example of this is "MiniGameSpinWheel"
everything that you will create or edit would go inside of your project named folder in order to avoid conflicts

3-The same structure should be followed for the scripts each script that you will create will include a namespace. e.g in this project each scripts are using "MiniGameSpinWheel" namespace this is to ensure that if someone else have same script lets say gamemanager and you also have a gamemanager it will not have a compile error for duplication since each of the project is using different namespaces

4-This part can be a little bit tricky as when we talk about desgin principles we directly points out towards OOP and design patterns but as we all know unity is not standard c# so we cant implement the design principles that we find 
if you search on the internet it will suggest you to go for the component based system as every property attached to the gameobject is public by default , to keep things simple i will suggest a simple rule of thumb

If you need a information from start to finish of the game cycle use scriptable objects instead of static variables as they are hard to view on the inspector if you are printing it in the console every time you are using it.

5-This project does not cover about how to export tags and layers , but incase your project needs to add custom tags and layers let me know i will update this project accordingly. I did not include it in this project to keep it simple.

6-We already tackled the problem of scirpts duplication conflict but we also need to talk about prefabs name duplication a good example of it would me e.g if your prefab name is player you can add start the name with something like "A45_Player" this will maintain the uniqueness  and duplication conflict.

7-There are two main directories that we need to talk about that is streamingassets and resources folders

8-Use the resources folder if your object depends upon other files in the project e.g , a player prefab will need to include some scripts and sprites and maybe audio too which are outside the folders 

9-StreamingAssets are for the files which are independent of other files in the project e.g , a JSON file containts the game info and other things an sql lite database file where you can read write operations

10-Keeping your project organized not only in the unity but also on the git branches is a good practice.
main/master --> The branch that will contain the most upto date and stable work
dev --> The branch on which you or other people will be working on, dev is usually the branch where merge of 2 or more features happens 
feature/feature-name --> Any new feature you will be working on should be done here

hotfix/production
hotfix/beta-testers
hotfix/internal-testers

A hotfix branch is usally a branch that refers to the problems of publish builds any bugs and fixes that will happen in that branch will be fixed here first than be merged in dev or main

11-This is all for the project at this point if ou have any questions please let me know I will be happy to answer it.
