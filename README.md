# 2D Game Project

## Description

This project implements a 2D game using Windows Forms in C#. The game features a player character navigating through a maze-like environment, avoiding zombies, collecting keys, and unlocking doors to progress through levels. The game includes basic collision detection, scoring, and time-tracking functionalities.

## Classes and Their Responsibilities

### Player Class

- Represents the main player character.
- **Attributes:**
  - `Rectangle rcDst`: Destination rectangle for drawing the player.
  - `Rectangle rcSrc`: Source rectangle for drawing the player.
  - `List<Bitmap> imgs`: List of images representing the player's animation frames.
  - `int iCurrFrame`: Current frame of the animation.
  - `int health`: Player's health points.

### Zombie Class

- Represents the enemy zombies.
- **Attributes:**
  - `Rectangle rcDst`: Destination rectangle for drawing the zombie.
  - `Rectangle rcSrc`: Source rectangle for drawing the zombie.
  - `List<Bitmap> imgs`: List of images representing the zombie's animation frames.
  - `int iCurrFrame`: Current frame of the animation.
  - `int speed`: Movement speed of the zombie.

### Key Class

- Represents the keys that the player collects.
- **Attributes:**
  - `Rectangle rcDst`: Destination rectangle for drawing the key.
  - `Rectangle rcSrc`: Source rectangle for drawing the key.
  - `Bitmap img`: Image representing the key.
  - `bool collected`: Flag indicating if the key has been collected by the player.

### Door Class

- Represents the doors that the player unlocks with keys.
- **Attributes:**
  - `Rectangle rcDst`: Destination rectangle for drawing the door.
  - `Rectangle rcSrc`: Source rectangle for drawing the door.
  - `Bitmap img`: Image representing the door.
  - `bool locked`: Flag indicating if the door is locked or unlocked.

### Form1 Class

- The main form of the game, responsible for game logic and rendering.
- **Attributes:**
  - `Player player`: Instance of the `Player` class representing the player character.
  - `List<Zombie> zombies`: List of `Zombie` instances representing the enemies.
  - `List<Key> keys`: List of `Key` instances representing the keys in the game.
  - `List<Door> doors`: List of `Door` instances representing the doors in the game.
  - `int score`: Player's score.
  - `int level`: Current level of the game.
  - `int remainingKeys`: Number of keys remaining to collect.
  - `int gameTime`: Elapsed time since the start of the game.
  - `Timer timer`: Timer object for game updates.
- **Methods:**
  - `Form1()`: Constructor, initializes game objects and sets up event handlers.
  - `Form1_Paint(object sender, PaintEventArgs e)`: Handles the paint event to draw the game scene.
  - `Form1_KeyDown(object sender, KeyEventArgs e)`: Handles key press events for player movement and actions.
  - `timer_Tick(object sender, EventArgs e)`: Timer event handler for updating game logic.
  - `InitializeLevel()`: Initializes the game objects for a new level.
  - `CheckCollisions()`: Checks for collisions between the player, keys, doors, and zombies.
  - `UpdateGameState()`: Updates the game state based on player actions and elapsed time.
  - `DrawScene(Graphics g)`: Draws the game scene including the player, zombies, keys, and doors.

## Key Bindings

- **Arrow Keys**: Move the player character ( left, right).
- **Spacebar**: Perform action (Jump).


