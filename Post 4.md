# Second Milestone

For our second milestone, we will go through:

- Develop combat system for the main character.
- Implement enemy AI for engaging encounters.
- Implement the health system for both character and enemy.
- Audio clips with object pooling.

## AI Navigation

First, download the AI Navigation package from Unity’s package manager. This package helps in creating navigation meshes and implementing pathfinding for AI-controlled movement in your game.

Use the nav mesh agent component to calculate the distance between the enemy and the player character. If the enemy is within a certain radius, it will follow the player.

First I pass my player position into Enemy controller script.

!Figure (1) Nav mesh Component

Now, with this script attached to the enemy object, find the distance between the player and the enemy object. If the distance is less than a specified radius, let the enemy follow the player using the Nav mesh component to catch and hit the player.

## Animation

The process of hitting the player involves an animation. Let’s go through how it is done. We have an animation called Attack01 which is a hitting animation, and I declare a parameter called Attack. On the transition between idle and attack, I set the condition attack.

!Figure Enemy animation

Now we need a script. When the enemy gets very close to the player, we want that animation to execute. The comments in the code explain this.

What we have achieved so far is that the enemy will find the path to get to the player and start hitting. The whole environment of the game is set up, such as the camera, the player, the enemy, and the logic of the fight.

## Health System

We implemented the health system on both objects, the enemy and the player. First, we created CharacterStats and attached it to both the player and enemy objects.

Both player and enemy objects contain this character-stats Component.

Now, what happens when the enemy object hits the player? This script is attached to the enemy object.

We simply just call the stats of player and decrease its health.

The field has also heart 3D model, and the purpose of it is to increase the player’s health when ever the player collides with it.

The script is attached to the player ninja object. Here we say if the player collides with heart object which has a tag Health than we increase the health by 20 and then we destroy the heart object.

## Sounds and Audio

First of all, I downloaded all the sounds from free sounds website. And then I used audacity program to add effects and edit the sounds files I downloaded.

For example, I did compress all files, compress is to make balance in waves and cut the silence part.

Well now!! But how are the audio clips are added to our game?

Have you every heard of objects pooling? If not don’t worry, we will go through it together.

Unity document says that Object Pooling is a great way to optimize your projects and lower the burden that is placed on the CPU when having to rapidly create and destroy GameObjects.

Let’s take first step how is it implemented?

!Figure footstep event

When these events happen, a function is triggered, called MoveSound. LevelManager is a static class that contains the list of audio clips.

In the MoveSound method, as the first parameter, we get the footsteps audio clip in position 0 and pass the player’s position as the second parameter. The idea is to play the clip at the player’s position.

But how is it technically done? Let’s call the playerSound method in the LevelManager script and see it together.

In a few words:

- Get one deactivated object.
- Get the audio component.
- Activate an object.
- Play the clip.

At the end with object pooling we implement a nice system for clips.
