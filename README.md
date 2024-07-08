2D Game Project
Overview
This project is a 2D game implemented in C# using the Windows Forms framework. The game features various actors, including the player, zombies, keys, doors, walls, ladders, and other elements that form the game environment. The game supports multiple levels with different maps and interactions between the player and various game elements.

Table of Contents
Features
Prerequisites
Installation
Usage
Controls
Code Structure
Classes and Methods
License
Features
2D game environment with multiple actors.
Player interaction with keys, doors, walls, ladders, and other elements.
Multiple levels with different maps.
Animated actors, including zombies and fire.
Basic collision detection and interaction logic.
Bitmap-based graphics with transparency support.
Score and time tracking.
Prerequisites
.NET Framework
Visual Studio or any other C# IDE
Installation
Clone the repository:

sh
Copy code
git clone https://github.com/yourusername/your-repo-name.git
Open the project in Visual Studio.

Restore any NuGet packages if required.

Build the project.

Usage
Run the project in Visual Studio by pressing F5 or selecting Debug > Start Debugging.

Use the keyboard controls to navigate and interact within the game environment.

Controls
Arrow Keys: Move the player character (up, down, left, right).
Spacebar: Perform an action (e.g., pick up a key, open a door).
Code Structure
Form1.cs: The main form handling the game's rendering and logic.
CActor.cs: Class representing actors in the game, including the player, zombies, walls, and other elements.
Bitmap Resources: Images used for various game elements, stored as .bmp and .gif files.
sound: Sound files used for game events, stored as .wav files.
Classes and Methods
Form1 Class
Properties
gameStatus: Integer representing the current game status (e.g., 0 for ongoing, 1 for level completion).
score: Integer representing the player's score.
ptime: Integer tracking the elapsed playtime.
player, zombie1, zombie2, zombie3, zombie4: Instances of the CActor class representing the player and zombie actors.
wall: Array of CActor representing wall elements.
door, key, ladder, ladders, fire: Instances of CActor representing doors, keys, ladders, and fire elements.
Methods
Form1_Paint(object sender, PaintEventArgs e): Handles the paint event to draw the game scene.
Form1_KeyDown(object sender, KeyEventArgs e): Handles key press events for player movement and actions.
timer1_Tick(object sender, EventArgs e): Timer event handler for updating game logic and redrawing the scene.
DrawDubb(Graphics g): Double-buffered drawing to prevent flickering.
DrawScene(Graphics g): Draws the entire game scene including all actors and elements.
createground(): Creates and initializes the ground elements.
createwall(): Creates and initializes the wall elements.
createkey(): Creates and initializes the key elements.
createdoor(): Creates and initializes the door elements.
towall(): Creates and initializes the top wall elements.
elementformap2(): Initializes elements for the second map.
newmap1them(): Creates and initializes the elements for a new map.
playSimpleSound(string path): Plays a sound from the given path.
playAgain(int seconds): Resets the game or loads a new level after a specified time.
CActor Class
Represents an actor in the game with properties for source and destination rectangles and a list of images.

Properties
rcSrc: Source rectangle for drawing.
rcDst: Destination rectangle for drawing.
imgs: List of images representing the actor's animation frames.
iCurrFrame: Current frame index for the animation.
iPoints: Points assigned to the actor for scoring purposes.
strImageFileName: Image file name for loading the actor's bitmap.
Methods
setCurrentFrame(int iFrame): Sets the current animation frame for the actor.
AdvanceAnimationFrame(): Advances to the next animation frame.
move(int dx, int dy): Moves the actor by the specified amount.
Draw(Graphics g): Draws the actor using the provided graphics context.
