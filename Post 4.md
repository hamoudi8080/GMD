# Second Milestone

For our second milestone, we will go through:

- Develop combat system for the main character.
- Implement enemy AI for engaging encounters.
- Implement the health system for both character and enemy.
- Audio clips with object pooling.

## AI Navigation

First, download the AI Navigation package from Unity’s package manager. This package helps in creating navigation meshes and implementing pathfinding for AI-controlled movement in your game.

We use the nav mesh agent component to calculate the distance between the enemy and the player character. If the enemy is within a certain radius, it will follow the player.

First I pass my player position into Enemy controller script.

<img width="1278" alt="image" src="https://github.com/hamoudi8080/GMD/assets/82207003/e68d8df9-7ca2-4ceb-ba82-95a419d8025a">



!Figure (1) Nav mesh Component and passing player position into Enemy controller

Now, with this script attached to the enemy object, find the distance between the player and the enemy object. If the distance is less than a specified radius,
let the enemy follow the player using the Nav mesh component to catch and hit the player.

![Picture2](https://github.com/hamoudi8080/GMD/assets/82207003/9ba78957-9ff7-4256-a88d-cbc24155efcf)



## Animation

The process of hitting the player involves an animation. 
Let’s go through how it is done.
We have an animation called Attack01 which is an enemy hitting animation, and I declare a trigger type parameter called Attack. On the transition between idle and attack, I set the condition attack when it is triggered.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/507617e6-bc9e-411e-86de-e3567c973cc9)


!Figure Enemy animation

Now we need a script. When the enemy gets very close to the player, we want that animation to execute. The comments in the code explain this.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/889d25be-b798-496b-9df6-4f25e747833c)



What we have achieved so far is that the enemy will find the path to get to the player and start hitting. The whole environment of the game is set up, such as the camera, the player, the enemy, and the logic of the fight.

## Health System

We implemented the health system on both objects, the enemy and the player. First, we created CharacterStats class and attached it to both the player and enemy objects.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/2b730542-c4a0-4976-af99-06fc73f0b0a4)



Now both player and enemy objects contain this character-stats Component.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/f830e2dc-8962-44dc-932f-234c1bdd5326)


Now, what happens when the enemy object hits the player? This script is attached to the enemy object.

We simply just call the stats of player and decrease its health.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/c076a6b5-3e0f-4fc5-ab1d-f68d9186c3d3)



The field has also heart 3D model, and the purpose of it is to increase the player’s health when ever the player collides with it.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/831392e0-a7f4-4d5b-9e46-27d41c69c166)


The script is attached to the player ninja object. Here we say if the player collides with heart object which has a tag Health than we increase the health by 20 and then we destroy the heart object.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/8bbae462-6036-40d7-b7fa-d157b0ab9ca3)




## Sounds and Audio

First of all, I downloaded all the sounds from free sounds website. And then I used audacity program to add effects and edit the sounds files I downloaded.

For example, I did compress all files, compress is to make balance in waves and cut the silence part.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/e7e5c5ad-3261-40f1-84c0-68be608416e7)



Well now!! But how are the audio clips are added to our game?

Have you every heard of objects pooling? If not don’t worry, we will go through it together.

Unity document says that Object Pooling is a great way to optimize your projects and lower the burden that is placed on the CPU when having to rapidly create and destroy GameObjects.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/a1f323a9-2901-4061-a276-a6c992974bb4)



Let’s take first step how is it implemented?

![image](https://github.com/hamoudi8080/GMD/assets/82207003/55fda6ac-6256-4b62-b673-000e48bbdc55)



!Figure footstep event

![image](https://github.com/hamoudi8080/GMD/assets/82207003/be15a889-b28f-4c22-9bd7-bc07505fcdfc)

When these events happen, a function is triggered, called MoveSound. LevelManager is a static class that contains the list of audio clips.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/e04488c9-1bf6-4de7-bbbb-6870f4a56ae2)


In the MoveSound method, as the first parameter, we get the footsteps audio clip in position 0 and pass the player’s position as the second parameter. The idea is to play the clip at the player’s position.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/c93eca25-622e-4653-b4b6-a81e797c9a04)


But how is it technically done? Let’s call the playerSound method in the LevelManager script and see it together.

In a few words:

- Get one deactivated object.
- Get the audio component.
- Activate an object.
- Play the clip.

![image](https://github.com/hamoudi8080/GMD/assets/82207003/e585e514-fa42-40b7-8405-bbd9b4a36efc)



At the end with object pooling we implement a nice system for clips.
