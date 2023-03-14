# Unity_FishCatchingGame
![Gif of the game being played](https://i.gyazo.com/84c30da9382d50e2c9af287a8350b86c.gif)
## Fish
The Fish prefab uses a Sprite Renderer, Rigidbody 2D, Capsule Collider 2D, and a FishDespawn Script.
The Sprite Renderer simply holds the reference to the image of the fish (“FishF-3”), a free asset found in the Unity store.
Rigidbody 2D is used to add gravity to the fish, no changes are made to the default parameters.
Capsule Collider 2D adds collision detection to the prefab, the capsule collider was used because it fit the shape of the fish the best.
The FishDespawn script runs on every frame to check if the fish has passed a given y dead zone (-6) and will destroy the fish object if it is passed the dead zone.
## Fish Spawner
The Fish Spawner prefab is a simple game object that contains a FishSpawner script that takes a GameObject parameter (it is given the Fish prefab) and a Spawn Rate (0.5s). The script will spawn a new Fish at a set y position and a random x position at the interval set by the Spawn Rate, and Time.deltaTime is used to ensure that the timer is consistent across all frame rates.  
## Bomb and Bomb Spawner
These two prefabs use the exact same logic as Fish and Fish Spawner, the only difference is that Bomb uses a different image and has a slower spawn rate.
## Logic Manager
This GameObject is responsible for handling the logic in the game, containing a Logic Script. The logic the game requires is increasing the score when a fish is caught, producing an explosion when a bomb is caught, displaying a game over screen, and restarting the game.
The LogicManager requires the following to be given to it: a Text (Legacy) object called ScoreText, a Game Over Screen, a Fish Spawner, and a Bomb Spawner.
addScore() – this function increases the playerScore variable and updates the ScoreText. 
playExplosion() – this function determines the location of the mouse and plays the Explosion prefab at that position.
restartGame() – uses SceneManager to load the active scene.
gameOver() – stops the fish and bomb spawners from spawning more objects, and sets the sets the active scene to gameOverScreen.
## Explosion
This animation was obtained via the Unity store for free (https://assetstore.unity.com/packages/2d/textures-materials/2d-flat-explosion-66932), a modification was made to destroy the prefab upon animation completion. I added this functionality so that the game wouldn’t slow down over time if multiple bomb catches were allowed before game over.
## Game Over Screen
The game over screen contains a Text (Legacy) object that displays the “Game Over” text, and a Button that has an On Click() function call to the LogicManager that calls the restartGame() function.
