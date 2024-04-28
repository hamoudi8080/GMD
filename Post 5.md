# Game Development Milestone 5

In the fifth milestone of our game development project, we will focus on several key features to enhance gameplay and user experience. 

Let's dive into the details:

*	Introduce scoring system with graphical user interface (GUI).

*	Particle system 

*	Score points for each enemy kill.

*	Display health indicator to show remaining health during combat.

*	Menu UI.

* New city Environment



## 1. Introducing a Scoring System with GUI

- We'll implement a scoring system that keeps track of points earned during gameplay.
- The graphical user interface (GUI) will prominently display the player's score.

## 2. Particle System

- We've downloaded the free asset "Cartoon FX Remaster Free" from the Asset Store.
- **Why use a particle system?**
  - It adds life and excitement to the game, engaging players.
  - Practical implementation:
    - In the game manager object, we've created an array list to manage particles.
      
      ![image](https://github.com/hamoudi8080/GMD/assets/82207003/77b21b67-8476-476d-8064-bdaabdeeadec)

    - When the player collides with a heart or an item, the corresponding particle effect is triggered at that position.
    - The `OnTriggerEnter` method attached to the player handles this functionality, espacially the line 24 and 35. We instanciate an object of it and lets the object takes effect at the postion of item or health.
      
      ![image](https://github.com/hamoudi8080/GMD/assets/82207003/e799beaf-f9e6-4f34-b9a5-daf984fee726)


## 3. Displaying Health Indicators

- We've obtained a free asset for the health UI.
- **How it works:**
  - Health indicators are placed above the heads of both enemies and the player.

 ![image](https://github.com/hamoudi8080/GMD/assets/82207003/d0957533-ebdb-4033-8fe9-3fea96fde73e)
    
  - We've created a script called `UILookAt` and attached it to the canvas.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/7576a511-4580-495f-8093-546cef5d2796)
    
  - This ensures that the health bar always faces the camera, providing a clear view for the user.
  - When the player hits an enemy, the health bar adjusts to reflect the change in health, and the UI effect appears above either the enemy or the player's head. The script is attached to the player, so we say
 whenever the health method triggered when the value passed to it, the method looks for the objects of enemy and player in order to change the UI health indicator.

    ![image](https://github.com/hamoudi8080/GMD/assets/82207003/279ba388-a603-4d64-92b0-9b02a8c2c2ae)


## 4. Menu UI

- We've designed a visually appealing menu scene using available assets.
- **User interaction:**
  - When the user starts or plays the game and presses the ESC key, the menu scene is triggered.
  - The menu scene allows the player to:
    - Exit the game by clicking on "Exit."
    - Start the game from scratch by clicking on "Start."
      
![image](https://github.com/hamoudi8080/GMD/assets/82207003/4fff27ef-35d0-4663-97a7-5392076b026f)

![image](https://github.com/hamoudi8080/GMD/assets/82207003/0484b68e-1377-4cfe-8824-10e402bb7cc9)



## 5. Level Completion Message

- After completing the first level which means he accomplished the number of kills, a scene triggers after a 5-second delay.
- This scene displays a message to the user before transitioning to the next level (the city environment scene).

![image](https://github.com/hamoudi8080/GMD/assets/82207003/675c568e-425b-4e3a-9c96-203e8da0f144)

## 6. The city environment
The environment should have had added in the second milestone, but becouse of some technical problems, i had to finish the UI first so i can move to it, but yeah same roles of the game with stronger enemies attributes and new environment. 

![image](https://github.com/hamoudi8080/GMD/assets/82207003/3daf972e-8658-47ca-a938-94f0661d8ccc)



Here we ended our journey of the game development. 
