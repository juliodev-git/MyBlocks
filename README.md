# MyBlocks
![screenshot](screenshot.PNG)
[Read More About MyBlocks](https://portfolium.com/entry/25d-mobile-multiplayer-game)

_______________________________________

**MyBlocks** is a 2.5D mobile multiplayer game where players can explore a world together. Fish, craft, skate and fight your way through a world collecting items and crafting weapons with friends!

_______________________________________

I developed the prototype of MyBlocks which inludes core gameplay mechanics such as player movement and a cosmetic UI interface for selecting hats, masks or glasses for your player to wear - an emote dropdown list also included. Additionally, I was in charge of creating all emotes and movement animations. 

_______________________________________

**Human.cs**: Reads input values from user (via controller or keyboard) and relays that information to designated Character.cs class attached to our main player. Other values sent to Character are camera rotational values to rotate player to face the same direction as the camera. Values are also read-in from the Character to disable certain actions when Character is in particular states such as fishing or interacting with NPCs.

**Character.cs**: The main script that moves the player, values sent in from Human are used to move the player via Unity's CharacterController component as well as rotate the character to face the same direction as camera during a fishing cast and fishing game.

