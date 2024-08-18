# MyBlocks
![screenshot](screenshot.png)
[Read More About MyBlocks](https://portfolium.com/entry/25d-mobile-multiplayer-game)

_______________________________________

**MyBlocks** is a 2.5D mobile multiplayer game where players can explore a world together. Fish, craft, skate and fight your way through a world collecting items and crafting weapons with friends!

_______________________________________

I developed the core gameplay mechanics including player movement, collision-based interactions (NPC's, level changing, fishing), and cinematic sequences in the form of a start screen and NPC cutscenes.The scipts above are core gameplay scripts used to move and animate the character, as well as change scenes via trigger colliders to paint the world as a series of interconnected environments.

_______________________________________

**Human.cs**: Reads input values from user (via controller or keyboard) and relays that information to designated Character.cs class attached to our main player. Other values sent to Character are camera rotational values to rotate player to face the same direction as the camera. Values are also read-in from the Character to disable certain actions when Character is in particular states such as fishing or interacting with NPCs.

**Character.cs**: The main script that moves the player, values sent in from Human are used to move the player via Unity's CharacterController component as well as rotate the character to face the same direction as camera during a fishing cast and fishing game.

