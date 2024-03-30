# Game Development Progress

## Camera Functionality
First of all, I set up the camera functionality. I integrated the Cinemachine package from the Unity Package Manager. This package plays a pivotal role in our game, enabling us to effortlessly track the player character with its advanced camera technology. Regardless of where the player moves within the game environment, Cinemachine ensures seamless camera follow, dynamically adjusting angles, positions, and perspectives to keep the player in focus. This not only enhances the player's immersion but also contributes to the overall cinematic experience of the game. An additional technique is that the camera will collide with some buildings so that when the user moves the mouse, it does not go inside the building.

## Environment Integration
The environment is integrated into the scene, serving as the battleground between the player and the enemy. Various colliders, such as box colliders and mesh colliders, are applied to the environmental objects to ensure accurate collision detection and interaction during gameplay. A new city is also added to the game to ensure that the game has a large battlefield with more challenging enemies.

## Player Movement and Control
Scripts for player movement direction and jumping have been implemented, along with additional camera movement code. This allows the player to move the character by hovering on a specific point on the screen while pressing the forward key, enhancing flexibility and ease of control for the user. Furthermore, a sprint feature has been added to the player, enabling increased movement speed when the left-shift key is pressed.

## Animation
In Animation figure (1), the Blend tree is a combination of three states: idle, walk, and sprint. The value between these three states is represented between 0, 0.5, 1. 0 is standing, 0.5 is walking, and 1 is sprinting.

This script manipulates between 0, 0.5, 1. When it is walking it returns 0.5, when it is walking, and the left-shift button is clicked it returns 1 which is sprinting.

We have three parameters which are representing our animation states. Speed we already mentioned in Animation figure (1), Attack is a trigger so when the left mouse clicked it goes into NormalAttack01_SwordShield transaction which hits the sword.

We added an event to our animation so that when the animation reaches a point, we want something to happen, like sound Effects, or any other event. In our case, when the animation reaches the event point before sec 0:08 we execute Animation figure (3). We print for now just "player attack".

## Milestone Completion
Now this is the post we have completed our first milestone. Which was:
- Downloading assets and 3D models for the environment and characters
- Implement basic character movement and animations
- Setup environment including park layout and camera configurations
- Install necessary packages such as input manager for player control
- A new city with all its objects is added next to the park
