# Silent Sea
Google Docs of this document: https://docs.google.com/document/d/1UIuVxF_ez1PMEKJQ0rrjCRz7GvshZujvrPQtbCcoz38/edit?usp=sharing

## Playthrough Link with Voiceover: https://youtu.be/jKzBrDz-w9E  
## Executive Summary  
The story of this project is that of a dystopian world many years in the future. Sea levels have risen so high that Chapel Hill is now a mile underwater. The player is a young scuba diver/fisherman lost at sea after attempting to rediscover Sitterson Hall, however, he managed to get stuck in the sunken Genome Parking Deck. To his dismay, his oxygen levels are running out and enemy sea creatures are on the hunt for fresh meat. He must abandon his goal of going to Sitterson and focus all his intentions on escaping an underwater grave. Luckily, he isn’t completely defenseless. He has his trusty raygun to combat enemies and interact with his surrounding environment. With enough skill and plenty of courage, he may find a way to escape his impending doom.
Silent Sea is an underwater horror/escape game that involves the player interacting with various enemies and objects in order to escape an underwater environment before he runs out of air or is killed by enemies. The dark game with a weak flashlight as an additional source of lighting adds to the dark and dreary aesthetic symbolizing the player’s impending demise.
The target audience of this game is anyone with a Meta Quest 3 that is excited by the idea of horror games in VR. There are plenty of games that exist that explore horror, but not too many attempt to give users a real-life horror experience. Luckily none of the monster prefabs in this game are realistic, which allows for a purposeful reduction in immersion to ensure that players would not experience significant trauma.


## Gameplay  
There are a couple of different objectives. First, the user must complete the tasks that differ from room to room. After completing the task, the player is then able to teleport to a different scene with a new challenge. It initially starts out easy. However, over time, enemies become increasingly difficult until reaching a final boss, who is significantly faster and more durable. After beating the final boss, the player will have beaten the game. The game can be lost if the player receives too much damage from enemies or takes too long in the game and runs out of oxygen.


## Mechanics  
When interacting with the puzzle, guessing incorrectly will hurt the player, so it is important to make sure that the player is not abusing the controls in the game. Otherwise, the user is free to interact however he pleases within his environment. The game physics as a result of having a teleportation device in the player’s left hand, is quite simple. Objects may pathfind towards him, however, the movement is uniform and will cease when attacking the player.  
Instead of score, players can track how well they did based on the two bars in the top right corner of the screen, the health and oxygen levels. The higher both these metrics are by the time the player completed the game, the better he did.
User Interface  
As a result of having teleportation in the left hand, it is important to keep a tool that allows the player to view exactly where he plans to go. Fortunately, the teleportation logic provided by Meta in their building blocks has a projecting vector already configured allowing players to know exactly where they will teleport before executing that command. The concept of only having a weak laser adds to the overall sense of horror.
Audio components were also used as an effect that added to increase the player’s feeling of immersion. Audio inputs included items like a raygun shooting sound and monster attacking sound.  
Throughout the project, for more important features like the raygun, flashlight, monsters, and map items, we used online 3D models. Here are images of the monster and raygun models we used, which formed a core foundation of the game logic utilized in the game:  


For game-specific items like the teleportation cube, code panel, and code panel hints, we found that generating our own objects to handle vital game logic was the best option. These objects were typically a mixture of cube-shaped game objects and textMeshes.  

## User Interface(UI) and Controls


The two main UI elements that appear in our game show up in the top right corner of the screen which includes the health and oxygen bars that outline the player’s success and winning conditions.  The health bar is the red bar and it tracks the amount of health the player has at any point and decreases due to getting hit by an enemy. The health serves as a way of punishing the player if they play too recklessly or don’t respect the enemies within the area and makes it so that the enemies are a threat to the player. The oxygen bar is the blue bar that appears under the health bar and it acts as a clock that the player has to race against since if they run out of oxygen the game ends and the player loses. As a UI element it gives the player feedback on when they are getting low on time or whether they can relax as they might have a lot of time remaining. It could also allow for different difficulties since different subsets of levels can be given expected times and players would have to beat increasingly fast times for a reward. 
For movement our game uses a teleportation system where the user can teleport around the floors and dodge monsters. The user can teleport with either hand and shoot with the trigger on the right hand controller which shoots the raygun and this controls almost all interaction between the user and the game. The raygun and teleportation are the main ways we implemented user control within our game




## Music/Sound:
Our game didn’t use much audio; we mainly had sound effects for monster spawning and for raygun shooting. However, these sound cues were added to augment the player’s immersion in the scene. Since the ray gun was the primary way that users could interact with the environment, having a sound play every time the button clicked allowed for better feeling of body ownership while playing the game.


## Assets:
Most Assets were taken from the Unity Asset Store. One asset we created was the box that you shoot to open the teleporter was created by us but most other things within the game were taken from the Unity Asset Store.  

Scene when player wins: includes the puzzle house from A6.


## Conclusion:
With the changes that we made to the initial game design we met the initial goals that we set out in our initial presentation. We were able to create a game where the players interact with monsters and we had it so that there was a win and loss condition that the player could reach. We didn’t implement a fear bar but with the changes to our overall design it wasn’t needed. We also were able to create a spooky environment so overall we met the goal we wanted with our project. The biggest challenge was testing our changes on a real VR headset and not having things that worked in the simulator work in the actual VR environment. We also got better at managing git and ran into less merge conflicts so we got a lot better at overall workflow. Overall we ended up happy with our project. We felt our game was actually fun and enjoyable even though everything didn’t work perfectly. In the future we would add different weapons and enemies and tap into the roguelike aspects of our game instead of trying to make a survival game we would look into procedurally generating floors and having a leaderboard based on oxygen level remaining. I think if we had more time we could make a pretty fun roguelike with the parts of the game we had. Overall we’re happy that our project turned out fun.


	

## Resources
Kunal Resources
Basic RayGun and monster spawning tutorial:
https://www.youtube.com/watch?v=CcJ4yMTzXUM

Flashlight tutorial:
https://www.youtube.com/watch?v=glBoaaEqPCI&ab_channel=FistFullofShrimp

Ray Gun Prefab
https://sketchfab.com/3d-models/ray-gun-for-assignment-pew-pew-66918bdb17634334a024eed11f3bd5fd

Monster Prefab:
https://sketchfab.com/3d-models/underwater-creature-e303e63150cb41f097b44a02e02e001c


Zain Assets/Tutorials Used:
Tutorial: For creating the ocean area:
Build a beautiful 3D open world in 5 minutes | Water, Lakes, Environment | Pt. 2

Assets:
AQUAS Lite - Built-In Render Pipeline | VFX Shaders | Unity Asset Store: For the water in the intro and win/loss scenes
Boats - PolyPack | 3D Sea | Unity Asset Store: For the boat in the intro and win/loss scenes
Simple Free Beach Models | 3D Props | Unity Asset Store: For the decorations in the win scene
Free Trees | 3D Trees | Unity Asset Store: Used for the trees on the beach island in the intro and win/loss scenes
The rest of these assets were used in A6 as well for the house that was imported into the win scene but not for anything new in the Final Project.
 https://assetstore.unity.com/packages/2d/textures-materials/roofing/stylize-roof-texture-153575: Used as texture for the Roof of the House 
https://assetstore.unity.com/packages/2d/textures-materials/brick/tileable-bricks-wall-24530: Used as texture for most of the walls of the house. https://assetstore.unity.com/packages/2d/textures-materials/tiles/pbr-tile-texture-floor-36243: Used as texture for floor of the house https://assetstore.unity.com/packages/3d/environments/landscapes/mountain-terrain-rocks-and-tree-97905: Used texture for outside winning area terrain and mountains. 
https://assetstore.unity.com/packages/3d/props/simple-free-beach-models-287370: Used to add props to the Oasis in winning outside area. https://assetstore.unity.com/packages/3d/vegetation/trees/free-trees-103208: Used for trees around the beach/Oasis https://assetstore.unity.com/packages/3d/props/interior/house-interior-free-258782: Used for decorating house interior with furniture.
 https://assetstore.unity.com/packages/2d/textures-materials/water/stylize-water-texture-153577: Used as texture for Oasis water 
https://assetstore.unity.com/packages/2d/gui/icons/simple-button-set-02-184903: Used the up and down arrows as images for the buttons in Puzzle1. 
https://assetstore.unity.com/packages/3d/props/interior/door-free-pack-aferar-148411: Used as Door to the House.

