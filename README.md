# GuitarHero

This is a small game project developed for a university project in Unity. The game is a basic implementation of the popular Guitar Hero game, where players have to press specific keys (Z for blue node, X for red node, and C for green node) in sync with the rhythm of the game to score points.

## Game Features
Three different colored nodes: blue, red, and green.<br>
Players need to press corresponding keys (Z for blue, X for red, and C for green) when the nodes align with the target area at the bottom of the screen.<br>
<br>
## Implementation
We have few main gameobjects design by Amit Melamed:<br>
1.Spawner - Who is spawning nodes in randomly time.<br>
You can choose what nodes to spawn and customize them.<br>
You can modify the nodes Velocity and the Min&Max time between each spawn.<br>
<br>
2.Nodes - We have Green,Blue and Red nodes that have scripted to be destroyed after certein time.<br>
When the nodes hit the Blue Heart (Guitar) this is the time to destroy them.<br>
<br>
3.Guitar - When the nodes collides with guitar and you hit the right Key - the nodes will be destroyed.<br>
