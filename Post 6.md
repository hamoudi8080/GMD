# Conclusion and Final Game

The game has been fully implemented and has achieved its objectives. The idea was to create a simple game with only two levels implemented in Unity. 

## Development Process

Initially, all essential assets were downloaded during the development process. The camera setup was achieved using the Cinemachine package, which was crucial as it dynamically adjusts angles, positions, and perspectives to keep the player in focus during fighting actions.

Environment and Battlefield Assets for the village were downloaded to create a battlefield for fighting, and positioning the environment was straightforward.

## Player Movement and Control Functionalities

Functionalities such as moving in the x and y directions using the Input Manager package, along with the ability to sprint by pressing the left-shift key and jump by pressing the spacebar, were implemented. Animations and audio were added to the player and enemy to simulate their fight. Additionally, the AI Navigation package was added to enable enemies to track and engage with the player.

A health system was integrated into the game, along with hearts and items to add excitement and prevent the game from becoming monotonous. When the player collides with hearts, their health level increases, providing them with a chance to persevere. 

Audio elements, including footsteps for player movement, sword movements, enemy attacks, and deaths, were incorporated to enhance the gaming experience. Object pooling functionality was utilized to optimize performance and reduce CPU burden.

## GUI Elements

GUI elements with particle system assets were downloaded and added to the game. These included a main menu for allowing users to exit or restart the game at any time. Health indicators were also displayed for both the player and enemy during combat to provide feedback to the user.

## Second Level

In the second level of the game, a new city environment was added with stronger versions of the same enemy characters and the same rules for first level.

## Design Pattern

The game followed a solid design pattern for optimization and performance. Each script in the scripts folder is responsible for specific actions, resulting in well-structured source code. This an aspect was challenging to achieve but was successfully managed.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/3e3184b0-6844-479c-953d-9015f27a1d9b)


The scene with folder is also a kind of good-structured.

It is worth mentioning that the rules, mechanisms, and some features of the game were inspired by a tutorial. However, many elements were customized and added, such as code, environments, animations, audio clips, and GUI menus, game is also following the SOLID Design pattern.

## Final Thoughts

Overall, the final game is playable and functioning well, although there are some remaining bugs. Nonetheless, the overall result is satisfactory.
