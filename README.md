# group3_gamedevelopmentpattern
## Group 3 Final Assignment Game Development Pattern

This final assignment has 4 different game development patterns:
 1. Bytecode Pattern
 2. Observer Pattern
 3. Spartial Partition Pattern
 4. State Pattern

They all are in one Unity project in C#. **Bytecode Pattern** and **Observer Pattern** are both in one scene which combined together. **Spartial Partition Pattern** and **State Pattern** are in two different scenes. Below is the descrption for each of the patterns:

## Bytecode and Observer Pattern:
In this unity project they are in Observer_Bytecode scene. While playing the game, you will see three different boxes which try to jump toward the sphere which is in the middle of the ground. Three are three different boxes with three different jump speed. Hence, you can see the Observer pattern base on the position of the sphere. Because the boxes only jump when the sphere is in the middle of the ground.
In this scene, Bytecode implement the **Interpreter Pattern** in Unity using C#. For that we converted date time of the current playing time using Interpreter Pattern. Thus, after playing the game Bytecode convert date time of this Observer Pattern and then shows this as a text in the game.

## Spartial Partition Pattern
This will be found in Spartial scene. After clicking the play button, you can see that there are zombies around the ground which hunting civilians around them. Whenever the civilians get closer to the zombies, they are going to follow civilians. When civilians get far away, zombies will stop untill another civilian gets close to them and follow that civilian. Thus, it can show the Spartial Partition pattern.

## State Pattern
In this unity project, you can find this pattern in State scene. There is a object called Creeper which hide behind another object called Skeleton. The Skeleton has a role of armour of the Creeper. The Skeleton covers the Creeper from the player. Because it is like an armour for Creeper. Then Creeper move froward toward the player and kills the Player. This pattern base on the state of the Player. Hence, State Pattern will be easily shown in this game.

**Note:** This project is totally categorized. So Materials, Objects, Scenes and Scripts are in their folders. Also, scripts are well structured and fully object oriented. Hence, for each sence, you have to go to Scripts folder with the same name as the scene. Each class of the codes are in different scripts so they can be easily found and they are completely object oriented.
