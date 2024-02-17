# GMD 
# Post 1 roll ball game

Welcome to Roll Ball, a simple game developed in Unity for beginners. In this game, there is a simple ground object, which contains the ball and cube objects which are surrounded by some walls so players can control a ball,
moving it in any direction with physics applied. The objective is to navigate the ball through cube objects, collecting objects along the way. The number of collected items is displayed in the top left corner of the screen. 
Upon completing the game, a "You Win" message will appear, indicating your win.

Are you ready to start a new the journey and learn some basics? Let’s start then!

## Technical Process:
 ![image](https://github.com/hamoudi8080/GMD/assets/82207003/b3073d12-0f15-474d-b529-064c05faf223)

let’s learn few concepts first:
1-Component: means that adding a behaviour to the object contains it, for example we have added rigid body component into the ball.
2-rigid body component is the behaviour of the physics add to the ball so that when you move it to specific direction it moves with physics.
3-Box collider component is added to all the walls objects which made from cube, so the behaviour of Box collider allows the objects to collide with each other.
If is Trigger attribute of Box collider is checked, that means when any object will not collide with it, fx the ball will fall down of the ground when it crosses the wall. 

 ![image](https://github.com/hamoudi8080/GMD/assets/82207003/75e6a626-f96a-4b42-89a2-ffdf747e4b3d)
 ![image](https://github.com/hamoudi8080/GMD/assets/82207003/8c4cd11e-5489-4edd-8f36-efadcfdf59ca)


There is also a concept called prefabs. A prefab is template or a blueprint for creating Game Objects. And even you can create multiple instances of it to apply different behaviour to it. 
It also serves as a reusable asset that encapsulates a set of components, properties, and behaviours that you can apply to multiple instances within your game.

 ![image](https://github.com/hamoudi8080/GMD/assets/82207003/9fddbbec-42a8-4da0-8c21-8a9986f1c208)

Materials are how a surface should be rendered, including references to textures used, tiling information, colour tints and more.
Fx in my game I have added few materials with each having a specific colour.

Scripts are in which or how you want your game object to behave.
Let see a simple example of rotator class.
 ![image](https://github.com/hamoudi8080/GMD/assets/82207003/09d3b43b-1c7d-46c0-8c43-f8489ae95ffb)
 ![image](https://github.com/hamoudi8080/GMD/assets/82207003/c5b4eb55-1dd6-439c-a82a-487cd8064f5e)


 
In the game, when the game starts, the cube objects are having the rotator script which are rotating by the use of transform -> rotate.
Transform is a component which contains the positions, rotate, and the scale of the object.
![image](https://github.com/hamoudi8080/GMD/assets/82207003/842587dc-4158-4f31-9559-de746328b54b)

 
Finally, we have simple UI Canvas, which displaying the count Text when the ball collect the cube objects and when it is done it displays win text.  
How is it done?
In PlayerController script which is a component of ball game object.
![image](https://github.com/hamoudi8080/GMD/assets/82207003/218c7417-3fff-4403-a76f-ba03b0b6aca6)

Both variables are set to public so we can pass text objects to it on player object (ball) and apply some roles on them.

In the start of the game, we have those actions. And we initiate the count to zero. 
![image](https://github.com/hamoudi8080/GMD/assets/82207003/3ea359df-97ea-4f0a-a014-af680d212ba1)

A method of SetCountText. 
![image](https://github.com/hamoudi8080/GMD/assets/82207003/8817bca9-82cb-4e2e-bae9-8c21afcab991)
![image](https://github.com/hamoudi8080/GMD/assets/82207003/c7c822fe-4aea-431f-ac78-1dadeb0c214a)

 
Another feature is added to game which is counting how many seconds took you to finished the game. 
![image](https://github.com/hamoudi8080/GMD/assets/82207003/2c7c7762-718d-44d7-bcef-1dd384b92119)


Final version
![image](https://github.com/hamoudi8080/GMD/assets/82207003/73b0936a-6765-4c4c-9a7b-a06e003b3d42)

Mohamed Resho
