TDRS
======

A top-down rhythm shooter made in Unity.

-OVERVIEW
RTSSG is a top-down action shooter that takes place in a bounded arena in which a number of enemy spawners (spheres) exist. The goal of the game is to progress to the end by way of destroying these spheres, which spawn enemies according to the music being played. The player must avoid these enemies and destroy all the spheres that appear to win.

-GAME STRUCTURE
The game will be separated into a series of sections that correspond to loops made from the background music. Each loop will contain a number of spheres -- the amount of spheres will be dictated by the character of the music in each loop. Once all of the spheres in a section are destroyed, the music will progress to the next loop, and the game’s “section” will change, spawning new spheres.

-SPHERES
These spheres will spawn enemies in various patterns according to rhythms in the song that are dictated by the instruments themselves. Each sphere will spawn enemy waves based on the specific rhythmic pattern, and will continue to do so until destroyed by the player. When a sphere is destroyed, the associated instrument will also stop playing, allowing the player to dictate the structure of both the enemy spawn and the music.

-PLAYER
The player will use the right stick to shoot in the direction that it is pointed and the left stick to move around the level. The player’s shots will also be dictated by the music, and shoot in various patterns (16th notes, 8th notes, etc.) and possess various attributes depending on the pattern.

-ENEMIES
The enemies will use various AI patterns to pursue and attempt to destroy the player. These patterns will include simple straight lines (no course change), pursuit of the player, etc. 

